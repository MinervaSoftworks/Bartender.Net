using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Section;

namespace Bartender.Net.Faction;
public class FactionSection : ISection {
    public string Name => "faction";

    public static readonly Selection Applications = new ("applications", AccessLevel.Limited, typeof (object));
    public static readonly Selection Armor = new ("armor", AccessLevel.Minimal, typeof (object));
    public static readonly Selection ArmoryNews = new ("armorynews", AccessLevel.Minimal, typeof (object));
    public static readonly Selection AttackNews = new ("attacknews", AccessLevel.Limited, typeof (object));
    public static readonly Selection Attacks = new ("attacks", AccessLevel.Limited, typeof (object));
    public static readonly Selection AttacksFull = new ("attacksfull", AccessLevel.Limited, typeof (object));
    public static readonly Selection Basic = new ("basic", AccessLevel.Public, typeof (object));
    public static readonly Selection Boosters = new ("boosters", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Caches = new ("caches", AccessLevel.Limited, typeof (object));
    public static readonly Selection Cesium = new ("cesium", AccessLevel.Limited, typeof (object));
    public static readonly Selection Chain = new ("chain", AccessLevel.Public, typeof (object));
    public static readonly Selection ChainReport = new ("chainreport", AccessLevel.Public, typeof (object));
    public static readonly Selection Chains = new ("chains", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Contributors = new ("contributors", AccessLevel.Limited, typeof (object));
    public static readonly Selection CrimeExp = new ("crimeexp", AccessLevel.Minimal, typeof (object));
    public static readonly Selection CrimeNews = new ("crimenews", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Crimes = new ("crimes", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Currency = new ("currency", AccessLevel.Limited, typeof (object));
    public static readonly Selection Donations = new ("donations", AccessLevel.Limited, typeof (object));
    public static readonly Selection Drugs = new ("drugs", AccessLevel.Minimal, typeof (object));
    public static readonly Selection FundsNews = new ("fundsnews", AccessLevel.Limited, typeof (object));
    public static readonly Selection Lookup = new ("lookup", AccessLevel.Public, typeof (object));
    public static readonly Selection MainNews = new ("mainnews", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Medical = new ("medical", AccessLevel.Minimal, typeof (object));
    public static readonly Selection MembershipNews = new ("membershipnews", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Positions = new ("positions", AccessLevel.Minimal, typeof (object));
    public static readonly Selection RankedWars = new ("rankedwars", AccessLevel.Public, typeof (object));
    public static readonly Selection Reports = new ("reports", AccessLevel.Limited, typeof (object));
    public static readonly Selection Revives = new ("revives", AccessLevel.Minimal, typeof (object));
    public static readonly Selection RevivesFull = new ("revivesfull", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Stats = new ("stats", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Temporary = new ("temporary", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Territory = new ("territory", AccessLevel.Public, typeof (object));
    public static readonly Selection TerritoryNews = new ("territorynews", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Timestamp = new ("timestamp", AccessLevel.Public, typeof (object));
    public static readonly Selection Upgrades = new ("upgrades", AccessLevel.Minimal, typeof (object));
    public static readonly Selection Weapons = new ("weapons", AccessLevel.Minimal, typeof (object));

    public IEnumerable<Selection> Selections {
        get {
            yield return Applications;
            yield return Armor;
            yield return ArmoryNews;
            yield return AttackNews;
            yield return Attacks;
            yield return AttacksFull;
            yield return Basic;
            yield return Boosters;
            yield return Caches;
            yield return Cesium;
            yield return Chain;
            yield return ChainReport;
            yield return Chains;
            yield return Contributors;
            yield return CrimeExp;
            yield return CrimeNews;
            yield return Crimes;
            yield return Currency;
            yield return Donations;
            yield return Drugs;
            yield return FundsNews;
            yield return Lookup;
            yield return MainNews;
            yield return Medical;
            yield return MembershipNews;
            yield return Positions;
            yield return RankedWars;
            yield return Reports;
            yield return Revives;
            yield return RevivesFull;
            yield return Stats;
            yield return Temporary;
            yield return Territory;
            yield return TerritoryNews;
            yield return Timestamp;
            yield return Upgrades;
            yield return Weapons;
        }
    }
}
