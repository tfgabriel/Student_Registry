using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;

namespace Student_Registry.Data
{
    public class Security
    {
        public bool ValidEmail(string email)
        {
            if (email.Contains("@liceu.com"))
            {
                return true;
            }
            else return false;
        }

        public bool ValidPassword(string password)
        {
            int capitalletterct = 0;
            int numberct = 0;
            int signct = 0;

            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Password must be between 8 characters and 16 long.");
                return false;
            }

            foreach (char x in password)
            {
                if (x >= 'A' && x <= 'Z')
                    capitalletterct++;
                if (x >= '0' && x <= '9')
                    numberct++;
                if (x >= 33 && x <= 40 || x >= 92 && x <= 96 || x >= 123 && x <= 127)
                    signct++;
            }

            if (capitalletterct > 0 && numberct > 0 && signct > 0)
                return true;
            else
                MessageBox.Show("Password must have at least a sign, a capital letter and a number.");
            return false;
        }
        public string HashPassword(string passsword)
        {

            using var h = SHA256.Create();
            byte[] bytes = h.ComputeHash(Encoding.UTF8.GetBytes(passsword));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}