using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    static class AplicationLicence
    {
        private static string trinal = "trinal";
        private static string common = "common";
        private static string pro = "pro";

        private static void AllowTrinal()=> 
            Console.WriteLine("Триальный режим");
        
        private static void AllowCommon()=>
            Console.WriteLine("Бесплатный режим");
        
        private static void AllowPro()=>
            Console.WriteLine("Платный режим");
        
        public static void ChooseLicence(string licence = "common")
        {
            licence = licence.ToLower();
            if (licence.Equals(trinal))
                AllowTrinal();
            if (licence.Equals(pro))
                AllowPro();
            else 
                AllowCommon(); 
        }

    }
}
