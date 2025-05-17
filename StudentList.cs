using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSM
{
    public partial class StudentList : Form
    {
        private Form mainForm;
        public StudentList(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new ScoreEntry();
            mainForm.Hide();
            form.ShowDialog();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new LearningHistory();
            mainForm.Hide();
            form.ShowDialog();
            mainForm.Show();
        }
    }
}
