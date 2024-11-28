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

namespace OptionalLesson
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        OptionalLessonDbEntities db = new OptionalLessonDbEntities();
        private void btnBack_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLessonId_Click(object sender, EventArgs e)
        {

        }

        private void StudentNumber_Click(object sender, EventArgs e)
        {

        }

        private void LessonNumber_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TeacherNumber_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            StudentNumber.Text=db.TblStudent.Count().ToString();
            int values = (db.TblLesson.Select(x=>new
            {
                FullName = x.TeacherName + " " + x.TeacherSurname
            }).ToList()).Distinct().Count();
            TeacherSum.Text = values.ToString();
            lessonSum.Text = db.TblLesson.Count().ToString();
        }
    }
}
