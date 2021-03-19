using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class CallHandler
    {
        private Call _clientCall;
        private Request _clientRequest;
        private string _referenceNumber;

        public Call ClientCall { get => _clientCall; set => _clientCall = value; }
        public Request ClientRequest { get => _clientRequest; set => _clientRequest = value; }

        public void LogCall()
        {

        }

        public void CreateJob()
        {

        }

        public void AnswerCall()
        {

        }

        public void EndCall()
        {

        }

        public void MakeCall(BusinessClient client)
        {

        }        
    }
}