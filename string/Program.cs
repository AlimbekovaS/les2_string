using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string str0 = new string('*', 20);

            string str1 = "г.Алматы";
            string str2 = "г.Алматы";
            if(str==str2)
            { }
            if(str1.Equals(str2))
            { }
            if(string.Compare(str1, str2, true)==0)
            { }

            Console.WriteLine(str1.CompareTo(str2));

            //concat

            string result = "Адрес: ";
            result = result + str1;

            string.Concat(result, str1, "-", str2);

            //contains

            Console.WriteLine(result.Contains("Алматы"));

            //StartWith
            string card = "4003**0327**7395**5051";
            string[] cardArr = card.Split(' ');

            string[] cardArr2 = card.Split(new String[] {"**"}, StringSplitOptions.None);
            //Join
            string cardJoin = string.Join("-", cardArr2);

            //trim


            if (card.StartsWith("4003"))
            {
                Console.WriteLine("VISA");
            }
            string url = "https://mystat.itstep.org/en/main/homework/page/index";
            int findPlacePosition = url.IndexOf("?", 0); // возвращает первое вхождение
            int findPlacePosition2 = url.LastIndexOf("?", 0); // возвращает первое вхождение
            Console.WriteLine();

            string address = "{city Almaty}";
            string trimAdderss = address.Trim('}');

            address = address.Insert(1, "Адрес");

            address = address.Remove(0, 1);

            address = address.Replace("city", "город");

            var test = address.Substring(0, 5);
            var test1 = address.Substring(address.IndexOf("{")+1,5);

            // фОРМАТИРОВАНИЕ СТРОК
            DateTime cd = DateTime.Now;
            string format1 = string.Format("{0:hh:mm} - {1:yyyy}", cd, cd);

            StringBuilder sb = new StringBuilder("test str");
            sb.Append()

        }
    }
}
