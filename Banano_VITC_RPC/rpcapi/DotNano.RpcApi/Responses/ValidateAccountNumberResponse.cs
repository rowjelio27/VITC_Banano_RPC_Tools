using System;
using System.Collections.Generic;
using System.Numerics;
using VITC.Shared.DataTypes;

namespace VITC.RpcApi.Responses
{
    public class ValidateAccountNumberResponse
    {
        public Int64 Valid
        {
            get;
            set;
        }

        public String Error
        {
            get;
            set;
        }

        public bool IsSuccessful => String.IsNullOrEmpty(Error);
    }
}