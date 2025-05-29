namespace PhoneBook
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new PhoneBook.Database1DataSet();
            this.Name_Label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.Search_Label = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.delete_input = new System.Windows.Forms.TextBox();
            this.Delete_Label = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Update = new System.Windows.Forms.TextBox();
            this.Id_Update = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone_Update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phonesTableAdapter = new PhoneBook.Database1DataSetTableAdapters.PhonesTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.PhoneCol});
            this.dataGridView1.DataSource = this.phonesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(257, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "ID";
            this.IdCol.HeaderText = "ID";
            this.IdCol.MinimumWidth = 6;
            this.IdCol.Name = "IdCol";
            this.IdCol.Width = 125;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 6;
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 125;
            // 
            // PhoneCol
            // 
            this.PhoneCol.DataPropertyName = "Phone";
            this.PhoneCol.HeaderText = "Phone";
            this.PhoneCol.MinimumWidth = 6;
            this.PhoneCol.Name = "PhoneCol";
            this.PhoneCol.Width = 125;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Label.Location = new System.Drawing.Point(12, 70);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(89, 26);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name :";
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(99, 70);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 26);
            this.name.TabIndex = 2;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Label.ForeColor = System.Drawing.Color.Black;
            this.Phone_Label.Location = new System.Drawing.Point(1, 106);
            this.Phone_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(94, 26);
            this.Phone_Label.TabIndex = 3;
            this.Phone_Label.Text = "Phone :";
            this.Phone_Label.Click += new System.EventHandler(this.Phone_Label_Click);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(99, 106);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(134, 26);
            this.phone.TabIndex = 4;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Silver;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(56, 150);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 26);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // search_input
            // 
            this.search_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.Location = new System.Drawing.Point(100, 66);
            this.search_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_input.Multiline = true;
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(134, 26);
            this.search_input.TabIndex = 7;
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.ForeColor = System.Drawing.Color.Black;
            this.Search_Label.Location = new System.Drawing.Point(2, 66);
            this.Search_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(101, 26);
            this.Search_Label.TabIndex = 8;
            this.Search_Label.Text = "Search :";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(50, 114);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(134, 26);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete_input
            // 
            this.delete_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delete_input.Enabled = false;
            this.delete_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_input.Location = new System.Drawing.Point(99, 66);
            this.delete_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_input.Multiline = true;
            this.delete_input.Name = "delete_input";
            this.delete_input.Size = new System.Drawing.Size(134, 26);
            this.delete_input.TabIndex = 10;
            this.delete_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delete_input_KeyPress);
            // 
            // Delete_Label
            // 
            this.Delete_Label.AutoSize = true;
            this.Delete_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Label.ForeColor = System.Drawing.Color.Black;
            this.Delete_Label.Location = new System.Drawing.Point(3, 66);
            this.Delete_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Delete_Label.Name = "Delete_Label";
            this.Delete_Label.Size = new System.Drawing.Size(50, 26);
            this.Delete_Label.TabIndex = 11;
            this.Delete_Label.Text = "ID :";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(54, 114);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 26);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 72);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 288);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.Name_Label);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.Phone_Label);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(237, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "ADD NAME";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.search_input);
            this.tabPage2.Controls.Add(this.Search_Label);
            this.tabPage2.Controls.Add(this.search);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(237, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "SEARCH";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.delete_input);
            this.tabPage3.Controls.Add(this.Delete);
            this.tabPage3.Controls.Add(this.Delete_Label);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(237, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "DELETE";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.Name_Update);
            this.tabPage4.Controls.Add(this.Id_Update);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.Phone_Update);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(237, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "UPDATE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(51, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID :";
            // 
            // Name_Update
            // 
            this.Name_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Update.Location = new System.Drawing.Point(99, 132);
            this.Name_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_Update.Multiline = true;
            this.Name_Update.Name = "Name_Update";
            this.Name_Update.Size = new System.Drawing.Size(134, 26);
            this.Name_Update.TabIndex = 6;
            // 
            // Id_Update
            // 
            this.Id_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id_Update.Enabled = false;
            this.Id_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Update.Location = new System.Drawing.Point(99, 75);
            this.Id_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Id_Update.Multiline = true;
            this.Id_Update.Name = "Id_Update";
            this.Id_Update.Size = new System.Drawing.Size(134, 26);
            this.Id_Update.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name :";
            // 
            // Phone_Update
            // 
            this.Phone_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Update.Location = new System.Drawing.Point(99, 172);
            this.Phone_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Phone_Update.Multiline = true;
            this.Phone_Update.Name = "Phone_Update";
            this.Phone_Update.Size = new System.Drawing.Size(134, 26);
            this.Phone_Update.TabIndex = 6;
            this.Phone_Update.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_Update_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone :";
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phone Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(688, 618);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private Database1DataSetTableAdapters.PhonesTableAdapter phonesTableAdapter;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox delete_input;
        private System.Windows.Forms.Label Delete_Label;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Update;
        private System.Windows.Forms.TextBox Id_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Phone_Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.Label label8;
    }
}

