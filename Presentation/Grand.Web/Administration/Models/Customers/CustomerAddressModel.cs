﻿using Grand.Admin.Models.Common;
using Grand.Web.Framework.Mvc;

namespace Grand.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseGrandModel
    {
        public string CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}