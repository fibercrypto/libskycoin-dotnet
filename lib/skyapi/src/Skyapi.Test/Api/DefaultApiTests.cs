/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.26.0
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using NUnit.Framework;
using Skyapi.Client;
using Skyapi.Api;
using RestSharp;
using Skyapi.Model;

namespace Skyapi.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi _instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            _instance = new DefaultApi(Utils.GetNodeHost());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOfType(typeof(DefaultApi), _instance, "instance is a DefaultApi");
        }


        /// <summary>
        /// Test AddressCount
        /// </summary>
        [Test]
        public void AddressCountTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.AddressCount(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.AddressCount(_instance);
            }
        }

        /// <summary>
        /// Test AddressUxouts
        /// </summary>
        [Test]
        public void AddressUxoutsTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.AddressUxouts(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                if (Utils.LiveDisableNetworking())
                {
                    LiveTest.AddressUxouts(_instance);
                }
                else
                {
                    Console.WriteLine("Skipping slow ux out tests when networking disabled");
                }
            }
        }

        /// <summary>
        /// Test ApiV1RawtxGet
        /// </summary>
        [Test]
        public void ApiV1RawtxGetTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.ApiRawTxGet(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.ApiRawTxGet(instance: _instance);
            }
        }

        /// <summary>
        /// Test ApiV2MetricsGet
        /// </summary>
        [Test]
        public void ApiV2MetricsGetTest()
        {
            //Only with API-SETS PROMETHEUS is active.
            try
            {
                var response = _instance.ApiV2MetricsGet();
                Assert.IsInstanceOf<string>(response, "response is string");
                Assert.IsNotNull(response);
                if (Utils.GetTestMode() == "stable") Assert.True(response.Contains("last_block_seq 180"));
            }
            catch (ApiException err)
            {
                Assert.AreEqual(403, err.ErrorCode,
                    "Endpoint Not tested. Endpoint are disable : Api-sets PROMETHEUS could be disabled." +
                    " Try to enable it.");
            }
        }

        /// <summary>
        /// Test BalanceGet
        /// </summary>
        [Test]
        public void BalanceGetTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Balance(_instance, Method.GET);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Balance(Method.GET, instance: _instance);
            }
        }

        /// <summary>
        /// Test BalancePost
        /// </summary>
        [Test]
        public void BalancePostTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Balance(_instance, Method.POST);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Balance(Method.POST, _instance);
            }
        }

        /// <summary>
        /// Test Block
        /// </summary>
        [Test]
        public void BlockTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Block(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Block(_instance);
            }
        }

        /// <summary>
        /// Test BlockchainMetadata
        /// </summary>
        [Test]
        public void BlockchainMetadataTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.BlockchainMetadata(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.BlockchainMetadata(_instance);
            }
        }

        /// <summary>
        /// Test BlockchainProgress
        /// </summary>
        [Test]
        public void BlockchainProgressTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.BlockChainProgress(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.BlockChainProgress(_instance);
            }
        }

        /// <summary>
        /// Test Blocks
        /// </summary>
        [Test]
        public void BlocksTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Blocks(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Blocks(_instance);
            }
        }

        /// <summary>
        /// Test CoinSupply
        /// </summary>
        [Test]
        public void CoinSupplyTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.CoinSupply(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.CoinSupply(_instance);
            }
        }

        /// <summary>
        /// Test Csrf
        /// </summary>
        [Test]
        public void CsrfTest()
        {
            //Only with _useCsrf==true
            if (Utils.UseCsrf())
            {
                var response = _instance.Csrf();
                Assert.IsNotNull(response.CsrfToken);
                Assert.True(response.CsrfToken.Length >= 235);
            }
        }

        /// <summary>
        /// Test DataDELETE
        /// </summary>
        [Test]
        public void DataDeleteTest()
        {
            if (!Utils.GetTestMode().Equals("stable"))
            {
                return;
            }

            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
            }

            _instance.DataPOST(type: "txid", key: "key1", val: "val1");
            var result = _instance.DataGET(type: "txid");
            _instance.DataPOST(type: "txid", key: "keytodel", val: "valtodel");
            _instance.DataDELETE(type: "txid", key: "keytodel");
            Assert.AreEqual(result, _instance.DataGET("txid"));
        }

        /// <summary>
        /// Test DataGET
        /// </summary>
        [Test]
        public void DataGetTest()
        {
            if (!Utils.GetTestMode().Equals("stable"))
            {
                return;
            }

            var allresult = new {data = new {key1 = "val1", key2 = "val2"}};
            var singleresult = new {data = "val1"};
            if (Utils.UseCsrf()) _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            _instance.DataPOST(type: "txid", key: "key1", val: "val1");
            _instance.DataPOST(type: "txid", key: "key2", val: "val2");
            //Varify all results.
            Assert.AreEqual(JsonConvert.SerializeObject(allresult),
                JsonConvert.SerializeObject(_instance.DataGET(type: "txid")));
            //Verify a single result.
            Assert.AreEqual(JsonConvert.SerializeObject(singleresult),
                JsonConvert.SerializeObject(_instance.DataGET(type: "txid", key: "key1")));
        }

        /// <summary>
        /// Test DataPOST
        /// </summary>
        [Test]
        public void DataPostTest()
        {
            if (!Utils.GetTestMode().Equals("stable"))
            {
                return;
            }

            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
            }

            _instance.DataPOST(type: "client", key: "key1", val: "val1");
        }

        /// <summary>
        /// Test DefaultConnections
        /// </summary>
        [Test]
        public void DefaultConnectionsTest()
        {
            var connections = _instance.DefaultConnections();
            Assert.IsNotEmpty(connections);
            connections.Sort();
            Utils.CheckGoldenFile("network-default-peers.golden", connections, connections.GetType());
        }

        /// <summary>
        /// Test Health
        /// </summary>
        [Test]
        public void HealthTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Health(instance: _instance);
            }
            else if (Utils.GetTestMode().Equals("live"))

            {
                LiveTest.Health(_instance);
            }
        }

        /// <summary>
        /// Test LastBlocks
        /// </summary>
        [Test]
        public void LastBlocksTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.LastBlocks(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.LastBlock(_instance);
            }
        }

        /// <summary>
        /// Test NetworkConnection and NetworkConnections
        /// </summary>
        [Test]
        public void NetworkConnectionTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.NetworkConnection(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.NetworkConnection(instance: _instance);
            }
        }

        /// <summary>
        /// Test NetworkConnectionsDisconnect
        /// </summary>
        [Test]
        public void NetworkConnectionsDisconnectTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.NetworkConnectionDisconnect(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.NetworkConnectionDisconnect(instance: _instance);
            }
        }

        /// <summary>
        /// Test NetworkConnectionsExchange
        /// </summary>
        [Test]
        public void NetworkConnectionsExchangeTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.NetworkConnectionExchange(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.NetworkConnectionExchange(_instance);
            }
        }

        /// <summary>
        /// Test NetworkConnectionsTrust
        /// </summary>
        [Test]
        public void NetworkConnectionsTrustTest()
        {
            var connections = _instance.NetworkConnectionsTrust();
            Assert.IsNotEmpty(connections);
            connections.Sort();
            Utils.CheckGoldenFile("network-trusted-peers.golden", connections, connections.GetType());
        }

        /// <summary>
        /// Test OutputsGet
        /// </summary>
        [Test]
        public void OutputsGetTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                if (Utils.DbNoUnconfirmed())
                {
                    StableTest.NoUnconfirmedOutputs(Method.GET, _instance);
                }
                else
                {
                    StableTest.Outputs(Method.GET, _instance);
                }
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Outputs(Method.GET, _instance);
            }
        }

        /// <summary>
        /// Test OutputsPost
        /// </summary>
        [Test]
        public void OutputsPostTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                if (Utils.DbNoUnconfirmed())
                {
                    StableTest.NoUnconfirmedOutputs(Method.POST, _instance);
                }
                else
                {
                    StableTest.Outputs(Method.POST, _instance);
                }
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Outputs(Method.POST, _instance);
            }
        }

        /// <summary>
        /// Test PendingTxs
        /// </summary>
        [Test]
        public void PendingTxsTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                if (Utils.DbNoUnconfirmed())
                {
                    StableTest.NoUnconfirmedPendingTxs(_instance);
                }
                else
                {
                    StableTest.PendingTxs(_instance);
                }
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.PendingTxs(_instance);
            }
        }

        /// <summary>
        /// Test ResendUnconfirmedTxns
        /// </summary>
        [Test]
        public void ResendUnconfirmedTxnsTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.ResendUnconfirmedTxns(instance: _instance);
            }
            else if (Utils.GetTestMode().Equals("live"))

            {
                LiveTest.ResendUnconfirmedTxns(_instance);
            }
        }

        /// <summary>
        /// Test Richlist
        /// </summary>
        [Test]
        public void RichlistTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.RichList(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.RichList(_instance);
            }
        }

        /// <summary>
        /// Test Transaction
        /// </summary>
        [Test]
        public void TransactionTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Transaction(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.Transaction(_instance);
            }
        }

        /// <summary>
        /// Test TransactionInject
        /// </summary>
        [Test]
        public void TransactionInjectTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.TransactionInject(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                if (Utils.LiveDisableNetworking())
                {
                    LiveTest.TransactionInjectDisableNetworking(_instance);
                }
                else
                {
                    LiveTest.TransactionInjectEnableNetworking(_instance);
                }
            }
        }

        /// <summary>
        /// Test TransactionPost
        /// </summary>
        [Test]
        public void TransactionPostTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.TransactionPost(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                ///////
            }
        }

        /// <summary>
        /// Test TransactionPostUnspent
        /// </summary>
        [Test]
        public void TransactionPostUnspentTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.TransactionPostUnspents(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                ///////
            }
        }

        /// <summary>
        /// Test TransactionVerify
        /// </summary>
        [Test]
        public void TransactionVerifyTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.TransactionVerify(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                ///////
            }
        }

        /// <summary>
        /// Test TransactionsGet
        /// </summary>
        [Test]
        public void TransactionsGetTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Transactions(method: Method.GET, instance: _instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                return;
                LiveTest.Transactions(Method.GET, _instance);
            }
        }

        /// <summary>
        /// Test TransactionsPost
        /// </summary>
        [Test]
        public void TransactionsPostTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Transactions(method: Method.POST, instance: _instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                return;
                LiveTest.Transactions(Method.POST, _instance);
            }
        }

        /// <summary>
        /// Test Uxout
        /// </summary>
        [Test]
        public void UxoutTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.Uxouts(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                /////////
            }
        }

        /// <summary>
        /// Test VerifyAddress
        /// </summary>
        [Test]
        public void VerifyAddressTest()
        {
            if (Utils.GetTestMode().Equals("stable") || Utils.GetTestMode().Equals("live"))
            {
                var testCases = new[]
                {
                    new
                    {
                        name = "valid address",
                        golden = "verify-address.golden",
                        adds = new Address("7cpQ7t3PZZXvjTst8G7Uvs7XH4LeM8fBPD"),
                        errCode = 200,
                        errMsg = ""
                    },
                    new
                    {
                        name = "invalid address",
                        golden = "",
                        adds = new Address("7apQ7t3PZZXvjTst8G7Uvs7XH4LeM8fBPD"),
                        errCode = 422,
                        errMsg = "Invalid checksum"
                    },
                    new
                    {
                        name = "missing address",
                        golden = "",
                        adds = new Address(""),
                        errCode = 400,
                        errMsg = "address is required"
                    }
                };
                foreach (var tc in testCases)
                {
                    if (Utils.UseCsrf())
                    {
                        _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
                    }

                    if (tc.errCode != 200)
                    {
                        var errRaw = Assert.Throws<ApiException>(() => _instance.VerifyAddress(tc.adds));
                        dynamic err = JsonConvert.DeserializeObject(errRaw.Message.Substring(28));
                        Assert.AreEqual(tc.errCode, errRaw.ErrorCode, tc.name);
                        Assert.AreEqual(tc.errMsg, err.error.message.ToString(), tc.name);
                    }
                    else
                    {
                        Assert.DoesNotThrow(() =>
                            {
                                dynamic result = _instance.VerifyAddress(tc.adds);
                                Utils.CheckGoldenFile(tc.golden, result.data, result.GetType());
                            }
                            , tc.name);
                    }
                }
            }
        }

        /// <summary>
        /// Test Version
        /// </summary>
        [Test]
        public void VersionTest()
        {
            var result = _instance.Version();
            Assert.IsNotEmpty(result.Branch);
            Assert.IsNotEmpty(result.Commit);
            Assert.IsNotEmpty(result.Version);
        }

        /// <summary>
        /// Test Wallet
        /// </summary>
        [Test]
        public void WalletTest()
        {
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            Assert.DoesNotThrow(() =>
            {
                var randSeed = Utils.GenString();
                var newwallet = _instance.WalletCreate(type: "deterministic", seed: randSeed,
                    label: "the label of my wallet");
                var wallet = _instance.Wallet(newwallet.Meta.Id);
                _instance.WalletUnload(newwallet.Meta.Id);
                Assert.AreEqual(newwallet, wallet);
            });
        }

        /// <summary>
        /// Test WalletBalance
        /// </summary>
        [Test]
        public void WalletBalanceTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.WalletBalance(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.WalletBalance(_instance);
            }
        }

        /// <summary>
        /// Test WalletCreate.Ignore that Test.Error:Error getting response stram (ReadDone2): ReceiveFailure.   
        /// </summary>
        [Test]
        public void WalletCreateTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            Assert.Ignore();
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            var testCases = new[]
            {
                new
                {
                    name = "missing seed.",
                    seed = "",
                    encrypt = false,
                    pass = "",
                    errCode = 400,
                    errMsg = "Error calling WalletCreate: 400 Bad Request - missing seed\n"
                },
                new
                {
                    name = "encrypt must be true",
                    seed = Utils.GenString(),
                    encrypt = false,
                    pass = "1234",
                    errCode = 400,
                    errMsg =
                        "Error calling WalletCreate: 400 Bad Request - encrypt must be true as password is provided\n"
                },
                new
                {
                    name = "no password",
                    seed = Utils.GenString(),
                    encrypt = true,
                    pass = "",
                    errCode = 400,
                    errMsg = "Error calling WalletCreate: 400 Bad Request - missing password\n"
                },
                new
                {
                    name = "no encrypt",
                    seed = Utils.GenString(),
                    encrypt = false,
                    pass = "",
                    errCode = 200,
                    errMsg = ""
                },
                new
                {
                    name = "encrypt wallet",
                    seed = Utils.GenString(),
                    encrypt = true,
                    pass = "1234",
                    errCode = 200,
                    errMsg = ""
                }
            };

            foreach (var tc in testCases)
            {
                if (tc.errCode != 200)
                {
                    var err = Assert.Throws<ApiException>(() =>
                        _instance.WalletCreate(type: "deterministic", seed: tc.seed, label: tc.name,
                            encrypt: tc.encrypt,
                            password: tc.pass));
                    Assert.AreEqual(tc.errCode, err.ErrorCode, tc.name);
                    Assert.AreEqual(tc.errMsg, err.Message, tc.name);
                }
                else
                {
                    var newWallet = _instance.WalletCreate(type: "deterministic", seed: tc.seed, label: tc.name,
                        encrypt: tc.encrypt,
                        password: tc.pass);
                    var walletByid = _instance.Wallet(newWallet.Meta.Id);
                    Assert.AreEqual(newWallet, walletByid, tc.name);
                }
            }
        }

        /// <summary>
        /// Test WalletDecrypt.Ignore that Test.Error:Error getting response stram (ReadDone2): ReceiveFailure.
        /// </summary>
        [Test]
        public void WalletDecryptTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            Assert.Ignore();
            var seed = Utils.GenString();
            var pass = "1234";
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
            }

            var walletEncrypt =
                _instance.WalletCreate(type: "deterministic", seed: seed, label: "decrypt wallet.", encrypt: true,
                    password: pass);
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            var walletDecrypt = _instance.WalletDecrypt(id: walletEncrypt.Meta.Id, password: pass);
            walletEncrypt.Meta.Encrypted = false;
            walletEncrypt.Meta.CryptoType = "";
            Assert.AreEqual(walletEncrypt, walletDecrypt);
        }

        /// <summary>
        /// Test WalletEncrypt.Ignore that Test.Error:Error getting response stram (ReadDone2): ReceiveFailure.
        /// </summary>
        [Test]
        public void WalletEncryptTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            Assert.Ignore();
            var seed = Utils.GenString();
            var pass = "1234";
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
            }

            var walletDecrypt =
                _instance.WalletCreate(type: "deterministic", seed: seed, label: "decrypt wallet.", encrypt: false);
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            var walletEncrypt = _instance.WalletEncrypt(id: walletDecrypt.Meta.Id, password: pass);
            walletEncrypt.Meta.Encrypted = false;
            walletEncrypt.Meta.CryptoType = "";
            Assert.AreEqual(walletDecrypt, walletEncrypt);
        }

        /// <summary>
        /// Test WalletFolder
        /// </summary>
        [Test]
        public void WalletFolderTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            Assert.DoesNotThrow(() =>
            {
                var folderName = _instance.WalletFolder();
                Assert.NotNull(folderName);
                Assert.IsNotEmpty(folderName.Address);
            });
        }

        /// <summary>
        /// Test WalletNewAddress
        /// </summary>
        [Test]
        public void WalletNewAddressTest()
        {
            Assert.Ignore();
            var wallets = _instance.Wallets();
            Console.WriteLine(JsonConvert.SerializeObject(wallets, Formatting.Indented));
            if (!wallets.Exists(wallet => wallet.Meta.Label.Equals("new_address_test")))
            {
                if (Utils.UseCsrf())
                {
                    _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
                }

                var seed = Utils.GenString();
                _instance.WalletCreate("deterministic", seed, "new_address_test");
            }

            var walletforTestNewAddress = wallets.Find(wallet => wallet.Meta.Label.Equals("new_address_test"));
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(instance: _instance));
            }

            dynamic address = _instance.WalletNewAddress(walletforTestNewAddress.Meta.Id);
            walletforTestNewAddress = _instance.Wallet(walletforTestNewAddress.Meta.Id);
            Assert.True(walletforTestNewAddress.Entries.Exists(entry =>
                entry.Address.Equals(address.addresses[0].ToString())));
        }

        /// <summary>
        /// Test WalletNewSeed
        /// </summary>
        [Test]
        public void WalletNewSeedTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            var testCases = new[]
            {
                new
                {
                    name = "entropy 128",
                    entropy = "128",
                    cantwords = 12,
                    errCode = 200,
                    errMsg = ""
                },
                new
                {
                    name = "entropy 256",
                    entropy = "256",
                    cantwords = 24,
                    errCode = 200,
                    errMsg = ""
                },
                new
                {
                    name = "entropy 100",
                    entropy = "100",
                    cantwords = 12,
                    errCode = 400,
                    errMsg = "Error calling WalletNewSeed: 400 Bad Request - entropy length must be 128 or 256\n"
                }
            };

            foreach (var tc in testCases)
            {
                if (tc.errCode != 200)
                {
                    var err = Assert.Throws<ApiException>(() => _instance.WalletNewSeed(tc.entropy));
                    Assert.AreEqual(tc.errCode, err.ErrorCode, tc.name);
                    Assert.AreEqual(tc.errMsg, err.Message, tc.name);
                }
                else
                {
                    dynamic newseed = _instance.WalletNewSeed(tc.entropy);
                    Assert.True(newseed.seed.ToString().Split(' ').Length == tc.cantwords, tc.name);
                    dynamic newseed2 = _instance.WalletNewSeed(tc.entropy);
                    Assert.AreNotEqual(newseed.seed.ToString(), newseed2.seed.ToString(), tc.name);
                }
            }
        }

        /// <summary>
        /// Test WalletRecover.Ignore that Test.Error:Error getting response stram (ReadDone2): ReceiveFailure.
        /// </summary>
        [Test]
        public void WalletRecoverTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            Assert.Ignore();
            var randSeed = Utils.GenString();

            Assert.DoesNotThrow(() =>
            {
                var pass = "1234";
                if (Utils.UseCsrf())
                {
                    _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
                }

                var wallet
                    = _instance.WalletCreate(type: "deterministic", label: "recover wallet", seed: randSeed,
                        encrypt: true, password: pass);
                Assert.True(wallet.Meta.Encrypted);
                if (Utils.UseCsrf())
                {
                    _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
                }

                dynamic recoverData = _instance.WalletRecover(id: wallet.Meta.Id, seed: randSeed);
                var recoverWallet = JsonConvert.DeserializeObject<Wallet>(recoverData.data.ToString());
                wallet.Meta.Encrypted = false;
                wallet.Meta.CryptoType = "";
                Assert.AreEqual(wallet, recoverWallet);
            });
        }

        /// <summary>
        /// Test WalletSeed.Ignore that Test. Error:Error getting response stram (ReadDone2): ReceiveFailure.
        /// </summary>
        [Test]
        public void WalletSeedTest()
        {
            Assert.Ignore();
            var pass = "1234";
            if (!_instance.Wallets().Exists(wallet => wallet.Meta.Label.Equals("seed test.")))
            {
                var seed = Utils.GenString();
                if (Utils.UseCsrf())
                {
                    _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
                }

                _instance.WalletCreate("deterministic", seed, "seed test.", encrypt: true, password: pass);
            }

            var walletseed = _instance.Wallets().Find(wallet => wallet.Meta.Label.Equals("seed test."));
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            var err = Assert.Throws<ApiException>(() => _instance.WalletSeed(walletseed.Meta.Id, pass));
            Assert.AreEqual(403, err.ErrorCode);
            Assert.AreEqual("Error calling WalletSeed: 403 Forbidden - Endpoint is disabled\n", err.Message);
        }

        /// <summary>
        /// Test WalletSeedVerify
        /// </summary>
        [Test]
        public void WalletSeedVerifyTest()
        {
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            //Test with correct seed
            var result =
                _instance.WalletSeedVerify(
                    "nut wife logic sample addict shop before tobacco crisp bleak lawsuit affair");
            Assert.NotNull(result);
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            //test with incorrect seed
            Assert.Throws<ApiException>(() => _instance.WalletSeedVerify("nut"));
        }

        /// <summary>
        /// Test WalletTransactions
        /// </summary>
        [Test]
        public void WalletTransactionsTest()
        {
            if (Utils.GetTestMode().Equals("stable"))
            {
                StableTest.WalletTransactions(_instance);
            }
            else if (Utils.GetTestMode().Equals("live"))
            {
                LiveTest.WalletTransactions(_instance);
            }
        }

        /// <summary>
        /// Test WalletUpdate
        /// </summary>
        [Test]
        public void WalletUpdateTest()
        {
            Assert.Ignore();
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            if (!_instance.Wallets().Exists(w => w.Meta.Label.Equals("my wallet update")))
            {
                if (Utils.UseCsrf())
                {
                    _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
                }

                var seed = Utils.GenString();
                _instance.WalletCreate("deterministic", seed, "my wallet update");
            }

            var wallet = _instance.Wallets().Find(w => w.Meta.Label.Equals("my wallet update"));
            var newlabel = "My new label for my wallet.";
            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            var result = _instance.WalletUpdate(wallet.Meta.Id, newlabel);

            var walletWithNewLabel = _instance.Wallet(wallet.Meta.Id);

            if (Utils.UseCsrf())
            {
                _instance.Configuration.AddApiKeyPrefix("X-CSRF-TOKEN", Utils.GetCsrf(_instance));
            }

            _instance.WalletUpdate(wallet.Meta.Id, "my wallet update");

            Assert.AreEqual("\"success\"", result);
            Assert.True(walletWithNewLabel.Meta.Label.Equals(newlabel));
        }

        /// <summary>
        /// Test Wallets
        /// </summary>
        [Test]
        public void WalletsTest()
        {
            if (Utils.GetTestMode() == "live" && !Utils.DoLiveWallet())
            {
                return;
            }

            var result = _instance.Wallets();

            result.ForEach(wlt =>
            {
                Assert.DoesNotThrow(() =>
                {
                    var walletById = _instance.Wallet(wlt.Meta.Id);
                    Assert.AreEqual(wlt, walletById);
                });
            });
        }
    }
}