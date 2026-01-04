{
  "feature": {
    "id": "cosmosdb.azure"
  },
  "requirements": [
    "vsWebWorkload"
  ],
  "editSteps": [
    "PickInstance",
    "RemoteConnection",
    "DependencySummary"
  ],
  "secretStores": [
    "secrets.user",
    "secrets.keyVault",
    "none"
  ],
  "properties": {
    "connectionId": {
      "value": "ConnectionStrings:CosmosDBConnection"
    }
  },
  "persistencePreprocessors": [
    "SecretStoreResourceId"
  ],
  "persistenceProperties": {
    "connectionId": {
      "isBase": true
    },
    "dynamicId": {
      "isBase": true
    },
    "ignored": {
      "isBase": true
    },
    "resourceId": {
      "parametrizer": "resourceId"
    },
    "secretStore": {},
    "serviceConnectorResourceId": {
      "parametrizer": "resourceId",
      "parametrizerArguments": "resourceGroupName=serviceConnectorResourceGr