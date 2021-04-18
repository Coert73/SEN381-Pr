using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Job : Jobs
    {
        public override string JobName { get => JobName; set => JobName = value; }
        public override string ReferenceNumber { get => ReferenceNumber; set => ReferenceNumber = value; }
        public override string Progression { get => Progression; set => Progression = value; }
        public override DateTime ArramgedData { get => ArramgedData; set => ArramgedData = value; }
        public override bool Completed { get => Completed; set => Completed = value; }
        public override Technician JobTechnician { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void LogClientRequest()
        {

        }

        public override string ToString()
        {
            return "Name: " + JobName + "Reference: " + ReferenceNumber + "Progression: " + Progression;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   JobName == job.JobName &&
                   ReferenceNumber == job.ReferenceNumber &&
                   Progression == job.Progression &&
                   ArramgedData == job.ArramgedData &&
                   Completed == job.Completed &&
                   EqualityComparer<Technician>.Default.Equals(JobTechnician, job.JobTechnician) &&
                   JobName == job.JobName &&
                   ReferenceNumber == job.ReferenceNumber &&
                   Progression == job.Progression &&
                   ArramgedData == job.ArramgedData &&
                   Completed == job.Completed &&
                   EqualityComparer<Technician>.Default.Equals(JobTechnician, job.JobTechnician);
        }

        public override int GetHashCode()
        {
            int hashCode = 865469888;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JobName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Progression);
            hashCode = hashCode * -1521134295 + ArramgedData.GetHashCode();
            hashCode = hashCode * -1521134295 + Completed.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Technician>.Default.GetHashCode(JobTechnician);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JobName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Progression);
            hashCode = hashCode * -1521134295 + ArramgedData.GetHashCode();
            hashCode = hashCode * -1521134295 + Completed.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Technician>.Default.GetHashCode(JobTechnician);
            return hashCode;
        }

        public Job(string jobName, string referenceNumber, string progression, DateTime arramgedData, bool completed, Technician jobTechnician)
        {
            JobName = jobName;
            ReferenceNumber = referenceNumber;
            Progression = progression;
            ArramgedData = arramgedData;
            Completed = completed;
            JobTechnician = jobTechnician;
        }


    }
}