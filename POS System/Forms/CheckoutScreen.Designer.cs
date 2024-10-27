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
            ButtonEftpos = new Button();
            ButtonReturn = new Button();
            ButtonCompletePayment = new Button();
            LabelTotal = new Label();
            ButtonCashPayment = new Button();
            SuspendLayout();
            // 
            // OrderListView
            // 
            OrderListView.Columns.AddRange(new ColumnHeader[] { Items, Price });
            OrderListView.Location = new Point(13, 75);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(262, 449);
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
            TextBoxAmountTendered.Location = new Point(344, 110);
            TextBoxAmountTendered.Name = "TextBoxAmountTendered";
            TextBoxAmountTendered.Size = new Size(99, 23);
            TextBoxAmountTendered.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 75);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 2;
            label1.Text = "Cash Tendered";
            label1.Click += label1_Click;
            // 
            // LabelChange
            // 
            LabelChange.AutoSize = true;
            LabelChange.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelChange.Location = new Point(335, 182);
            LabelChange.Name = "LabelChange";
            LabelChange.Size = new Size(99, 30);
            LabelChange.TabIndex = 3;
            LabelChange.Text = "Change: ";
            // 
            // ButtonEftpos
            // 
            ButtonEftpos.FlatStyle = FlatStyle.System;
            ButtonEftpos.Location = new Point(660, 231);
            ButtonEftpos.Name = "ButtonEftpos";
            ButtonEftpos.Size = new Size(102, 59);
            ButtonEftpos.TabIndex = 4;
            ButtonEftpos.Text = "EFTPOS / Card";
            ButtonEftpos.UseVisualStyleBackColor = true;
            ButtonEftpos.Click += ButtonEftpos_Click;
            // 
            // ButtonReturn
            // 
            ButtonReturn.Location = new Point(988, 34);
            ButtonReturn.Name = "ButtonReturn";
            ButtonReturn.Size = new Size(95, 62);
            ButtonReturn.TabIndex = 5;
            ButtonReturn.Text = "Return to menu";
            ButtonReturn.UseVisualStyleBackColor = true;
            ButtonReturn.Click += ButtonMenu_Click;
            // 
            // ButtonCompletePayment
            // 
            ButtonCompletePayment.Location = new Point(660, 296);
            ButtonCompletePayment.Name = "ButtonCompletePayment";
            ButtonCompletePayment.Size = new Size(102, 54);
            ButtonCompletePayment.TabIndex = 6;
            ButtonCompletePayment.Text = "Complete Order";
            ButtonCompletePayment.UseVisualStyleBackColor = true;
            ButtonCompletePayment.Click += ButtonCompletePayment_Click;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(13, 527);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(65, 25);
            LabelTotal.TabIndex = 7;
            LabelTotal.Text = "Total: ";
            // 
            // ButtonCashPayment
            // 
            ButtonCashPayment.Location = new Point(660, 168);
            ButtonCashPayment.Name = "ButtonCashPayment";
            ButtonCashPayment.Size = new Size(102, 57);
            ButtonCashPayment.TabIndex = 8;
            ButtonCashPayment.Text = "Tender Cash";
            ButtonCashPayment.UseVisualStyleBackColor = true;
            ButtonCashPayment.Click += ButtonCashPayment_Click;
            // 
            // CheckoutScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 574);
            Controls.Add(ButtonCashPayment);
            Controls.Add(LabelTotal);
            Controls.Add(ButtonCompletePayment);
            Controls.Add(ButtonReturn);
            Controls.Add(ButtonEftpos);
            Controls.Add(LabelChange);
            Controls.Add(label1);
            Controls.Add(TextBoxAmountTendered);
            Controls.Add(OrderListView);
            Name = "CheckoutScreen";
            Text = "CheckoutScreen";
            ResumeLayout(false);
            PerformLayout();
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
    }
}