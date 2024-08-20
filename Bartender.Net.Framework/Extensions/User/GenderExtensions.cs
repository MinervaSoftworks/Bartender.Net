using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Extensions.User;

public static class GenderExtensions {
    public static string ToGenderString (this Gender type) => type switch {
        Gender.Enby => "Enby",
        Gender.Female => "Female",
        Gender.Male => "Male",
        _ => throw new Exception ("Unknown gender")
    };
}
