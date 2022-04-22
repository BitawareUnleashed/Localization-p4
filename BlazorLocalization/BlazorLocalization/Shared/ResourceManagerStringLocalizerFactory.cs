using Microsoft.Extensions.Localization;

namespace BlazorLocalization.Shared
{
    internal class ResourceManagerStringLocalizerFactory : IStringLocalizerFactory
    {
        private IStringLocalizerFactory _stringLocalizerFactory;

        public IStringLocalizer Create(Type resourceSource)
        {
            throw new NotImplementedException();
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            throw new NotImplementedException();
        }

        public ResourceManagerStringLocalizerFactory(IStringLocalizerFactory stringLocalizerFactory)
        {
            _stringLocalizerFactory = stringLocalizerFactory;
        }
    }
}