namespace CSharpStuffs
{
   public class Patient
    {
        public string PatientName { get; set; }
        public string AdmissionDate { get; set; }
        public string ReleaseDate { get; set; }

        public DoctorInfo DoctorInfo { get; set; }
        public LifeInsurance Insurance { get; set; }

       public Patient(string patientName,string admissionDate,string releaseDate,string doctorName,string doctorSpeciality, string workingAt)
       {
           PatientName = patientName;
           AdmissionDate = admissionDate;
           ReleaseDate = releaseDate;

           //Composition comes into picture now
           //It also means when we construct Patient, we also constructed DoctorInfo
           //Hence, scope of Doctorinfo is dependent on Patient
           DoctorInfo = new DoctorInfo
           {
               DoctorName = doctorName,
               DoctorSpeciality = doctorSpeciality,
               WorkingAt = workingAt
           };

       }

       //Overrideenn ToString() for convience 
       public override string ToString()
       {
           string result = PatientName + " " +
                           AdmissionDate + " " +
                           ReleaseDate + " ";
           //Filling Other objects
           if (DoctorInfo != null)
           {
               result += DoctorInfo.DoctorName + " "
                         + DoctorInfo.DoctorSpeciality + " "
                         + DoctorInfo.WorkingAt;
           }
           if (Insurance != null)
           {
               result += " "+ Insurance.PolicyName + " "
                         + Insurance.CompanyName;
           }
           return result;
       }
    }
}
