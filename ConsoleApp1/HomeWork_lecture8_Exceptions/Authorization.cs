using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture8_Exceptions
{
    /// <summary>
    ///Создать класс, в котором будет статический метод.
    //Этот метод принимает на вход три параметра: Login, Password, confirmPassword.
    //Все поля имеют тип данных String.
    //Длина login должна быть меньше 20 символов и не должен содержать пробелы.
    //Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
    //Длина password должна быть меньше 20 символов, не должен содержать пробел и должен содержать хотя бы одну цифру.
    //Также password и confirmPassword должны быть равны.
    //Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
    //WrongPasswordException и WrongLoginException - пользовательские классы-исключения с двумя конструкторами
    //один по умолчанию, второй принимает сообщение исключения и передает его в конструктор класса Exception.
    //Метод возвращает true, если значения верны или false в другом случае.
    /// </summary> 
    public class Authorization
    {
        Authorization authorization = new Authorization();
        public static bool Authorize(string login, string password, string confirmPassword)
        {
            if (login.Length == 0)
            {
                throw new WrongLoginException("Login is required");
            }
            if (login.Length > 20 || login.Contains(' '))
            {
                throw new WrongLoginException("Login should be less than 20 characters and should not contain any spaces");
            }

            if ((password.Length > 20) || (password.Contains(' ')) || (password.Length == 0))
            {
                throw new WrongPasswordException("Password is required, must be less than 20 characters, should not contain any spaces and should contain at least one digit");
            }
            else
            {
                if (password.GetHashCode() != confirmPassword.GetHashCode())
                {
                    throw new WrongPasswordException("Passwords don't match");
                }
            }
            return true;
        }
    }
}