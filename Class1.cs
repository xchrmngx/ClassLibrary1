using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mail_LIB
{
    public class Class1
    {
        public bool check_Mail(String mail) // Проверка правильности почты 
        {
            var trimmedEmail = mail.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        public bool check_Password(String password) // Проверка пароля
        {
            var regex = new Regex(@"([a - z].*[A - Z])|(.*[!,@,#,$,%,^,&,*,?,_,~])|(.*[1,2,3,4,5,6,7,8,9,0])");// Проверка на содержание нужных символов
            if (regex.IsMatch(password))
            {
                if (password.Length >= 8)// проверка длины пароля 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool check_login(string login) // Проверка логина
        {
            var regex = new Regex(@"([a - z].*[A - Z])|(.*[1,2,3,4,5,6,7,8,9,0])");// Проверка на содержание нужных символов
            if (regex.IsMatch(login))
            {
                if (login.Length >= 6)// проверка длины логина 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
