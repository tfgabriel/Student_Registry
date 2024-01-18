namespace Student_Registry
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        
        public Management manager = new Management();

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Security s = new Security();

            if (email.Text == string.Empty || password.Text == string.Empty)
            {
                MessageBox.Show("Please enter all the credentials.");
            }
            else if (!s.ValidEmail(email.Text))
            {
                MessageBox.Show("Please enter the correct email address.");
            }
            else if (email.Text != manager.CheckTeacher(email.Text).Email && s.HashPassword(password.Text) != manager.CheckTeacher(email.Text).Password) 
            {
                MessageBox.Show("Email address not in the data base or entered wrong password.");
            }
            else
            {
                
                Teacher teacher = manager.BuildTeacherModel(email.Text, s.HashPassword(password.Text));
                this.Visible = false;
                studentsform studentsform = new studentsform
                {
                    teacher = teacher,
                };

                studentsform.ShowDialog();
                this.Close();


            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            manager.LoadData();
        }
    }
}
