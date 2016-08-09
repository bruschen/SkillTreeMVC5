using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC5.HW.Session1.Constant
{
    public enum BillingCategory
    {
        [Description("收入")]
        Revenue = 0,
        [Description("支出")]
        expense = 1
    }


}