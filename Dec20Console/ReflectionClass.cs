using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dec20Console
{
    internal class ReflectionClass
    {
        static void Main(string[] args)
        {
          Assembly assembly = Assembly.LoadFile(@"C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\System.dll");
            Console.WriteLine("FullName : " + assembly.FullName);
            Console.WriteLine("SecurityRuleSet : "+assembly.SecurityRuleSet);
            Console.WriteLine("Evidence : " + assembly.Evidence);
            Console.WriteLine("PermissionSet : " + assembly.PermissionSet);
            Console.WriteLine("CustomAttributes : " + assembly.CustomAttributes);
            Console.WriteLine("EntryPoint : " + assembly.EntryPoint);
            Console.WriteLine("ReflectionOnly : " + assembly.ReflectionOnly);
            Console.WriteLine("Location : " + assembly.Location);

            foreach (Type cls in assembly.GetTypes())
            {
                Console.WriteLine(cls);
            }



            Console.ReadLine();
        }

    }
}
