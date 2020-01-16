using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Problem_02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string artist = input.Substring(0, input.IndexOf(":"));
                string song = input.Substring(input.IndexOf(":") + 1);

                if (ValidatesArtist(artist) && ValidatesSong(song))
                {
                    int length = artist.Length;

                    StringBuilder buildText = new StringBuilder();

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ':')
                        {
                            buildText.Append('@');
                        }
                        else if (input[i] == ' ' || input[i] == '\'')
                        {
                            buildText.Append(input[i]);
                        }
                        else
                        {
                            char symbol = (char)(input[i] + length);

                            if (char.IsUpper(input[i]) && symbol > 'Z')
                            {
                                symbol = (char)(symbol - 26);
                            }
                            else if (char.IsLower(input[i]) && symbol > 'z')
                            {
                                symbol = (char)(symbol - 26);
                            }
                            buildText.Append(symbol);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {buildText.ToString()}");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
        public static bool ValidatesSong(string song)
        {
            bool isValid = true;

            for (int i = 0; i < song.Length; i++)
            {
                if (!char.IsUpper(song[i]) && song[i] != ' ')
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        public static bool ValidatesArtist(string artist)
        {
            bool isValid = true;

            if (!char.IsUpper(artist[0]))
            {
                isValid = false;
            }
            for (int i = 1; i < artist.Length; i++)
            {
                if (!char.IsLower(artist[i]) && artist[i] != ' ' && artist[i] != '\'')
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
