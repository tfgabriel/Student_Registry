using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registry.Forms
{
    public partial class addgrade : Form
    {
        public addgrade()
        {
            InitializeComponent();
        }
        public string Grade;
        private void done_Click(object sender, EventArgs e)
        {
            
            Grade = comboBox1.SelectedItem.ToString() + "/" + monthCalendar1.SelectionStart.ToShortDateString().Split("/")[1] + "." + monthCalendar1.SelectionStart.ToShortDateString().Split("/")[0];
            this.Close();
            
        }

        private void addgrade_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add((i + 1).ToString());
            }
        }

        
    }
}
