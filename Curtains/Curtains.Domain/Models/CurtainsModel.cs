﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class CurtainsModel : BaseEntity
    {
        public CurtainsModel()
        {
            Sets = new HashSet<ProductSetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        public bool Density { get; set; }
        public bool SunProtection { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int FabricId { get; set; }
        public int MaterialId { get; set; }
        public int AccessoriesId { get; set; }
        public int CurtainsTypeId { get; set; }
        public int CurtainsKindId { get; set; }
        public decimal Price { get; set; }
        public string Purpose { get; set; }
        #endregion

        #region NavigationProperties
        public virtual FabricModel Fabric { get; set; }  
        public virtual MaterialModel Material { get; set; }  
        public virtual AccessoriesModel Accessories { get; set; }  
        public virtual CurtainsTypeModel CurtainsType { get; set; }  
        public virtual CurtainsKindModel CurtainsKind { get; set; }  
        public virtual MarketingInfoModel MarketingInfo { get; set; }  
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
