using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Social_Media
{
    internal class Hovedbruker
    {
        private string _Name { get; set; }
        private int _Age { get; set; }

        private string _City { get; set; }

        private int _Born { get; set; }

        private string _Bio { get; set; }

        private List<Profilside> _friends { get; set; }

        private int _friendCounter;


        public Hovedbruker(string name, int age, string city, int born, string bio)
        {
            _Name = name;
            _Age = age;
            _City = city;
            _Born = born;
            _Bio = bio;
            _friends = new List<Profilside>();
          _friendCounter = 0;
        }




        public void addfriend(List<Profilside> profiler)
        {
            Console.WriteLine("skriv inn navn på person du vil legge til som venn");
            var ProfilName = Console.ReadLine();
            var selectedfriend = profiler.FirstOrDefault(p => p._Name == ProfilName);

            if(selectedfriend != null)
            {
                    _friends.Add(selectedfriend);
                    Console.WriteLine($"{selectedfriend._Name} har blitt lagt til i venneliste");
            }else
            {
                Console.WriteLine("Ugyldig navn prøv igjen");
            }
        }


        public void removeFriend()
        {
            Console.WriteLine("Skriv inn navn på venn du vil fjerne");
            var Friendname = Console.ReadLine();
            var selectedfriend = _friends.FirstOrDefault(p => p._Name==Friendname);

            if(selectedfriend != null)
            {
                _friends.Remove(selectedfriend);
            } else
            {
                Console.WriteLine("Ugyldig navn prøv igjen");
            }
        }


        public void HovedbrukerIntroduksjon()
        {
            Console.WriteLine();
            Console.WriteLine($" Profil {_Name}");
            Console.WriteLine("Status: <innlogget>");
            Console.WriteLine();
        }


        public void friendlist()
        {
            Console.WriteLine("FriendList");
            Console.WriteLine("------------");
            foreach (var friend in _friends)
            {
                friend.Friendsnformasjon();
                Console.WriteLine();
             
            }

       
        }



        public void friendinfoprofile()
        {
            for (int i = 0; i < _friends.Count; i++)
            {
                Profilside? friend = _friends[i];
           
                Console.WriteLine($"  {i + 1}. - {friend._Name}");
            }
            var input = Convert.ToInt32(Console.ReadLine());
                _friends[input -1].ProfilIntroduksjon();
            
        }
    }
}
