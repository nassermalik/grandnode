﻿using Grand.Web.Framework.Mvc;

namespace Grand.Web.Models.Common
{
    public partial class LogoModel : BaseGrandModel
    {
        public string StoreName { get; set; }

        public string LogoPath { get; set; }
    }
}