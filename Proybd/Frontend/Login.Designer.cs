namespace Proybd
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblLogin = new Label();
            lblUsuario = new Label();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(676, 203);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(109, 47);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(363, 280);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(131, 44);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(352, 349);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(181, 44);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(562, 291);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(346, 33);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(562, 360);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 33);
            txtPassword.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Tan;
            btnIngresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(546, 439);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(164, 43);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseMnemonic = false;
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1199, 654);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
    }
}
