
namespace GUI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pLogin = new System.Windows.Forms.Panel();
            this.bLoginUserGuest = new System.Windows.Forms.Button();
            this.tituleLogin1 = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pPassword = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.Label();
            this.tituleLogin = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pLogin.Controls.Add(this.bLoginUserGuest);
            this.pLogin.Controls.Add(this.tituleLogin1);
            this.pLogin.Controls.Add(this.cbShowPassword);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbUser);
            this.pLogin.Controls.Add(this.pPassword);
            this.pLogin.Controls.Add(this.pUser);
            this.pLogin.Controls.Add(this.tituleLogin);
            this.pLogin.Location = new System.Drawing.Point(333, 127);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(185, 236);
            this.pLogin.TabIndex = 0;
            // 
            // bLoginUserGuest
            // 
            this.bLoginUserGuest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLoginUserGuest.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bLoginUserGuest.Location = new System.Drawing.Point(51, 180);
            this.bLoginUserGuest.Name = "bLoginUserGuest";
            this.bLoginUserGuest.Size = new System.Drawing.Size(85, 22);
            this.bLoginUserGuest.TabIndex = 8;
            this.bLoginUserGuest.Text = "Login as guest";
            this.bLoginUserGuest.UseVisualStyleBackColor = false;
            this.bLoginUserGuest.Click += new System.EventHandler(this.bLoginUserGuest_Click);
            // 
            // tituleLogin1
            // 
            this.tituleLogin1.AutoSize = true;
            this.tituleLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleLogin1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleLogin1.Location = new System.Drawing.Point(22, 45);
            this.tituleLogin1.Name = "tituleLogin1";
            this.tituleLogin1.Size = new System.Drawing.Size(147, 25);
            this.tituleLogin1.TabIndex = 7;
            this.tituleLogin1.Text = "Management";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbShowPassword.Location = new System.Drawing.Point(3, 214);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbShowPassword.TabIndex = 6;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bLogin.Location = new System.Drawing.Point(51, 152);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(85, 22);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(22, 126);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(143, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(22, 89);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(143, 20);
            this.tbUser.TabIndex = 3;
            // 
            // pPassword
            // 
            this.pPassword.AutoSize = true;
            this.pPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pPassword.Location = new System.Drawing.Point(19, 110);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(53, 13);
            this.pPassword.TabIndex = 2;
            this.pPassword.Text = "Password";
            // 
            // pUser
            // 
            this.pUser.AutoSize = true;
            this.pUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pUser.Location = new System.Drawing.Point(19, 73);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(29, 13);
            this.pUser.TabIndex = 1;
            this.pUser.Text = "User";
            // 
            // tituleLogin
            // 
            this.tituleLogin.AutoSize = true;
            this.tituleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleLogin.Location = new System.Drawing.Point(46, 17);
            this.tituleLogin.Name = "tituleLogin";
            this.tituleLogin.Size = new System.Drawing.Size(93, 25);
            this.tituleLogin.TabIndex = 0;
            this.tituleLogin.Text = "Catalog";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bExit.Location = new System.Drawing.Point(737, 446);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(85, 22);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog Management - Login";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label tituleLogin;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label pPassword;
        private System.Windows.Forms.Label pUser;
        private System.Windows.Forms.Button bLoginUserGuest;
        private System.Windows.Forms.Label tituleLogin1;
        private System.Windows.Forms.Button bExit;
    }
}

