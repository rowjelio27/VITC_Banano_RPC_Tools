using System;
using System.Collections.Generic;
using System.Numerics;
using VITC.Shared.DataTypes;

namespace VITC.RpcApi.Responses
{
    public class AccountHistoryResponse
    {
        //public PublicAddress Account
        //{
        //    get;
        //    set;
        //}

        //public HexKey64 Previous
        //{
        //    get;
        //    set;
        //}

        //public IEnumerable<AccountHistoryHistory> History
        //{
        //    get;
        //    set;
        //}

        public String Error
        {
            get;
            set;
        }

        public bool IsSuccessful => String.IsNullOrEmpty(Error);


        public string jsonrpc { get; set; }

        public IEnumerable<Result> result { get; set; }


        public class Result //least nested thing
        {
            public string blockType { get; set; }
            public string height { get; set; }
            public string hash { get; set; }
            public string previousHash { get; set; }
            public string address { get; set; }
            public string publicKey { get; set; }
            public string producer { get; set; }
            public string fromaddress { get; set; }
            public string toaddress { get; set; }
            public string sendBlockHash { get; set; }
            public string tokenId { get; set; }
            public BigInteger amount { get; set; }
            public string fee { get; set; }
            public string data { get; set; }
            public string difficulty { get; set; }
            public string nonce { get; set; }
            public string signature { get; set; }
            public string quotaByStake { get; set; }
            public string totalQuota { get; set; }
            public string vmLogHash { get; set; }

            public TokenInfo tokeninfo { get; set; }
            public string confirmations { get; set; }
            public string firstSnapshotHash { get; set; }
            public string receiveBlockHeight { get; set; }
            public string receiveBlockHash { get; set; }
            public long timestamp { get; set; }


            //public string blockcount { get; set; }
            public triggeredSendBlockList triggeredsendblocklist { get; set; }
        }

    }



    public class TokenInfo //most nested element
    {
        public string tokenname { get; set; }
        public string tokensymbol { get; set; }
        public string totalsupply { get; set; }
        public string decimals { get; set; }
        public string owner { get; set; }
        public string tokenid { get; set; }
        public string maxsupply { get; set; }
        public string ownerburnonly { get; set; }
        public string isreissuable { get; set; }
        public string index { get; set; }
        public string isownerburnonly { get; set; }
    }
    public class triggeredSendBlockList   //Second most nested thing
    {
        public string blockType { get; set; }
        public string height { get; set; }
        public string hash { get; set; }
        public string previousHash { get; set; }
        public string address { get; set; }
        public string publicKey { get; set; }
        public string producer { get; set; }
        public string fromAddress { get; set; }
        public string toAddress { get; set; }
        public string sendBlockHash { get; set; }
        public string tokenId { get; set; }
        public BigInteger amount { get; set; }
        public string fee { get; set; }
        public string data { get; set; }
        public string difficulty { get; set; }
        public string nonce { get; set; }
        public string signature { get; set; }
        public string quotaByStake { get; set; }
        public string totalQuota { get; set; }
        public string vmLogHash { get; set; }

        public TokenInfo tokeninfo { get; set; }

    }

    //public class balanceInfoMap //most nested element
    //{
    //    public tti_22d0b205bed4d268a05dfc3c tti_22d0b205bed4d268a05dfc3c { get; set; }
    //}




    //public class AccountHistoryHistory
    //{
    //    public String Type
    //    {
    //        get;
    //        set;
    //    }

    //    public PublicAddress Account
    //    {
    //        get;
    //        set;
    //    }

    //    public BigInteger Amount
    //    {
    //        get;
    //        set;
    //    }

    //    public Int64 LocalTimestamp
    //    {
    //        get;
    //        set;
    //    }

    //    public Int64 Height
    //    {
    //        get;
    //        set;
    //    }

    //    public HexKey64 Hash
    //    {
    //        get;
    //        set;
    //    }
    //}
}