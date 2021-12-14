using System;
using System.Collections.Generic;
using System.Numerics;
using VITC.Shared.DataTypes;
using VITC.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VITC.RpcApi.Responses
{
    public class AccountBalanceResponse
    {
        //public BigInteger Balance
        //{
        //    get;
        //    set;
        //}

        //public BigInteger Pending
        //{
        //    get;
        //    set;
        //}

        public string jsonrpc { get; set; }


        public Result result { get; set; }
        public String Error
        {
            get;
            set;
        }

        //        {
        //    "jsonrpc": "2.0",
        //    "id": 17,
        //    "result": {
        //        "address": "vite_0b573f9d1fca7d830fc0d1552e3ff7b7f44455e38c8218fd10",
        //        "blockCount": "21846",
        //        "balanceInfoMap": {
        //            "tti_5649544520544f4b454e6e40": {
        //                "tokenInfo": {
        //                    "tokenName": "VITE",
        //                    "tokenSymbol": "VITE",
        //                    "totalSupply": "1001699224353751966255398604",
        //                    "decimals": 18,
        //                    "owner": "vite_0000000000000000000000000000000000000004d28108e76b",
        //                    "tokenId": "tti_5649544520544f4b454e6e40",
        //                    "maxSupply": "115792089237316195423570985008687907853269984665640564039457584007913129639935",
        //                    "ownerBurnOnly": false,
        //                    "isReIssuable": true,
        //                    "index": 0,
        //                    "isOwnerBurnOnly": false
        //                },
        //                "balance": "0"
        //            }
        //        }
        //    }
        //}

        //        level 1
        //jsonrpc
        //id
        //result:
        //  level 2
        //  address
        //  blockCount
        //  balanceInfoMap:
        //    level3
        //    Balance
        //    contract ID:
        //      level 4
        //      tokenInfo:
        //         Level5
        //         tokenName
        //         tokenSymbol
        //         totalSupply
        //         decimals
        //         owner
        //         tokenId
        //         maxSupply
        //         ownerBurnOnly
        //         isReIssuable
        //         index
        //         isOwnerBurnOnly

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

        public class balanceInfoMap //most nested element
        {
            public tti_22d0b205bed4d268a05dfc3c tti_22d0b205bed4d268a05dfc3c { get; set; }
        }

     
        public class tti_22d0b205bed4d268a05dfc3c   //Second most nested thing
        {
            public TokenInfo tokeninfo { get; set; }
            public BigInteger Balance { get; set; }
        }

        public class Result //least nested thing
        {
            public string address { get; set; }
            public string blockcount { get; set; }
            public balanceInfoMap balanceinfomap { get; set; }
        }



        //public class VisualElement //final classs
        //{
        //    public string ID { get; set; }
        //    public Position position { get; set; }
        //    public double width { get; set; }
        //    public double height { get; set; }
        //    public string label { get; set; }
        //    public string colour { get; set; }
        //    public string action { get; set; }
        //    public ActionParams actionParams { get; set; }
        //}


        public bool IsSuccessful => String.IsNullOrEmpty(Error);
    }





}