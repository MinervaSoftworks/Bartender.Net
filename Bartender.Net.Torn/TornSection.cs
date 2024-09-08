using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Section;

namespace Bartender.Net.Torn;
public class TornSection : ISection {
    public string Name => "torn";

    public static readonly Selection Bank = new ("bank", AccessLevel.Public, typeof (object));
    public static readonly Selection Cards = new ("cards", AccessLevel.Public, typeof (object));
    public static readonly Selection ChainReport = new ("chainreport", AccessLevel.Public, typeof (object));
    public static readonly Selection CityShops = new ("cityshops", AccessLevel.Public, typeof (object));
    public static readonly Selection Companies = new ("companies", AccessLevel.Public, typeof (object));
    public static readonly Selection Competition = new ("competition", AccessLevel.Public, typeof (object));
    public static readonly Selection DirtyBombs = new ("dirtybombs", AccessLevel.Public, typeof (object));
    public static readonly Selection Education = new ("education", AccessLevel.Public, typeof (object));
    public static readonly Selection FactionTree = new ("factiontree", AccessLevel.Public, typeof (object));
    public static readonly Selection Gyms = new ("gyms", AccessLevel.Public, typeof (object));
    public static readonly Selection Honors = new ("honors", AccessLevel.Public, typeof (object));
    public static readonly Selection ItemDetails = new ("itemdetails", AccessLevel.Public, typeof (object));
    public static readonly Selection Items = new ("items", AccessLevel.Public, typeof (object));
    public static readonly Selection ItemStats = new ("itemstats", AccessLevel.Public, typeof (object));
    public static readonly Selection LogCategories = new ("logcategories", AccessLevel.Public, typeof (object));
    public static readonly Selection LogTypes = new ("logtypes", AccessLevel.Public, typeof (object));
    public static readonly Selection Medals = new ("medals", AccessLevel.Public, typeof (object));
    public static readonly Selection OrganisedCrimes = new ("organisedcrimes", AccessLevel.Public, typeof (object));
    public static readonly Selection PawnShop = new ("pawnshop", AccessLevel.Public, typeof (object));
    public static readonly Selection PokerTables = new ("pokertables", AccessLevel.Public, typeof (object));
    public static readonly Selection Properties = new ("properties", AccessLevel.Public, typeof (object));
    public static readonly Selection Rackets = new ("rackets", AccessLevel.Public, typeof (object));
    public static readonly Selection RaidReport = new ("raidreport", AccessLevel.Public, typeof (object));
    public static readonly Selection Raids = new ("raids", AccessLevel.Public, typeof (object));
    public static readonly Selection RankedWarReport = new ("rankedwarreport", AccessLevel.Public, typeof (object));
    public static readonly Selection RankedWars = new ("rankedwars", AccessLevel.Public, typeof (object));
    public static readonly Selection RockPaperScissors = new ("rockpaperscissors", AccessLevel.Public, typeof (object));
    public static readonly Selection SearchForCash = new ("searchforcash", AccessLevel.Public, typeof (object));
    public static readonly Selection Shoplifting = new ("shoplifting", AccessLevel.Public, typeof (object));
    public static readonly Selection Stats = new ("stats", AccessLevel.Public, typeof (object));
    public static readonly Selection Stocks = new ("stocks", AccessLevel.Public, typeof (object));
    public static readonly Selection Territory = new ("territory", AccessLevel.Public, typeof (object));
    public static readonly Selection TerritoryNames = new ("territorynames", AccessLevel.Public, typeof (object));
    public static readonly Selection TerritoryWarReport = new ("territorywarreport", AccessLevel.Public, typeof (object));
    public static readonly Selection TerritoryWars = new ("territorywars", AccessLevel.Public, typeof (object));

    public IEnumerable<Selection> Selections {
        get {
            yield return Bank;
            yield return Cards;
            yield return ChainReport;
            yield return CityShops;
            yield return Companies;
            yield return Competition;
            yield return DirtyBombs;
            yield return Education;
            yield return FactionTree;
            yield return Gyms;
            yield return Honors;
            yield return ItemDetails;
            yield return Items;
            yield return ItemStats;
            yield return LogCategories;
            yield return LogTypes;
            yield return Medals;
            yield return OrganisedCrimes;
            yield return PawnShop;
            yield return PokerTables;
            yield return Properties;
            yield return Rackets;
            yield return RaidReport;
            yield return Raids;
            yield return RankedWarReport;
            yield return RankedWars;
            yield return RockPaperScissors;
            yield return SearchForCash;
            yield return Shoplifting;
            yield return Stats;
            yield return Stocks;
            yield return Territory;
            yield return TerritoryNames;
            yield return TerritoryWarReport;
            yield return TerritoryWars;
        }
    }
}
