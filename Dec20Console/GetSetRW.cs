using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace OtherNs
{
    public class OtherNSP{
    public static void fun1()
        {
            Console.WriteLine("From Other NameSpace");
        }
    }
}

namespace Dec20Console
{
    internal class GetSetRW
    {
        private string Name = "N";
        public string myName
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
      
            static void Main(string[] args)
            {
                GetSetRW c = new GetSetRW();
                c.myName = "Naveen M";
                Console.WriteLine(c.myName);
            OtherNs.OtherNSP.fun1();
            Console.ReadLine();
            }
        
    }
    
}
