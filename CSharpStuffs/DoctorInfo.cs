namespace CSharpStuffs
{
   public class DoctorInfo
    {
      public DoctorInfo(string doctorName, string doctorSpeciality, string workingAt)
       {
           DoctorName = doctorName;
           DoctorSpeciality = doctorSpeciality;
           WorkingAt = workingAt;
       }

       public string DoctorName { get; set; }
       public string DoctorSpeciality { get; set; }
       public string WorkingAt { get; set; }

       public override string ToString()
       {
           string result = DoctorName + " " + DoctorSpeciality + " " + WorkingAt;
           return result;
       }

       public virtual string Information()
       {
           return "DoctorInfo Assigned!";
       } 
    }
}
