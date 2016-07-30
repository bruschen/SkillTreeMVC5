using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5.HW.Session1.Models.ViewModel
{
    public class AccountingViewModels
    {
        [DisplayName("#")]
        
        public int ID { get; set; }

        [DisplayName("類別")]
        public string Category { get; set; }

        [DisplayName("日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}")]
        public  DateTime BillingDate { get; set; }

        [DisplayName("金額")]
        public  decimal BillingAmount { get; set; }
    }
}