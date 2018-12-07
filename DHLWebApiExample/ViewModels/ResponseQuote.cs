using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class ResponseQuote
    {
        public BkgDetailsResp BkgDetails { get; set; }
        public List<Service> Srvs { get; set; }
    }
}
