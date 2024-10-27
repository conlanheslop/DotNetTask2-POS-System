namespace POS_System.Forms
{
    partial class SpecialFunctionsScreen
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
            label1 = new Label();
            ButtonViewSalesReport = new Button();
            ButtonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(654, 74);
            label1.TabIndex = 0;
            label1.Text = "Special Functions Menu";
            // 
            // ButtonViewSalesReport
            // 
            ButtonViewSalesReport.Anchor = AnchorStyles.None;
            ButtonViewSalesReport.BackColor = Color.Coral;
            ButtonViewSalesReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonViewSalesReport.ForeColor = SystemColors.ButtonHighlight;
            ButtonViewSalesReport.Location = new Point(440, 56);
            ButtonViewSalesReport.Margin = new Padding(4, 5, 4, 5);
            ButtonViewSalesReport.Name = "ButtonViewSalesReport";
            ButtonViewSalesReport.Size = new Size(270, 135);
            ButtonViewSalesReport.TabIndex = 1;
            ButtonViewSalesReport.Text = "View Sales Report";
            ButtonViewSalesReport.UseVisualStyleBackColor = false;
            ButtonViewSalesReport.Click += ButtonViewSalesReport_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Anchor = AnchorStyles.None;
            ButtonExit.BackColor = Color.Firebrick;
            ButtonExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonExit.ForeColor = SystemColors.ButtonHighlight;
            ButtonExit.Location = new Point(439, 304);
            ButtonExit.Margin = new Padding(4, 5, 4, 5);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(273, 136);
            ButtonExit.TabIndex = 2;
            ButtonExit.Text = "Exit to Item Menu";
            ButtonExit.UseVisualStyleBackColor = false;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ButtonViewSalesReport, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonExit, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 201);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1151, 497);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1151, 201);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // SpecialFunctionsScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 698);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1173, 754);
            Name = "SpecialFunctionsScreen";
            Text = "SpecialFunctionsScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ButtonViewSalesReport;
        private Button ButtonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}