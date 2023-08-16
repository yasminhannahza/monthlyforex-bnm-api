using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthlyforex_bnm_api.Models
{
    public class Data
    {
        public string currency_code { get; set; }
        public int unit { get; set; }
        public List<Rate> rate { get; set; }
    }

    public class Meta
    {
        public string quote { get; set; }
        public string session { get; set; }
        public string last_updated { get; set; }
        public int total_result { get; set; }
    }

    public class Rate
    {
        public string date { get; set; }
        public double buying_rate { get; set; }
        public double selling_rate { get; set; }
        public double middle_rate { get; set; }
    }

    public class ForexModel
    {
        public Data data { get; set; }
        public Meta meta { get; set; }
    }

}
