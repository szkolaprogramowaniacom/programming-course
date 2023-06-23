namespace ProgrammingCourse.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDownload = new Button();
            textBoxUrl = new TextBox();
            textBoxSource = new TextBox();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDownload.Location = new Point(410, 12);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 23);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUrl.Location = new Point(12, 12);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(392, 23);
            textBoxUrl.TabIndex = 1;
            // 
            // textBoxSource
            // 
            textBoxSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSource.Location = new Point(12, 46);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.ScrollBars = ScrollBars.Both;
            textBoxSource.Size = new Size(491, 233);
            textBoxSource.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 294);
            Controls.Add(textBoxSource);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonDownload);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private TextBox textBoxUrl;
        private TextBox textBoxSource;
    }
}