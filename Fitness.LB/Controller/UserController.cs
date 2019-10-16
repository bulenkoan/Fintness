using Fitness.LB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Fitness.LB.Controller
{/// КОНТРОЛЛЕР ПОЬЗОВАТЕЛЯ.
/// </summary>
    public class UserController
    {
        public User User { get; }
        /// <summary>
        /// Создаие нового контроллера ползователя.
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height )
        {
            //TODO: check
            var gender = new Gender(genderName);            
            User = new User(userName, gender, birthDay,weight, height);

        }
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }

        }
        /*public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }

        }*/
        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получиь данные пользователя.
        /// </summary>

        // public UserController()
        //{
        // var formatter = new BinaryFormatter();

        //using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
        //{
        // if(formatter.Deserialize(fs) is User user)
        //{
        //   User = user;
        //}
        //}

    
    }
}
