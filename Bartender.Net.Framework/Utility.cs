namespace Bartender.Net.Framework;

public static class Utility {
    public static List<T> TornDictionaryToList<T> (this Dictionary<string, T> dict) where T : BartenderEntity {
        var entities = new List<T> ();

        foreach (var entity in dict) {
            entity.Value.ID = int.Parse (entity.Key);

            entities.Add (entity.Value);
        }

        return entities;
    }

    public static Dictionary<string, T> ToTornDictionary<T> (this List<T> list) where T : BartenderEntity {
        var dict = new Dictionary<string, T> ();

        foreach (var application in list) {
            dict.Add (application.ID.ToString (), application);
        }

        return dict;
    }
}
