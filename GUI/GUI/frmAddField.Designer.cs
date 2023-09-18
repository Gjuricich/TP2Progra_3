
namespace GUI
{
    partial class frmAddField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddField));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tituleUser = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tituleMain1 = new System.Windows.Forms.Label();
            this.tituleMain = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lSelect = new System.Windows.Forms.Label();
            this.lMarc = new System.Windows.Forms.Label();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.lNewBrand = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.lBrand = new System.Windows.Forms.Label();
            this.lNewCategory = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.cbBrandCategory = new System.Windows.Forms.ComboBox();
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
            this.panel3.Size = new System.Drawing.Size(855, 73);
            this.panel3.TabIndex = 2;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(762, 34);
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
            this.pbxUser.Location = new System.Drawing.Point(749, 33);
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
            this.tituleMain1.Location = new System.Drawing.Point(92, 26);
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
            this.tituleMain.Location = new System.Drawing.Point(3, 26);
            this.tituleMain.Name = "tituleMain";
            this.tituleMain.Size = new System.Drawing.Size(93, 25);
            this.tituleMain.TabIndex = 8;
            this.tituleMain.Text = "Catalog";
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bClose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bClose.Location = new System.Drawing.Point(737, 446);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(85, 22);
            this.bClose.TabIndex = 9;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(274, 147);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(263, 21);
            this.cbSelect.TabIndex = 46;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // lSelect
            // 
            this.lSelect.AutoSize = true;
            this.lSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lSelect.Location = new System.Drawing.Point(271, 131);
            this.lSelect.Name = "lSelect";
            this.lSelect.Size = new System.Drawing.Size(69, 13);
            this.lSelect.TabIndex = 49;
            this.lSelect.Text = "Select option";
            // 
            // lMarc
            // 
            this.lMarc.AutoSize = true;
            this.lMarc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lMarc.Location = new System.Drawing.Point(271, 131);
            this.lMarc.Name = "lMarc";
            this.lMarc.Size = new System.Drawing.Size(0, 13);
            this.lMarc.TabIndex = 48;
            // 
            // tbNew
            // 
            this.tbNew.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNew.Location = new System.Drawing.Point(274, 258);
            this.tbNew.MaxLength = 50;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(263, 20);
            this.tbNew.TabIndex = 47;
            // 
            // lNewBrand
            // 
            this.lNewBrand.AutoSize = true;
            this.lNewBrand.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lNewBrand.Location = new System.Drawing.Point(271, 242);
            this.lNewBrand.Name = "lNewBrand";
            this.lNewBrand.Size = new System.Drawing.Size(85, 13);
            this.lNewBrand.TabIndex = 51;
            this.lNewBrand.Text = "New/Edit  brand";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAdd.Location = new System.Drawing.Point(582, 146);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 20);
            this.bAdd.TabIndex = 58;
            this.bAdd.Text = "Add ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bdelete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bdelete.Location = new System.Drawing.Point(582, 198);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(60, 20);
            this.bdelete.TabIndex = 59;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEdit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bEdit.Location = new System.Drawing.Point(582, 172);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(60, 20);
            this.bEdit.TabIndex = 60;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lBrand.Location = new System.Drawing.Point(271, 187);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(35, 13);
            this.lBrand.TabIndex = 61;
            this.lBrand.Text = "Brand";
            // 
            // lNewCategory
            // 
            this.lNewCategory.AutoSize = true;
            this.lNewCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lNewCategory.Location = new System.Drawing.Point(271, 242);
            this.lNewCategory.Name = "lNewCategory";
            this.lNewCategory.Size = new System.Drawing.Size(100, 13);
            this.lNewCategory.TabIndex = 62;
            this.lNewCategory.Text = "New/Edit  Category";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCategory.Location = new System.Drawing.Point(271, 187);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(49, 13);
            this.lCategory.TabIndex = 63;
            this.lCategory.Text = "Category";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bSave.Location = new System.Drawing.Point(380, 414);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(92, 23);
            this.bSave.TabIndex = 64;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbBrandCategory
            // 
            this.cbBrandCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbBrandCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBrandCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbBrandCategory.FormattingEnabled = true;
            this.cbBrandCategory.Location = new System.Drawing.Point(274, 203);
            this.cbBrandCategory.Name = "cbBrandCategory";
            this.cbBrandCategory.Size = new System.Drawing.Size(263, 21);
            this.cbBrandCategory.TabIndex = 65;
            // 
            // frmAddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.cbBrandCategory);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lNewCategory);
            this.Controls.Add(this.lBrand);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lNewBrand);
            this.Controls.Add(this.lSelect);
            this.Controls.Add(this.lMarc);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAdminBrandCategory_Load);
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
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lSelect;
        private System.Windows.Forms.Label lMarc;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Label lNewBrand;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lBrand;
        private System.Windows.Forms.Label lNewCategory;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cbBrandCategory;
    }
}