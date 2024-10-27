namespace POS_System.Forms
{
    partial class AuthorisationScreen
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new MaskedTextBox();
            LoginButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(418, 58);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 7;
            label1.Text = "DotNET POS System";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(374, 127);
            label2.Name = "label2";
            label2.Size = new Size(395, 48);
            label2.TabIndex = 8;
            label2.Text = "Manager Authorisation";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(372, 243);
            label3.Name = "label3";
            label3.Size = new Size(399, 49);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(367, 358);
            label4.Name = "label4";
            label4.Size = new Size(408, 53);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top;
            UsernameTextBox.Cursor = Cursors.IBeam;
            UsernameTextBox.Location = new Point(373, 295);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(397, 31);
            UsernameTextBox.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PasswordTextBox.Location = new Point(373, 414);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(397, 31);
            PasswordTextBox.TabIndex = 10;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Location = new Point(372, 610);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(399, 80);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += ButtonLogin_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 8);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(UsernameTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.63107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.36893F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 198F));
            tableLayoutPanel1.Size = new Size(1143, 750);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // AuthorisationScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AuthorisationScreen";
            Text = "AuthorisationScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UsernameTextBox;
        private MaskedTextBox PasswordTextBox;
        private Button LoginButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}