using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registry
{
    public partial class studentsform : Form
    {
        public Teacher teacher;
        public studentsform()
        {
            InitializeComponent();
        }

        private void studentsform_Load(object sender, EventArgs e)
        {

            label2.Text = "Hello, " + teacher.Name + "!";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
