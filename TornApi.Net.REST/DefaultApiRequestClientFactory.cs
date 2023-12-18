namespace TornApi.Net.REST {
    public class DefaultApiRequestClientFactory : IHttpClientFactory, IDisposable {
        private static object _instLock = new object ();

        public static DefaultApiRequestClientFactory Instance {
            get {
                if(_instance is null) {
                    lock(_instLock) {
                        if(_instance is null) {
                            _instance = new DefaultApiRequestClientFactory ();
                        }
                    }
                }

                return _instance;
            }
        }

        private DefaultApiRequestClientFactory () { }

        private static DefaultApiRequestClientFactory? _instance;

        private readonly Lazy<HttpMessageHandler> _lazyHandler = new Lazy<HttpMessageHandler> (() => new HttpClientHandler ());

        public HttpClient CreateClient (string name) => new (_lazyHandler.Value, disposeHandler: false);

        public void Dispose () {
            if (_lazyHandler.IsValueCreated) {
                _lazyHandler.Value.Dispose ();
            }
        }
    }
}
