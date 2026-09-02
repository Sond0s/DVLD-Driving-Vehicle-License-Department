using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public class User
    {
        //initialize the UsersBLL object to avoid null reference exception
        public static UsersBLL _CurrentUser = new UsersBLL();
    }
}
