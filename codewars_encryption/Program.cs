using System;
using System.Linq;
namespace codewars_encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = Kata.Encrypt(null, 4);

            Console.WriteLine("Final Result: " + answer);
        }
    }

    public class Kata
    {
        public static string Encrypt(string text, int n)
        {
            if (n <= 0 || text == null)
            {
                return text;
            }
            else
            {
                for (int j = 1; j < n + 1; j++)
                {
                    string odds = "";
                    string evens = "";
                    var encryptArray = text.ToCharArray();
                    int stringlength = encryptArray.Length;
                    for (int i = 1; i < stringlength; i += 2)
                    {
                        odds += encryptArray[i];

                        //Console.WriteLine(odds);
                    }

                    for (int i = 0; i < stringlength; i += 2)
                    {
                        evens += encryptArray[i];

                        //Console.WriteLine(evens);
                    }
                    text = odds + evens;


                    Console.Write("encryption pass " + j + ": " + text + "  \n");
                }
                return text;
            }
        }




        public static string Decrypt(string encryptedText, int n)
        {
            if (n <= 0 || encryptedText == null)
            {
                return encryptedText;
            }
            else
            {
                for (int j = 1; j < n + 1; j++)
                    
                {
                    
                    var encryptArray = encryptedText.ToCharArray();
                    int stringlength = encryptArray.Length;

                    string odds = new string(encryptedText.Take(encryptedText.Length / 2).ToArray());

                    string evens = new string(encryptedText.Skip(encryptedText.Length / 2).ToArray());

                    encryptedText = "";

                    for (int i = 0; i < odds.Length + evens.Length; i ++)
                    {
                        if (i < evens.Length)
                        {
                            encryptedText += evens[i];
                        }

                        if (i < odds.Length)
                        {
                            encryptedText += odds[i];
                        }


                    }


                    Console.Write("decryption pass " + j + ": " + encryptedText + "  \n");
                }
                return encryptedText;
            }

        }
    }

}
