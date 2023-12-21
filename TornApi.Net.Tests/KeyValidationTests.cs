using TornApi.Net.REST;
using TornApi.Net.Models.Key;

namespace TornApi.Net.Tests {
    public class KeyValidationTests {
        [SetUp]
        public void Setup () {

        }

        [Test]
        public async Task ValidKeyIsValid () {
            var key = "fJ5VhgSCO3nIvYRd";
            var apiUrl = @"https://api.torn.com/user/";
            var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, apiUrl);
            var accessLevel = AccessLevel.PublicOnly;

            var actual = await client.ValidateKeyAsync (key, accessLevel);

            Assert.IsTrue(actual.IsKeyUsable);
        }

        [Test]
        public async Task InvalidKeyIsInvalid () {
            var key = "fJ5VhgSCO3nIvYRda";
            var apiUrl = @"https://api.torn.com/user/";
            var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, apiUrl);
            var accessLevel = AccessLevel.PublicOnly;

            var actual = await client.ValidateKeyAsync (key, accessLevel);

            Assert.IsFalse (actual.IsKeyUsable);
        }

        [Test]
        public async Task KeyHasRequiredAccessLevel () {
            var key = "fJ5VhgSCO3nIvYRd";
            var apiUrl = @"https://api.torn.com/user/";
            var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, apiUrl);
            var accessLevel = AccessLevel.FullAccess;

            var actual = await client.ValidateKeyAsync (key, accessLevel);

            Assert.IsTrue (actual.HasRequiredAccessLevel);
        }

        [Test]
        public async Task KeyDoesntHaveRequiredAccessLevel () {
            var key = "qZl2qF9VlWmS9e6W";
            var apiUrl = @"https://api.torn.com/user/";
            var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, apiUrl);
            var accessLevel = AccessLevel.FullAccess;

            var actual = await client.ValidateKeyAsync (key, accessLevel);

            Assert.IsFalse (actual.HasRequiredAccessLevel);
        }
    }
}