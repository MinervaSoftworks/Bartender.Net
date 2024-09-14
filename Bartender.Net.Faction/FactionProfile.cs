using Bartender.Net.Faction.Applications;
using Bartender.Net.Faction.Armor;
using Bartender.Net.Faction.ArmoryNews;
using Bartender.Net.Faction.AttackNews;
using Bartender.Net.Faction.AttacksFull;
using Bartender.Net.Faction.Basic;
using Bartender.Net.Faction.Boosters;
using Bartender.Net.Faction.Caches;
using Bartender.Net.Faction.Chain;
using Bartender.Net.Faction.ChainReport;
using Bartender.Net.Faction.Chains;
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
using Bartender.Net.Faction.Stats;
using Bartender.Net.Faction.Temporary;
using Bartender.Net.Faction.Territory;
using Bartender.Net.Faction.TerritoryNews;
using Bartender.Net.Faction.Upgrades;
using Bartender.Net.Faction.Weapons;
using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Reports;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.RevivesFull;

namespace Bartender.Net.Faction;

public class FactionProfile : IBartenderEntity {
    public required int ID { get; set; }

    public required ApplicationsRoot Applications { get; set; }

    public required ArmorRoot Armor { get; set; }

    public required ArmoryNewsRoot ArmoryNews { get; set; }

    public required AttackNewsRoot AttackNews { get; set; }

    public required FactionAttacksFullRoot FactionAttacksFull { get; set; }

    public required FactionBasic FactionBasic { get; set; }

    public required BoostersRoot Boosters { get; set; }

    public required CachesRoot Caches { get; set; }

    public required ChainRoot Chain { get; set; }

    public required ChainReportRoot ChainReport { get; set; }

    public required ChainStubsRoot Chains { get; set; }

    public required ContributorsRoot Contributors { get; set; }

    public required CrimeExpRoot CrimeExp { get; set; }

    public required CrimeNewsRoot CrimeNews { get; set; }

    public required FactionCrimesRoot Crimes { get; set; }

    public required CurrencyRoot Currency { get; set; }

    public required DonationsRoot Donations { get; set; }

    public required DrugsRoot Drugs { get; set; }

    public required FundsNewsRoot FundsNews { get; set; }

    public required MainNewsRoot MainNews { get; set; }

    public required MedicalRoot Medical { get; set; }

    public required MembershipNewsRoot MembershipNews { get; set; }

    public required PositionsRoot Positions { get; set; }

    public required RankedWarsRoot RankedWars { get; set; }

    public required ReportsRoot Reports { get; set; }

    public required RevivesRoot Revives { get; set; }

    public required ReviveFullRoot ReviveFull { get; set; }

    public required StatsRoot Stats { get; set; }

    public required TemporaryRoot Temporary { get; set; }

    public required TerritoryRoot Territory { get; set; }

    public required TerritoryNewsRoot TerritoryNews { get; set; }

    public required UpgradesRoot Upgrades { get; set; }

    public required WeaponsRoot Weapons { get; set; }
}
