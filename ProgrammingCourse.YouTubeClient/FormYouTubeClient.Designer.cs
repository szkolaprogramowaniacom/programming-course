namespace ProgrammingCourse.YouTubeClient
{
    partial class FormYouTubeClient
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
            label1 = new Label();
            textBoxDownload = new TextBox();
            buttonDownload = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "YT Movie URL";
            // 
            // textBoxDownload
            // 
            textBoxDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDownload.Location = new Point(30, 65);
            textBoxDownload.Margin = new Padding(4, 5, 4, 5);
            textBoxDownload.Name = "textBoxDownload";
            textBoxDownload.Size = new Size(825, 31);
            textBoxDownload.TabIndex = 1;
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDownload.Location = new Point(866, 65);
            buttonDownload.Margin = new Padding(4, 5, 4, 5);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(107, 38);
            buttonDownload.TabIndex = 2;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // FormYouTubeClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 163);
            Controls.Add(buttonDownload);
            Controls.Add(textBoxDownload);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormYouTubeClient";
            Text = "You Tube Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDownload;
        private Button buttonDownload;
    }
}