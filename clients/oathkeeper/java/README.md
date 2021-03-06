# hydra-client

ORY Oathkeeper
- API version: v0.0.0-alpha.1
  - Build date: 2020-01-06T12:26:57.595218+01:00[Europe/Berlin]

ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.

  For more information, please visit [https://www.ory.am](https://www.ory.am)

*Automatically generated by the [OpenAPI Generator](https://openapi-generator.tech)*


## Requirements

Building the API client library requires:
1. Java 1.7+
2. Maven/Gradle

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn clean install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn clean deploy
```

Refer to the [OSSRH Guide](http://central.sonatype.org/pages/ossrh-guide.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
  <groupId>sh.ory.oathkeeper</groupId>
  <artifactId>hydra-client</artifactId>
  <version>v0.0.0-alpha.1</version>
  <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "sh.ory.oathkeeper:hydra-client:v0.0.0-alpha.1"
```

### Others

At first generate the JAR by executing:

```shell
mvn clean package
```

Then manually install the following JARs:

* `target/hydra-client-v0.0.0-alpha.1.jar`
* `target/lib/*.jar`

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

// Import classes:
import sh.ory.oathkeeper.ApiClient;
import sh.ory.oathkeeper.ApiException;
import sh.ory.oathkeeper.Configuration;
import sh.ory.oathkeeper.models.*;
import sh.ory.oathkeeper.api.ApiApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");

    ApiApi apiInstance = new ApiApi(defaultClient);
    try {
      apiInstance.decisions();
    } catch (ApiException e) {
      System.err.println("Exception when calling ApiApi#decisions");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiApi* | [**decisions**](docs/ApiApi.md#decisions) | **GET** /decisions | Access Control Decision API
*ApiApi* | [**getRule**](docs/ApiApi.md#getRule) | **GET** /rules/{id} | Retrieve a rule
*ApiApi* | [**getVersion**](docs/ApiApi.md#getVersion) | **GET** /version | Get service version
*ApiApi* | [**getWellKnownJSONWebKeys**](docs/ApiApi.md#getWellKnownJSONWebKeys) | **GET** /.well-known/jwks.json | Lists cryptographic keys
*ApiApi* | [**isInstanceAlive**](docs/ApiApi.md#isInstanceAlive) | **GET** /health/alive | Check alive status
*ApiApi* | [**isInstanceReady**](docs/ApiApi.md#isInstanceReady) | **GET** /health/ready | Check readiness status
*ApiApi* | [**listRules**](docs/ApiApi.md#listRules) | **GET** /rules | List all rules


## Documentation for Models

 - [CreateRuleCreated](docs/CreateRuleCreated.md)
 - [CreateRuleForbidden](docs/CreateRuleForbidden.md)
 - [CreateRuleForbiddenBody](docs/CreateRuleForbiddenBody.md)
 - [CreateRuleInternalServerError](docs/CreateRuleInternalServerError.md)
 - [CreateRuleInternalServerErrorBody](docs/CreateRuleInternalServerErrorBody.md)
 - [CreateRuleUnauthorized](docs/CreateRuleUnauthorized.md)
 - [CreateRuleUnauthorizedBody](docs/CreateRuleUnauthorizedBody.md)
 - [DecisionsForbidden](docs/DecisionsForbidden.md)
 - [DecisionsForbiddenBody](docs/DecisionsForbiddenBody.md)
 - [DecisionsInternalServerError](docs/DecisionsInternalServerError.md)
 - [DecisionsInternalServerErrorBody](docs/DecisionsInternalServerErrorBody.md)
 - [DecisionsNotFound](docs/DecisionsNotFound.md)
 - [DecisionsNotFoundBody](docs/DecisionsNotFoundBody.md)
 - [DecisionsUnauthorized](docs/DecisionsUnauthorized.md)
 - [DecisionsUnauthorizedBody](docs/DecisionsUnauthorizedBody.md)
 - [DeleteRuleForbidden](docs/DeleteRuleForbidden.md)
 - [DeleteRuleForbiddenBody](docs/DeleteRuleForbiddenBody.md)
 - [DeleteRuleInternalServerError](docs/DeleteRuleInternalServerError.md)
 - [DeleteRuleInternalServerErrorBody](docs/DeleteRuleInternalServerErrorBody.md)
 - [DeleteRuleNotFound](docs/DeleteRuleNotFound.md)
 - [DeleteRuleNotFoundBody](docs/DeleteRuleNotFoundBody.md)
 - [DeleteRuleUnauthorized](docs/DeleteRuleUnauthorized.md)
 - [DeleteRuleUnauthorizedBody](docs/DeleteRuleUnauthorizedBody.md)
 - [GetRuleForbidden](docs/GetRuleForbidden.md)
 - [GetRuleForbiddenBody](docs/GetRuleForbiddenBody.md)
 - [GetRuleInternalServerError](docs/GetRuleInternalServerError.md)
 - [GetRuleInternalServerErrorBody](docs/GetRuleInternalServerErrorBody.md)
 - [GetRuleNotFound](docs/GetRuleNotFound.md)
 - [GetRuleNotFoundBody](docs/GetRuleNotFoundBody.md)
 - [GetRuleOK](docs/GetRuleOK.md)
 - [GetRuleUnauthorized](docs/GetRuleUnauthorized.md)
 - [GetRuleUnauthorizedBody](docs/GetRuleUnauthorizedBody.md)
 - [GetWellKnownForbidden](docs/GetWellKnownForbidden.md)
 - [GetWellKnownForbiddenBody](docs/GetWellKnownForbiddenBody.md)
 - [GetWellKnownJSONWebKeysInternalServerError](docs/GetWellKnownJSONWebKeysInternalServerError.md)
 - [GetWellKnownJSONWebKeysInternalServerErrorBody](docs/GetWellKnownJSONWebKeysInternalServerErrorBody.md)
 - [GetWellKnownJSONWebKeysOK](docs/GetWellKnownJSONWebKeysOK.md)
 - [GetWellKnownOK](docs/GetWellKnownOK.md)
 - [GetWellKnownUnauthorized](docs/GetWellKnownUnauthorized.md)
 - [GetWellKnownUnauthorizedBody](docs/GetWellKnownUnauthorizedBody.md)
 - [HealthNotReadyStatus](docs/HealthNotReadyStatus.md)
 - [HealthStatus](docs/HealthStatus.md)
 - [InlineResponse500](docs/InlineResponse500.md)
 - [IsInstanceAliveInternalServerError](docs/IsInstanceAliveInternalServerError.md)
 - [IsInstanceAliveInternalServerErrorBody](docs/IsInstanceAliveInternalServerErrorBody.md)
 - [IsInstanceAliveOK](docs/IsInstanceAliveOK.md)
 - [JsonWebKey](docs/JsonWebKey.md)
 - [JsonWebKeySet](docs/JsonWebKeySet.md)
 - [JudgeForbidden](docs/JudgeForbidden.md)
 - [JudgeForbiddenBody](docs/JudgeForbiddenBody.md)
 - [JudgeInternalServerError](docs/JudgeInternalServerError.md)
 - [JudgeInternalServerErrorBody](docs/JudgeInternalServerErrorBody.md)
 - [JudgeNotFound](docs/JudgeNotFound.md)
 - [JudgeNotFoundBody](docs/JudgeNotFoundBody.md)
 - [JudgeUnauthorized](docs/JudgeUnauthorized.md)
 - [JudgeUnauthorizedBody](docs/JudgeUnauthorizedBody.md)
 - [ListRulesForbidden](docs/ListRulesForbidden.md)
 - [ListRulesForbiddenBody](docs/ListRulesForbiddenBody.md)
 - [ListRulesInternalServerError](docs/ListRulesInternalServerError.md)
 - [ListRulesInternalServerErrorBody](docs/ListRulesInternalServerErrorBody.md)
 - [ListRulesOK](docs/ListRulesOK.md)
 - [ListRulesUnauthorized](docs/ListRulesUnauthorized.md)
 - [ListRulesUnauthorizedBody](docs/ListRulesUnauthorizedBody.md)
 - [Rule](docs/Rule.md)
 - [RuleHandler](docs/RuleHandler.md)
 - [RuleMatch](docs/RuleMatch.md)
 - [SwaggerCreateRuleParameters](docs/SwaggerCreateRuleParameters.md)
 - [SwaggerGetRuleParameters](docs/SwaggerGetRuleParameters.md)
 - [SwaggerHealthStatus](docs/SwaggerHealthStatus.md)
 - [SwaggerJSONWebKey](docs/SwaggerJSONWebKey.md)
 - [SwaggerJSONWebKeySet](docs/SwaggerJSONWebKeySet.md)
 - [SwaggerListRulesParameters](docs/SwaggerListRulesParameters.md)
 - [SwaggerNotReadyStatus](docs/SwaggerNotReadyStatus.md)
 - [SwaggerRule](docs/SwaggerRule.md)
 - [SwaggerRuleHandler](docs/SwaggerRuleHandler.md)
 - [SwaggerRuleMatch](docs/SwaggerRuleMatch.md)
 - [SwaggerRuleResponse](docs/SwaggerRuleResponse.md)
 - [SwaggerRulesResponse](docs/SwaggerRulesResponse.md)
 - [SwaggerUpdateRuleParameters](docs/SwaggerUpdateRuleParameters.md)
 - [SwaggerVersion](docs/SwaggerVersion.md)
 - [UpdateRuleForbidden](docs/UpdateRuleForbidden.md)
 - [UpdateRuleForbiddenBody](docs/UpdateRuleForbiddenBody.md)
 - [UpdateRuleInternalServerError](docs/UpdateRuleInternalServerError.md)
 - [UpdateRuleInternalServerErrorBody](docs/UpdateRuleInternalServerErrorBody.md)
 - [UpdateRuleNotFound](docs/UpdateRuleNotFound.md)
 - [UpdateRuleNotFoundBody](docs/UpdateRuleNotFoundBody.md)
 - [UpdateRuleOK](docs/UpdateRuleOK.md)
 - [UpdateRuleUnauthorized](docs/UpdateRuleUnauthorized.md)
 - [UpdateRuleUnauthorizedBody](docs/UpdateRuleUnauthorizedBody.md)
 - [Upstream](docs/Upstream.md)
 - [Version](docs/Version.md)


## Documentation for Authorization

All endpoints do not require authorization.
Authentication schemes defined for the API:

## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

hi@ory.am

