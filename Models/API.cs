using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthlyforex_bnm_api.Models 
{ 
    public static class API
    {
        public static string ForexAPI { get; } = @"https://api.bnm.gov.my/public/exchange-rate/*currency/year/*year/month/*month?session=1200&quote=rm";
    }
}

