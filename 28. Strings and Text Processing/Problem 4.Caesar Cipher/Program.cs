namespace CaesarCipher
{
    using System;
    using System.Linq;
    using System.Text;
    
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine(); 
            
            StringBuilder encriptedText = new StringBuilder();
            
            for (int i = 0; i < inputLine.Length; i++)
            { 
                    char currentSimbol = inputLine[i];
                    int numberNextSymbol = currentSimbol + 3;
                    char nextsymbol = (char)numberNextSymbol;
                
                    encriptedText.Append(nextsymbol);    
            }
            
            Console.WriteLine(encriptedText);
        }
    }
}
