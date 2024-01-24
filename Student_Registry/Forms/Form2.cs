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


namespace Student_Registry
{
    public partial class Studentsform : Form
    {
        public Teacher teacher;
        

        public Studentsform()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        public Management manager = new Management();

        public string grade;
        public int buttonpressed;
        public List<Label> label = new List<Label>();
        public List<Button> button = new List<Button>();


        private void studentsform_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add((i+1).ToString());
            }

            label2.Text = "Hello, " + teacher.Name + "!";
            string[] classes = teacher.Classes.Split(" ");

            //int i = 0;
            //Point point = new Point();

            button1.Text = classes[0];
            button2.Text = classes[1];
            button3.Text = classes[2];
            button4.Text = classes[3];

            /*foreach (string className in classes)
            {
                point.X = 10;
                point.Y = 45 * i;
                panel1.Controls.Add(intf.AddClass(className));

                i++;
            }*/


        }

        public Button AddGrade(string name, Point point, int width, int height)
        {
            Button buton = new Button
            {
                Name = name,
                Width = width,
                Height = height,
                Location = point,
                Text = "Add Grade",

            };
            buton.Click += new EventHandler(buton_Click);
            return buton;
        }

        public Label Grades(string name, Point point, int width, int height, string grades)
        {
            Label grade = new Label
            {

                Name = name,
                Width = width,
                Height = height,
                Location = point,
                Text = grades

            };


            return grade;
        }

        private void buton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label.Clear();
            panel2.Controls.Clear();
            string[] students = manager.BuildClass(button1.Text).Students.Split("/");
            Point point = new Point();
            int j = 0;

            foreach (string student in students)
            {
                point.X = 10;
                point.Y = 45 * j;

                panel2.Controls.Add(new Label { Text = student, Width = 150, Location = point });

                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;


                label.Add(Grades("grade" + j, point, 320, 35, grades));
                panel2.Controls.Add(label[j]);
                

                point.X += 390;
                button.Add(AddGrade("buton" + j, point, 150, 35));
                panel2.Controls.Add(button[j]);

                j++;
            }


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
                point.Y = 45 * j;

                panel2.Controls.Add(new Label { Text = student, Width = 150, Location = point });

                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 200, Location = point });

                point.X += 390;
                panel2.Controls.Add(AddGrade("buton" + j, point, 150, 35));

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
                point.Y = 45 * j;

                panel2.Controls.Add(new Label { Text = student, Width = 150, Location = point });

                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 200, Location = point });

                point.X += 390;
                panel2.Controls.Add(AddGrade("buton" + j, point, 150, 35));

                j++;
            }
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
                point.Y = 45 * j;

                panel2.Controls.Add(new Label { Text = student, Width = 150, Location = point });

                string grades = manager.BuildStudent(student).Grades;
                point.Y += 20;
                panel2.Controls.Add(new Label { Text = grades, Width = 200, Location = point });

                point.X += 390;
                panel2.Controls.Add(AddGrade("buton" + j, point, 150, 35));

                j++;
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString != null && monthCalendar1.SelectionStart.ToShortDateString() != null)
            {
                grade = comboBox1.SelectedItem.ToString() + "/" + monthCalendar1.SelectionStart.ToShortDateString().Split("/")[1] + "." + monthCalendar1.SelectionStart.ToShortDateString().Split("/")[0];
                
                label[0].Text += " " + grade;
            }
                

            else
                MessageBox.Show("Please select a date and a grade.");
        }
    }
}
