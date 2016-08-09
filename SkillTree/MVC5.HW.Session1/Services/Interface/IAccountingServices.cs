using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5.HW.Session1.Models.ViewModel;

namespace MVC5.HW.Session1.Services.Interface
{
    public interface IAccountingServices
    {
        List<AccountingViewModels> GetAccountingViewModels();
    }
}
