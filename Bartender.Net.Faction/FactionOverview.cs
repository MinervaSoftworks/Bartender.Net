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
using Bartender.Net.Faction.Reports;
using Bartender.Net.Faction.Revives;
using Bartender.Net.Faction.RevivesFull;
using Bartender.Net.Faction.Stats;
using Bartender.Net.Faction.Temporary;
using Bartender.Net.Faction.Territory;
using Bartender.Net.Faction.TerritoryNews;
using Bartender.Net.Faction.Upgrades;
using Bartender.Net.Faction.Weapons;
using Bartender.Net.Framework.Common.Reports;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.RevivesFull;

namespace Bartender.Net.Faction;

public record FactionOverview (ApplicationsRoot? Applications = null,
                               ArmorRoot? Armor = null,
                               ArmoryNewsRoot? ArmoryNews = null,
                               AttackNewsRoot? AttackNews = null,
                               FactionAttacksFullRoot? FactionAttacksFull = null,
                               FactionBasic? FactionBasic = null,
                               BoostersRoot? Boosters = null,
                               CachesRoot? Caches = null,
                               ChainRoot? Chain = null,
                               ChainReportRoot? ChainReport = null,
                               ChainsRoot? Chains = null,
                               ContributorsRoot? Contributors = null,
                               CrimeExpRoot? CrimeExp = null,
                               CrimeNewsRoot? CrimeNews = null,
                               FactionCrimesRoot? Crimes = null,
                               CurrencyRoot? Currency = null,
                               DonationsRoot? Donations = null,
                               DrugsRoot? Drugs = null,
                               FundsNewsRoot? FundsNews = null,
                               MainNewsRoot? MainNews = null,
                               MedicalRoot? Medical = null,
                               MembershipNewsRoot? MembershipNews = null,
                               PositionsRoot? Positions = null,
                               RankedWarsRoot? RankedWars = null,
                               FactionReportsRoot? Reports = null,
                               FactionRevivesRoot? Revives = null,
                               FactionReviveFullRoot? ReviveFull = null,
                               StatsRoot? Stats = null,
                               TemporaryRoot? Temporary = null,
                               TerritoryRoot? Territory = null,
                               TerritoryNewsRoot? TerritoryNews = null,
                               UpgradesRoot? Upgrades = null,
                               WeaponsRoot? Weapons = null);
