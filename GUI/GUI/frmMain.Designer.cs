
namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituleUser = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tituleMain1 = new System.Windows.Forms.Label();
            this.tituleMain = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tituleDescription = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tituleUser);
            this.panel1.Controls.Add(this.pbxUser);
            this.panel1.Controls.Add(this.tituleMain1);
            this.panel1.Controls.Add(this.tituleMain);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 65);
            this.panel1.TabIndex = 0;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(762, 25);
            this.tituleUser.Name = "tituleUser";
            this.tituleUser.Size = new System.Drawing.Size(58, 13);
            this.tituleUser.TabIndex = 1;
            this.tituleUser.Text = "User guest";
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
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbDescription.Location = new System.Drawing.Point(538, 281);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(259, 87);
            this.rtbDescription.TabIndex = 12;
            this.rtbDescription.Text = "";
            // 
            // tituleDescription
            // 
            this.tituleDescription.AutoSize = true;
            this.tituleDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleDescription.Location = new System.Drawing.Point(535, 265);
            this.tituleDescription.Name = "tituleDescription";
            this.tituleDescription.Size = new System.Drawing.Size(63, 13);
            this.tituleDescription.TabIndex = 13;
            this.tituleDescription.Text = "Description ";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(538, 82);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(259, 168);
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearch.Location = new System.Drawing.Point(17, 82);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(262, 20);
            this.tbSearch.TabIndex = 15;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAdd.Location = new System.Drawing.Point(538, 386);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 22);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Visible = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEdit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bEdit.Location = new System.Drawing.Point(639, 386);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(58, 22);
            this.bEdit.TabIndex = 17;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Visible = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bDelete.Location = new System.Drawing.Point(737, 386);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(60, 22);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tituleDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituleMain1;
        private System.Windows.Forms.Label tituleMain;
        private System.Windows.Forms.Label tituleUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label tituleDescription;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
    }
}