namespace JobApplication
{
    partial class FAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.gvCompany = new System.Windows.Forms.DataGridView();
            this.tabJobSeeker = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabEmployer = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPost = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabApplyForm = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComname = new System.Windows.Forms.TextBox();
            this.imgComlogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCominsert = new System.Windows.Forms.Button();
            this.btnComdelete = new System.Windows.Forms.Button();
            this.btnComupdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtComEmpComname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvComEmpCatalog = new System.Windows.Forms.DataGridView();
            this.txtComEmpEmpname = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).BeginInit();
            this.tabJobSeeker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComlogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComEmpCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabCompany);
            this.tabControl1.Controls.Add(this.tabJobSeeker);
            this.tabControl1.Controls.Add(this.tabEmployer);
            this.tabControl1.Controls.Add(this.tabPost);
            this.tabControl1.Controls.Add(this.tabApplyForm);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(210, 30);
            this.tabControl1.Location = new System.Drawing.Point(100, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1720, 880);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.gvComEmpCatalog);
            this.tabCompany.Controls.Add(this.panel2);
            this.tabCompany.Controls.Add(this.panel1);
            this.tabCompany.Controls.Add(this.gvCompany);
            this.tabCompany.Location = new System.Drawing.Point(4, 34);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompany.Size = new System.Drawing.Size(1712, 842);
            this.tabCompany.TabIndex = 0;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // gvCompany
            // 
            this.gvCompany.AllowUserToOrderColumns = true;
            this.gvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCompany.Location = new System.Drawing.Point(727, 6);
            this.gvCompany.Name = "gvCompany";
            this.gvCompany.RowHeadersWidth = 51;
            this.gvCompany.RowTemplate.Height = 24;
            this.gvCompany.Size = new System.Drawing.Size(979, 376);
            this.gvCompany.TabIndex = 0;
            // 
            // tabJobSeeker
            // 
            this.tabJobSeeker.Controls.Add(this.dataGridView2);
            this.tabJobSeeker.Location = new System.Drawing.Point(4, 34);
            this.tabJobSeeker.Name = "tabJobSeeker";
            this.tabJobSeeker.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobSeeker.Size = new System.Drawing.Size(1712, 842);
            this.tabJobSeeker.TabIndex = 1;
            this.tabJobSeeker.Text = "Job Seeker";
            this.tabJobSeeker.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(265, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(497, 299);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabEmployer
            // 
            this.tabEmployer.Controls.Add(this.dataGridView3);
            this.tabEmployer.Location = new System.Drawing.Point(4, 34);
            this.tabEmployer.Name = "tabEmployer";
            this.tabEmployer.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployer.Size = new System.Drawing.Size(1712, 842);
            this.tabEmployer.TabIndex = 2;
            this.tabEmployer.Text = "Employer";
            this.tabEmployer.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(265, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(497, 299);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPost
            // 
            this.tabPost.Controls.Add(this.dataGridView4);
            this.tabPost.Location = new System.Drawing.Point(4, 34);
            this.tabPost.Name = "tabPost";
            this.tabPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPost.Size = new System.Drawing.Size(1712, 842);
            this.tabPost.TabIndex = 3;
            this.tabPost.Text = "Post";
            this.tabPost.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(265, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(497, 299);
            this.dataGridView4.TabIndex = 2;
            // 
            // tabApplyForm
            // 
            this.tabApplyForm.Location = new System.Drawing.Point(4, 34);
            this.tabApplyForm.Name = "tabApplyForm";
            this.tabApplyForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplyForm.Size = new System.Drawing.Size(1712, 842);
            this.tabApplyForm.TabIndex = 4;
            this.tabApplyForm.Text = "Apply Form";
            this.tabApplyForm.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComupdate);
            this.panel1.Controls.Add(this.btnComdelete);
            this.panel1.Controls.Add(this.btnCominsert);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.imgComlogo);
            this.panel1.Controls.Add(this.txtComname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 376);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logo";
            // 
            // txtComname
            // 
            this.txtComname.Location = new System.Drawing.Point(109, 67);
            this.txtComname.Name = "txtComname";
            this.txtComname.Size = new System.Drawing.Size(233, 33);
            this.txtComname.TabIndex = 3;
            // 
            // imgComlogo
            // 
            this.imgComlogo.Location = new System.Drawing.Point(109, 121);
            this.imgComlogo.Name = "imgComlogo";
            this.imgComlogo.Size = new System.Drawing.Size(70, 70);
            this.imgComlogo.TabIndex = 4;
            this.imgComlogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCominsert
            // 
            this.btnCominsert.Location = new System.Drawing.Point(3, 327);
            this.btnCominsert.Name = "btnCominsert";
            this.btnCominsert.Size = new System.Drawing.Size(125, 46);
            this.btnCominsert.TabIndex = 6;
            this.btnCominsert.Text = "Insert";
            this.btnCominsert.UseVisualStyleBackColor = true;
            // 
            // btnComdelete
            // 
            this.btnComdelete.Location = new System.Drawing.Point(294, 327);
            this.btnComdelete.Name = "btnComdelete";
            this.btnComdelete.Size = new System.Drawing.Size(125, 46);
            this.btnComdelete.TabIndex = 7;
            this.btnComdelete.Text = "Delete";
            this.btnComdelete.UseVisualStyleBackColor = true;
            // 
            // btnComupdate
            // 
            this.btnComupdate.Location = new System.Drawing.Point(587, 327);
            this.btnComupdate.Name = "btnComupdate";
            this.btnComupdate.Size = new System.Drawing.Size(125, 46);
            this.btnComupdate.TabIndex = 8;
            this.btnComupdate.Text = "Update";
            this.btnComupdate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtComEmpEmpname);
            this.panel2.Controls.Add(this.txtComEmpComname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 376);
            this.panel2.TabIndex = 9;
            // 
            // txtComEmpComname
            // 
            this.txtComEmpComname.Location = new System.Drawing.Point(231, 85);
            this.txtComEmpComname.Name = "txtComEmpComname";
            this.txtComEmpComname.Size = new System.Drawing.Size(233, 33);
            this.txtComEmpComname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employer Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "ComEmpCatalog Data";
            // 
            // gvComEmpCatalog
            // 
            this.gvComEmpCatalog.AllowUserToOrderColumns = true;
            this.gvComEmpCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvComEmpCatalog.Location = new System.Drawing.Point(727, 460);
            this.gvComEmpCatalog.Name = "gvComEmpCatalog";
            this.gvComEmpCatalog.RowHeadersWidth = 51;
            this.gvComEmpCatalog.RowTemplate.Height = 24;
            this.gvComEmpCatalog.Size = new System.Drawing.Size(979, 376);
            this.gvComEmpCatalog.TabIndex = 10;
            // 
            // txtComEmpEmpname
            // 
            this.txtComEmpEmpname.Location = new System.Drawing.Point(231, 172);
            this.txtComEmpEmpname.Name = "txtComEmpEmpname";
            this.txtComEmpEmpname.Size = new System.Drawing.Size(233, 33);
            this.txtComEmpEmpname.TabIndex = 4;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tabControl1);
            this.Name = "FAdmin";
            this.Text = "FAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).EndInit();
            this.tabJobSeeker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabEmployer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComEmpCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.TabPage tabJobSeeker;
        private System.Windows.Forms.DataGridView gvCompany;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabEmployer;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPost;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabApplyForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgComlogo;
        private System.Windows.Forms.TextBox txtComname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComupdate;
        private System.Windows.Forms.Button btnComdelete;
        private System.Windows.Forms.Button btnCominsert;
        private System.Windows.Forms.DataGridView gvComEmpCatalog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtComEmpComname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComEmpEmpname;
    }
}