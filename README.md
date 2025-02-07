# Graph Variations - Paging with / without SDK / custom SDK

* PageIterator (GraphSdkSamples)
* OdataNextLink (GraphSdkSamples)
* ToGetRequestInformation / RequestAdapter.SendAsync (GraphSdkSamples)
* Custom SDK (see below for generation, GraphCustomSamples)


## Custom SDK

Motivation: not use the backing store when you only read data

https://martin-machacek.com/blogPost/b2634898-a82d-4651-9e51-ed02882ac606

```bash
kiota generate `
--openapi "D:/GitWorkspace/GraphVariations/openapi.yaml" `
--output "D:/GitWorkspace/GraphVariations/NoBackingStore.Graph/Generated" `
--language CSharp `
--class-name UsersClient `
--namespace-name "NoBackingStore.Graph" `
--include-path "/users" `
--include-path "/users/**" 
```