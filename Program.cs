using System;
using System.Text;






namespace array_tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrie-ti mailul:");

            string email = Console.ReadLine();

            int @apare = email.IndexOf("@");

            string domain = email.Substring(0, @apare);
            string name = email.Substring(@apare);
            string emailAscuns;
            emailAscuns = EmailHide(domain);


            Console.WriteLine("emailul tau este " + emailAscuns + name);

        }
        public static string EmailHide(string domain)

        {
            StringBuilder email = new StringBuilder();

            int domainLenght = domain.Length;

            for (int i = 0; i < domainLenght; i++)
            {
                email.Append("#");

            }
            var emailUnu = email.ToString();
            return emailUnu;

        }
    }
}

