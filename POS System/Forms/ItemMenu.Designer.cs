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
            ButtonLogout = new Button();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelName.Location = new Point(12, 9);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(93, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Logged in User:";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRole.Location = new Point(12, 36);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(35, 15);
            LabelRole.TabIndex = 1;
            LabelRole.Text = "Role:";
            // 
            // LabelDateAndTime
            // 
            LabelDateAndTime.AutoSize = true;
            LabelDateAndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDateAndTime.Location = new Point(12, 61);
            LabelDateAndTime.Name = "LabelDateAndTime";
            LabelDateAndTime.Size = new Size(88, 15);
            LabelDateAndTime.TabIndex = 2;
            LabelDateAndTime.Text = "Date and Time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogout.Location = new Point(844, 24);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(77, 39);
            ButtonLogout.TabIndex = 3;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += button1_Click;
            // 
            // ItemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 738);
            Controls.Add(ButtonLogout);
            Controls.Add(LabelDateAndTime);
            Controls.Add(LabelRole);
            Controls.Add(LabelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ItemMenu";
            Text = "Item Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private Label LabelRole;
        private Label LabelDateAndTime;
        private System.Windows.Forms.Timer timer1;
        private Button ButtonLogout;
    }
}