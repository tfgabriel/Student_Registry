using Student_Registry.Data;
using Student_Registry.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registry.UI
{
    public class Interface
    {
        public Management manager = new Management();
        public Button AdaugaNota(string name, Point point, int width, int height)
        {
            Button buton = new Button();
            buton.Name = name;
            buton.Width = width;
            buton.Height = height;
            buton.Location = point;
            buton.Click += new EventHandler(buton_Click);
            buton.Text = "Adauga Nota";

            return buton;
        }

        public void buton_Click(object sender, EventArgs e)
        {
            string grade;
            addgrade addgrade = new addgrade();
            addgrade.ShowDialog();

        }

        public Button AddClass(string classs)
        {
            Button buton = new Button();
            buton.Name = classs;
            buton.Text=classs;
            buton.Width = 60;
            buton.Height = 40;
            buton.Click +=new EventHandler(butonny_Click);

            return buton;
        }
        
        public void butonny_Click(object sender, EventArgs e)
        {
            
            string[] students = manager.BuildClass(button1.Text).Students.Split("/");

            Point point = new Point();
            Point panelpoint = new Point();
            int j = 0;
            foreach (string student in students)
            {
                
                point.X = 10;
                point.Y = 45 * j;

                panel2.Controls.Add(new Label { Text = student, Width = 150, Location = point });
                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 200, Location = point });
                point.X += 390;
                panel2.Controls.Add(AdaugaNota("buton" + j, point, 150, 35));

                j++;
            }
        }
    }
}
