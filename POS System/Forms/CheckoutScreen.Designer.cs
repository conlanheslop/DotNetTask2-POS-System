namespace POS_System.Forms
{
    partial class CheckoutScreen
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
            OrderListView = new ListView();
            Items = new ColumnHeader();
            Price = new ColumnHeader();
            TextBoxAmountTendered = new TextBox();
            label1 = new Label();
            LabelChange = new Label();
            ButtonReturn = new Button();
            ButtonCompletePayment = new Button();
            LabelTotal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ButtonEftpos = new Button();
            ButtonCashPayment = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // OrderListView
            // 
            OrderListView.Anchor = AnchorStyles.None;
            OrderListView.Columns.AddRange(new ColumnHeader[] { Items, Price });
            OrderListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderListView.Location = new Point(46, 15);
            OrderListView.Margin = new Padding(4, 5, 4, 5);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(495, 746);
            OrderListView.TabIndex = 0;
            OrderListView.UseCompatibleStateImageBehavior = false;
            OrderListView.View = View.Details;
            // 
            // Items
            // 
            Items.Text = "Items";
            Items.Width = 160;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 98;
            // 
            // TextBoxAmountTendered
            // 
            TextBoxAmountTendered.Anchor = AnchorStyles.Top;
            TextBoxAmountTendered.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxAmountTendered.Location = new Point(88, 200);
            TextBoxAmountTendered.Margin = new Padding(4, 5, 4, 5);
            TextBoxAmountTendered.Name = "TextBoxAmountTendered";
            TextBoxAmountTendered.Size = new Size(188, 39);
            TextBoxAmountTendered.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 2;
            label1.Text = "Cash Tendered";
            label1.Click += label1_Click;
            // 
            // LabelChange
            // 
            LabelChange.AutoSize = true;
            LabelChange.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelChange.Location = new Point(4, 833);
            LabelChange.Margin = new Padding(4, 0, 4, 0);
            LabelChange.Name = "LabelChange";
            LabelChange.Size = new Size(150, 45);
            LabelChange.TabIndex = 3;
            LabelChange.Text = "Change: ";
            // 
            // ButtonReturn
            // 
            ButtonReturn.Anchor = AnchorStyles.None;
            ButtonReturn.BackColor = SystemColors.AppWorkspace;
            ButtonReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonReturn.ForeColor = SystemColors.ButtonHighlight;
            ButtonReturn.Location = new Point(270, 685);
            ButtonReturn.Margin = new Padding(4, 5, 4, 5);
            ButtonReturn.Name = "ButtonReturn";
            ButtonReturn.Size = new Size(228, 103);
            ButtonReturn.TabIndex = 5;
            ButtonReturn.Text = "Cancel Order";
            ButtonReturn.UseVisualStyleBackColor = false;
            ButtonReturn.Click += ButtonMenu_Click;
            // 
            // ButtonCompletePayment
            // 
            ButtonCompletePayment.Anchor = AnchorStyles.None;
            ButtonCompletePayment.BackColor = Color.MediumSeaGreen;
            ButtonCompletePayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCompletePayment.ForeColor = SystemColors.ButtonHighlight;
            ButtonCompletePayment.Location = new Point(270, 831);
            ButtonCompletePayment.Margin = new Padding(4, 5, 4, 5);
            ButtonCompletePayment.Name = "ButtonCompletePayment";
            ButtonCompletePayment.Size = new Size(228, 103);
            ButtonCompletePayment.TabIndex = 6;
            ButtonCompletePayment.Text = "Complete Order";
            ButtonCompletePayment.UseVisualStyleBackColor = false;
            ButtonCompletePayment.Click += ButtonCompletePayment_Click;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(4, 832);
            LabelTotal.Margin = new Padding(4, 0, 4, 0);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(112, 45);
            LabelTotal.TabIndex = 7;
            LabelTotal.Text = "Total: ";
            LabelTotal.Click += LabelTotal_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ButtonCompletePayment, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonReturn, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1193, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.30198F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.698019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.Size = new Size(513, 957);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LabelTotal, 0, 2);
            tableLayoutPanel2.Controls.Add(OrderListView, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 93.17618F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.82382154F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
            tableLayoutPanel2.Size = new Size(588, 957);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(LabelChange, 0, 4);
            tableLayoutPanel3.Controls.Add(TextBoxAmountTendered, 0, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(ButtonCashPayment, 1, 2);
            tableLayoutPanel3.Controls.Add(ButtonEftpos, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(588, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 26.358696F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 73.641304F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 482F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel3.Size = new Size(605, 957);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // ButtonEftpos
            // 
            ButtonEftpos.Anchor = AnchorStyles.Top;
            ButtonEftpos.BackColor = Color.Sienna;
            ButtonEftpos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEftpos.ForeColor = SystemColors.ButtonHighlight;
            ButtonEftpos.Location = new Point(411, 356);
            ButtonEftpos.Margin = new Padding(4, 5, 4, 5);
            ButtonEftpos.Name = "ButtonEftpos";
            ButtonEftpos.Size = new Size(146, 98);
            ButtonEftpos.TabIndex = 4;
            ButtonEftpos.Text = "EFTPOS / Card";
            ButtonEftpos.UseVisualStyleBackColor = false;
            ButtonEftpos.Click += ButtonEftpos_Click;
            // 
            // ButtonCashPayment
            // 
            ButtonCashPayment.Anchor = AnchorStyles.Top;
            ButtonCashPayment.BackColor = Color.RoyalBlue;
            ButtonCashPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCashPayment.ForeColor = SystemColors.ButtonHighlight;
            ButtonCashPayment.Location = new Point(411, 200);
            ButtonCashPayment.Margin = new Padding(4, 5, 4, 5);
            ButtonCashPayment.Name = "ButtonCashPayment";
            ButtonCashPayment.Size = new Size(146, 95);
            ButtonCashPayment.TabIndex = 8;
            ButtonCashPayment.Text = "Tender Cash";
            ButtonCashPayment.UseVisualStyleBackColor = false;
            ButtonCashPayment.Click += ButtonCashPayment_Click;
            // 
            // CheckoutScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 957);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1728, 1013);
            Name = "CheckoutScreen";
            Text = "CheckoutScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView OrderListView;
        private ColumnHeader Items;
        private ColumnHeader Price;
        private TextBox TextBoxAmountTendered;
        private Label label1;
        private Label LabelChange;
        private Button ButtonEftpos;
        private Button ButtonReturn;
        private Button ButtonCompletePayment;
        private Label LabelTotal;
        private Button ButtonCashPayment;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}