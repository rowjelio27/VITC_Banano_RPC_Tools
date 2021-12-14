using System;
using System.Collections.Generic;
using System.Numerics;
using VITC.Shared.DataTypes;

namespace VITC.RpcApi.Responses
{
    public class AccountBlockCountResponse
    {
        public Int64 BlockCount
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