using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            StringEqualitySpecifyingCompareRules();
            FunWithStringBuilder();
            StringIterpritation();
            Console.ReadLine();
        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Vlad";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters",firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contaings the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("d","dislav"));
            Console.WriteLine();
        }
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation");
            string s1 = "Privet Sladkii ";
            string s2 = "Poshli gulayt'";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();

        }
        static void EscapeChars()
        {
            Console.WriteLine("=>Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet name\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everone loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");
            Console.WriteLine("All finished.\n\n\n\a");
            Console.WriteLine();
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string myLongString = @"This is a very
                        very
                                very
                                        long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun sets""");
        }
        // Несмотря на то что string относится к ссылочным типам и ==,!= должны сравнивать
        // указывают ли обе ссылки на одно место памяти, для string значение сравнения было переопределенно
        static void StringEquality()
        {
            Console.WriteLine("=>String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine("s2 = {0}",s2);
            Console.WriteLine();
            //Проверить строки на равенство.
            Console.WriteLine("s1 == s2:{0}", s1==s2);
            Console.WriteLine("s1 == Hello!: {0} ", s1=="Hello!");
            Console.WriteLine("s1 == HELLO!: {0} ", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0} ", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
        }
        static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality Case Insensitive:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("si = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Проверить результаты изменения стандартных правил сравнения.
            Console .WriteLine ("Default rules: s1={0}, s2={1}s1.Equals(s2) : {2}", s1, s2,s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals (s2,StringComparison.OrdinalIgnoreCase) : {0}",s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invarariant Culture:s1.Equals(s2, StringComparison.InvanantCulturelgnoreCase) : { 0}",s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase)) ;
            Console.WriteLine();
            Console.WriteLine("Default rules: sl={0},s2={1} si.IndexOf(\"E\"): {2}",s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\",StringCompanson.OrdinallgnoreCase) : {0}",s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invarariant Culture: s1.IndexOf(\"E\",StringComparison.InvanantCultureIgnoreCase) : {0}",s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Useing the StringBuilder:");
            //Создаёт экзембляр Сб с исходным значение 256 символов, по умолчанию 16.
            //StringBuilder sb = new StringBuilder("***** Fantastic Games *****",256);
            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.AppendLine("Half-Life");
            sb.AppendLine("Morrownd");
            sb.AppendLine("Deus Ex " +"2");
            sb.AppendLine("System Shock");
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars", sb.Length);
            Console.WriteLine();
        }
        static void StringIterpritation()
        {
            int age = 4;
            string name = "Soren";
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting + "\t" + greeting2);
        }

    }
}
