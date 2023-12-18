namespace TornApi.Net.REST {
    public class DefaultSingleRequestClientFactory : IHttpClientFactory, IDisposable {
        private static object _instLock = new object ();

        public static DefaultSingleRequestClientFactory Instance {
            get {
                if(_instance is null) {
                    lock(_instLock) {
                        if(_instance is null) {
                            _instance = new DefaultSingleRequestClientFactory ();
                        }
                    }
                }

                return _instance;
            }
        }

        private DefaultSingleRequestClientFactory () { }

        private static DefaultSingleRequestClientFactory? _instance;

        private readonly Lazy<HttpMessageHandler> _lazyHandler = new Lazy<HttpMessageHandler> (() => new HttpClientHandler ());

        public HttpClient CreateClient (string name) => new (_lazyHandler.Value, disposeHandler: false);

        public void Dispose () {
            if (_lazyHandler.IsValueCreated) {
                _lazyHandler.Value.Dispose ();
            }
        }
    }
}
