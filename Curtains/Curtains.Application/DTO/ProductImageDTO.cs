﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ProductImageDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ProductImageDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents path to image of product.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        ///  This property represents curtains, which image is presented.
        /// </summary>
        public CurtainsDTO Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows data transfer object.
        /// </summary>
        public PillowsDTO Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads data transfer object.
        /// </summary>
        public BedspreadsDTO Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product sets data transfer object.
        /// </summary>
        public ProductSetDTO Sets { get; set; }
        /// <summary>
        ///  This property represents fabrics data transfer object.
        /// </summary>
        public FabricDTO Fabrics { get; set; }
        /// <summary>
        ///  This property represents marketing information data transfer object.
        /// </summary>
        public MarketingInfoDTO MarketingInfo { get; set; }
        #endregion
    }
}