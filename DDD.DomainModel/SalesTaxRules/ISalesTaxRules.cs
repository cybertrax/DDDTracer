﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.DomainModel
{
    public interface ISalesTaxRules
    {
        Money GetTax(OrderLine orderLine);

    }
}
