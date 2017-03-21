using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class DTO_User
    {
        private string _User;

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        private string _Pass;

        public string Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
       
    }
}
