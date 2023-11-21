using HomeWork.Domain.Interface;

using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace HomeWork.Domain.Domain
{
    public class User : IAccount
    {
        private static int Id { get; set; } 
        public string FullName { get; set; }
        public string _email;

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    return;
                }
                Console.WriteLine("Sifre min 8 karakterden ibaret olmalidir , en az 1 boyuk 1 kicik herf ve 1 reqem olmalidir ");
            }
        }
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                if (EmailChecker(value))
                {
                    _email = value;
                    return;
                }
                Console.WriteLine("Emaili duzgun daxil edin");
            }
        }

        public User(string email, string pasword)
        {
            Password = pasword;
            Email = email;
            Id++;
        }


        public bool PasswordChecker(string password)
        {
            Regex paswordregex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            Match match = paswordregex.Match(password);

            return match.Success;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {FullName} {_email} ");
        }

        public bool EmailChecker(string email)
        {
            Regex emailregex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Match match = emailregex.Match(email);
            return match.Success;
        }
    }
}
