using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class Service
    {
        public string GlobalProductCode { get; set; }
        public List<MrkSrv> MrkSrvs { get; set; }
        public string CountryCode { get; set; }
    }
}
