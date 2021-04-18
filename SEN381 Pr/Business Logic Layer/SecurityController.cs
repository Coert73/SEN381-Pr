using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    class SecurityController
    {

        //This class will deal with user login and credential validations

        private string _username;
        private string _password;

        ADOMethodController Controller = new ADOMethodController();

        public SecurityController(LoginFrm form, string user,string pass)
        {

            List<string> credentials = Controller.ValidateCredentials(user);

            if (credentials[0] == user && credentials[1] == pass)
            {
                MenuFrm formMen = new MenuFrm();
                formMen.Show();               
                form.Hide();
            }
            else
            {
                MessageBox.Show("Failed to validate Credentials!");
            }
        }      
    }
}
