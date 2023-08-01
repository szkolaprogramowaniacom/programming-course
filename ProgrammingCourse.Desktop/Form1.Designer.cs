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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDownload.Location = new Point(678, 16);
            buttonDownload.Margin = new Padding(3, 4, 3, 4);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(107, 31);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUrl.Location = new Point(14, 16);
            textBoxUrl.Margin = new Padding(3, 4, 3, 4);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(657, 27);
            textBoxUrl.TabIndex = 1;
            // 
            // textBoxSource
            // 
            textBoxSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSource.Location = new Point(14, 61);
            textBoxSource.Margin = new Padding(3, 4, 3, 4);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.ScrollBars = ScrollBars.Both;
            textBoxSource.Size = new Size(770, 285);
            textBoxSource.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(14, 368);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(106, 368);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 415);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxSource);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonDownload);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private Button button2;
    }
}