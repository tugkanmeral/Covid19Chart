﻿using Core.CoreEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
