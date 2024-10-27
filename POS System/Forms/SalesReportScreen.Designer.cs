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
            ButtonBack = new Button();
            orderID = new ColumnHeader();
            itemID = new ColumnHeader();
            totalPrice = new ColumnHeader();
            dateAndTime = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(304, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "Sales Report";
            // 
            // SalesListView
            // 
            SalesListView.Columns.AddRange(new ColumnHeader[] { orderID, itemID, totalPrice, dateAndTime });
            SalesListView.Location = new Point(27, 87);
            SalesListView.Name = "SalesListView";
            SalesListView.Size = new Size(735, 351);
            SalesListView.TabIndex = 1;
            SalesListView.UseCompatibleStateImageBehavior = false;
            SalesListView.View = View.Details;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(582, 26);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(88, 43);
            ButtonBack.TabIndex = 2;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
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
            // SalesReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}