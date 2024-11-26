using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submit_Exercise
{
    internal class String
    {
        private static void Mainstring(string[] args)
        {
            /*string s = "A quote is an exact copy of someone else's words, usually enclosed" +
                " in quotation marks and credited to the original author or speaker.";
            int words = CountWords(s);
            Console.WriteLine(words);

            /*int pos = s.IndexOf("exact");
            Console.WriteLine(pos);

            s = s.Replace("exact", "same");
            Console.WriteLine(s);
            s =s.ToUpper();
            Console.WriteLine(s);*/

            /*string s2 = "Hello world";
            for (int i = 0; i < s2.Length; i++)
            {
                Console.WriteLine(s2[i]);
            }

        }
        static int CountWords(string s)
        {
            int count = 0;
            //Bỏ khoảng trắng thừa tron chuỗi
            s = s.Trim(); // Bỏ khoảng trắng đầu và cuối chuỗi
            while(s.IndexOf("  ")! = -1)
                s = s.Replace("  ", " ");
           //Đếm
           foreach(char c in s)
                if(c == ' ') count++;
            return count;*/
        }
    }
}
