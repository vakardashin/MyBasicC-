using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOopApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName) 
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
        }
		
		// Функция возвращает Имя Отчество Фамилия
        public string GetFullName()
        {
            string fullName = FirstName;
            if (MiddleName.Length > 0) fullName += " " + MiddleName;
            fullName += " " + LastName;
            return fullName;
        }
            
        // Функция возвращает Фамилия И.О.
        public string GetShortName()
        {
            string shortName = LastName;
            // char[] fN = FirstName.ToCharArray();
            char fN = FirstName[0];
            // char[] mN = MiddleName.ToCharArray();
            char mN = MiddleName[0];
            // shortName += " " + fN[0] + "." + mN[0] + ".";
            shortName += " " + fN + "." + mN + ".";
            return shortName;
        }
        

        public virtual string GetInfo()
        {
            string info = GetFullName();
            return info;
        }
    }
}
