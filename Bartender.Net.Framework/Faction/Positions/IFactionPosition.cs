namespace Bartender.Net.Framework.Faction.Positions;

public interface IFactionPosition : IBartenderEntity {
    int CanAccessFactionApi { get; }
    int CanAdjustMemberBalance { get; }
    int CanChangeAnnouncement { get; }
    int CanChangeDescription { get; }
    int CanGiveItem { get; }
    int CanGiveMoney { get; }
    int CanGivePoints { get; }
    int CanKickMembers { get; }
    int CanLoanTemporaryItem { get; }
    int CanLoanWeaponAndArmory { get; }
    int CanManageApplications { get; }
    int CanManageForum { get; }
    int CanManageUpgrades { get; }
    int CanManageWars { get; }
    int CanPlanAndInitiateOrganisedCrime { get; }
    int CanRetrieveLoanedArmory { get; }
    int CanSendNewsletter { get; }
    int CanUseBoosterItem { get; }
    int CanUseDrugItem { get; }
    int CanUseEnergyRefill { get; }
    int CanUseMedicalItem { get; }
    int CanUseNerveRefill { get; }
    int Default { get; }
    string Name { get; }
}
