namespace Demo03_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login user1 = new Login() { 
                Email = "samuel.legrain@bstorm.be"
            };

            user1.Password = "Test1234=";



            Console.WriteLine($"Votre email est {user1.Email}");
            //Impossible à lire pour la propriété Password, elle est WriteOnly
            //Console.WriteLine($"Votre mot de passe est {user1.Password}");

            string inputEmail, inputPassword;
            do
            {
                Console.WriteLine($"Veuillez indiquer votre email :");
                inputEmail = Console.ReadLine();
                Console.WriteLine($"Veuillez mot de passe :");
                inputPassword = Console.ReadLine();
            } while (!user1.CheckIdentity(inputEmail, inputPassword));
        }
    }
}
