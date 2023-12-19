using System.Data;

namespace Social_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Profilside> profiler = new List<Profilside>();

            // hovedbruker
            Hovedbruker Mainuser = new Hovedbruker("Didrik", 23, "Porsgrunn", 230400,"Hei jeg liker og programmere");


            // nye profiler
            Profilside user1 = new Profilside("Hanne",22,"Elverum",23052001,"Jeg liker og dra på stranda");
            Profilside user2 = new Profilside("Stian", 25, "Elverum", 23052001, "Jeg liker og dra på stranda");
            Profilside user3 = new Profilside("David", 29, "Elverum", 23052001, "Jeg liker og dra på stranda");
            Profilside user4 = new Profilside("Silje", 18, "Elverum", 23052001, "jeg liker Data");
            Profilside user5 = new Profilside("Karoline", 23, "Elverum", 23052001, "Jeg liker og gå tur");
            Profilside user6 = new Profilside("Espen", 25, "Elverum", 23052001, "Jeg liker og svømme");
            profiler.Add(user1);
            profiler.Add(user2);    
            profiler.Add(user3);    
            profiler.Add(user4);
            profiler.Add(user5);
            profiler.Add(user6);

            

            bool friendFace = true;
            Console.WriteLine("Velkommen til FriendFace");
            while (friendFace)
            {
              
                Mainuser.HovedbrukerIntroduksjon();
                Console.WriteLine("1. Legg til Venn");
                Console.WriteLine("2. Fjern Venn");
                Console.WriteLine("3. Se venneliste");
                Console.WriteLine("4. velg en venn du vil se profilen til");
                Console.WriteLine("5. Slett logg");
                Console.WriteLine("6. exit FriendFace");

                var input = Console.ReadLine();


                switch (input)
                {

                    case "1":
                        Mainuser.addfriend(profiler);
                        break;

                    case "2":
                        Mainuser.removeFriend();
                        break;

                    case "3":
                        Mainuser.friendlist();        
                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("velg Venn du vil se profil til");
                        Mainuser.friendinfoprofile();
                        break;
                    
                        case "5":
                            Console.Clear();      
                        break;

                    case "6":
                        friendFace = false;
                        break;

                    default:
                        Console.WriteLine("Feil svar, prøv igjen");
                        break;

                }     
            }
        }
    }
}

/*
Her trenger en bruker en profilside med diverse info om seg

Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. 
Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

Lag et kommandbasert meny i konsollen der du kan:

Legge til forskjellige brukere som venn (på den som er innlogget)
Fjerne brukere som venn
Printe ut en liste av alle man har lagt til som venn
Velge en av vennene og printe ut profilinformasjonen deres. */