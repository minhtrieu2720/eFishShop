using System;
using System.Collections.Generic;
using System.Text;

namespace eFishShop.Utilities.Exceptions
{
    public class eFishShopException : Exception
    {
        public eFishShopException()
        {
        }

        public eFishShopException(string message)
            : base(message)
        {
        }

        public eFishShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
