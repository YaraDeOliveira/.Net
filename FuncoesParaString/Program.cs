using System;

namespace FuncoesParaString {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            int x = 12345;

            string z = x.ToString("C");

            string s1 = original.ToLower();
            string s2 = original.Trim();
            string s3 = original.ToUpper();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine(z);    
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToLower: -" + s1 + "-");
            Console.WriteLine("ToUpper: -" + s3 + "-");
            Console.WriteLine("Trim: -" + s2 + "-");
            Console.WriteLine("IndexOf'bc' " + n1);
            Console.WriteLine("LastIndexOf'bc' " + n2);
            Console.WriteLine("Substring(3) " + s4);
            Console.WriteLine("Substring(3, 5) " + s5);
            Console.WriteLine("Replace('a','x')" + s6);
            Console.WriteLine("Replace('abc', 'xy'): " + s7);
            Console.WriteLine("IsNullorEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
