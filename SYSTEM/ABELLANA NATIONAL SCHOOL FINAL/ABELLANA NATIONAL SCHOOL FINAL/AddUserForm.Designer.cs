namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class AddUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbutype = new System.Windows.Forms.ComboBox();
            this.tBLUSERTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtUser_ID = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.PB_image = new System.Windows.Forms.PictureBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tBLUSERTYPEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.aNSDATABASEV2Dataset1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_USERTYPETableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSetTableAdapters.TBL_USERTYPETableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERTYPEBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEV2Dataset1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbutype);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtUser_ID);
            this.groupBox2.Controls.Add(this.txtMiddlename);
            this.groupBox2.Controls.Add(this.txtFirstname);
            this.groupBox2.Controls.Add(this.txtLastname);
            this.groupBox2.Controls.Add(this.PB_image);
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(64, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 382);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // cmbutype
            // 
            this.cmbutype.DataSource = this.tBLUSERTYPEBindingSource;
            this.cmbutype.DisplayMember = "USER_TYPE";
            this.cmbutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbutype.FormattingEnabled = true;
            this.cmbutype.Location = new System.Drawing.Point(185, 311);
            this.cmbutype.Name = "cmbutype";
            this.cmbutype.Size = new System.Drawing.Size(168, 26);
            this.cmbutype.TabIndex = 94;
            this.cmbutype.ValueMember = "USER_TYPEID";
            this.cmbutype.SelectedIndexChanged += new System.EventHandler(this.cmbutype_SelectedIndexChanged);
            // 
            // tBLUSERTYPEBindingSource
            // 
            this.tBLUSERTYPEBindingSource.DataMember = "TBL_USERTYPE";
            this.tBLUSERTYPEBindingSource.DataSource = this.aNS_DATABASEDataSet;
            // 
            // aNS_DATABASEDataSet
            // 
            this.aNS_DATABASEDataSet.DataSetName = "ANS_DATABASEDataSet";
            this.aNS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(36, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 93;
            this.label10.Text = "UserType :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(185, 195);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(303, 27);
            this.txtUsername.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 92;
            this.label7.Text = "Username:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(534, 253);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(211, 33);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUser_ID
            // 
            this.txtUser_ID.Enabled = false;
            this.txtUser_ID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser_ID.ForeColor = System.Drawing.Color.Black;
            this.txtUser_ID.Location = new System.Drawing.Point(185, 51);
            this.txtUser_ID.MaxLength = 50;
            this.txtUser_ID.Name = "txtUser_ID";
            this.txtUser_ID.Size = new System.Drawing.Size(303, 27);
            this.txtUser_ID.TabIndex = 68;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.ForeColor = System.Drawing.Color.Black;
            this.txtMiddlename.Location = new System.Drawing.Point(185, 156);
            this.txtMiddlename.MaxLength = 50;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(303, 27);
            this.txtMiddlename.TabIndex = 4;
            this.txtMiddlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddlename_KeyPress);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(185, 121);
            this.txtFirstname.MaxLength = 50;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(303, 27);
            this.txtFirstname.TabIndex = 3;
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.Location = new System.Drawing.Point(185, 86);
            this.txtLastname.MaxLength = 50;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(303, 27);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // PB_image
            // 
            this.PB_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_image.Location = new System.Drawing.Point(534, 62);
            this.PB_image.Name = "PB_image";
            this.PB_image.Size = new System.Drawing.Size(211, 185);
            this.PB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_image.TabIndex = 90;
            this.PB_image.TabStop = false;
            this.PB_image.Click += new System.EventHandler(this.PB_image_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtContactNo.Location = new System.Drawing.Point(185, 272);
            this.txtContactNo.MaxLength = 11;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(303, 27);
            this.txtContactNo.TabIndex = 8;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(185, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(303, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Middlename :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(36, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 18);
            this.Label1.TabIndex = 73;
            this.Label1.Text = "User ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 74;
            this.label8.Text = "Firstname :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(36, 89);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 18);
            this.Label2.TabIndex = 74;
            this.Label2.Text = "Lastname :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(36, 275);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 18);
            this.Label3.TabIndex = 75;
            this.Label3.Text = "Contact No :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(36, 240);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(98, 18);
            this.Label6.TabIndex = 78;
            this.Label6.Text = "Password :";
            // 
            // tBLUSERTYPEBindingSource1
            // 
            this.tBLUSERTYPEBindingSource1.DataMember = "TBL_USERTYPE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1033, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 378);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(35, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 38);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(35, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(35, 157);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(122, 38);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 103;
            this.label4.Text = "ADD USER";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(1324, 12);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 31);
            this.Button3.TabIndex = 102;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tBL_USERTYPETableAdapter
            // 
            this.tBL_USERTYPETableAdapter.ClearBeforeFill = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddUserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUserForm_FormClosed);
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERTYPEBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEV2Dataset1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtUser_ID;
        internal System.Windows.Forms.TextBox txtMiddlename;
        internal System.Windows.Forms.TextBox txtFirstname;
        internal System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.PictureBox PB_image;
        internal System.Windows.Forms.TextBox txtContactNo;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbutype;
        private System.Windows.Forms.BindingSource aNSDATABASEV2Dataset1BindingSource;
        private ANS_DATABASEDataSet aNS_DATABASEDataSet;
        private System.Windows.Forms.BindingSource tBLUSERTYPEBindingSource;
        private ANS_DATABASEDataSetTableAdapters.TBL_USERTYPETableAdapter tBL_USERTYPETableAdapter;
        private System.Windows.Forms.BindingSource tBLUSERTYPEBindingSource1;
    }
}