using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class BkgDetailsResp
    {
        public ServiceArea OriginServiceArea { get; set; }
        public ServiceArea DestinationServiceArea { get; set; }
        public List<QtdShpResp> QtdShps { get; set; }
    }
}
