namespace Bartender.Net.Framework.User.Skills;

public interface IUserSkills : IBartenderEntity {
    string Bootlegging { get; set; }
    string Burglary { get; set; }
    string CardSkimming { get; set; }
    string Cracking { get; set; }
    string Disposal { get; set; }
    string Forgery { get; set; }
    string Graffiti { get; set; }
    string Hustling { get; set; }
    string Pickpocketing { get; set; }
    int PlayerId { get; set; }
    string Racing { get; set; }
    string Reviving { get; set; }
    string SearchForCash { get; set; }
    string Shoplifting { get; set; }
}