using UI.Api;

namespace UI
{
    public sealed partial class App
    {
        public App()
        {
            ApiClient.Init("http://localhost:49698/api/students");
        }
    }
}
