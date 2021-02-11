﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eFishShop.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "eFishShop";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 4;
            public const int NumberOfLatestProducts = 6;
        }
    }
}
