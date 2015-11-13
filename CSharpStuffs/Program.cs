using System;

namespace CSharpStuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("Tim","12-08-2015","20-08-2015","Cook","Physician","Fortis");
            Console.WriteLine(patient.ToString());
            

            //Now, we can add insurance by aggregation
            patient.Insurance = new LifeInsurance
            {
                CompanyName = "HDFC",
                PolicyName = "LIFE-AXA"
            };
            Console.WriteLine(patient.ToString());
            Console.ReadLine();
        }
    }
}
