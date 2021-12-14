using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VITC.Shared;
using VITC.Shared.DataTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WinFormsApp1
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
            public string blocktype { get; set; }
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


    public class VITCRpcClient : IDisposable
    {
        private Uri _rpcUri;
        private HttpClient _httpClient;
        public VITCRpcClient(string ipAddress, int port, HttpClient httpClient = null)
        {
            //_rpcUri = new Uri($"http://{ipAddress}:{port}/");
            _rpcUri = new Uri($"{ipAddress}:{port}/");



            _httpClient = httpClient ?? new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        public VITCRpcClient(string uri)
        {
            _rpcUri = new Uri(uri);
            _httpClient = new HttpClient();
        }

        private async Task<string> CallRpcMethod(string json)
        {
            json = json.Replace("\"True\"", "\"true\"");
            json = json.Replace("\"False\"", "\"false\"");
            var content = new StringContent(json, Encoding.UTF8, "application/json");
           
            var responseMessage = await _httpClient.PostAsync(_rpcUri, content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new HttpRequestException($"Http status code: {responseMessage.StatusCode}");
            return await responseMessage.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }



        public async Task<AccountBalanceResponse> AccountBalance(string account)
        {
            var jobject = new JObject();

            jobject["jsonrpc"] = "2.0";
            jobject["id"] = "17";
            jobject["method"] = "ledger_getAccountInfoByAddress";
            jobject["params"] = new JArray(account);


            //string wow1 = "          {                \"jsonrpc\": \"2.0\",	\"id\": 17,	\"method\": \"ledger_getAccountBlocksByAddress\",	\"params\": [\"vite_a58abf32ac4a6c7d259431d23a5bf7d8e5c058bf05681dd436\", null, 3]}";
            //string wow1 = "          {                \"jsonrpc\": \"2.0\",	\"id\": 17,	\"method\": \"ledger_getAccountBlocksByAddress\",	\"params\": [\"vite_a58abf32ac4a6c7d259431d23a5bf7d8e5c058bf05681dd436\", null, 3]}";
            //string wow1 = "          {                \"jsonrpc\": \"2.0\",	\"id\": 17,	\"method\": \"ledger_getAccountInfoByAddress\",	\"params\": [\"vite_a58abf32ac4a6c7d259431d23a5bf7d8e5c058bf05681dd436\"]}";


            var response = await CallRpcMethod(jobject.ToString());// jobject.ToString());

            //left off here. you get the result just fine. you need to figure out how to parse the JSON, but it has SUB JSON within the JSON, so it's tricky.
            //good luck!
            //response = response.Replace("[", "").Replace("]", "");
            return JsonConvert.DeserializeObject<AccountBalanceResponse>(response, DotNano.Shared.JsonSerializationSettings.PascalCaseSettings);
        }


        public async Task<AccountHistoryResponse> AccountHistory(PublicAddress account, int Pagecount, int PageSize)
        {
            var jobject = new JObject();

            jobject["jsonrpc"] = "2.0";
            jobject["id"] = "17";
            jobject["method"] = "ledger_getAccountBlocksByAddress";
            jobject["params"] = new JArray(account.Address, Pagecount, PageSize);
            var response = await CallRpcMethod(jobject.ToString());// jobject.ToString());
            return JsonConvert.DeserializeObject<AccountHistoryResponse>(response, DotNano.Shared.JsonSerializationSettings.PascalCaseSettings);
        }

        public class SendResponse
        {
            public string result
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


        public async Task<SendResponse> SendVitC(HexKey64 wallet, string source, string destination, BigInteger amount, string tokenContractID)
        {
            //var jobject = new JObject();
            //jobject["action"] = "send";
            //jobject["wallet"] = wallet.ToString();
            //jobject["source"] = source.ToString();
            //jobject["destination"] = destination.ToString();
            //jobject["amount"] = amount.ToString();
            //if (id != null)
            //    jobject["id"] = id;
            //if (work != null)
            //    jobject["work"] = work;


            var jobject = new JObject();

            jobject["jsonrpc"] = "2.0";
            jobject["id"] = "17";
            jobject["method"] = "wallet_createTxWithPassphrase";

            var jobject2 = new JObject();

            jobject2["selfAddr"] = source;
            jobject2["toAddr"] = destination;
            jobject2["tokenTypeId"] = tokenContractID;
            jobject2["passphrase"] = "rogelio9";
            jobject2["amount"] = amount.ToString();


            jobject["params"] = new JArray(jobject2);





            var response = await CallRpcMethod(jobject.ToString());
            
            return JsonConvert.DeserializeObject<SendResponse>(response, DotNano.Shared.JsonSerializationSettings.PascalCaseSettings);
        }


    }
}
