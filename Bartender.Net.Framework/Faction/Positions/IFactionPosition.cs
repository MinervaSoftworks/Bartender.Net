namespace Bartender.Net.Framework.Faction.Positions;

public interface IFactionPosition : IBartenderEntity {
    int CanAccessFactionApi { get; set; }
    int CanAdjustMemberBalance { get; set; }
    int CanChangeAnnouncement { get; set; }
    int CanChangeDescription { get; set; }
    int CanGiveItem { get; set; }
    int CanGiveMoney { get; set; }
    int CanGivePoints { get; set; }
    int CanKickMembers { get; set; }
    int CanLoanTemporaryItem { get; set; }
    int CanLoanWeaponAndArmory { get; set; }
    int CanManageApplications { get; set; }
    int CanManageForum { get; set; }
    int CanManageUpgrades { get; set; }
    int CanManageWars { get; set; }
    int CanPlanAndInitiateOrganisedCrime { get; set; }
    int CanRetrieveLoanedArmory { get; set; }
    int CanSendNewsletter { get; set; }
    int CanUseBoosterItem { get; set; }
    int CanUseDrugItem { get; set; }
    int CanUseEnergyRefill { get; set; }
    int CanUseMedicalItem { get; set; }
    int CanUseNerveRefill { get; set; }
    int Default { get; set; }
    string Name { get; set; }
}
