using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class JobsADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Jobs");
        }

        public DataSet InsertJob(Job jobTemp)
        {
            return Controller.CarryCommand($"INSERT INTO Jobs (JobId,AdressId,ReferenceNumber,EscalationLevel,AssignedTechnician,ContractId) VALUES ('{jobTemp.JobId}',{int.Parse(jobTemp.AddressId)},'{jobTemp.ReferenceNumber}',{jobTemp.EscalationLevel},'{jobTemp.AssignedTechnician}','{jobTemp.ContractId}')");
        }

        public DataSet DeleteJob(Job jobTemp)
        {
            return Controller.CarryCommand($"DELETE FROM Jobs WHERE JobId = '{jobTemp.JobId}'");
        }

        public DataSet UpdateJob(Job jobTemp)
        {
            return Controller.CarryCommand($"");
        }

        public int CountJobs()
        {
            return Controller.CarryCommand("SELECT * FROM Jobs").Tables[0].Rows.Count;
        }

        public DataSet EscelateJob(Job jobTemp)
        {
            return Controller.CarryCommand($"UPDATE Jobs SET EscalationLevel = {jobTemp.EscalationLevel} WHERE JobId = '{jobTemp.JobId}'");
        }
    }
}
