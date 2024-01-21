using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Registry.Data;
using Student_Registry.Models;
using Student_Registry.UI;

namespace Student_Registry
{
    public partial class studentsform : Form
    {
        public Teacher teacher;
        public studentsform()
        {
            InitializeComponent();
        }
        
        public Management manager = new Management();
        public Interface intf = new Interface();

        private void studentsform_Load(object sender, EventArgs e)
        {
            
            label2.Text = "Hello, " + teacher.Name + "!";
            string[] classes = teacher.Classes.Split(" ");

            int i = 0;
            Point point = new Point();
            //button1 .Text = classes[0];
            //button2 .Text = classes[1];
            //button3 .Text = classes[2];
            //button4 .Text = classes[3];

            foreach (string className in classes)
            {
                point.X = 10;
                point.Y = 45 * i;
                panel1.Controls.Add(intf.AddClass(className));

                i++;
            }
            //int j = 0;
            //foreach (Button button in panel1.Controls)
            //{
                //point.X = 10;
                //point.Y = 45 * j;
               // while (manager.BuildClass(button.Text).Students[j] != string.Empty)
               //     panel2.Controls.Add(new Label { Text = manager.BuildClass(button.Text).Students[j], Height = 40, Width = 150, Location = point });
              //  j++;
            //}

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string[] students = manager.BuildClass(button1.Text).Students.Split("/");
            
            Point point = new Point();
            int j = 0;
            foreach (string student in students)
            {
                point.X = 10;
                point.Y = 45*j;

                panel2.Controls.Add(new Label { Text = student , Width = 150, Location = point});
                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 200, Location = point });
                point.X += 390;
                panel2.Controls.Add(intf.AdaugaNota("buton"+j, point, 150, 35));

                j++;
            }
            
            //panel2.Controls.Add(new Button { Text = "Adauga Nota", Width = 150, Height = 35, Location = point, Name = "buton" });
            //panel2.Controls.Add(new Label { Text = students[0] + "\n" + students[1] + "\n" + students[2] });
            //panel2.Controls.Add(new Label { Text = students[0] + "\n" + students[1] + "\n" + students[2] });





            //panel2.Controls.Add(new Label { Text = manager.BuildClass(button1.Text).Students[j], Height = 40, Width = 150, Location = point });
            //j--;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string[] students = manager.BuildClass(button2.Text).Students.Split("/");

            Point point = new Point();
            int j = 0;
            foreach (string student in students)
            {
                point.X = 10;
                point.Y = 60 * j;
                int i = 1;

                panel2.Controls.Add(new Label { Text = student, Width = 200, Location = point });
                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 500, Location = point });
                
                j++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string[] students = manager.BuildClass(button3.Text).Students.Split("/");

            Point point = new Point();
            int j = 0;
            foreach (string student in students)
            {
                point.X = 10;
                point.Y = 60 * j;
                int i = 1;

                panel2.Controls.Add(new Label { Text = student, Width = 200, Location = point });
                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 500, Location = point });
                //point.X += 100;
                //panel2.Controls.Add(new Button { Text = "Adauga Nota", Width = 150, Location = point, Name = "buton"+j });

                j++;
            }

            //panel2.Controls.Add(new Button { Text = "Adauga Nota", Width = 150, Location = point,  });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string[] students = manager.BuildClass(button4.Text).Students.Split("/");

            Point point = new Point();
            int j = 0;
            foreach (string student in students)
            {
                point.X = 10;
                point.Y = 60 * j;
                int i = 1;

                panel2.Controls.Add(new Label { Text = student, Width = 200, Location = point });
                string grades = manager.BuildStudent(student).Grades;
                point.Y += 60;
                panel2.Controls.Add(new Label { Text = grades, Width = 500, Location = point });

                j++;
            }
        }
    }
}
