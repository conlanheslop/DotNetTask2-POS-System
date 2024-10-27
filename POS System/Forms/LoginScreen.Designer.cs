namespace POS_System
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            label2 = new Label();
            PasswordTextBox = new MaskedTextBox();
            LoginButton = new Button();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            UsernameTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(340, 136);
            label2.Name = "label2";
            label2.Size = new Size(334, 54);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(341, 413);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(332, 34);
            PasswordTextBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.BackColor = Color.RoyalBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.HighlightText;
            LoginButton.Location = new Point(364, 551);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(285, 71);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(340, 204);
            label3.Name = "label3";
            label3.Size = new Size(333, 32);
            label3.TabIndex = 5;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(341, 364);
            label4.Name = "label4";
            label4.Size = new Size(331, 32);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 20);
            label1.Name = "label1";
            label1.Size = new Size(330, 45);
            label1.TabIndex = 0;
            label1.Text = "DotNET POS System";
            label1.Click += label1_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top;
            UsernameTextBox.Cursor = Cursors.IBeam;
            UsernameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextBox.Location = new Point(341, 253);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(332, 34);
            UsernameTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 9);
            tableLayoutPanel1.Controls.Add(label4, 0, 6);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 0, 7);
            tableLayoutPanel1.Controls.Add(UsernameTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1014, 722);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(385, 70);
            label5.Name = "label5";
            label5.Size = new Size(243, 38);
            label5.TabIndex = 7;
            label5.Text = "Point of sale system";
            label5.Click += label5_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1014, 722);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(0, 778);
            Name = "LoginScreen";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Login Menu";
            Load += LoginScreen_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private MaskedTextBox PasswordTextBox;
        private Button LoginButton;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox UsernameTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
    }
}
