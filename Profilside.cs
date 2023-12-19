using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Social_Media
{
   public class Profilside
    {

        public string _Name {get; set; }
        private int _Age {get; set; }

        private string _City { get; set; }  

        private int _Born { get; set; }

        private string _Bio { get; set; }  
        
       



        public Profilside(string name, int age, string city, int born, string bio)
        {
           
            _Name = name;
            _Age = age;
            _City = city;
            _Born = born;
            _Bio = bio;
        }



        public void Friendsnformasjon()
        {
            Console.WriteLine($" - {_Name}");
        }



        public void ProfilIntroduksjon()
        {
            Console.WriteLine("Min FaceFriend profil");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Navn: {_Name}");
            Console.WriteLine($"Alder: {_Age}");
            Console.WriteLine($"By: {_City}");
            Console.WriteLine($"født: {_Born}");
            Console.WriteLine($"Informasjon om meg: {_Bio}");
        }
    }
}
