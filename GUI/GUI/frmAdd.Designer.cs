
namespace GUI
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tituleUser = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tituleMain1 = new System.Windows.Forms.Label();
            this.tituleMain = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tituleUser);
            this.panel3.Controls.Add(this.pbxUser);
            this.panel3.Controls.Add(this.tituleMain1);
            this.panel3.Controls.Add(this.tituleMain);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 65);
            this.panel3.TabIndex = 1;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(762, 25);
            this.tituleUser.Name = "tituleUser";
            this.tituleUser.Size = new System.Drawing.Size(77, 13);
            this.tituleUser.TabIndex = 1;
            this.tituleUser.Text = "Maxi Programa";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUser.BackgroundImage")));
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Location = new System.Drawing.Point(749, 24);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(15, 15);
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            // 
            // tituleMain1
            // 
            this.tituleMain1.AutoSize = true;
            this.tituleMain1.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain1.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain1.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain1.Location = new System.Drawing.Point(84, 17);
            this.tituleMain1.Name = "tituleMain1";
            this.tituleMain1.Size = new System.Drawing.Size(145, 28);
            this.tituleMain1.TabIndex = 9;
            this.tituleMain1.Text = "Management";
            // 
            // tituleMain
            // 
            this.tituleMain.AutoSize = true;
            this.tituleMain.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain.Location = new System.Drawing.Point(3, 17);
            this.tituleMain.Name = "tituleMain";
            this.tituleMain.Size = new System.Drawing.Size(88, 28);
            this.tituleMain.TabIndex = 8;
            this.tituleMain.Text = "Catalog";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bExit.Location = new System.Drawing.Point(737, 446);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(85, 22);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tituleUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label tituleMain1;
        private System.Windows.Forms.Label tituleMain;
        private System.Windows.Forms.Button bExit;
    }
}