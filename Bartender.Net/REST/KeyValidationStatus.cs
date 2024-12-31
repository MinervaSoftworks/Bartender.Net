using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST {
    public class KeyValidationStatus : IKeyValidationStatus {
        public IApiResponse? Result { get; set; }

        public bool IsValid { get; set; } = false;

        public bool HasRequiredAccessLevel { get; set; } = false;

        public bool IsUsable => IsValid && HasRequiredAccessLevel;
    }
}
