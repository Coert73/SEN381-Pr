using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public abstract class Client
    {
        public BusinessClient BusinessClient
        {
            get => default;
            set
            {
            }
        }

        public IndividualClient IndividualClient
        {
            get => default;
            set
            {
            }
        }
    }
}