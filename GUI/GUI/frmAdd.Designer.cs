
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
            this.lImage = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lCategory = new System.Windows.Forms.Label();
            this.tbCodeArt = new System.Windows.Forms.TextBox();
            this.lMarc = new System.Windows.Forms.Label();
            this.bAddArticle = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lCodeArt = new System.Windows.Forms.Label();
            this.cbMarc = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
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
            this.tituleMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain1.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain1.Location = new System.Drawing.Point(84, 17);
            this.tituleMain1.Name = "tituleMain1";
            this.tituleMain1.Size = new System.Drawing.Size(147, 25);
            this.tituleMain1.TabIndex = 9;
            this.tituleMain1.Text = "Management";
            // 
            // tituleMain
            // 
            this.tituleMain.AutoSize = true;
            this.tituleMain.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain.Location = new System.Drawing.Point(3, 17);
            this.tituleMain.Name = "tituleMain";
            this.tituleMain.Size = new System.Drawing.Size(93, 25);
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
            this.bExit.TabIndex = 8;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lImage
            // 
            this.lImage.AutoSize = true;
            this.lImage.Location = new System.Drawing.Point(224, 335);
            this.lImage.Name = "lImage";
            this.lImage.Size = new System.Drawing.Size(69, 13);
            this.lImage.TabIndex = 43;
            this.lImage.Text = "URL Images:";
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(227, 351);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(416, 20);
            this.tbImage.TabIndex = 6;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(224, 296);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(34, 13);
            this.lPrice.TabIndex = 41;
            this.lPrice.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(227, 312);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(416, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(224, 257);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(52, 13);
            this.lCategory.TabIndex = 39;
            this.lCategory.Text = "Category:";
            // 
            // tbCodeArt
            // 
            this.tbCodeArt.Location = new System.Drawing.Point(227, 117);
            this.tbCodeArt.Name = "tbCodeArt";
            this.tbCodeArt.Size = new System.Drawing.Size(416, 20);
            this.tbCodeArt.TabIndex = 0;
            // 
            // lMarc
            // 
            this.lMarc.AutoSize = true;
            this.lMarc.Location = new System.Drawing.Point(224, 218);
            this.lMarc.Name = "lMarc";
            this.lMarc.Size = new System.Drawing.Size(34, 13);
            this.lMarc.TabIndex = 36;
            this.lMarc.Text = "Marc:";
            // 
            // bAddArticle
            // 
            this.bAddArticle.Location = new System.Drawing.Point(402, 405);
            this.bAddArticle.Name = "bAddArticle";
            this.bAddArticle.Size = new System.Drawing.Size(75, 23);
            this.bAddArticle.TabIndex = 7;
            this.bAddArticle.Text = "Add";
            this.bAddArticle.UseVisualStyleBackColor = true;
            this.bAddArticle.Click += new System.EventHandler(this.bAddArticle_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(227, 195);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(416, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(227, 156);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(416, 20);
            this.tbName.TabIndex = 1;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(224, 179);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(63, 13);
            this.lDescription.TabIndex = 31;
            this.lDescription.Text = "Description:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(224, 140);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 30;
            this.lName.Text = "Name:";
            // 
            // lCodeArt
            // 
            this.lCodeArt.AutoSize = true;
            this.lCodeArt.Location = new System.Drawing.Point(224, 101);
            this.lCodeArt.Name = "lCodeArt";
            this.lCodeArt.Size = new System.Drawing.Size(67, 13);
            this.lCodeArt.TabIndex = 29;
            this.lCodeArt.Text = "Code Article:";
            // 
            // cbMarc
            // 
            this.cbMarc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarc.FormattingEnabled = true;
            this.cbMarc.Location = new System.Drawing.Point(227, 235);
            this.cbMarc.Name = "cbMarc";
            this.cbMarc.Size = new System.Drawing.Size(416, 21);
            this.cbMarc.TabIndex = 44;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(227, 272);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(416, 21);
            this.cbCategory.TabIndex = 45;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbMarc);
            this.Controls.Add(this.lImage);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.tbCodeArt);
            this.Controls.Add(this.lMarc);
            this.Controls.Add(this.bAddArticle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCodeArt);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tituleUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label tituleMain1;
        private System.Windows.Forms.Label tituleMain;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lImage;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.TextBox tbCodeArt;
        private System.Windows.Forms.Label lMarc;
        private System.Windows.Forms.Button bAddArticle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCodeArt;
        private System.Windows.Forms.ComboBox cbMarc;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}