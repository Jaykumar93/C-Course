using System;

namespace AsciiExample
{
    class Program
    {
        static void Main()
        {
            char ch = 'A';
            byte b = (byte)ch;
            Console.WriteLine(b); //65
            char ch2 = (char)b;
            Console.WriteLine(ch2); //A

            //generate byte[]
            byte[] bytes = new byte[128];
            for (byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }
            string s = System.Text.Encoding.ASCII.GetString(bytes);
            Console.WriteLine(s);

            // string to byte[]
            string sentence = "THe quick brown for jumps over the lazy dog";
            byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(sentence);



            string sentence2 = "THe quick brown for jumps over the lazy dog";
            byte[] bytes22 = System.Text.Encoding.Unicode.GetBytes(sentence2);

            Console.ReadKey();
        }
    }
}
