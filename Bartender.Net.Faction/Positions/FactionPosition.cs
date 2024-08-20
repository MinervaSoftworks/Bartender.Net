using Newtonsoft.Json;

namespace Bartender.Net.Faction.Positions;

public class FactionPosition {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public required string Name { get; set; }

    [JsonProperty ("default")]
    public required int Default { get; set; }

    [JsonProperty ("canUseMedicalItem")]
    public required int CanUseMedicalItem { get; set; }

    [JsonProperty ("canUseBoosterItem")]
    public required int CanUseBoosterItem { get; set; }

    [JsonProperty ("canUseDrugItem")]
    public required int CanUseDrugItem { get; set; }

    [JsonProperty ("canUseEnergyRefill")]
    public required int CanUseEnergyRefill { get; set; }

    [JsonProperty ("canUseNerveRefill")]
    public required int CanUseNerveRefill { get; set; }

    [JsonProperty ("canLoanTemporaryItem")]
    public required int CanLoanTemporaryItem { get; set; }

    [JsonProperty ("canLoanWeaponAndArmory")]
    public required int CanLoanWeaponAndArmory { get; set; }

    [JsonProperty ("canRetrieveLoanedArmory")]
    public required int CanRetrieveLoanedArmory { get; set; }

    [JsonProperty ("canPlanAndInitiateOrganisedCrime")]
    public required int CanPlanAndInitiateOrganisedCrime { get; set; }

    [JsonProperty ("canAccessFactionApi")]
    public required int CanAccessFactionApi { get; set; }

    [JsonProperty ("canGiveItem")]
    public required int CanGiveItem { get; set; }

    [JsonProperty ("canGiveMoney")]
    public required int CanGiveMoney { get; set; }

    [JsonProperty ("canGivePoints")]
    public required int CanGivePoints { get; set; }

    [JsonProperty ("canManageForum")]
    public required int CanManageForum { get; set; }

    [JsonProperty ("canManageApplications")]
    public required int CanManageApplications { get; set; }

    [JsonProperty ("canKickMembers")]
    public required int CanKickMembers { get; set; }

    [JsonProperty ("canAdjustMemberBalance")]
    public required int CanAdjustMemberBalance { get; set; }

    [JsonProperty ("canManageWars")]
    public required int CanManageWars { get; set; }

    [JsonProperty ("canManageUpgrades")]
    public required int CanManageUpgrades { get; set; }

    [JsonProperty ("canSendNewsletter")]
    public required int CanSendNewsletter { get; set; }

    [JsonProperty ("canChangeAnnouncement")]
    public required int CanChangeAnnouncement { get; set; }

    [JsonProperty ("canChangeDescription")]
    public required int CanChangeDescription { get; set; }
}
