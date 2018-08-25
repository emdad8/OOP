using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class InterfaceProgramming
    {

        public static void test_8()
        {
            string mystr = "Hello";

            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection();


            I1.CloneMe(mystr);
            I1.CloneMe(unixOS);
            I1.CloneMe(sqlConn);
            Console.ReadLine();
        } 
    }



    public class I1
    {
        public static void CloneMe(ICloneable c) {

            object theClone = c.Clone();
            Console.WriteLine("Your clone is a : {0} ",theClone.GetType().Name);

        }
    }




     


}
