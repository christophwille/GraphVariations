using Riok.Mapperly.Abstractions;

namespace GraphSdkSamples
{
    [Mapper]
    public partial class GraphUserToUserModelMapper
    {
        public partial GraphVariations.Common.RestModels.User UserToUserDto(Microsoft.Graph.Models.User user);
    }
}
