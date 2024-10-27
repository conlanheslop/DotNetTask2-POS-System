namespace POS_System.Forms
{
    partial class SalesReportScreen
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
            SalesListView = new ListView();
            orderID = new ColumnHeader();
            itemID = new ColumnHeader();
            totalPrice = new ColumnHeader();
            dateAndTime = new ColumnHeader();
            ButtonBack = new Button();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            LabelTo = new Label();
            ButtonFilter = new Button();
            LabelFilterError = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(457, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 48);
            label1.TabIndex = 0;
            label1.Text = "Sales Report";
            // 
            // SalesListView
            // 
            SalesListView.Anchor = AnchorStyles.None;
            SalesListView.Columns.AddRange(new ColumnHeader[] { orderID, itemID, totalPrice, dateAndTime });
            SalesListView.Location = new Point(38, 18);
            SalesListView.Margin = new Padding(4, 5, 4, 5);
            SalesListView.Name = "SalesListView";
            SalesListView.Size = new Size(1067, 530);
            SalesListView.TabIndex = 1;
            SalesListView.UseCompatibleStateImageBehavior = false;
            SalesListView.View = View.Details;
            // 
            // orderID
            // 
            orderID.Text = "Order ID";
            orderID.Width = 130;
            // 
            // itemID
            // 
            itemID.Text = "Item IDs";
            itemID.Width = 260;
            // 
            // totalPrice
            // 
            totalPrice.Text = "Total Price";
            totalPrice.Width = 130;
            // 
            // dateAndTime
            // 
            dateAndTime.Text = "Date / Time";
            dateAndTime.Width = 160;
            // 
            // ButtonBack
            // 
            ButtonBack.Anchor = AnchorStyles.None;
            ButtonBack.Location = new Point(980, 11);
            ButtonBack.Margin = new Padding(4, 5, 4, 5);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(126, 42);
            ButtonBack.TabIndex = 2;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Anchor = AnchorStyles.None;
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(38, 16);
            StartDatePicker.Margin = new Padding(4, 5, 4, 5);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(148, 31);
            StartDatePicker.TabIndex = 3;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Anchor = AnchorStyles.None;
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(323, 16);
            EndDatePicker.Margin = new Padding(4, 5, 4, 5);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(148, 31);
            EndDatePicker.TabIndex = 4;
            // 
            // LabelTo
            // 
            LabelTo.Anchor = AnchorStyles.None;
            LabelTo.AutoSize = true;
            LabelTo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTo.Location = new Point(242, 16);
            LabelTo.Margin = new Padding(4, 0, 4, 0);
            LabelTo.Name = "LabelTo";
            LabelTo.Size = new Size(37, 31);
            LabelTo.TabIndex = 5;
            LabelTo.Text = "to";
            LabelTo.UseMnemonic = false;
            // 
            // ButtonFilter
            // 
            ButtonFilter.Anchor = AnchorStyles.Left;
            ButtonFilter.Location = new Point(502, 11);
            ButtonFilter.Margin = new Padding(4, 5, 4, 5);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(117, 42);
            ButtonFilter.TabIndex = 6;
            ButtonFilter.Text = "Filter";
            ButtonFilter.UseVisualStyleBackColor = true;
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // LabelFilterError
            // 
            LabelFilterError.AutoSize = true;
            LabelFilterError.BackColor = SystemColors.ControlLightLight;
            LabelFilterError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFilterError.ForeColor = Color.Red;
            LabelFilterError.Location = new Point(39, 80);
            LabelFilterError.Margin = new Padding(4, 0, 4, 0);
            LabelFilterError.Name = "LabelFilterError";
            LabelFilterError.Size = new Size(0, 40);
            LabelFilterError.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1143, 120);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.01351F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.9864864F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 445F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel2.Controls.Add(ButtonBack, 4, 0);
            tableLayoutPanel2.Controls.Add(ButtonFilter, 3, 0);
            tableLayoutPanel2.Controls.Add(LabelTo, 1, 0);
            tableLayoutPanel2.Controls.Add(EndDatePicker, 2, 0);
            tableLayoutPanel2.Controls.Add(StartDatePicker, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 120);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1143, 64);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(SalesListView, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 184);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1143, 566);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // SalesReportScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(LabelFilterError);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SalesReportScreen";
            Text = "SalesReportScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView SalesListView;
        private Button ButtonBack;
        private ColumnHeader orderID;
        private ColumnHeader itemID;
        private ColumnHeader totalPrice;
        private ColumnHeader dateAndTime;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Label LabelTo;
        private Button ButtonFilter;
        private Label LabelFilterError;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}