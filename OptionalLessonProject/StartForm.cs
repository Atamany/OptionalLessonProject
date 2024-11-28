using OptionalLesson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalLessonProject.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLesson_Click(object sender, EventArgs e)
        {
            LessonForm frmLesson = new LessonForm();
            frmLesson.Show();
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm frmStudent = new StudentForm();
            frmStudent.Show();
        }

        

        private void btnStatics_Click(object sender, EventArgs e)
        {
            StaticsForm frmStats = new StaticsForm();
            frmStats.Show();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLesson_Click_1(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistic_Click_1(object sender, EventArgs e)
        {

        }
    }
}
