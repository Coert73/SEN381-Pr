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

        public void LogClientRequest()
        {

        }
    }
}