namespace ComLabManager.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            imageList1 = new ImageList(components);
            PBlogin = new PictureBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)PBlogin).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(397, 194);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter User Name";
            txtUsername.Size = new Size(291, 45);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(397, 273);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(291, 48);
            txtPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Aqua;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(397, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(291, 52);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // PBlogin
            // 
            PBlogin.Image = (Image)resources.GetObject("PBlogin.Image");
            PBlogin.Location = new Point(23, 12);
            PBlogin.Name = "PBlogin";
            PBlogin.Size = new Size(321, 542);
            PBlogin.SizeMode = PictureBoxSizeMode.Zoom;
            PBlogin.TabIndex = 2;
            PBlogin.TabStop = false;
            PBlogin.WaitOnLoad = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Sitka Small", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(350, 45);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(379, 58);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "WELCOME USER";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 566);
            Controls.Add(lblLogin);
            Controls.Add(PBlogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)PBlogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ImageList imageList1;
        private PictureBox PBlogin;
        private Label lblLogin;
    }
}