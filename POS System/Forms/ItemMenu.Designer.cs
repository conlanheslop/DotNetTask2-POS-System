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
            LabelTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ButtonCompleteOrder = new Button();
            ButtonLogout = new Button();
            OrderListView = new ListView();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            MenuItemsListView = new ListView();
            ButtonSpecialFunctions = new Button();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelName.Location = new Point(12, 9);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(40, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRole.Location = new Point(194, 9);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(32, 15);
            LabelRole.TabIndex = 1;
            LabelRole.Text = "Role";
            // 
            // LabelDateAndTime
            // 
            LabelDateAndTime.AutoSize = true;
            LabelDateAndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDateAndTime.Location = new Point(334, 9);
            LabelDateAndTime.Name = "LabelDateAndTime";
            LabelDateAndTime.Size = new Size(88, 15);
            LabelDateAndTime.TabIndex = 2;
            LabelDateAndTime.Text = "Date and Time";
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(719, 503);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(67, 32);
            LabelTotal.TabIndex = 3;
            LabelTotal.Text = "Total";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // ButtonCompleteOrder
            // 
            ButtonCompleteOrder.Location = new Point(882, 262);
            ButtonCompleteOrder.Name = "ButtonCompleteOrder";
            ButtonCompleteOrder.Size = new Size(134, 71);
            ButtonCompleteOrder.TabIndex = 5;
            ButtonCompleteOrder.Text = "Complete Order";
            ButtonCompleteOrder.UseVisualStyleBackColor = true;
            ButtonCompleteOrder.Click += ButtonCompleteOrder_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(901, 99);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(99, 56);
            ButtonLogout.TabIndex = 6;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += LogoutButton_Click;
            // 
            // OrderListView
            // 
            OrderListView.Columns.AddRange(new ColumnHeader[] { Item, Price });
            OrderListView.Location = new Point(27, 90);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(187, 445);
            OrderListView.TabIndex = 7;
            OrderListView.UseCompatibleStateImageBehavior = false;
            OrderListView.View = View.Details;
            OrderListView.SelectedIndexChanged += OrderListView_SelectedIndexChanged_1;
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
            MenuItemsListView.Location = new Point(311, 90);
            MenuItemsListView.Name = "MenuItemsListView";
            MenuItemsListView.Size = new Size(555, 368);
            MenuItemsListView.TabIndex = 8;
            MenuItemsListView.UseCompatibleStateImageBehavior = false;
            MenuItemsListView.View = View.Tile;
            MenuItemsListView.ItemActivate += MenuItemsListView_ItemActivate;
            MenuItemsListView.SelectedIndexChanged += MenuItemsListView_SelectedIndexChanged;
            // 
            // ButtonSpecialFunctions
            // 
            ButtonSpecialFunctions.Location = new Point(901, 178);
            ButtonSpecialFunctions.Name = "ButtonSpecialFunctions";
            ButtonSpecialFunctions.Size = new Size(99, 58);
            ButtonSpecialFunctions.TabIndex = 9;
            ButtonSpecialFunctions.Text = "Special Functions";
            ButtonSpecialFunctions.UseVisualStyleBackColor = true;
            ButtonSpecialFunctions.Click += ButtonSpecialFunctions_click;
            // 
            // ItemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 681);
            Controls.Add(ButtonSpecialFunctions);
            Controls.Add(MenuItemsListView);
            Controls.Add(OrderListView);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonCompleteOrder);
            Controls.Add(LabelTotal);
            Controls.Add(LabelDateAndTime);
            Controls.Add(LabelRole);
            Controls.Add(LabelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemMenu";
            Text = "ItemMenu";
            Load += ItemMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private Label LabelRole;
        private Label LabelDateAndTime;
        private Label LabelTotal;
        private System.Windows.Forms.Timer timer1;
        private Button ButtonCompleteOrder;
        private Button ButtonLogout;
        private ListView OrderListView;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ListView MenuItemsListView;
        private Button ButtonSpecialFunctions;
    }
}