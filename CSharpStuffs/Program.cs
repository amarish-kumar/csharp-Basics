using System;
using System.Collections.Generic;

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

            //Doctor is having DoctorInfo and inheriting ToString() method
            Doctor doctor = new Doctor("Peter", "Orthopaedics","Apollo");
            
            Console.WriteLine(doctor);
            Console.WriteLine(doctor.Information("Some"));

            //Now Call Information Method from different Instances
            DoctorInfo doctorInfo = new DoctorInfo("John","Surgeon","Goverment");

            //Another scenario
            //IS A relationship comes into picture.
            DoctorInfo doctorInfo2 = new Doctor("Michael", "Cardiologists‎","Private");
            Console.WriteLine(doctorInfo2.Information("New Information Type added"));

            Console.WriteLine("Printing Collection!");
            List<DoctorInfo>doctorInfos=new List<DoctorInfo>();

            //Adding in collection
            doctorInfos.Add(doctorInfo);
            doctorInfos.Add(doctor);
            doctorInfos.Add(doctorInfo2);

            //Printing the collection
            foreach (var infos in doctorInfos)
            {
                Console.WriteLine(infos.Information());
            }
           // Console.WriteLine(doctorInfo.Information());
           // Console.WriteLine(doctor.Information());
            Console.ReadLine();
        }
    }
}
