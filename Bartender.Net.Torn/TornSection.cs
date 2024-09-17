//using Bartender.Net.Framework.Key;
//using Bartender.Net.Framework.Sections;

//namespace Bartender.Net.Torn;
//public class TornSection : ISection, IBartenderEntity {
//    public int ID => 6;

//    public string Name => "torn";

//    public static readonly Selection Bank = new ("bank", AccessLevel.Public, typeof(BankRoot));
//    public static readonly Selection Cards = new ("cards", AccessLevel.Public, typeof(CardsRoot));
//    public static readonly Selection ChainReport = new ("chainreport", AccessLevel.Public, typeof(ChainReportRoot));
//    public static readonly Selection CityShops = new ("cityshops", AccessLevel.Public, typeof(CityShopsRoot));
//    public static readonly Selection Companies = new ("companies", AccessLevel.Public, typeof(CompaniesRoot));
//    public static readonly Selection Competition = new ("competition", AccessLevel.Public, typeof(CompetitionRoot));
//    public static readonly Selection DirtyBombs = new ("dirtybombs", AccessLevel.Public, typeof(DirtyBombsRoot));
//    public static readonly Selection Education = new ("education", AccessLevel.Public, typeof(EducationRoot));
//    public static readonly Selection FactionTree = new ("factiontree", AccessLevel.Public, typeof(FactionTreeRoot));
//    public static readonly Selection Gyms = new ("gyms", AccessLevel.Public, typeof(GymsRoot));
//    public static readonly Selection Honors = new ("honors", AccessLevel.Public, typeof(HonorsRoot));
//    public static readonly Selection ItemDetails = new ("itemdetails", AccessLevel.Public, typeof(ItemDetailsRoot));
//    public static readonly Selection Items = new ("items", AccessLevel.Public, typeof(ItemsRoot));
//    public static readonly Selection ItemStats = new ("itemstats", AccessLevel.Public, typeof(ItemStatsRoot));
//    public static readonly Selection LogCategories = new ("logcategories", AccessLevel.Public, typeof(LogCategoriesRoot));
//    public static readonly Selection LogTypes = new ("logtypes", AccessLevel.Public, typeof(LogTypesRoot));
//    public static readonly Selection Medals = new ("medals", AccessLevel.Public, typeof(MedalsRoot));
//    public static readonly Selection OrganisedCrimes = new ("organisedcrimes", AccessLevel.Public, typeof(OrganisedCrimesRoot));
//    public static readonly Selection PawnShop = new ("pawnshop", AccessLevel.Public, typeof(PawnShopRoot));
//    public static readonly Selection PokerTables = new ("pokertables", AccessLevel.Public, typeof(PokerTablesRoot));
//    public static readonly Selection Properties = new ("properties", AccessLevel.Public, typeof(PropertiesRoot));
//    public static readonly Selection Rackets = new ("rackets", AccessLevel.Public, typeof(RacketsRoot));
//    public static readonly Selection RaidReport = new ("raidreport", AccessLevel.Public, typeof(RaidReportRoot));
//    public static readonly Selection Raids = new ("raids", AccessLevel.Public, typeof(RaidsRoot));
//    public static readonly Selection RankedWarReport = new ("rankedwarreport", AccessLevel.Public, typeof(RankedWarReportRoot));
//    public static readonly Selection RankedWars = new ("rankedwars", AccessLevel.Public, typeof(RankedWarsRoot));
//    public static readonly Selection RockPaperScissors = new ("rockpaperscissors", AccessLevel.Public, typeof(RockPaperScissorsRoot));
//    public static readonly Selection SearchForCash = new ("searchforcash", AccessLevel.Public, typeof(SearchForCashRoot));
//    public static readonly Selection Shoplifting = new ("shoplifting", AccessLevel.Public, typeof(ShopliftingRoot));
//    public static readonly Selection Stats = new ("stats", AccessLevel.Public, typeof(StatsRoot));
//    public static readonly Selection Stocks = new ("stocks", AccessLevel.Public, typeof(StocksRoot));
//    public static readonly Selection Territory = new ("territory", AccessLevel.Public, typeof(TerritoryRoot));
//    public static readonly Selection TerritoryNames = new ("territorynames", AccessLevel.Public, typeof(TerritoryNamesRoot));
//    public static readonly Selection TerritoryWarReport = new ("territorywarreport", AccessLevel.Public, typeof(TerritoryWarReportRoot));
//    public static readonly Selection TerritoryWars = new ("territorywars", AccessLevel.Public, typeof(TerritoryWarsRoot));

//    public IEnumerable<Selection> Selections {
//        get {
//            yield return Bank;
//            yield return Cards;
//            yield return ChainReport;
//            yield return CityShops;
//            yield return Companies;
//            yield return Competition;
//            yield return DirtyBombs;
//            yield return Education;
//            yield return FactionTree;
//            yield return Gyms;
//            yield return Honors;
//            yield return ItemDetails;
//            yield return Items;
//            yield return ItemStats;
//            yield return LogCategories;
//            yield return LogTypes;
//            yield return Medals;
//            yield return OrganisedCrimes;
//            yield return PawnShop;
//            yield return PokerTables;
//            yield return Properties;
//            yield return Rackets;
//            yield return RaidReport;
//            yield return Raids;
//            yield return RankedWarReport;
//            yield return RankedWars;
//            yield return RockPaperScissors;
//            yield return SearchForCash;
//            yield return Shoplifting;
//            yield return Stats;
//            yield return Stocks;
//            yield return Territory;
//            yield return TerritoryNames;
//            yield return TerritoryWarReport;
//            yield return TerritoryWars;
//        }
//    }
//}
