﻿using Grand.Web.Framework.Mvc;

namespace Grand.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseGrandModel
    {
        public bool ShippingRequired { get; set; }
        public bool DisableBillingAddressCheckoutStep { get; set; }
    }
}