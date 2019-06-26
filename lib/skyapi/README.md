# Skyapi - the C# library for the Skycoin REST API.

Skycoin is a next-generation cryptocurrency.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.26.0
- SDK version: 0.26.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://skycoin.net](https://skycoin.net)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Skyapi.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Diagnostics;
using Skyapi.Api;
using Skyapi.Client;
using Skyapi.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://127.0.0.1:6420";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Returns the total number of unique address that have coins.
                InlineResponse200 result = apiInstance.AddressCount();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AddressCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://127.0.0.1:6420*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**AddressCount**](docs/DefaultApi.md#addresscount) | **GET** /api/v1/addresscount | Returns the total number of unique address that have coins.
*DefaultApi* | [**AddressUxouts**](docs/DefaultApi.md#addressuxouts) | **GET** /api/v1/address_uxouts | 
*DefaultApi* | [**ApiV1RawtxGet**](docs/DefaultApi.md#apiv1rawtxget) | **GET** /api/v1/rawtx | 
*DefaultApi* | [**ApiV2MetricsGet**](docs/DefaultApi.md#apiv2metricsget) | **GET** /api/v2/metrics | 
*DefaultApi* | [**BalanceGet**](docs/DefaultApi.md#balanceget) | **GET** /api/v1/balance | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
*DefaultApi* | [**BalancePost**](docs/DefaultApi.md#balancepost) | **POST** /api/v1/balance | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
*DefaultApi* | [**Block**](docs/DefaultApi.md#block) | **GET** /api/v1/block | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
*DefaultApi* | [**BlockchainMetadata**](docs/DefaultApi.md#blockchainmetadata) | **GET** /api/v1/blockchain/metadata | Returns the blockchain metadata.
*DefaultApi* | [**BlockchainProgress**](docs/DefaultApi.md#blockchainprogress) | **GET** /api/v1/blockchain/progress | Returns the blockchain sync progress.
*DefaultApi* | [**Blocks**](docs/DefaultApi.md#blocks) | **GET** /api/v1/blocks | Returns the balance of one or more addresses, both confirmed and predicted. The predicted balance is the confirmed balance minus the pending spends.
*DefaultApi* | [**CoinSupply**](docs/DefaultApi.md#coinsupply) | **GET** /api/v1/coinSupply | 
*DefaultApi* | [**Csrf**](docs/DefaultApi.md#csrf) | **GET** /api/v1/csrf | Creates a new CSRF token. Previous CSRF tokens are invalidated by this call.
*DefaultApi* | [**DataDELETE**](docs/DefaultApi.md#datadelete) | **DELETE** /api/v2/data | 
*DefaultApi* | [**DataGET**](docs/DefaultApi.md#dataget) | **GET** /api/v2/data | 
*DefaultApi* | [**DataPOST**](docs/DefaultApi.md#datapost) | **POST** /api/v2/data | 
*DefaultApi* | [**DefaultConnections**](docs/DefaultApi.md#defaultconnections) | **GET** /api/v1/network/defaultConnections | defaultConnectionsHandler returns the list of default hardcoded bootstrap addresses.\\n They are not necessarily connected to.
*DefaultApi* | [**Health**](docs/DefaultApi.md#health) | **GET** /api/v1/health | Returns node health data.
*DefaultApi* | [**LastBlocks**](docs/DefaultApi.md#lastblocks) | **GET** /api/v1/last_blocks | 
*DefaultApi* | [**NetworkConnection**](docs/DefaultApi.md#networkconnection) | **GET** /api/v1/network/connection | This endpoint returns a specific connection.
*DefaultApi* | [**NetworkConnections**](docs/DefaultApi.md#networkconnections) | **GET** /api/v1/network/connections | This endpoint returns all outgoings connections.
*DefaultApi* | [**NetworkConnectionsDisconnect**](docs/DefaultApi.md#networkconnectionsdisconnect) | **POST** /api/v1/network/connection/disconnect | 
*DefaultApi* | [**NetworkConnectionsExchange**](docs/DefaultApi.md#networkconnectionsexchange) | **GET** /api/v1/network/connections/exchange | 
*DefaultApi* | [**NetworkConnectionsTrust**](docs/DefaultApi.md#networkconnectionstrust) | **GET** /api/v1/network/connections/trust | trustConnectionsHandler returns all trusted connections.\\n They are not necessarily connected to. In the default configuration, these will be a subset of the default hardcoded bootstrap addresses.
*DefaultApi* | [**OutputsGet**](docs/DefaultApi.md#outputsget) | **GET** /api/v1/outputs | If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
*DefaultApi* | [**OutputsPost**](docs/DefaultApi.md#outputspost) | **POST** /api/v1/outputs | If neither addrs nor hashes are specificed, return all unspent outputs. If only one filter is specified, then return outputs match the filter. Both filters cannot be specified.
*DefaultApi* | [**PendingTxs**](docs/DefaultApi.md#pendingtxs) | **GET** /api/v1/pendingTxs | 
*DefaultApi* | [**ResendUnconfirmedTxns**](docs/DefaultApi.md#resendunconfirmedtxns) | **POST** /api/v1/resendUnconfirmedTxns | 
*DefaultApi* | [**Richlist**](docs/DefaultApi.md#richlist) | **GET** /api/v1/richlist | Returns the top skycoin holders.
*DefaultApi* | [**Transaction**](docs/DefaultApi.md#transaction) | **GET** /api/v1/transaction | 
*DefaultApi* | [**TransactionInject**](docs/DefaultApi.md#transactioninject) | **POST** /api/v1/injectTransaction | Broadcast a hex-encoded, serialized transaction to the network.
*DefaultApi* | [**TransactionPost**](docs/DefaultApi.md#transactionpost) | **POST** /api/v2/transaction | 
*DefaultApi* | [**TransactionPostUnspent**](docs/DefaultApi.md#transactionpostunspent) | **POST** /api/v2/transaction/unspent | 
*DefaultApi* | [**TransactionRaw**](docs/DefaultApi.md#transactionraw) | **GET** /api/v2/transaction/raw | Returns the hex-encoded byte serialization of a transaction. The transaction may be confirmed or unconfirmed.
*DefaultApi* | [**TransactionVerify**](docs/DefaultApi.md#transactionverify) | **POST** /api/v2/transaction/verify | 
*DefaultApi* | [**TransactionsGet**](docs/DefaultApi.md#transactionsget) | **GET** /api/v1/transactions | Returns transactions that match the filters.
*DefaultApi* | [**TransactionsPost**](docs/DefaultApi.md#transactionspost) | **POST** /api/v1/transactions | Returns transactions that match the filters.
*DefaultApi* | [**Uxout**](docs/DefaultApi.md#uxout) | **GET** /api/v1/uxout | Returns an unspent output by ID.
*DefaultApi* | [**VerifyAddress**](docs/DefaultApi.md#verifyaddress) | **POST** /api/v2/address/verify | Verifies a Skycoin address.
*DefaultApi* | [**Version**](docs/DefaultApi.md#version) | **GET** /api/v1/version | 
*DefaultApi* | [**Wallet**](docs/DefaultApi.md#wallet) | **GET** /api/v1/wallet | Returns a wallet by id.
*DefaultApi* | [**WalletBalance**](docs/DefaultApi.md#walletbalance) | **GET** /api/v1/wallet/balance | Returns the wallet's balance, both confirmed and predicted.  The predicted balance is the confirmed balance minus the pending spends.
*DefaultApi* | [**WalletCreate**](docs/DefaultApi.md#walletcreate) | **POST** /api/v1/wallet/create | 
*DefaultApi* | [**WalletDecrypt**](docs/DefaultApi.md#walletdecrypt) | **POST** /api/v1/wallet/decrypt | Decrypts wallet.
*DefaultApi* | [**WalletEncrypt**](docs/DefaultApi.md#walletencrypt) | **POST** /api/v1/wallet/encrypt | Encrypt wallet.
*DefaultApi* | [**WalletFolder**](docs/DefaultApi.md#walletfolder) | **GET** /api/v1/wallets/folderName | 
*DefaultApi* | [**WalletNewAddress**](docs/DefaultApi.md#walletnewaddress) | **POST** /api/v1/wallet/newAddress | 
*DefaultApi* | [**WalletNewSeed**](docs/DefaultApi.md#walletnewseed) | **GET** /api/v1/wallet/newSeed | 
*DefaultApi* | [**WalletRecover**](docs/DefaultApi.md#walletrecover) | **POST** /api/v2/wallet/recover | Recovers an encrypted wallet by providing the seed. The first address will be generated from seed and compared to the first address of the specified wallet. If they match, the wallet will be regenerated with an optional password. If the wallet is not encrypted, an error is returned.
*DefaultApi* | [**WalletSeed**](docs/DefaultApi.md#walletseed) | **POST** /api/v1/wallet/seed | This endpoint only works for encrypted wallets. If the wallet is unencrypted, The seed will be not returned.
*DefaultApi* | [**WalletSeedVerify**](docs/DefaultApi.md#walletseedverify) | **POST** /api/v2/wallet/seed/verify | Verifies a wallet seed.
*DefaultApi* | [**WalletTransaction**](docs/DefaultApi.md#wallettransaction) | **POST** /api/v1/wallet/transaction | Creates a signed transaction
*DefaultApi* | [**WalletTransactionSign**](docs/DefaultApi.md#wallettransactionsign) | **POST** /api/v2/wallet/transaction/sign | Creates a signed transaction
*DefaultApi* | [**WalletTransactions**](docs/DefaultApi.md#wallettransactions) | **GET** /api/v1/wallet/transactions | 
*DefaultApi* | [**WalletUnload**](docs/DefaultApi.md#walletunload) | **POST** /api/v1/wallet/unload | Unloads wallet from the wallet service.
*DefaultApi* | [**WalletUpdate**](docs/DefaultApi.md#walletupdate) | **POST** /api/v1/wallet/update | Update the wallet.
*DefaultApi* | [**Wallets**](docs/DefaultApi.md#wallets) | **GET** /api/v1/wallets | 


## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.ApiV1PendingTxsTransaction](docs/ApiV1PendingTxsTransaction.md)
 - [Model.ApiV1PendingTxsTransactionOutputs](docs/ApiV1PendingTxsTransactionOutputs.md)
 - [Model.BlockSchema](docs/BlockSchema.md)
 - [Model.BlockSchemaBody](docs/BlockSchemaBody.md)
 - [Model.BlockVerboseSchema](docs/BlockVerboseSchema.md)
 - [Model.BlockVerboseSchemaBody](docs/BlockVerboseSchemaBody.md)
 - [Model.BlockVerboseSchemaHeader](docs/BlockVerboseSchemaHeader.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2008Data](docs/InlineResponse2008Data.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.InlineResponseDefault](docs/InlineResponseDefault.md)
 - [Model.NetworkConnectionSchema](docs/NetworkConnectionSchema.md)
 - [Model.NetworkConnectionSchemaUnconfirmedVerifyTransaction](docs/NetworkConnectionSchemaUnconfirmedVerifyTransaction.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionEncoded](docs/TransactionEncoded.md)
 - [Model.TransactionEncodedS](docs/TransactionEncodedS.md)
 - [Model.TransactionStatus](docs/TransactionStatus.md)
 - [Model.TransactionTxn](docs/TransactionTxn.md)
 - [Model.TransactionV2ParamsAddress](docs/TransactionV2ParamsAddress.md)
 - [Model.TransactionV2ParamsAddressHoursSelection](docs/TransactionV2ParamsAddressHoursSelection.md)
 - [Model.TransactionV2ParamsUnspent](docs/TransactionV2ParamsUnspent.md)
 - [Model.TransactionV2ParamsUnspentHoursSelection](docs/TransactionV2ParamsUnspentHoursSelection.md)
 - [Model.TransactionV2ParamsUnspentTo](docs/TransactionV2ParamsUnspentTo.md)
 - [Model.TransactionVerbose](docs/TransactionVerbose.md)
 - [Model.TransactionVerboseTxn](docs/TransactionVerboseTxn.md)
 - [Model.TransactionVerboseTxnInputs](docs/TransactionVerboseTxnInputs.md)
 - [Model.TransactionVerifyRequest](docs/TransactionVerifyRequest.md)
 - [Model.WalletTransactionRequest](docs/WalletTransactionRequest.md)
 - [Model.WalletTransactionRequestHoursSelection](docs/WalletTransactionRequestHoursSelection.md)
 - [Model.WalletTransactionRequestWallet](docs/WalletTransactionRequestWallet.md)
 - [Model.WalletTransactionSignRequest](docs/WalletTransactionSignRequest.md)


## Documentation for Authorization


### csrfAuth

- **Type**: API key

- **API key parameter name**: X-CSRF-TOKEN
- **Location**: HTTP header
