using Newtonsoft.Json;

namespace Bartender.Net.Faction.Positions;

public class FactionPosition : IFactionPosition {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public string Name { get; set; }

    [JsonProperty ("default")]
    public int Default { get; set; }

    [JsonProperty ("canUseMedicalItem")]
    public int CanUseMedicalItem { get; set; }

    [JsonProperty ("canUseBoosterItem")]
    public int CanUseBoosterItem { get; set; }

    [JsonProperty ("canUseDrugItem")]
    public int CanUseDrugItem { get; set; }

    [JsonProperty ("canUseEnergyRefill")]
    public int CanUseEnergyRefill { get; set; }

    [JsonProperty ("canUseNerveRefill")]
    public int CanUseNerveRefill { get; set; }

    [JsonProperty ("canLoanTemporaryItem")]
    public int CanLoanTemporaryItem { get; set; }

    [JsonProperty ("canLoanWeaponAndArmory")]
    public int CanLoanWeaponAndArmory { get; set; }

    [JsonProperty ("canRetrieveLoanedArmory")]
    public int CanRetrieveLoanedArmory { get; set; }

    [JsonProperty ("canPlanAndInitiateOrganisedCrime")]
    public int CanPlanAndInitiateOrganisedCrime { get; set; }

    [JsonProperty ("canAccessFactionApi")]
    public int CanAccessFactionApi { get; set; }

    [JsonProperty ("canGiveItem")]
    public int CanGiveItem { get; set; }

    [JsonProperty ("canGiveMoney")]
    public int CanGiveMoney { get; set; }

    [JsonProperty ("canGivePoints")]
    public int CanGivePoints { get; set; }

    [JsonProperty ("canManageForum")]
    public int CanManageForum { get; set; }

    [JsonProperty ("canManageApplications")]
    public int CanManageApplications { get; set; }

    [JsonProperty ("canKickMembers")]
    public int CanKickMembers { get; set; }

    [JsonProperty ("canAdjustMemberBalance")]
    public int CanAdjustMemberBalance { get; set; }

    [JsonProperty ("canManageWars")]
    public int CanManageWars { get; set; }

    [JsonProperty ("canManageUpgrades")]
    public int CanManageUpgrades { get; set; }

    [JsonProperty ("canSendNewsletter")]
    public int CanSendNewsletter { get; set; }

    [JsonProperty ("canChangeAnnouncement")]
    public int CanChangeAnnouncement { get; set; }

    [JsonProperty ("canChangeDescription")]
    public int CanChangeDescription { get; set; }
}
