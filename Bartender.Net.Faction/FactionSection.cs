using Bartender.Net.Faction.Applications;
using Bartender.Net.Faction.Armor;
using Bartender.Net.Faction.ArmoryNews;
using Bartender.Net.Faction.AttackNews;
using Bartender.Net.Faction.Attacks;
using Bartender.Net.Faction.AttacksFull;
using Bartender.Net.Faction.Basic;
using Bartender.Net.Faction.Boosters;
using Bartender.Net.Faction.Caches;
using Bartender.Net.Faction.Chain;
using Bartender.Net.Faction.ChainReport;
using Bartender.Net.Faction.Chains;
using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Faction.Contributors;
using Bartender.Net.Faction.CrimeExp;
using Bartender.Net.Faction.CrimeNews;
using Bartender.Net.Faction.Crimes;
using Bartender.Net.Faction.Currency;
using Bartender.Net.Faction.Donations;
using Bartender.Net.Faction.Drugs;
using Bartender.Net.Faction.FundsNews;
using Bartender.Net.Faction.MainNews;
using Bartender.Net.Faction.Medical;
using Bartender.Net.Faction.MembershipNews;
using Bartender.Net.Faction.Positions;
using Bartender.Net.Faction.RankedWars;
using Bartender.Net.Faction.Reports;
using Bartender.Net.Faction.Revives;
using Bartender.Net.Faction.RevivesFull;
using Bartender.Net.Faction.Stats;
using Bartender.Net.Faction.Temporary;
using Bartender.Net.Faction.Territory;
using Bartender.Net.Faction.TerritoryNews;
using Bartender.Net.Faction.Upgrades;
using Bartender.Net.Faction.Weapons;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Common.Reports;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.RevivesFull;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Faction;

public class FactionSection : Section {
    private static FactionSection _instance = default!;

    private readonly static object _lock = new ();

    public static FactionSection Instance {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new FactionSection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection Applications;
    public readonly Selection Armor;
    public readonly Selection ArmoryNews;
    public readonly Selection AttackNews;
    public readonly Selection Attacks;
    public readonly Selection AttacksFull;
    public readonly Selection Basic;
    public readonly Selection Boosters;
    public readonly Selection Caches;
    public readonly Selection Chain;
    public readonly Selection ChainReport;
    public readonly Selection Chains;
    public readonly Selection Contributors;
    public readonly Selection CrimeExp;
    public readonly Selection CrimeNews;
    public readonly Selection Crimes;
    public readonly Selection Currency;
    public readonly Selection Donations;
    public readonly Selection Drugs;
    public readonly Selection FundsNews;
    public readonly Selection MainNews;
    public readonly Selection Medical;
    public readonly Selection MembershipNews;
    public readonly Selection Positions;
    public readonly Selection RankedWars;
    public readonly Selection Reports;
    public readonly Selection Revives;
    public readonly Selection RevivesFull;
    public readonly Selection Stats;
    public readonly Selection Temporary;
    public readonly Selection Territory;
    public readonly Selection TerritoryNews;
    public readonly Selection Upgrades;
    public readonly Selection Weapons;

    public override IEnumerable<Selection> Selections {
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
            yield return Upgrades;
            yield return Weapons;
        }
    }

