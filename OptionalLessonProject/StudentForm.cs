using OptionalLessonProject;
using OptionalLessonProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OptionalLesson
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        OptionalLessonDbEntities db = new OptionalLessonDbEntities();
        private void btnBack_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblStudent.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblStudent student = new TblStudent();
            student.StudentName = txtStudentName.Text;
            student.StudentSurname = txtStudentSurname.Text;
            student.LessonId = (int)cmbLesson.SelectedValue;
            db.TblStudent.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Başarıyla Eklendi!");
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStudentId.Text);
            var removeValue = db.TblStudent.Find(id);
            db.TblStudent.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Başarıyla Silindi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStudentId.Text);
            var updateValue = db.TblStudent.Find(id);
            updateValue.StudentName = txtStudentName.Text;
            updateValue.StudentSurname = txtStudentSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnShowByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStudentId.Text);
            var values = db.TblStudent.Where(x => x.StudentId == id).ToList();
            dataGridView1.DataSource = values;
        }

        private void txtStudentSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblOptionalLesson_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'optionalLessonDbDataSet.TblLesson' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblLessonTableAdapter.Fill(this.optionalLessonDbDataSet.TblLesson);

        }
    }
}
