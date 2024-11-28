using OptionalLessonProject;
using OptionalLessonProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalLessonProject
{
    public partial class LessonForm : Form
    {
        public LessonForm()
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
            var values = db.TblLesson.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLesson lesson = new TblLesson();
            lesson.LessonName = txtLessonName.Text;
            lesson.TeacherName = txtTeacherName.Text;
            lesson.TeacherSurname = txtTeacherSurname.Text;
            db.TblLesson.Add(lesson);
            db.SaveChanges();
            MessageBox.Show("Ders Başarıyla Eklendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLessonId.Text);
            var removeValue = db.TblLesson.Find(id);
            db.TblLesson.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ders Başarıyla Silindi!");
        }

        private void txtLessonId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLessonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLessonId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLessonId.Text);
            var updateValue = db.TblLesson.Find(id);
            updateValue.LessonName = txtLessonName.Text;
            updateValue.TeacherName = txtTeacherName.Text;
            updateValue.TeacherSurname = txtTeacherSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnShowByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLessonId.Text);
            var values = db.TblLesson.Where(x => x.LessonId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
