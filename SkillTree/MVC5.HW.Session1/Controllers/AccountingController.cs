using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.HW.Session1.Models.ViewModel;
using MVC5.HW.Session1.Services;
using MVC5.HW.Session1.Services.Interface;

namespace MVC5.HW.Session1.Controllers
{
    public class AccountingController : Controller
    {
        private IAccountingServices _accountingServices;

        public AccountingController()
        {
            this._accountingServices= new AccountingServices();
        }

        // GET: Accounting
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AccountList()
        {

            List<AccountingViewModels> accountingViewModelses = _accountingServices.GetAccountingViewModels();

            return View(accountingViewModelses);
        }

        
    }
}