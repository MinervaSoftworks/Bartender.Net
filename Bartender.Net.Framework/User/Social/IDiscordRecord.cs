namespace Bartender.Net.Framework.User.Social;

public interface IDiscordRecord : IBartenderEntity {
    string DiscordID { get; set; }
    int UserID { get; set; }
}