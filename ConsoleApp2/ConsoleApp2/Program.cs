using System;
using System.Reflection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly=Assembly.GetExecutingAssembly();
         Type customerType=assembly.GetType("ConsoleApp2.Customer");
      object customerInstance= Activator.CreateInstance(customerType);

              MethodInfo getMethodInfo= customerType.GetMethod("GetFullName");
            string[] parameters=new string[2];
            parameters[0] = "arif";
            parameters[1] = "islam";
            string fullName=(string)getMethodInfo.Invoke(customerInstance, parameters);
            Console.WriteLine(fullName);
            Console.ReadLine();
            //Customer c1=new Customer();
            // string fullName= c1.GetFullName("arif","islam");
            //  Console.WriteLine(fullName);//Eearly Binding at compile Time

        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
           return firstName + " " + lastName;
        }
     
    }

}
