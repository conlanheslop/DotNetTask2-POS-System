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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProgressBarEftpos
            // 
            ProgressBarEftpos.Anchor = AnchorStyles.Top;
            ProgressBarEftpos.Location = new Point(47, 195);
            ProgressBarEftpos.Margin = new Padding(4, 5, 4, 5);
            ProgressBarEftpos.Name = "ProgressBarEftpos";
            ProgressBarEftpos.Size = new Size(789, 97);
            ProgressBarEftpos.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 48);
            label1.TabIndex = 1;
            label1.Text = "EFTPOS Payment In Progress";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ProgressBarEftpos, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
<<<<<<< Updated upstream
            tableLayoutPanel1.Size = new Size(884, 380);
            tableLayoutPanel1.TabIndex = 2;

=======
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(884, 380);
            tableLayoutPanel1.TabIndex = 2;
>>>>>>> Stashed changes
            // 
            // EftposScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 380);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimumSize = new Size(906, 436);
            Name = "EftposScreen";
            Text = "EFTPOS Payment System";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar ProgressBarEftpos;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}