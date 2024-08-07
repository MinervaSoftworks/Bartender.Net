namespace Bartender.Net.Framework.User.Skills;

public interface ISkillsRoot : IBartenderEntity {
    string Bootlegging { get; }
    string Burglary { get; }
    string CardSkimming { get; }
    string Cracking { get; }
    string Disposal { get; }
    string Forgery { get; }
    string Graffiti { get; }
    string Hustling { get; }
    string Pickpocketing { get; }
    int PlayerId { get; }
    string Racing { get; }
    string Reviving { get; }
    string SearchForCash { get; }
    string Shoplifting { get; }
}