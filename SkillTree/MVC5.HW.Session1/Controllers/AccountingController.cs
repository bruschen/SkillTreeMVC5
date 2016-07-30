using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.HW.Session1.Models.ViewModel;

namespace MVC5.HW.Session1.Controllers
{
    public class AccountingController : Controller
    {
        // GET: Accounting
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AccountList()
        {
            List<AccountingViewModels> accountingViewModelses = GetAccountingViewModels();

            return View(accountingViewModelses);
        }

        private List<AccountingViewModels> GetAccountingViewModels()
        {
            List<AccountingViewModels> resultList = new List<AccountingViewModels>
            {
                new AccountingViewModels()
                {
                    ID = 1,
                    Category = "支出",
                    BillingDate = new DateTime(2016, 1, 1),
                    BillingAmount = 300
                },
                new AccountingViewModels()
                {
                    ID = 2,
                    Category = "支出",
                    BillingDate = new DateTime(2016, 1, 2),
                    BillingAmount = 1600
                },
                new AccountingViewModels()
                {
                    ID = 3,
                    Category = "支出",
                    BillingDate = new DateTime(2016, 1, 3),
                    BillingAmount = 800
                }
            };

            return resultList;
        }
    }
}