    private FactionSection () : base ("faction") {
        Applications = new (this, "applications", AccessLevel.Limited, typeof (FactionApplicationsRoot), typeof (FactionApplication));
        Armor = new (this, "armor", AccessLevel.Minimal, typeof (ArmorRoot), typeof (FactionLoanable));
        ArmoryNews = new (this, "armorynews", AccessLevel.Minimal, typeof (ArmoryNewsRoot), typeof (NewsEntry));
        AttackNews = new (this, "attacknews", AccessLevel.Limited, typeof (FactionAttackNewsRoot), typeof (NewsEntry));
        Attacks = new (this, "attacks", AccessLevel.Limited, typeof (FactionAttacksRoot), typeof (FactionAttack));
        AttacksFull = new (this, "attacksfull", AccessLevel.Limited, typeof (FactionAttacksFullRoot), typeof (FactionAttackFull));
        Basic = new (this, "basic", AccessLevel.Public, typeof (FactionBasic), typeof (FactionBasic));
        Boosters = new (this, "boosters", AccessLevel.Minimal, typeof (BoostersRoot), typeof (FactionArmoryItem));
        Caches = new (this, "caches", AccessLevel.Limited, typeof (CachesRoot), typeof (FactionArmoryItem));
        Chain = new (this, "chain", AccessLevel.Public, typeof (ChainRoot), typeof (CurrentChain));
        ChainReport = new (this, "chainreport", AccessLevel.Public, typeof (ChainReportRoot), typeof (FactionChainReport));
        Chains = new (this, "chains", AccessLevel.Minimal, typeof (ChainsRoot), typeof (FactionChain));
        Contributors = new (this, "contributors", AccessLevel.Limited, typeof (ContributorsRoot), typeof (StatContributors));
        CrimeExp = new (this, "crimeexp", AccessLevel.Minimal, typeof (CrimeExpRoot), typeof (CrimeExpRoot));
        CrimeNews = new (this, "crimenews", AccessLevel.Minimal, typeof (CrimeNewsRoot), typeof (NewsEntry));
        Crimes = new (this, "crimes", AccessLevel.Minimal, typeof (FactionCrimesRoot), typeof (FactionCrime));
        Currency = new (this, "currency", AccessLevel.Limited, typeof (CurrencyRoot), typeof (CurrencyRoot));
        Donations = new (this, "donations", AccessLevel.Limited, typeof (DonationsRoot), typeof (DonationEntry));
        Drugs = new (this, "drugs", AccessLevel.Minimal, typeof (DrugsRoot), typeof (FactionArmoryItem));
        FundsNews = new (this, "fundsnews", AccessLevel.Limited, typeof (FundsNewsRoot), typeof (NewsEntry));
        MainNews = new (this, "mainnews", AccessLevel.Minimal, typeof (MainNewsRoot), typeof (NewsEntry));
        Medical = new (this, "medical", AccessLevel.Minimal, typeof (MedicalRoot), typeof (FactionArmoryItem));
        MembershipNews = new (this, "membershipnews", AccessLevel.Minimal, typeof (MembershipNewsRoot), typeof (NewsEntry));
        Positions = new (this, "positions", AccessLevel.Minimal, typeof (PositionsRoot), typeof (FactionPosition));
        RankedWars = new (this, "rankedwars", AccessLevel.Public, typeof (RankedWarsRoot), typeof (RankedWarEntry));
        Reports = new (this, "reports", AccessLevel.Limited, typeof (FactionReportsRoot), typeof (Report));
        Revives = new (this, "revives", AccessLevel.Minimal, typeof (FactionRevivesRoot), typeof (Revive));
        RevivesFull = new (this, "revivesfull", AccessLevel.Minimal, typeof (FactionReviveFullRoot), typeof (ReviveFull));
        Stats = new (this, "stats", AccessLevel.Minimal, typeof (StatsRoot), typeof (StatsEntry));
        Temporary = new (this, "temporary", AccessLevel.Minimal, typeof (TemporaryRoot), typeof (FactionLoanable));
        Territory = new (this, "territory", AccessLevel.Public, typeof (TerritoryRoot), typeof (FactionTerritory));
        TerritoryNews = new (this, "territorynews", AccessLevel.Minimal, typeof (TerritoryNewsRoot), typeof (NewsEntry));
        Upgrades = new (this, "upgrades", AccessLevel.Minimal, typeof (FactionUpgradesRoot), typeof (FactionUpgradesRoot));
        Weapons = new (this, "weapons", AccessLevel.Minimal, typeof (WeaponsRoot), typeof (FactionLoanable));
    }
}
