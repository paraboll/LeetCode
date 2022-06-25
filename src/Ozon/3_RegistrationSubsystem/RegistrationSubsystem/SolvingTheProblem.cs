using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegistrationSubsystem
{
    public static class SolvingTheProblem
    {
        public static string[] LoginValidation(string[] logins)
        {
            var validLogins = new List<string>();
            for(int i = 0;i < logins.Length; i++)
            {
                //Логин — это последовательность из латинских букв в любом регистре, цифр и символов «_» или «-» (подчеркивание и дефис).
                //Логин не должен начинаться с дефиса.
                //Логин должен иметь длину от 2 до 24 символов.
                //Логины, которые отличаются только регистром, считаются одинаковыми.
                var regex = new Regex(@"[0-9a-zA-Z_][0-9a-zA-Z_-]{1,23}");
                MatchCollection matches = regex.Matches(logins[i]);
                if(matches.Count > 0 && !validLogins.Any( x => x.ToLower() == matches.First().Value.ToLower() ))
                {
                    validLogins.Add(logins[i]);
                }
            }

            return validLogins.ToArray();
        }
    }
}
