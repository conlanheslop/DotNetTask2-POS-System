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
            ButtonLogout = new Button();
            ButtonSpecialFunctions = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelName.Location = new Point(3, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(49, 19);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRole.Location = new Point(198, 0);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(39, 19);
            LabelRole.TabIndex = 1;
            LabelRole.Text = "Role";
            // 
            // LabelDateAndTime
            // 
            LabelDateAndTime.AutoSize = true;
            LabelDateAndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDateAndTime.Location = new Point(400, 0);
            LabelDateAndTime.Name = "LabelDateAndTime";
            LabelDateAndTime.Size = new Size(106, 19);
            LabelDateAndTime.TabIndex = 2;
            LabelDateAndTime.Text = "Date and Time";
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
            ButtonCompleteOrder.Location = new Point(875, 573);
            ButtonCompleteOrder.Name = "ButtonCompleteOrder";
            ButtonCompleteOrder.Size = new Size(162, 43);
            ButtonCompleteOrder.TabIndex = 5;
            ButtonCompleteOrder.Text = "Proceed";
            ButtonCompleteOrder.UseVisualStyleBackColor = false;
            ButtonCompleteOrder.Click += ButtonCompleteOrder_Click;
            // 
            // LabelTotal
            // 
            LabelTotal.Anchor = AnchorStyles.Left;
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(3, 582);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(73, 32);
            LabelTotal.TabIndex = 3;
            LabelTotal.Text = "Total:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 469F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel2.Controls.Add(LabelDateAndTime, 2, 0);
            tableLayoutPanel2.Controls.Add(LabelName, 0, 0);
            tableLayoutPanel2.Controls.Add(LabelRole, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1047, 55);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // OrderListView
            // 
            OrderListView.Columns.AddRange(new ColumnHeader[] { Item, Price });
            OrderListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderListView.Location = new Point(3, 3);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(237, 471);
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
            MenuItemsListView.Location = new Point(491, 3);
            MenuItemsListView.Name = "MenuItemsListView";
            MenuItemsListView.Size = new Size(370, 488);
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
            // ButtonSpecialFunctions
            // 
            ButtonSpecialFunctions.Anchor = AnchorStyles.None;
            ButtonSpecialFunctions.BackColor = Color.RoyalBlue;
            ButtonSpecialFunctions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSpecialFunctions.ForeColor = SystemColors.ButtonHighlight;
            ButtonSpecialFunctions.Location = new Point(873, 508);
            ButtonSpecialFunctions.Name = "ButtonSpecialFunctions";
            ButtonSpecialFunctions.Size = new Size(165, 42);
            ButtonSpecialFunctions.TabIndex = 10;
            ButtonSpecialFunctions.Text = "Special Functions";
            ButtonSpecialFunctions.UseVisualStyleBackColor = false;
            ButtonSpecialFunctions.Click += ButtonSpecialFunctions_click;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 681);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemMenu";
            Text = "ItemMenu";
            Load += ItemMenu_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label LabelName;
        private Label LabelRole;
        private Label LabelDateAndTime;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ButtonCompleteOrder;
        private Label LabelTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView OrderListView;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ListView MenuItemsListView;
        private Button ButtonLogout;
        private Button ButtonSpecialFunctions;
        private TableLayoutPanel tableLayoutPanel1;
    }
}