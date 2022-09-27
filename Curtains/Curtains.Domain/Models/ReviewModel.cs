using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ReviewModel : BaseEntity
    {
        #region PropertiesRegion
        public string PersonName { get; set; }  
        public string Country { get; set; }  
        public string City { get; set; }  
        public string Review { get; set; }  
        public string Image { get; set; }  
        #endregion
    }
}
