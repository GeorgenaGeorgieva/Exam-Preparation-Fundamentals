using System;
using System.Text;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
           
            for (int i = 0; i < userNames.Length; i++)
            {
                string currentUser = userNames[i];
                bool isLengthValid = true;
                bool isContentValid = true;
                
                if (currentUser.Length < 3 || currentUser.Length > 16)
                {
                    isLengthValid = false;
                }
                
                for (int k = 0; k < currentUser.Length; k++)
                {
                    char currentSymbol = currentUser[k];
                    
                    if (!char.IsLetterOrDigit(currentSymbol) && currentSymbol != '-' && currentSymbol != '_')
                    {
                        isContentValid = false;
                        break;
                    } 
                }
                
                if (isLengthValid && isContentValid)
                {
                    Console.WriteLine(currentUser);
                }
            }
        }
    }
}
