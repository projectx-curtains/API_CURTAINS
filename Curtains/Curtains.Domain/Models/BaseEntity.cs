﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes base entity, which properties will be inherited by other entities.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        ///  This property represents unique identifier for entities.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = "";
        /// <summary>
        ///  This property represents description of entities.
        /// </summary>
        public string Description { get; set; } = "";
    }
}