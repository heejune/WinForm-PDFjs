namespace WinFormPDFViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.locateBtn = new System.Windows.Forms.Button();
            this.locateText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(561, 381);
            this.webBrowser1.TabIndex = 0;
            // 
            // locateBtn
            // 
            this.locateBtn.Location = new System.Drawing.Point(474, 388);
            this.locateBtn.Name = "locateBtn";
            this.locateBtn.Size = new System.Drawing.Size(75, 23);
            this.locateBtn.TabIndex = 1;
            this.locateBtn.Text = "Locate";
            this.locateBtn.UseVisualStyleBackColor = true;
            this.locateBtn.Click += new System.EventHandler(this.locateBtn_Click);
            // 
            // locateText
            // 
            this.locateText.Location = new System.Drawing.Point(62, 390);
            this.locateText.Name = "locateText";
            this.locateText.Size = new System.Drawing.Size(385, 20);
            this.locateText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locateText);
            this.Controls.Add(this.locateBtn);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button locateBtn;
        private System.Windows.Forms.TextBox locateText;
        private System.Windows.Forms.Label label1;
    }
}

