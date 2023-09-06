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
            buttonCancel = new Button();
            progressBarDownload = new ProgressBar();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "YT Movie URL";
            // 
            // textBoxDownload
            // 
            textBoxDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDownload.Location = new Point(24, 52);
            textBoxDownload.Margin = new Padding(3, 4, 3, 4);
            textBoxDownload.Name = "textBoxDownload";
            textBoxDownload.Size = new Size(652, 27);
            textBoxDownload.TabIndex = 1;
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDownload.Location = new Point(684, 52);
            buttonDownload.Margin = new Padding(3, 4, 3, 4);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(86, 31);
            buttonDownload.TabIndex = 2;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(684, 91);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 31);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // progressBarDownload
            // 
            progressBarDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarDownload.Location = new Point(24, 86);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new Size(652, 29);
            progressBarDownload.TabIndex = 4;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(24, 118);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(18, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "...";
            // 
            // FormYouTubeClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 147);
            Controls.Add(labelStatus);
            Controls.Add(progressBarDownload);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDownload);
            Controls.Add(textBoxDownload);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormYouTubeClient";
            Text = "You Tube Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDownload;
        private Button buttonDownload;
        private Button buttonCancel;
        private ProgressBar progressBarDownload;
        private Label labelStatus;
    }
}