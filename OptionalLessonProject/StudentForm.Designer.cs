namespace OptionalLesson
{
    partial class StudentForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowByID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.lblOptionalLesson = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.optionalLessonDbDataSet = new OptionalLessonProject.OptionalLessonDbDataSet();
            this.tblLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLessonTableAdapter = new OptionalLessonProject.OptionalLessonDbDataSetTableAdapters.TblLessonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalLessonDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(22, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 43);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowByID
            // 
            this.btnShowByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowByID.Location = new System.Drawing.Point(161, 318);
            this.btnShowByID.Name = "btnShowByID";
            this.btnShowByID.Size = new System.Drawing.Size(161, 23);
            this.btnShowByID.TabIndex = 56;
            this.btnShowByID.Text = "ID\'ye göre listele";
            this.btnShowByID.UseVisualStyleBackColor = true;
            this.btnShowByID.Click += new System.EventHandler(this.btnShowByID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(161, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 23);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(161, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 23);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(161, 204);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(161, 23);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // cmbLesson
            // 
            this.cmbLesson.DataSource = this.tblLessonBindingSource;
            this.cmbLesson.DisplayMember = "LessonName";
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(161, 174);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(161, 24);
            this.cmbLesson.TabIndex = 52;
            this.cmbLesson.ValueMember = "LessonId";
            // 
            // lblOptionalLesson
            // 
            this.lblOptionalLesson.AutoSize = true;
            this.lblOptionalLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOptionalLesson.Location = new System.Drawing.Point(56, 177);
            this.lblOptionalLesson.Name = "lblOptionalLesson";
            this.lblOptionalLesson.Size = new System.Drawing.Size(100, 16);
            this.lblOptionalLesson.TabIndex = 51;
            this.lblOptionalLesson.Text = "Seçmeli Ders";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.Location = new System.Drawing.Point(42, 152);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(114, 16);
            this.lblStudentSurname.TabIndex = 50;
            this.lblStudentSurname.Text = "Öğrenci Soyadı";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(161, 146);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(161, 22);
            this.txtStudentSurname.TabIndex = 49;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(68, 124);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(88, 16);
            this.lblStudentName.TabIndex = 48;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(161, 118);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(161, 22);
            this.txtStudentName.TabIndex = 47;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentId.Location = new System.Drawing.Point(71, 96);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(85, 16);
            this.lblStudentId.TabIndex = 46;
            this.lblStudentId.Text = "Öğrenci No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 251);
            this.dataGridView1.TabIndex = 45;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(148, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 25);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Öğrenci İşlemleri";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(161, 90);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(161, 22);
            this.txtStudentId.TabIndex = 43;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(161, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // optionalLessonDbDataSet
            // 
            this.optionalLessonDbDataSet.DataSetName = "OptionalLessonDbDataSet";
            this.optionalLessonDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonBindingSource
            // 
            this.tblLessonBindingSource.DataMember = "TblLesson";
            this.tblLessonBindingSource.DataSource = this.optionalLessonDbDataSet;
            // 
            // tblLessonTableAdapter
            // 
            this.tblLessonTableAdapter.ClearBeforeFill = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowByID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.lblOptionalLesson);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnAdd);
            this.Name = "StudentForm";
            this.Text = "Öğrenci Formu";
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalLessonDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowByID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblOptionalLesson;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbLesson;
        private OptionalLessonProject.OptionalLessonDbDataSet optionalLessonDbDataSet;
        private System.Windows.Forms.BindingSource tblLessonBindingSource;
        private OptionalLessonProject.OptionalLessonDbDataSetTableAdapters.TblLessonTableAdapter tblLessonTableAdapter;
    }
}