using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5.HW.Session1.Models;
using MVC5.HW.Session1.Models.ViewModel;
using MVC5.HW.Session1.Services.Interface;

namespace MVC5.HW.Session1.Services
{
    public class AccountingServices: IAccountingServices
    {
        public List<AccountingViewModels> GetAccountingViewModels()
        {
            List<AccountingViewModels> accountingViewModelsList = new List<AccountingViewModels>();

            List<AccountBook> accountBookList = new List<AccountBook>();

            using (var ctx = new SkillTreeHomeworkEntities())
            {
                accountBookList = ctx.AccountBook.ToList<AccountBook>();

                accountingViewModelsList = accountBookList.Take(10).Select((b, i) => new AccountingViewModels()
                {
                    ID = i,
                    Category = b.Categoryyy.ToString(),
                    BillingDate = b.Dateee,
                    BillingAmount = b.Amounttt
                }).ToList();

            }


            return accountingViewModelsList;
        }

        public List<AccountingViewModels> GetAccountingViewModels2()
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