using System;
using System.Collections.Generic;
using System.Numerics;
using VITC.Shared.DataTypes;

namespace VITC.RpcApi.Responses
{
    public class AccountsBalancesResponse
    {
        public Dictionary<PublicAddress, AccountsBalancesBalance> Balances
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

    public class AccountsBalancesBalance
    {
        public BigInteger Balance
        {
            get;
            set;
        }

        public BigInteger Pending
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