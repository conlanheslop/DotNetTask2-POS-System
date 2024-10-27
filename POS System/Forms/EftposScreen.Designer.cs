namespace POS_System.Forms
{
    partial class EftposScreen
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
            components = new System.ComponentModel.Container();
            ProgressBarEftpos = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // ProgressBarEftpos
            // 
            ProgressBarEftpos.Location = new Point(26, 98);
            ProgressBarEftpos.Name = "ProgressBarEftpos";
            ProgressBarEftpos.Size = new Size(552, 58);
            ProgressBarEftpos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 29);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 1;
            label1.Text = "EFTPOS Payment Progress";
            // 
            // EftposScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 228);
            Controls.Add(label1);
            Controls.Add(ProgressBarEftpos);
            Name = "EftposScreen";
            Text = "EFTPOS Payment System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar ProgressBarEftpos;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}