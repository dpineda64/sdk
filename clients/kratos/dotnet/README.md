# Ory.Kratos.Client - the C# library for the Ory Kratos

Welcome to the ORY Kratos HTTP API documentation!

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.5.4-alpha.1
- SDK version: 0.5.4-alpha.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.ory.sh](https://www.ory.sh)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdminApi(config);
            var body = new KratosCreateIdentity(); // KratosCreateIdentity |  (optional) 

            try
            {
                // Create an Identity
                KratosIdentity result = apiInstance.CreateIdentity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.CreateIdentity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**CreateIdentity**](docs/AdminApi.md#createidentity) | **POST** /identities | Create an Identity
*AdminApi* | [**CreateRecoveryLink**](docs/AdminApi.md#createrecoverylink) | **POST** /recovery/link | Create a Recovery Link
*AdminApi* | [**DeleteIdentity**](docs/AdminApi.md#deleteidentity) | **DELETE** /identities/{id} | Delete an Identity
*AdminApi* | [**GetIdentity**](docs/AdminApi.md#getidentity) | **GET** /identities/{id} | Get an Identity
*AdminApi* | [**GetSchema**](docs/AdminApi.md#getschema) | **GET** /schemas/{id} | 
*AdminApi* | [**GetSelfServiceError**](docs/AdminApi.md#getselfserviceerror) | **GET** /self-service/errors | Get User-Facing Self-Service Errors
*AdminApi* | [**GetSelfServiceLoginFlow**](docs/AdminApi.md#getselfserviceloginflow) | **GET** /self-service/login/flows | Get Login Flow
*AdminApi* | [**GetSelfServiceRecoveryFlow**](docs/AdminApi.md#getselfservicerecoveryflow) | **GET** /self-service/recovery/flows | Get information about a recovery flow
*AdminApi* | [**GetSelfServiceRegistrationFlow**](docs/AdminApi.md#getselfserviceregistrationflow) | **GET** /self-service/registration/flows | Get Registration Flow
*AdminApi* | [**GetSelfServiceSettingsFlow**](docs/AdminApi.md#getselfservicesettingsflow) | **GET** /self-service/settings/flows | Get Settings Flow
*AdminApi* | [**GetSelfServiceVerificationFlow**](docs/AdminApi.md#getselfserviceverificationflow) | **GET** /self-service/verification/flows | Get Verification Flow
*AdminApi* | [**ListIdentities**](docs/AdminApi.md#listidentities) | **GET** /identities | List Identities
*AdminApi* | [**Prometheus**](docs/AdminApi.md#prometheus) | **GET** /metrics/prometheus | Get snapshot metrics from the Hydra service. If you're using k8s, you can then add annotations to your deployment like so:
*AdminApi* | [**UpdateIdentity**](docs/AdminApi.md#updateidentity) | **PUT** /identities/{id} | Update an Identity
*HealthApi* | [**IsInstanceAlive**](docs/HealthApi.md#isinstancealive) | **GET** /health/alive | Check alive status
*HealthApi* | [**IsInstanceReady**](docs/HealthApi.md#isinstanceready) | **GET** /health/ready | Check readiness status
*PublicApi* | [**CompleteSelfServiceBrowserSettingsOIDCSettingsFlow**](docs/PublicApi.md#completeselfservicebrowsersettingsoidcsettingsflow) | **POST** /self-service/browser/flows/registration/strategies/oidc/settings/connections | Complete the Browser-Based Settings Flow for the OpenID Connect Strategy
*PublicApi* | [**CompleteSelfServiceLoginFlowWithPasswordMethod**](docs/PublicApi.md#completeselfserviceloginflowwithpasswordmethod) | **POST** /self-service/login/methods/password | Complete Login Flow with Username/Email Password Method
*PublicApi* | [**CompleteSelfServiceRecoveryFlowWithLinkMethod**](docs/PublicApi.md#completeselfservicerecoveryflowwithlinkmethod) | **POST** /self-service/recovery/methods/link | Complete Recovery Flow with Link Method
*PublicApi* | [**CompleteSelfServiceRegistrationFlowWithPasswordMethod**](docs/PublicApi.md#completeselfserviceregistrationflowwithpasswordmethod) | **POST** /self-service/registration/methods/password | Complete Registration Flow with Username/Email Password Method
*PublicApi* | [**CompleteSelfServiceSettingsFlowWithPasswordMethod**](docs/PublicApi.md#completeselfservicesettingsflowwithpasswordmethod) | **POST** /self-service/settings/methods/password | Complete Settings Flow with Username/Email Password Method
*PublicApi* | [**CompleteSelfServiceSettingsFlowWithProfileMethod**](docs/PublicApi.md#completeselfservicesettingsflowwithprofilemethod) | **POST** /self-service/settings/methods/profile | Complete Settings Flow with Profile Method
*PublicApi* | [**CompleteSelfServiceVerificationFlowWithLinkMethod**](docs/PublicApi.md#completeselfserviceverificationflowwithlinkmethod) | **POST** /self-service/verification/methods/link | Complete Verification Flow with Link Method
*PublicApi* | [**GetSchema**](docs/PublicApi.md#getschema) | **GET** /schemas/{id} | 
*PublicApi* | [**GetSelfServiceError**](docs/PublicApi.md#getselfserviceerror) | **GET** /self-service/errors | Get User-Facing Self-Service Errors
*PublicApi* | [**GetSelfServiceLoginFlow**](docs/PublicApi.md#getselfserviceloginflow) | **GET** /self-service/login/flows | Get Login Flow
*PublicApi* | [**GetSelfServiceRecoveryFlow**](docs/PublicApi.md#getselfservicerecoveryflow) | **GET** /self-service/recovery/flows | Get information about a recovery flow
*PublicApi* | [**GetSelfServiceRegistrationFlow**](docs/PublicApi.md#getselfserviceregistrationflow) | **GET** /self-service/registration/flows | Get Registration Flow
*PublicApi* | [**GetSelfServiceSettingsFlow**](docs/PublicApi.md#getselfservicesettingsflow) | **GET** /self-service/settings/flows | Get Settings Flow
*PublicApi* | [**GetSelfServiceVerificationFlow**](docs/PublicApi.md#getselfserviceverificationflow) | **GET** /self-service/verification/flows | Get Verification Flow
*PublicApi* | [**InitializeSelfServiceBrowserLogoutFlow**](docs/PublicApi.md#initializeselfservicebrowserlogoutflow) | **GET** /self-service/browser/flows/logout | Initialize Browser-Based Logout User Flow
*PublicApi* | [**InitializeSelfServiceLoginViaAPIFlow**](docs/PublicApi.md#initializeselfserviceloginviaapiflow) | **GET** /self-service/login/api | Initialize Login Flow for API clients
*PublicApi* | [**InitializeSelfServiceLoginViaBrowserFlow**](docs/PublicApi.md#initializeselfserviceloginviabrowserflow) | **GET** /self-service/login/browser | Initialize Login Flow for browsers
*PublicApi* | [**InitializeSelfServiceRecoveryViaAPIFlow**](docs/PublicApi.md#initializeselfservicerecoveryviaapiflow) | **GET** /self-service/recovery/api | Initialize Recovery Flow for API Clients
*PublicApi* | [**InitializeSelfServiceRecoveryViaBrowserFlow**](docs/PublicApi.md#initializeselfservicerecoveryviabrowserflow) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browser Clients
*PublicApi* | [**InitializeSelfServiceRegistrationViaAPIFlow**](docs/PublicApi.md#initializeselfserviceregistrationviaapiflow) | **GET** /self-service/registration/api | Initialize Registration Flow for API clients
*PublicApi* | [**InitializeSelfServiceRegistrationViaBrowserFlow**](docs/PublicApi.md#initializeselfserviceregistrationviabrowserflow) | **GET** /self-service/registration/browser | Initialize Registration Flow for browsers
*PublicApi* | [**InitializeSelfServiceSettingsViaAPIFlow**](docs/PublicApi.md#initializeselfservicesettingsviaapiflow) | **GET** /self-service/settings/api | Initialize Settings Flow for API Clients
*PublicApi* | [**InitializeSelfServiceSettingsViaBrowserFlow**](docs/PublicApi.md#initializeselfservicesettingsviabrowserflow) | **GET** /self-service/settings/browser/flows | Initialize Settings Flow for Browsers
*PublicApi* | [**InitializeSelfServiceVerificationViaAPIFlow**](docs/PublicApi.md#initializeselfserviceverificationviaapiflow) | **GET** /self-service/verification/api | Initialize Verification Flow for API Clients
*PublicApi* | [**InitializeSelfServiceVerificationViaBrowserFlow**](docs/PublicApi.md#initializeselfserviceverificationviabrowserflow) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*PublicApi* | [**RevokeSession**](docs/PublicApi.md#revokesession) | **DELETE** /sessions | Revoke and Invalidate a Session
*PublicApi* | [**Whoami**](docs/PublicApi.md#whoami) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*VersionApi* | [**GetVersion**](docs/VersionApi.md#getversion) | **GET** /version | Get service version


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.KratosCompleteSelfServiceLoginFlowWithPasswordMethod](docs/KratosCompleteSelfServiceLoginFlowWithPasswordMethod.md)
 - [Model.KratosCompleteSelfServiceRecoveryFlowWithLinkMethod](docs/KratosCompleteSelfServiceRecoveryFlowWithLinkMethod.md)
 - [Model.KratosCompleteSelfServiceSettingsFlowWithPasswordMethod](docs/KratosCompleteSelfServiceSettingsFlowWithPasswordMethod.md)
 - [Model.KratosCompleteSelfServiceVerificationFlowWithLinkMethod](docs/KratosCompleteSelfServiceVerificationFlowWithLinkMethod.md)
 - [Model.KratosCreateIdentity](docs/KratosCreateIdentity.md)
 - [Model.KratosCreateRecoveryLink](docs/KratosCreateRecoveryLink.md)
 - [Model.KratosErrorContainer](docs/KratosErrorContainer.md)
 - [Model.KratosFormField](docs/KratosFormField.md)
 - [Model.KratosGenericError](docs/KratosGenericError.md)
 - [Model.KratosGenericErrorPayload](docs/KratosGenericErrorPayload.md)
 - [Model.KratosHealthNotReadyStatus](docs/KratosHealthNotReadyStatus.md)
 - [Model.KratosHealthStatus](docs/KratosHealthStatus.md)
 - [Model.KratosIdentity](docs/KratosIdentity.md)
 - [Model.KratosLoginFlow](docs/KratosLoginFlow.md)
 - [Model.KratosLoginFlowMethod](docs/KratosLoginFlowMethod.md)
 - [Model.KratosLoginFlowMethodConfig](docs/KratosLoginFlowMethodConfig.md)
 - [Model.KratosLoginViaApiResponse](docs/KratosLoginViaApiResponse.md)
 - [Model.KratosMessage](docs/KratosMessage.md)
 - [Model.KratosRecoveryAddress](docs/KratosRecoveryAddress.md)
 - [Model.KratosRecoveryFlow](docs/KratosRecoveryFlow.md)
 - [Model.KratosRecoveryFlowMethod](docs/KratosRecoveryFlowMethod.md)
 - [Model.KratosRecoveryFlowMethodConfig](docs/KratosRecoveryFlowMethodConfig.md)
 - [Model.KratosRecoveryLink](docs/KratosRecoveryLink.md)
 - [Model.KratosRegistrationFlow](docs/KratosRegistrationFlow.md)
 - [Model.KratosRegistrationFlowMethod](docs/KratosRegistrationFlowMethod.md)
 - [Model.KratosRegistrationFlowMethodConfig](docs/KratosRegistrationFlowMethodConfig.md)
 - [Model.KratosRegistrationViaApiResponse](docs/KratosRegistrationViaApiResponse.md)
 - [Model.KratosRevokeSession](docs/KratosRevokeSession.md)
 - [Model.KratosSession](docs/KratosSession.md)
 - [Model.KratosSettingsFlow](docs/KratosSettingsFlow.md)
 - [Model.KratosSettingsFlowMethod](docs/KratosSettingsFlowMethod.md)
 - [Model.KratosSettingsFlowMethodConfig](docs/KratosSettingsFlowMethodConfig.md)
 - [Model.KratosSettingsViaApiResponse](docs/KratosSettingsViaApiResponse.md)
 - [Model.KratosUpdateIdentity](docs/KratosUpdateIdentity.md)
 - [Model.KratosVerifiableAddress](docs/KratosVerifiableAddress.md)
 - [Model.KratosVerificationFlow](docs/KratosVerificationFlow.md)
 - [Model.KratosVerificationFlowMethod](docs/KratosVerificationFlowMethod.md)
 - [Model.KratosVerificationFlowMethodConfig](docs/KratosVerificationFlowMethodConfig.md)
 - [Model.KratosVersion](docs/KratosVersion.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="sessionToken"></a>
### sessionToken

- **Type**: API key
- **API key parameter name**: X-Session-Token
- **Location**: HTTP header

