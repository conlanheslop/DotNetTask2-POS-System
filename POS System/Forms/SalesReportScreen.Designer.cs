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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "Sales Report";
            // 
            // SalesListView
            // 
            SalesListView.Columns.AddRange(new ColumnHeader[] { orderID, itemID, totalPrice, dateAndTime });
            SalesListView.Location = new Point(27, 115);
            SalesListView.Name = "SalesListView";
            SalesListView.Size = new Size(735, 323);
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
            ButtonBack.Location = new Point(674, 30);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(88, 43);
            ButtonBack.TabIndex = 2;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(27, 86);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(105, 23);
            StartDatePicker.TabIndex = 3;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(202, 86);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(105, 23);
            EndDatePicker.TabIndex = 4;
            // 
            // LabelTo
            // 
            LabelTo.AutoSize = true;
            LabelTo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTo.Location = new Point(155, 86);
            LabelTo.Name = "LabelTo";
            LabelTo.Size = new Size(24, 20);
            LabelTo.TabIndex = 5;
            LabelTo.Text = "to";
            LabelTo.UseMnemonic = false;
            // 
            // ButtonFilter
            // 
            ButtonFilter.Location = new Point(335, 84);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(82, 25);
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
            LabelFilterError.Location = new Point(27, 48);
            LabelFilterError.Name = "LabelFilterError";
            LabelFilterError.Size = new Size(0, 25);
            LabelFilterError.TabIndex = 7;
            // 
            // SalesReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelFilterError);
            Controls.Add(ButtonFilter);
            Controls.Add(LabelTo);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(ButtonBack);
            Controls.Add(SalesListView);
            Controls.Add(label1);
            Name = "SalesReportScreen";
            Text = "SalesReportScreen";
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
    }
}