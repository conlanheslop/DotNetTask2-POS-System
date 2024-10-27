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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(432, 50);
            label1.TabIndex = 0;
            label1.Text = "Special Functions Menu";
            // 
            // ButtonViewSalesReport
            // 
            ButtonViewSalesReport.Location = new Point(342, 134);
            ButtonViewSalesReport.Name = "ButtonViewSalesReport";
            ButtonViewSalesReport.Size = new Size(100, 49);
            ButtonViewSalesReport.TabIndex = 1;
            ButtonViewSalesReport.Text = "View Sales Report";
            ButtonViewSalesReport.UseVisualStyleBackColor = true;
            ButtonViewSalesReport.Click += ButtonViewSalesReport_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(342, 226);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(100, 49);
            ButtonExit.TabIndex = 2;
            ButtonExit.Text = "Exit to Item Menu";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // SpecialFunctionsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 419);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonViewSalesReport);
            Controls.Add(label1);
            Name = "SpecialFunctionsScreen";
            Text = "SpecialFunctionsScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonViewSalesReport;
        private Button ButtonExit;
    }
}