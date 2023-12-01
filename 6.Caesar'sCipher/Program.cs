using System;

namespace Caesar_sCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher (check Resources tab for more info) shifts each letter by a number of letters. If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet. In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.\nCreate a function that takes a string s(text to be encrypted) and an integer k(the rotation factor).It should return an encrypted string.");


            string text;
            int offset;

            Console.WriteLine("Give me the text and then press Enter: ");
            text = Console.ReadLine();
            Console.WriteLine("Give me the offset and then press Enter: ");
            offset = int.Parse( Console.ReadLine());



            caesarCipher(text,offset);



            Console.ReadLine();
        }

        private static void caesarCipher(string text, int offset)
        {
            char spliter = ' ';
            foreach (var item in text.Split())
            {
                foreach (var item2 in item)
                {
                    if ((item2 > 64 && item2 < 91) || (item2 > 96 && item2 < 122))
                    {
                        //Console.WriteLine(item2);
                    }
                    else
                    {
                        Console.WriteLine(spliter+=item2);
                        break;
                    }
                }
            }

            
        }
    }
}
