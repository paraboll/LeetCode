using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegistrationSubsystemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var _answers = new string[] { 
                "NO", "YES","YES","YES", "NO", "YES", "NO", "YES", "NO", "NO", 
                "NO", "YES", "YES", "NO", "YES", "YES", "NO", "YES", 
                "YES", "NO", "NO", "NO", "YES" }; //Убрать.

            using (StreamReader read = new StreamReader("TestData.txt"))//Убрать.
            { //Убрать.

                var CountSet = Convert.ToInt32(read.ReadLine()); //считываем количество считываний -- Убрать.
                //var CountSet = Convert.ToInt32(Console.ReadLine()); // Добавить.
                for (int i = 0; i < CountSet; i++)
                {
                    var validLogins = new HashSet<string>(); //Быстрее list.

                    //var countLogin = Convert.ToInt32(Console.ReadLine()); //Добавить.
                    var countLogin = Convert.ToInt32(read.ReadLine()); //Убрать.
                    for (int j = 0; j < countLogin; j++)
                    {
                        //var currentLogin = Console.ReadLine(); //Добавить.
                        var currentLogin = read.ReadLine().ToLower();//Убрать.
                        if (IsLoginValidation(currentLogin) && !validLogins.Contains(currentLogin))
                        {
                            validLogins.Add(currentLogin.ToLower());
                            Console.WriteLine("YES");
                            continue;
                        }

                        Console.WriteLine("NO");
                    }
                    Console.WriteLine();
                }
            } //Убрать.
        }

        public static bool IsLoginValidation(string login)
        {
            var regex = new Regex(@"^[0-9a-zA-Z_]{1}[0-9a-zA-Z_-]{1,23}$");
            MatchCollection matches = regex.Matches(login);
            if (matches.Count > 0) 
            {
                return true;
            }

            return false;
        }
    }
}
