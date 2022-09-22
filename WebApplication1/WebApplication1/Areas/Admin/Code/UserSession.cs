using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Areas.Admin.Code
{
    [Serializable]
    //luu cac thong tin thuoc tinh
    public class UserSession
    {
        public string UserName
        {
            set; get;
        }
    }
}