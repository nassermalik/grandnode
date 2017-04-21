﻿using Grand.Web.Framework.Mvc;

namespace Grand.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : BaseGrandModel
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}