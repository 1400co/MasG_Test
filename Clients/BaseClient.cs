using ServiceStack;

namespace Clients
{
    public abstract class BaseClient
    {
        internal JsonServiceClient CreateRestClient(string baseUrl) => new JsonServiceClient(baseUrl);
    }
}
