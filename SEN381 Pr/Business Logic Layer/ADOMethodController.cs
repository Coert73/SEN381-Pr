using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    class ADOMethodController
    {      
        #region Controllers
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Business Logic Layer part of the data passing thru...

        TechADOController TechCon = new TechADOController();
        JobsADOController JobCon = new JobsADOController();
        LoginADOController SecCon = new LoginADOController();
        RequestADOController ReqCon = new RequestADOController();
        CallsADOController CallCon = new CallsADOController();
        ClientADOController ClientCon = new ClientADOController();
        ContractADOController ContractCon = new ContractADOController();
        ReportADOController RepCon = new ReportADOController();
        ServicesADOController ServicesCon = new ServicesADOController();
        PackageADOController PackCon = new PackageADOController();
        ContractADOController ConCon = new ContractADOController();
        BusinessADOController BusCon = new BusinessADOController();
        AddressADOController AddCon = new AddressADOController();
        #endregion

        #region Calls
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods for Calls
        public void LoadCallsData(DataGridView tab)
        {
            tab.DataSource = CallCon.LoadData();
            tab.DataMember = "Table";
        }

        public string InsertCallData(string callid, string clientid, string contractid, byte inout, string duration, string calldate)
        {
            callid = (CallCon.CountCalls() + 1).ToString();
            CallCon.InsertData(new Call(callid,clientid,contractid,inout,duration,calldate));

            MessageBox.Show("Call logged");

            return callid;
        }
        #endregion

        #region Requests
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
        //Methods for requests

        public void InsertRequest(string clientId,string callId)
        {
            string referencenumber = string.Empty;
            byte approval = 0;
            char reqstatus = ' ';
            Random rand = new Random();
            long number = rand.Next(2134125, 3134125);
            referencenumber = number.ToString();
            number = rand.Next(2134125, 3134125);
            referencenumber =  referencenumber +  number.ToString();
            referencenumber += (ReqCon.CountRequest() + 1);           
            reqstatus = 'A';
            ReqCon.InsertRequest(new Request(referencenumber,clientId,callId,approval,reqstatus));
            MessageBox.Show("Request Created!");
        }

        public void LoadReqData(DataGridView tab)
        {
            RefreshData(tab);
            tab.DataSource = ReqCon.LoadData();
            tab.DataMember = "Table";
        }      

        public void UpdateRequest(DataGridView tab, string referencenumber)
        {
            byte approval = 1;
            ReqCon.UpdateRequest(referencenumber, approval);
            tab.DataSource = ReqCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Closed Request!");
        }

        public void SortData(DataGridView tab, string sort)
        {
            RefreshData(tab);
            tab.DataSource = ReqCon.SortRequestData(sort);
            tab.DataMember = "Table";
        }
        #endregion

        #region Address
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods for Addresses
        public void LoadAddressData(DataGridView tab)
        {
            tab.DataSource = AddCon.LoadData();
            tab.DataMember = "Table";
        }

        public void InsertAddressData(DataGridView tab, string id,string street, string code, string city, string country)
        {            
            AddCon.InsertAddress(new Address(id,street,code,city,country));
            tab.DataSource = AddCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Address");
        }

        public void UpdateAddressData(DataGridView tab, string id, string street, string code, string city, string country)
        {
            AddCon.UpdateAddress(new Address(id, street, code, city, country));
            tab.DataSource = AddCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Address");
        }

        public void DeleteAddressData(DataGridView tab, string id, string street, string code, string city, string country)
        {
            AddCon.DeleteAddress(new Address(id, street, code, city, country));
            tab.DataSource = AddCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Address");
        }

        #endregion

        #region Technicians
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods For Technicians

        public DataSet LoadTechData()
        {
            return TechCon.LoadData();
        }

        public void InsertTechData(DataGridView tab, string id, string name, string surname, string number)
        {
            id = (name.Substring(0, 2).ToUpper() + surname.Substring(0, 2).ToUpper() + (TechCon.CountTechs() + 1)).ToString();
            TechCon.InsertTechnician(new Technician(id, name, surname, number));
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Technician");
        }

        public void UpdateTechData(DataGridView tab, string id, string name, string surname, string number)
        {
            TechCon.UpdateTechnician(new Technician(id, name, surname, number));
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Technician");
        }

        public void DeleteTechData(DataGridView tab, string id, string name, string surname, string number)
        {
            TechCon.DeleteTechnician(new Technician(id, name, surname, number));
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Technician");
        }

        #endregion

        #region Clients

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods For Clients

        public DataSet LoadClientData()
        {
            return ClientCon.LoadData();
        }

        public void InsertClientData(DataGridView tab, string businessID, string clientContract, string clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position, string altcontact, string altnum, string clientID, string clientservicelevel)
        {
            int charcount = 8 - (ClientCon.CountClients().ToString().Length);
            clientID = clientservicelevel + (ClientCon.CountClients() + 1).ToString().PadLeft(charcount,'0');
            MessageBox.Show(clientID);
            ClientCon.InsertClient(new IndividualClient(businessID,clientContract,clientAddress,clientName,clientSurname,clientNumber,callsMade,position,clientID,altnum,altcontact,clientservicelevel));      
            tab.DataSource = ClientCon.LoadData();
            tab.DataMember = "Table";         
            MessageBox.Show("Inserted Client");               
        }

        public void UpdateClientData(DataGridView tab, string businessID, string clientContract, string clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position, string altcontact, string altnum, string clientID, string clientservicelevel)
        {
            ClientCon.UpdateClient(new IndividualClient(businessID, clientContract, clientAddress, clientName, clientSurname, clientNumber, callsMade, position, clientID, altnum, altcontact, clientservicelevel));
            tab.DataSource = ClientCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Client");
        }

        public void DeleteClientData(DataGridView tab, string businessID, string clientContract, string clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position, string altcontact, string altnum, string clientID, string clientservicelevel)
        {
            ClientCon.DeleteClient(new IndividualClient(businessID, clientContract, clientAddress, clientName, clientSurname, clientNumber, callsMade, position, clientID, altnum, altcontact, clientservicelevel));
            tab.DataSource = ClientCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Client");
        }

        #endregion

        #region Services

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods for Services

        public void LoadServices(DataGridView tab)
        {            
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
        }

        public void InsertService(DataGridView tab, string id,string name,string desc,string level,int period,string sal,bool equip)
        {
            id = level + name.Substring(0, 3).ToUpper() + (ServicesCon.CountServices() + 1).ToString();                      
            ServicesCon.InsertService(new Service(id.ToString(),name,desc,period,sal,level,equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Service");
        }

        public void UpdateService(DataGridView tab, string id, string name, string desc, string level, int period, string sal, bool equip)
        {            
            ServicesCon.UpdateService(new Service(id, name, desc, period, sal, level, equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Service");
        }

        public void DeleteService(DataGridView tab, string id, string name, string desc, string level, int period, string sal, bool equip)
        {
            ServicesCon.DeleteService(new Service(id, name, desc, period, sal, level, equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Service");
        }

        #endregion

        #region Packages

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Package Methods and Functions

        public void LoadPackageData(DataGridView tab)
        {
            tab.DataSource = PackCon.LoadData();
            tab.DataMember = "Table";
        }

        public void InsertPackageData(DataGridView tab, string id, string name, string type, ListBox list)
        {
            List<string> ServiceList = new List<string>();                

            int index = 12 - list.Items.Count;       

            foreach (var item in list.Items)
            {
                ServiceList.Add(item.ToString());
            }
            
            for (int i = 0; i < index; i++)
            {
                ServiceList.Add("NNON11");
            }

            id =  name.Substring(0, 3).ToUpper() + type + (PackCon.CountPackages() + 1).ToString();
            PackCon.InsertPackage(new Package(id, name, type, ServiceList));
            tab.DataSource = PackCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Package");
        }

        public void UpdatePackageData(DataGridView tab, string id, string name, string type, ListBox list)
        {
            List<string> ServiceList = new List<string>();

            int index = 12 - list.Items.Count;

            foreach (var item in list.Items)
            {
                ServiceList.Add(item.ToString());
            }

            for (int i = 0; i < index; i++)
            {
                ServiceList.Add("NONON5");
            }

            PackCon.UpdatePackage(new Package(id,name,type,ServiceList));
            tab.DataSource = PackCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Package");
        }

        public void DeletePackageData(DataGridView tab, string id, string name, string type, ListBox list)
        {
            List<string> ServiceList = new List<string>();

            foreach (var item in list.Items)
            {
                ServiceList.Add(item.ToString());
            }

            PackCon.DeletePackage(new Package(id, name, type, ServiceList));
            tab.DataSource = PackCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Package");
        }

        #endregion

        #region Contracts

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Contract Methods and Functions

        public void LoadContracts(DataGridView tab)
        {
            tab.DataSource = ContractCon.LoadData();
            tab.DataMember = "Table";
        }

        public void InsertContracts(DataGridView tab, string id, string packageId,string name,string contractType,string start,string end,bool status,string level)
        {
            string num = ConCon.CountContract().ToString();
            int length = num.Length; 

            if (ConCon.CountContract() == 0)
            {
                num = "000001";
            }
            else
            {
                int temp = int.Parse(num);
                num = (temp + 1).ToString();

                if (num.Length < 6)
                {
                    for (int i = 0; i < 6 - length; i++)
                    {
                        num = "0" + num;
                    }
                }
            }          

            id = start.Substring(0, 4) + contractType.Substring(0,1) + level + num;
            ContractCon.InsertContract(new Contract(id,packageId,name,contractType,start.Replace("/","-"),end.Replace("/", "-"), status,char.Parse(level.Substring(0,1))));
            tab.DataSource = ContractCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Service");
        }

        public void UpdateContracts(DataGridView tab, string id, string packageId, string name, string contractType, string start, string end, bool status, string level)
        {           
            ContractCon.UpdateContract(new Contract(id, packageId, name, contractType, start.Replace("/", "-"), end.Replace("/", "-"), status, char.Parse(level.Substring(0, 1))));
            tab.DataSource = ContractCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Service");
        }

        public void DeleteContracts(DataGridView tab, string id, string packageId, string name, string contractType, string start, string end, bool status, string level)
        {           
            ContractCon.DeleteContract(new Contract(id, packageId, name, contractType, start, end, status, char.Parse(level.Substring(0, 1))));
            tab.DataSource = ContractCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Service");
        }

        #endregion

        #region Businesses

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Business Methods

        public void LoadBusinessData(DataGridView tab)
        {
            tab.DataSource = BusCon.LoadBusiness();
            tab.DataMember = "Table";
        }

        public void InsertBusinessData(DataGridView tab, string id, string name)
        {
            id = "BUS" + ((BusCon.CountBusiness() + 1).ToString());    
            BusCon.InsertBusiness(new BusinessClient(name, id));
            tab.DataSource = BusCon.LoadBusiness();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Business");
        }

        public void UpdateBusinessData(DataGridView tab, string id,string name)
        {         
            BusCon.UpdateBusiness(new BusinessClient(name, id));
            tab.DataSource = BusCon.LoadBusiness();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Business");
        }

        public void DeleteBusinessData(DataGridView tab, string id, string name)
        {           
            BusCon.DeleteBusiness(new BusinessClient(name, id));
            tab.DataSource = BusCon.LoadBusiness();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Business");
        }

        #endregion

        #region Jobs

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Methods for Jobs
        public DataSet LoadJobData()
        {
            return JobCon.LoadData();
        }

        public void InsertJobData(DataGridView tab,string jobId,string AddressId,string referencenumber,string level,string technician,string contractId)
        {
            jobId = "Job" + (JobCon.CountJobs() + 1).ToString();
            JobCon.InsertJob(new Job(jobId,AddressId,referencenumber,int.Parse(level),technician,contractId));
            tab.DataSource = LoadJobData();
            tab.DataMember = "Table";
            MessageBox.Show("Job Created!");
        }

        public void LoadTree(TreeView tree)
        {
            DataSet ds = JobCon.LoadData();
            List<TreeNode> treelist = new List<TreeNode>();

            foreach (DataTable item in JobCon.RetrieveAssigned().Tables)
            {
                foreach (DataRow row in item.Rows)
                {
                    treelist.Add(new TreeNode(row["JobId"].ToString(), new TreeNode[] {new TreeNode(row["AssignedTechnician"].ToString())}));
                }
            }

            TreeNode[] array = treelist.ToArray();

            tree.Nodes.Add(new TreeNode("Assigned Jobs",array));
            tree.Nodes.Add(new TreeNode("Unassigned Jobs"));
          
              
        }     

        public void UpdateJobData(DataGridView tab, string id)
        {
            RefreshData(tab);
            //tab.DataSource = JobCon.UpdateJob(new Job(), id);
            tab.DataMember = "Table";
        }

        public void DeleteJobData(DataGridView tab,string jobId, string AddressId, string referencenumber, string level, string technician, string contractId)
        {            
            JobCon.DeleteJob(new Job(jobId, AddressId, referencenumber, int.Parse(level), technician, contractId));
            tab.DataSource = LoadJobData();
            tab.DataMember = "Table";
            MessageBox.Show("Job Deleted!");
        }

        public void EscelateJob(DataGridView tab, string jobId, string AddressId, string referencenumber, string level, string technician, string contractId)
        {
            JobCon.EscelateJob(new Job(jobId, AddressId, referencenumber, (int.Parse(level) + 1), technician, contractId));
            tab.DataSource = LoadJobData();
            tab.DataMember = "Table";
            MessageBox.Show("Job Escelated!");
        }

        public void CountJobs(Label lbl)
        {
            lbl.Text = JobCon.CountJobs().ToString() + " Jobs";
        }

        public List<string> GetClientInfoForJobs(string clientId)
        {
            List<string> temp = new List<string>();
            temp = ClientCon.ClientData(clientId);
            return temp;
        }

        #endregion

        #region Login

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Security Layer Controllers

        public List<string> ValidateCredentials(string username)
        {
            List<string> UserCredentials = new List<string>();
            int i = 0;

            if (SecCon.LoadData(username).Tables[i].Rows.Count > 0)
            {
                foreach (DataRow row in SecCon.LoadData(username).Tables[i].Rows)
                {
                    if (username == row.ItemArray.GetValue(1).ToString())
                    {
                        UserCredentials.Add(row.ItemArray.GetValue(1).ToString());
                        UserCredentials.Add(row.ItemArray.GetValue(3).ToString());

                    }
                    else
                    {
                        UserCredentials.Add("NONE");
                        UserCredentials.Add("NONE");
                    }
                    i++;
                }
            }
            else
            {
                UserCredentials.Add("NONE");
                UserCredentials.Add("NONE");
            }                        

            return UserCredentials;
        }

        #endregion

        #region CallHandler

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Call Handler ADO Method Controllers

        public void LoadCallClients(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = ClientCon.LoadData();
            tab.DataMember = "Table";
        }

        public void LoadCalls(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = CallCon.LoadData();
            tab.DataMember = "Table";
        }

        #endregion

        #region Reports

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Report ADO Controller Methods

        public void LoadReports(DataGridView tab) {

            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.LoadData();
            tab.DataMember = "Table";
        }       

        public void SearchReport(DataGridView tab,int refer)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.SearchReport(refer);
            tab.DataMember = "Table";
        }

        public void SortReports(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.SortReportData();
            tab.DataMember = "Table";
        }

        public void RefreshData(DataGridView tab)
        {
            tab.DataSource = null;
            tab.Rows.Clear();
            tab.Update();
            tab.Refresh();
        }

        #endregion
    }
}
