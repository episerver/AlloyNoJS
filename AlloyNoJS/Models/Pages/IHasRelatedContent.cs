using EPiServer.Core;

namespace AlloyNoJS.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
