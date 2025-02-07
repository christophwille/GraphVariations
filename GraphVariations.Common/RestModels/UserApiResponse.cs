using System.Text.Json.Serialization;

namespace GraphVariations.Common.RestModels
{
    public class UserApiResponse
    {
        [JsonPropertyName("@odata.context")]
        public string OdataContext { get; set; }

        [JsonPropertyName("@odata.deltaLink")]
        public string DeltaLink { get; set; }
        [JsonPropertyName("@odata.nextLink")]
        public string NextLink { get; set; }
        [JsonPropertyName("value")]
        public List<User> Value { get; set; }
    }
}
