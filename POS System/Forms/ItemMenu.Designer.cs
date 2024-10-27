namespace POS_System.Forms
{
    partial class ItemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMenu));
            LabelName = new Label();
            LabelRole = new Label();
            LabelDateAndTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            ButtonCompleteOrder = new Button();
            LabelTotal = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            OrderListView = new ListView();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            MenuItemsListView = new ListView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonSpecialFunctions = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelName.Location = new Point(4, 0);
            LabelName.Margin = new Padding(4, 0, 4, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(68, 28);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRole.Location = new Point(351, 0);
            LabelRole.Margin = new Padding(4, 0, 4, 0);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(54, 28);
            LabelRole.TabIndex = 1;
            LabelRole.Text = "Role";
            // 
            // LabelDateAndTime
            // 
            LabelDateAndTime.AutoSize = true;
            LabelDateAndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDateAndTime.Location = new Point(703, 0);
            LabelDateAndTime.Margin = new Padding(4, 0, 4, 0);
            LabelDateAndTime.Name = "LabelDateAndTime";
            LabelDateAndTime.Size = new Size(151, 28);
            LabelDateAndTime.TabIndex = 2;
            LabelDateAndTime.Text = "Date and Time";
            // 
            // LabelTotal
            // 
            LabelTotal.Anchor = AnchorStyles.Left;
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(1240, 29);
            LabelTotal.Margin = new Padding(4, 0, 4, 0);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(109, 48);
            LabelTotal.TabIndex = 3;
            LabelTotal.Text = "Total:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.71251F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2874889F));
            tableLayoutPanel3.Controls.Add(ButtonCompleteOrder, 1, 1);
            tableLayoutPanel3.Controls.Add(LabelTotal, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 55);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.09375F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.90625F));
            tableLayoutPanel3.Size = new Size(1047, 626);
            tableLayoutPanel3.TabIndex = 17;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // ButtonCompleteOrder
            // 
            ButtonCompleteOrder.Anchor = AnchorStyles.Top;
            ButtonCompleteOrder.BackColor = Color.MediumSeaGreen;
            ButtonCompleteOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCompleteOrder.ForeColor = SystemColors.ButtonHighlight;
            ButtonCompleteOrder.Location = new Point(1250, 111);
            ButtonCompleteOrder.Margin = new Padding(4, 5, 4, 5);
            ButtonCompleteOrder.Name = "ButtonCompleteOrder";
            ButtonCompleteOrder.Size = new Size(231, 117);
            ButtonCompleteOrder.TabIndex = 5;
            ButtonCompleteOrder.Text = "Proceed";
            ButtonCompleteOrder.UseVisualStyleBackColor = false;
            ButtonCompleteOrder.Click += ButtonCompleteOrder_Click;
            // 
            // LabelTotal
            // 
            ButtonLogout.Anchor = AnchorStyles.Top;
            ButtonLogout.BackColor = Color.Firebrick;
            ButtonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogout.ForeColor = SystemColors.ButtonHighlight;
            ButtonLogout.Location = new Point(1247, 5);
            ButtonLogout.Margin = new Padding(4, 5, 4, 5);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(238, 76);
            ButtonLogout.TabIndex = 6;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = false;
            ButtonLogout.Click += LogoutButton_Click;
            // 
            // tableLayoutPanel2
            // 
            // 
            // OrderListView
            // 
            OrderListView.Columns.AddRange(new ColumnHeader[] { Item, Price });
            OrderListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderListView.Location = new Point(58, 5);
            OrderListView.Margin = new Padding(4, 5, 4, 5);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(346, 729);
            OrderListView.TabIndex = 7;
            OrderListView.UseCompatibleStateImageBehavior = false;
            OrderListView.View = View.Details;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 80;
            // 
            // MenuItemsListView
            // 
            MenuItemsListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MenuItemsListView.Location = new Point(502, 5);
            MenuItemsListView.Margin = new Padding(4, 5, 4, 5);
            MenuItemsListView.Name = "MenuItemsListView";
            MenuItemsListView.Size = new Size(728, 729);
            MenuItemsListView.TabIndex = 8;
            MenuItemsListView.UseCompatibleStateImageBehavior = false;
            MenuItemsListView.View = View.Tile;
            MenuItemsListView.Click += MenuItemsListView_ItemActivate;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Anchor = AnchorStyles.Top;
            ButtonLogout.BackColor = Color.Firebrick;
            ButtonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogout.ForeColor = SystemColors.ButtonHighlight;
            ButtonLogout.Location = new Point(872, 3);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(167, 46);
            ButtonLogout.TabIndex = 6;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = false;
            ButtonLogout.Click += LogoutButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7041435F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2958565F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 537F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tableLayoutPanel1.Controls.Add(ButtonSpecialFunctions, 3, 1);
            tableLayoutPanel1.Controls.Add(LabelName, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelRole, 1, 0);
            tableLayoutPanel1.Controls.Add(LabelDateAndTime, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonLogout, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9536438F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0463562F));
            tableLayoutPanel1.Size = new Size(1496, 151);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // ButtonSpecialFunctions
            // 
            ButtonSpecialFunctions.Anchor = AnchorStyles.None;
            ButtonSpecialFunctions.BackColor = Color.RoyalBlue;
            ButtonSpecialFunctions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSpecialFunctions.ForeColor = SystemColors.ButtonHighlight;
            ButtonSpecialFunctions.Location = new Point(1248, 99);
            ButtonSpecialFunctions.Margin = new Padding(4, 5, 4, 5);
            ButtonSpecialFunctions.Name = "ButtonSpecialFunctions";
            ButtonSpecialFunctions.Size = new Size(236, 39);
            ButtonSpecialFunctions.TabIndex = 10;
            ButtonSpecialFunctions.Text = "Special Functions";
            ButtonSpecialFunctions.UseVisualStyleBackColor = false;
            ButtonSpecialFunctions.Click += ButtonSpecialFunctions_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 444F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 738F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Controls.Add(MenuItemsListView, 2, 0);
            tableLayoutPanel2.Controls.Add(OrderListView, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 151);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1496, 739);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.62032F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3796787F));
            tableLayoutPanel3.Controls.Add(ButtonCompleteOrder, 1, 1);
            tableLayoutPanel3.Controls.Add(LabelTotal, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 890);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 43.3070869F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 56.6929131F));
            tableLayoutPanel3.Size = new Size(1496, 245);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7041435F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2958565F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 376F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.Controls.Add(ButtonSpecialFunctions, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonLogout, 3, 0);
            tableLayoutPanel1.Controls.Add(MenuItemsListView, 2, 0);
            tableLayoutPanel1.Controls.Add(OrderListView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.434166F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.565836F));
            tableLayoutPanel1.Size = new Size(1047, 562);
            tableLayoutPanel1.TabIndex = 15;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // ItemMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 1135);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1518, 1191);
            Name = "ItemMenu";
            Text = "ItemMenu";
            Load += ItemMenu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();

            ResumeLayout(false);
        }

        #endregion
        private Label LabelName;
        private Label LabelRole;
        private Label LabelDateAndTime;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ButtonCompleteOrder;
        private Button ButtonLogout;
        private Button ButtonSpecialFunctions;
        private ListView OrderListView;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ListView MenuItemsListView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}