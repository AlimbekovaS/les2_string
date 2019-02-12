using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region
        static string searchResult = @"[{'PIN':'10021 01','BRAND':'LMI','NAME':'опора амортизатора переднего!\\ Audi 100/A6 2.0-4.2 91-97','ARTID':'36680','PARNR':'0000109760',
'KEYZAK':'0000006819','RVALUE':'1','RDPRF':'1','MINBM':'1.000','VENSL':'86.0','PRICE':'1691.00','WAERS':'RUB','DLVDT':'20170525181500','ANALOG':'','MSG':null,'PriceTenge':0,'PriceRub':0.0,
'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null}, {'PIN':'10021 01','BRAND':'LMI','NAME':'опора амортизатора переднего!\\ Audi 100/A6 2.0-4.2 91-97','ARTID':'36680','PARNR':'0000139657','KEYZAK':'0000011450','RVALUE':'37','RDPRF':'1','MINBM':
'1.000','VENSL':'54.0','PRICE':'555.00','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,
'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null}";
        #endregion
        static void Main(string[] args)
        {
            //string[] resultArr =
            //    searchResult
            //    .Trim('[')
            //    .Trim(']')
            //    .Trim('{')
            //    .Trim('}')
            //    .Split(new string[] { "}, {" },
            //            StringSplitOptions.None);

            //for (int i = 0; i < resultArr.Length; i++)
            //{
            //    string[] res = resultArr[i].Split(',');
            //    for (int g = 0; g < res.Length; g++)
            //    {
            //        string[] prop = res[g].Replace("'", "")
            //            .Split(':');

            //        if (prop[0] == "PIN" || prop[0] == "NAME" || prop[0] == "PRICE")
            //        {
            //            Console.WriteLine("{0}: {1}", prop[0], prop[1]);
            //        }
            //    }
            //        Console.WriteLine("--------------------------------------------------------");


            //}

            string N = "1234567891011121314151617181955";

            int sum = 0;
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine(N[i]);
                sum += Int32.Parse(N[i].ToString());
            }
            Console.WriteLine(sum);



        }

       
    }
}
