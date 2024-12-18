using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsEntry : BartenderEntity {
    [JsonProperty ("bazaarcustomers")]
    public required int Bazaarcustomers { get; set; }

    [JsonProperty ("bazaarsales")]
    public required int Bazaarsales { get; set; }

    [JsonProperty ("bazaarprofit")]
    public required int Bazaarprofit { get; set; }

    [JsonProperty ("useractivity")]
    public required int Useractivity { get; set; }

    [JsonProperty ("activestreak")]
    public required int Activestreak { get; set; }

    [JsonProperty ("bestactivestreak")]
    public required int Bestactivestreak { get; set; }

    [JsonProperty ("itemsbought")]
    public required int Itemsbought { get; set; }

    [JsonProperty ("pointsbought")]
    public required int Pointsbought { get; set; }

    [JsonProperty ("itemsboughtabroad")]
    public required int Itemsboughtabroad { get; set; }

    [JsonProperty ("moneyinvested")]
    public required long Moneyinvested { get; set; }

    [JsonProperty ("investedprofit")]
    public required int Investedprofit { get; set; }

    [JsonProperty ("weaponsbought")]
    public required int Weaponsbought { get; set; }

    [JsonProperty ("trades")]
    public required int Trades { get; set; }

    [JsonProperty ("itemssent")]
    public required int Itemssent { get; set; }

    [JsonProperty ("auctionswon")]
    public required int Auctionswon { get; set; }

    [JsonProperty ("auctionsells")]
    public required int Auctionsells { get; set; }

    [JsonProperty ("pointssold")]
    public required int Pointssold { get; set; }

    [JsonProperty ("attackswon")]
    public required int Attackswon { get; set; }

    [JsonProperty ("attackslost")]
    public required int Attackslost { get; set; }

    [JsonProperty ("attacksdraw")]
    public required int Attacksdraw { get; set; }

    [JsonProperty ("bestkillstreak")]
    public required int Bestkillstreak { get; set; }

    [JsonProperty ("killstreak")]
    public required int Killstreak { get; set; }

    [JsonProperty ("moneymugged")]
    public required int Moneymugged { get; set; }

    [JsonProperty ("attacksstealthed")]
    public required int Attacksstealthed { get; set; }

    [JsonProperty ("attackhits")]
    public required int Attackhits { get; set; }

    [JsonProperty ("attackmisses")]
    public required int Attackmisses { get; set; }

    [JsonProperty ("attackdamage")]
    public required int Attackdamage { get; set; }

    [JsonProperty ("attackcriticalhits")]
    public required int Attackcriticalhits { get; set; }

    [JsonProperty ("respectforfaction")]
    public required int Respectforfaction { get; set; }

    [JsonProperty ("onehitkills")]
    public required int Onehitkills { get; set; }

    [JsonProperty ("defendswon")]
    public required int Defendswon { get; set; }

    [JsonProperty ("defendslost")]
    public required int Defendslost { get; set; }

    [JsonProperty ("defendsstalemated")]
    public required int Defendsstalemated { get; set; }

    [JsonProperty ("bestdamage")]
    public required int Bestdamage { get; set; }

    [JsonProperty ("roundsfired")]
    public required int Roundsfired { get; set; }

    [JsonProperty ("yourunaway")]
    public required int Yourunaway { get; set; }

    [JsonProperty ("theyrunaway")]
    public required int Theyrunaway { get; set; }

    [JsonProperty ("highestbeaten")]
    public required int Highestbeaten { get; set; }

    [JsonProperty ("peoplebusted")]
    public required int Peoplebusted { get; set; }

    [JsonProperty ("failedbusts")]
    public required int Failedbusts { get; set; }

    [JsonProperty ("peoplebought")]
    public required int Peoplebought { get; set; }

    [JsonProperty ("peopleboughtspent")]
    public required int Peopleboughtspent { get; set; }

    [JsonProperty ("virusescoded")]
    public required int Virusescoded { get; set; }

    [JsonProperty ("cityfinds")]
    public required int Cityfinds { get; set; }

    [JsonProperty ("traveltimes")]
    public required int Traveltimes { get; set; }

    [JsonProperty ("bountiesplaced")]
    public required int Bountiesplaced { get; set; }

    [JsonProperty ("bountiesreceived")]
    public required int Bountiesreceived { get; set; }

    [JsonProperty ("bountiescollected")]
    public required int Bountiescollected { get; set; }

    [JsonProperty ("totalbountyreward")]
    public required int Totalbountyreward { get; set; }

    [JsonProperty ("revives")]
    public required int Revives { get; set; }

    [JsonProperty ("revivesreceived")]
    public required int Revivesreceived { get; set; }

    [JsonProperty ("medicalitemsused")]
    public required int Medicalitemsused { get; set; }

    [JsonProperty ("statenhancersused")]
    public required int Statenhancersused { get; set; }

    [JsonProperty ("trainsreceived")]
    public required int Trainsreceived { get; set; }

    [JsonProperty ("totalbountyspent")]
    public required int Totalbountyspent { get; set; }

    [JsonProperty ("drugsused")]
    public required int Drugsused { get; set; }

    [JsonProperty ("overdosed")]
    public required int Overdosed { get; set; }

    [JsonProperty ("meritsbought")]
    public required int Meritsbought { get; set; }

    [JsonProperty ("personalsplaced")]
    public required int Personalsplaced { get; set; }

    [JsonProperty ("classifiedadsplaced")]
    public required int Classifiedadsplaced { get; set; }

    [JsonProperty ("mailssent")]
    public required int Mailssent { get; set; }

    [JsonProperty ("friendmailssent")]
    public required int Friendmailssent { get; set; }

    [JsonProperty ("factionmailssent")]
    public required int Factionmailssent { get; set; }

    [JsonProperty ("companymailssent")]
    public required int Companymailssent { get; set; }

    [JsonProperty ("spousemailssent")]
    public required int Spousemailssent { get; set; }

    [JsonProperty ("largestmug")]
    public required int Largestmug { get; set; }

    [JsonProperty ("cantaken")]
    public required int Cantaken { get; set; }

    [JsonProperty ("exttaken")]
    public required int Exttaken { get; set; }

    [JsonProperty ("kettaken")]
    public required int Kettaken { get; set; }

    [JsonProperty ("lsdtaken")]
    public required int Lsdtaken { get; set; }

    [JsonProperty ("opitaken")]
    public required int Opitaken { get; set; }

    [JsonProperty ("shrtaken")]
    public required int Shrtaken { get; set; }

    [JsonProperty ("spetaken")]
    public required int Spetaken { get; set; }

    [JsonProperty ("pcptaken")]
    public required int Pcptaken { get; set; }

    [JsonProperty ("xantaken")]
    public required int Xantaken { get; set; }

    [JsonProperty ("victaken")]
    public required int Victaken { get; set; }

    [JsonProperty ("chahits")]
    public required int Chahits { get; set; }

    [JsonProperty ("heahits")]
    public required int Heahits { get; set; }

    [JsonProperty ("axehits")]
    public required int Axehits { get; set; }

    [JsonProperty ("grehits")]
    public required int Grehits { get; set; }

    [JsonProperty ("machits")]
    public required int Machits { get; set; }

    [JsonProperty ("pishits")]
    public required int Pishits { get; set; }

    [JsonProperty ("rifhits")]
    public required int Rifhits { get; set; }

    [JsonProperty ("shohits")]
    public required int Shohits { get; set; }

    [JsonProperty ("smghits")]
    public required int Smghits { get; set; }

    [JsonProperty ("piehits")]
    public required int Piehits { get; set; }

    [JsonProperty ("slahits")]
    public required int Slahits { get; set; }

    [JsonProperty ("argtravel")]
    public required int Argtravel { get; set; }

    [JsonProperty ("mextravel")]
    public required int Mextravel { get; set; }

    [JsonProperty ("dubtravel")]
    public required int Dubtravel { get; set; }

    [JsonProperty ("hawtravel")]
    public required int Hawtravel { get; set; }

    [JsonProperty ("japtravel")]
    public required int Japtravel { get; set; }

    [JsonProperty ("lontravel")]
    public required int Lontravel { get; set; }

    [JsonProperty ("soutravel")]
    public required int Soutravel { get; set; }

    [JsonProperty ("switravel")]
    public required int Switravel { get; set; }

    [JsonProperty ("chitravel")]
    public required int Chitravel { get; set; }

    [JsonProperty ("cantravel")]
    public required int Cantravel { get; set; }

    [JsonProperty ("dumpfinds")]
    public required int Dumpfinds { get; set; }

    [JsonProperty ("dumpsearches")]
    public required int Dumpsearches { get; set; }

    [JsonProperty ("itemsdumped")]
    public required int Itemsdumped { get; set; }

    [JsonProperty ("daysbeendonator")]
    public required int Daysbeendonator { get; set; }

    [JsonProperty ("caytravel")]
    public required int Caytravel { get; set; }

    [JsonProperty ("jailed")]
    public required int Jailed { get; set; }

    [JsonProperty ("hospital")]
    public required int Hospital { get; set; }

    [JsonProperty ("attacksassisted")]
    public required int Attacksassisted { get; set; }

    [JsonProperty ("bloodwithdrawn")]
    public required int Bloodwithdrawn { get; set; }

    [JsonProperty ("networth")]
    public required int Networth { get; set; }

    [JsonProperty ("missionscompleted")]
    public required int Missionscompleted { get; set; }

    [JsonProperty ("contractscompleted")]
    public required int Contractscompleted { get; set; }

    [JsonProperty ("dukecontractscompleted")]
    public required int Dukecontractscompleted { get; set; }

    [JsonProperty ("missioncreditsearned")]
    public required int Missioncreditsearned { get; set; }

    [JsonProperty ("consumablesused")]
    public required int Consumablesused { get; set; }

    [JsonProperty ("candyused")]
    public required int Candyused { get; set; }

    [JsonProperty ("alcoholused")]
    public required int Alcoholused { get; set; }

    [JsonProperty ("energydrinkused")]
    public required int Energydrinkused { get; set; }

    [JsonProperty ("nerverefills")]
    public required int Nerverefills { get; set; }

    [JsonProperty ("unarmoredwon")]
    public required int Unarmoredwon { get; set; }

    [JsonProperty ("h2hhits")]
    public required int H2hhits { get; set; }

    [JsonProperty ("organisedcrimes")]
    public required int Organisedcrimes { get; set; }

    [JsonProperty ("territorytime")]
    public required int Territorytime { get; set; }

    [JsonProperty ("territoryjoins")]
    public required int Territoryjoins { get; set; }

    [JsonProperty ("stockpayouts")]
    public required int Stockpayouts { get; set; }

    [JsonProperty ("stockprofits")]
    public required int Stockprofits { get; set; }

    [JsonProperty ("stocklosses")]
    public required int Stocklosses { get; set; }

    [JsonProperty ("stockfees")]
    public required int Stockfees { get; set; }

    [JsonProperty ("stocknetprofits")]
    public required int Stocknetprofits { get; set; }

    [JsonProperty ("arrestsmade")]
    public required int Arrestsmade { get; set; }

    [JsonProperty ("tokenrefills")]
    public required int Tokenrefills { get; set; }

    [JsonProperty ("booksread")]
    public required int Booksread { get; set; }

    [JsonProperty ("traveltime")]
    public required int Traveltime { get; set; }

    [JsonProperty ("boostersused")]
    public required int Boostersused { get; set; }

    [JsonProperty ("rehabs")]
    public required int Rehabs { get; set; }

    [JsonProperty ("rehabcost")]
    public required int Rehabcost { get; set; }

    [JsonProperty ("awards")]
    public required int Awards { get; set; }

    [JsonProperty ("receivedbountyvalue")]
    public required int Receivedbountyvalue { get; set; }

    [JsonProperty ("networthpending")]
    public required int Networthpending { get; set; }

    [JsonProperty ("networthwallet")]
    public required int Networthwallet { get; set; }

    [JsonProperty ("networthbank")]
    public required int Networthbank { get; set; }

    [JsonProperty ("networthpoints")]
    public required int Networthpoints { get; set; }

    [JsonProperty ("networthcayman")]
    public required int Networthcayman { get; set; }

    [JsonProperty ("networthvault")]
    public required int Networthvault { get; set; }

    [JsonProperty ("networthpiggybank")]
    public required int Networthpiggybank { get; set; }

    [JsonProperty ("networthitems")]
    public required int Networthitems { get; set; }

    [JsonProperty ("networthdisplaycase")]
    public required int Networthdisplaycase { get; set; }

    [JsonProperty ("networthbazaar")]
    public required int Networthbazaar { get; set; }

    [JsonProperty ("networthproperties")]
    public required int Networthproperties { get; set; }

    [JsonProperty ("networthstockmarket")]
    public required int Networthstockmarket { get; set; }

    [JsonProperty ("networthitemmarket")]
    public required int Networthitemmarket { get; set; }

    [JsonProperty ("networthauctionhouse")]
    public required int Networthauctionhouse { get; set; }

    [JsonProperty ("networthcompany")]
    public required int Networthcompany { get; set; }

    [JsonProperty ("networthbookie")]
    public required int Networthbookie { get; set; }

    [JsonProperty ("networthenlistedcars")]
    public required int Networthenlistedcars { get; set; }

    [JsonProperty ("networthloan")]
    public required int Networthloan { get; set; }

    [JsonProperty ("networthunpaidfees")]
    public required int Networthunpaidfees { get; set; }

    [JsonProperty ("racingskill")]
    public required int Racingskill { get; set; }

    [JsonProperty ("raceswon")]
    public required int Raceswon { get; set; }

    [JsonProperty ("racesentered")]
    public required int Racesentered { get; set; }

    [JsonProperty ("racingpointsearned")]
    public required int Racingpointsearned { get; set; }

    [JsonProperty ("specialammoused")]
    public required int Specialammoused { get; set; }

    [JsonProperty ("cityitemsbought")]
    public required int Cityitemsbought { get; set; }

    [JsonProperty ("hollowammoused")]
    public required int Hollowammoused { get; set; }

    [JsonProperty ("tracerammoused")]
    public required int Tracerammoused { get; set; }

    [JsonProperty ("piercingammoused")]
    public required int Piercingammoused { get; set; }

    [JsonProperty ("incendiaryammoused")]
    public required int Incendiaryammoused { get; set; }

    [JsonProperty ("attackswonabroad")]
    public required int Attackswonabroad { get; set; }

    [JsonProperty ("defendslostabroad")]
    public required int Defendslostabroad { get; set; }

    [JsonProperty ("rankedwarringwins")]
    public required int Rankedwarringwins { get; set; }

    [JsonProperty ("retals")]
    public required int Retals { get; set; }

    [JsonProperty ("elo")]
    public required int Elo { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("totalstats")]
    public required int Totalstats { get; set; }

    [JsonProperty ("manuallabor")]
    public required int Manuallabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }

    [JsonProperty ("totalworkingstats")]
    public required int Totalworkingstats { get; set; }

    [JsonProperty ("jobpointsused")]
    public required int Jobpointsused { get; set; }

    [JsonProperty ("reviveskill")]
    public required int Reviveskill { get; set; }

    [JsonProperty ("itemslooted")]
    public required int Itemslooted { get; set; }

    [JsonProperty ("rankedwarhits")]
    public required int Rankedwarhits { get; set; }

    [JsonProperty ("raidhits")]
    public required int Raidhits { get; set; }

    [JsonProperty ("territoryclears")]
    public required int Territoryclears { get; set; }

    [JsonProperty ("criminaloffenses")]
    public required int Criminaloffenses { get; set; }

    [JsonProperty ("theft")]
    public required int Theft { get; set; }

    [JsonProperty ("vandalism")]
    public required int Vandalism { get; set; }

    [JsonProperty ("fraud")]
    public required int Fraud { get; set; }

    [JsonProperty ("counterfeiting")]
    public required int Counterfeiting { get; set; }

    [JsonProperty ("illicitservices")]
    public required int Illicitservices { get; set; }

    [JsonProperty ("cybercrime")]
    public required int Cybercrime { get; set; }

    [JsonProperty ("extortion")]
    public required int Extortion { get; set; }

    [JsonProperty ("illegalproduction")]
    public required int Illegalproduction { get; set; }

    [JsonProperty ("eastereggs")]
    public required int Eastereggs { get; set; }

    [JsonProperty ("eastereggsused")]
    public required int Eastereggsused { get; set; }

    [JsonProperty ("refills")]
    public required int Refills { get; set; }
}
