# Graph Variations - Paging with / without SDK / custom SDK

* PageIterator as per docs, but generic (GraphSdkSamples-PageViaIteratorAsync)
* OdataNextLink as per docs, but generic (GraphSdkSamples-PageViaOdataLinkAsync)
* ToGetRequestInformation / RequestAdapter.SendAsync (GraphSdkSamples-PageViaRequestInformationAsync)
* ConvertToNativeRequestAsync with custom models to side-step backing store (GraphSdkSamples-PageNativeRequestCustomModelsAsync)
* Custom SDK generated without backing store (see below for generation, GraphCustomSamples-PageCustomSdkAsync)
* Naked REST with custom models and simple REST (GraphCustomSamples-PageNakedRestAsync)
* Simple.OData.Client, just for fun though (GraphCustomSamples-PageSimpleODataClientAsync)

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