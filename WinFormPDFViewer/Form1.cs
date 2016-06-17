using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormPDFViewer
{
    // without this, ArgumentException will occur when setting ObjectForScripting to this
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            locateText.TextChanged += LocateText_TextChanged;
        }

        private void LocateText_TextChanged(object sender, EventArgs e)
        {
            if (locateText.Text.EndsWith("pdf", true, null) == true && 
                File.Exists(locateText.Text) == true)
            {
                var buffer = File.ReadAllBytes(locateText.Text);

                // Document.InvokeScript seems not understanding the Blob type
                //object[] args = { fileBytes };
                //webBrowser1.Document.InvokeScript("PDFViewerApplication.open", args);

                // so convert it to base64 and pass it
                var asBase64 = Convert.ToBase64String(buffer);
                webBrowser1.Document.InvokeScript("openPdfAsBase64", new[] { asBase64 });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            // https://github.com/TaoK/PoorMansTSqlFormatter/blob/d6b4f7bedc02ce1bf59acb16dd1f49609c216aa7/PoorMansTSqlFormatterDemo/FrameworkClassReplacements/CustomContentWebBrowser.cs

            //webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.ObjectForScripting = this;
            webBrowser1.WebBrowserShortcutsEnabled = true;
            var view_page = String.Format("file:///{0}/web/viewer.html", dir);
            this.webBrowser1.Url = new Uri(view_page);
        }

        private void locateBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                locateText.Text = dlg.FileName;
            }
        }
    }
}
