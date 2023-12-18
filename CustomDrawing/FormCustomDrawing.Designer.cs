namespace CustomDrawing
{
    partial class FormCustomDrawing
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
            fractalControl1 = new FractalControl();
            SuspendLayout();
            // 
            // fractalControl1
            // 
            fractalControl1.Dock = DockStyle.Fill;
            fractalControl1.Location = new Point(0, 0);
            fractalControl1.Name = "fractalControl1";
            fractalControl1.Size = new Size(819, 504);
            fractalControl1.TabIndex = 0;
            fractalControl1.Text = "fractalControl1";
            // 
            // FormCustomDrawing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 504);
            Controls.Add(fractalControl1);
            Name = "FormCustomDrawing";
            Text = "Custom Drawing Example";
            ResumeLayout(false);
        }

        #endregion

        private FractalControl fractalControl1;
    }
}
