﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testapp.Enum
{
    public static class PaymentOrderType
    {
        public static readonly string PhysicalProduct = "PhysicalProduct";
        public static readonly string Book = "Book";
        public static readonly string Membership = "Membership";
        public static readonly string MembershipOrUpgrade = "MembershipOrUpgrade";
        public static readonly string PhysicalProductOrBook = "PhysicalProductOrBook";
        public static readonly string UpgradeMemebership = "UpgradeMemebership";
    }
}