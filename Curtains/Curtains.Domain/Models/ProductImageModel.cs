﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of image product.
    /// </summary>
    public class ProductImageModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents path to image of product.
        /// </summary>
        public string ImagePath { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains, which image is presented.
        /// </summary>
        public virtual CurtainsModel Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows, which image is presented.
        /// </summary>
        public virtual PillowsModel Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads, which image is presented.
        /// </summary>
        public virtual BedspreadsModel Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product sets, which image is presented.
        /// </summary>
        public virtual ProductSetModel Sets { get; set; }
        /// <summary>
        ///  This property represents fabrics, which image is presented.
        /// </summary>
        public virtual FabricModel Fabrics { get; set; }
        #endregion
    }
}
