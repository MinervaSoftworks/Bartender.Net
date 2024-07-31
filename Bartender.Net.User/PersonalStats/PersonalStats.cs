using Bartender.Net.Framework.User.PersonalStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStats : IPersonalStats {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bazaarcustomers")]
    public int Bazaarcustomers { get; set; }

    [JsonProperty ("bazaarsales")]
    public int Bazaarsales { get; set; }

    [JsonProperty ("bazaarprofit")]
    public int Bazaarprofit { get; set; }

    [JsonProperty ("useractivity")]
    public int Useractivity { get; set; }

    [JsonProperty ("activestreak")]
    public int Activestreak { get; set; }

    [JsonProperty ("bestactivestreak")]
    public int Bestactivestreak { get; set; }

    [JsonProperty ("itemsbought")]
    public int Itemsbought { get; set; }

    [JsonProperty ("pointsbought")]
    public int Pointsbought { get; set; }

    [JsonProperty ("itemsboughtabroad")]
    public int Itemsboughtabroad { get; set; }

    [JsonProperty ("moneyinvested")]
    public long Moneyinvested { get; set; }

    [JsonProperty ("investedprofit")]
    public int Investedprofit { get; set; }

    [JsonProperty ("weaponsbought")]
    public int Weaponsbought { get; set; }

    [JsonProperty ("trades")]
    public int Trades { get; set; }

    [JsonProperty ("itemssent")]
    public int Itemssent { get; set; }

    [JsonProperty ("auctionswon")]
    public int Auctionswon { get; set; }

    [JsonProperty ("auctionsells")]
    public int Auctionsells { get; set; }

    [JsonProperty ("pointssold")]
    public int Pointssold { get; set; }

    [JsonProperty ("attackswon")]
    public int Attackswon { get; set; }

    [JsonProperty ("attackslost")]
    public int Attackslost { get; set; }

    [JsonProperty ("attacksdraw")]
    public int Attacksdraw { get; set; }

    [JsonProperty ("bestkillstreak")]
    public int Bestkillstreak { get; set; }

    [JsonProperty ("killstreak")]
    public int Killstreak { get; set; }

    [JsonProperty ("moneymugged")]
    public int Moneymugged { get; set; }

    [JsonProperty ("attacksstealthed")]
    public int Attacksstealthed { get; set; }

    [JsonProperty ("attackhits")]
    public int Attackhits { get; set; }

    [JsonProperty ("attackmisses")]
    public int Attackmisses { get; set; }

    [JsonProperty ("attackdamage")]
    public int Attackdamage { get; set; }

    [JsonProperty ("attackcriticalhits")]
    public int Attackcriticalhits { get; set; }

    [JsonProperty ("respectforfaction")]
    public int Respectforfaction { get; set; }

    [JsonProperty ("onehitkills")]
    public int Onehitkills { get; set; }

    [JsonProperty ("defendswon")]
    public int Defendswon { get; set; }

    [JsonProperty ("defendslost")]
    public int Defendslost { get; set; }

    [JsonProperty ("defendsstalemated")]
    public int Defendsstalemated { get; set; }

    [JsonProperty ("bestdamage")]
    public int Bestdamage { get; set; }

    [JsonProperty ("roundsfired")]
    public int Roundsfired { get; set; }

    [JsonProperty ("yourunaway")]
    public int Yourunaway { get; set; }

    [JsonProperty ("theyrunaway")]
    public int Theyrunaway { get; set; }

    [JsonProperty ("highestbeaten")]
    public int Highestbeaten { get; set; }

    [JsonProperty ("peoplebusted")]
    public int Peoplebusted { get; set; }

    [JsonProperty ("failedbusts")]
    public int Failedbusts { get; set; }

    [JsonProperty ("peoplebought")]
    public int Peoplebought { get; set; }

    [JsonProperty ("peopleboughtspent")]
    public int Peopleboughtspent { get; set; }

    [JsonProperty ("virusescoded")]
    public int Virusescoded { get; set; }

    [JsonProperty ("cityfinds")]
    public int Cityfinds { get; set; }

    [JsonProperty ("traveltimes")]
    public int Traveltimes { get; set; }

    [JsonProperty ("bountiesplaced")]
    public int Bountiesplaced { get; set; }

    [JsonProperty ("bountiesreceived")]
    public int Bountiesreceived { get; set; }

    [JsonProperty ("bountiescollected")]
    public int Bountiescollected { get; set; }

    [JsonProperty ("totalbountyreward")]
    public int Totalbountyreward { get; set; }

    [JsonProperty ("revives")]
    public int Revives { get; set; }

    [JsonProperty ("revivesreceived")]
    public int Revivesreceived { get; set; }

    [JsonProperty ("medicalitemsused")]
    public int Medicalitemsused { get; set; }

    [JsonProperty ("statenhancersused")]
    public int Statenhancersused { get; set; }

    [JsonProperty ("trainsreceived")]
    public int Trainsreceived { get; set; }

    [JsonProperty ("totalbountyspent")]
    public int Totalbountyspent { get; set; }

    [JsonProperty ("drugsused")]
    public int Drugsused { get; set; }

    [JsonProperty ("overdosed")]
    public int Overdosed { get; set; }

    [JsonProperty ("meritsbought")]
    public int Meritsbought { get; set; }

    [JsonProperty ("personalsplaced")]
    public int Personalsplaced { get; set; }

    [JsonProperty ("classifiedadsplaced")]
    public int Classifiedadsplaced { get; set; }

    [JsonProperty ("mailssent")]
    public int Mailssent { get; set; }

    [JsonProperty ("friendmailssent")]
    public int Friendmailssent { get; set; }

    [JsonProperty ("factionmailssent")]
    public int Factionmailssent { get; set; }

    [JsonProperty ("companymailssent")]
    public int Companymailssent { get; set; }

    [JsonProperty ("spousemailssent")]
    public int Spousemailssent { get; set; }

    [JsonProperty ("largestmug")]
    public int Largestmug { get; set; }

    [JsonProperty ("cantaken")]
    public int Cantaken { get; set; }

    [JsonProperty ("exttaken")]
    public int Exttaken { get; set; }

    [JsonProperty ("kettaken")]
    public int Kettaken { get; set; }

    [JsonProperty ("lsdtaken")]
    public int Lsdtaken { get; set; }

    [JsonProperty ("opitaken")]
    public int Opitaken { get; set; }

    [JsonProperty ("shrtaken")]
    public int Shrtaken { get; set; }

    [JsonProperty ("spetaken")]
    public int Spetaken { get; set; }

    [JsonProperty ("pcptaken")]
    public int Pcptaken { get; set; }

    [JsonProperty ("xantaken")]
    public int Xantaken { get; set; }

    [JsonProperty ("victaken")]
    public int Victaken { get; set; }

    [JsonProperty ("chahits")]
    public int Chahits { get; set; }

    [JsonProperty ("heahits")]
    public int Heahits { get; set; }

    [JsonProperty ("axehits")]
    public int Axehits { get; set; }

    [JsonProperty ("grehits")]
    public int Grehits { get; set; }

    [JsonProperty ("machits")]
    public int Machits { get; set; }

    [JsonProperty ("pishits")]
    public int Pishits { get; set; }

    [JsonProperty ("rifhits")]
    public int Rifhits { get; set; }

    [JsonProperty ("shohits")]
    public int Shohits { get; set; }

    [JsonProperty ("smghits")]
    public int Smghits { get; set; }

    [JsonProperty ("piehits")]
    public int Piehits { get; set; }

    [JsonProperty ("slahits")]
    public int Slahits { get; set; }

    [JsonProperty ("argtravel")]
    public int Argtravel { get; set; }

    [JsonProperty ("mextravel")]
    public int Mextravel { get; set; }

    [JsonProperty ("dubtravel")]
    public int Dubtravel { get; set; }

    [JsonProperty ("hawtravel")]
    public int Hawtravel { get; set; }

    [JsonProperty ("japtravel")]
    public int Japtravel { get; set; }

    [JsonProperty ("lontravel")]
    public int Lontravel { get; set; }

    [JsonProperty ("soutravel")]
    public int Soutravel { get; set; }

    [JsonProperty ("switravel")]
    public int Switravel { get; set; }

    [JsonProperty ("chitravel")]
    public int Chitravel { get; set; }

    [JsonProperty ("cantravel")]
    public int Cantravel { get; set; }

    [JsonProperty ("dumpfinds")]
    public int Dumpfinds { get; set; }

    [JsonProperty ("dumpsearches")]
    public int Dumpsearches { get; set; }

    [JsonProperty ("itemsdumped")]
    public int Itemsdumped { get; set; }

    [JsonProperty ("daysbeendonator")]
    public int Daysbeendonator { get; set; }

    [JsonProperty ("caytravel")]
    public int Caytravel { get; set; }

    [JsonProperty ("jailed")]
    public int Jailed { get; set; }

    [JsonProperty ("hospital")]
    public int Hospital { get; set; }

    [JsonProperty ("attacksassisted")]
    public int Attacksassisted { get; set; }

    [JsonProperty ("bloodwithdrawn")]
    public int Bloodwithdrawn { get; set; }

    [JsonProperty ("networth")]
    public int Networth { get; set; }

    [JsonProperty ("missionscompleted")]
    public int Missionscompleted { get; set; }

    [JsonProperty ("contractscompleted")]
    public int Contractscompleted { get; set; }

    [JsonProperty ("dukecontractscompleted")]
    public int Dukecontractscompleted { get; set; }

    [JsonProperty ("missioncreditsearned")]
    public int Missioncreditsearned { get; set; }

    [JsonProperty ("consumablesused")]
    public int Consumablesused { get; set; }

    [JsonProperty ("candyused")]
    public int Candyused { get; set; }

    [JsonProperty ("alcoholused")]
    public int Alcoholused { get; set; }

    [JsonProperty ("energydrinkused")]
    public int Energydrinkused { get; set; }

    [JsonProperty ("nerverefills")]
    public int Nerverefills { get; set; }

    [JsonProperty ("unarmoredwon")]
    public int Unarmoredwon { get; set; }

    [JsonProperty ("h2hhits")]
    public int H2hhits { get; set; }

    [JsonProperty ("organisedcrimes")]
    public int Organisedcrimes { get; set; }

    [JsonProperty ("territorytime")]
    public int Territorytime { get; set; }

    [JsonProperty ("territoryjoins")]
    public int Territoryjoins { get; set; }

    [JsonProperty ("stockpayouts")]
    public int Stockpayouts { get; set; }

    [JsonProperty ("stockprofits")]
    public int Stockprofits { get; set; }

    [JsonProperty ("stocklosses")]
    public int Stocklosses { get; set; }

    [JsonProperty ("stockfees")]
    public int Stockfees { get; set; }

    [JsonProperty ("stocknetprofits")]
    public int Stocknetprofits { get; set; }

    [JsonProperty ("arrestsmade")]
    public int Arrestsmade { get; set; }

    [JsonProperty ("tokenrefills")]
    public int Tokenrefills { get; set; }

    [JsonProperty ("booksread")]
    public int Booksread { get; set; }

    [JsonProperty ("traveltime")]
    public int Traveltime { get; set; }

    [JsonProperty ("boostersused")]
    public int Boostersused { get; set; }

    [JsonProperty ("rehabs")]
    public int Rehabs { get; set; }

    [JsonProperty ("rehabcost")]
    public int Rehabcost { get; set; }

    [JsonProperty ("awards")]
    public int Awards { get; set; }

    [JsonProperty ("receivedbountyvalue")]
    public int Receivedbountyvalue { get; set; }

    [JsonProperty ("networthpending")]
    public int Networthpending { get; set; }

    [JsonProperty ("networthwallet")]
    public int Networthwallet { get; set; }

    [JsonProperty ("networthbank")]
    public int Networthbank { get; set; }

    [JsonProperty ("networthpoints")]
    public int Networthpoints { get; set; }

    [JsonProperty ("networthcayman")]
    public int Networthcayman { get; set; }

    [JsonProperty ("networthvault")]
    public int Networthvault { get; set; }

    [JsonProperty ("networthpiggybank")]
    public int Networthpiggybank { get; set; }

    [JsonProperty ("networthitems")]
    public int Networthitems { get; set; }

    [JsonProperty ("networthdisplaycase")]
    public int Networthdisplaycase { get; set; }

    [JsonProperty ("networthbazaar")]
    public int Networthbazaar { get; set; }

    [JsonProperty ("networthproperties")]
    public int Networthproperties { get; set; }

    [JsonProperty ("networthstockmarket")]
    public int Networthstockmarket { get; set; }

    [JsonProperty ("networthitemmarket")]
    public int Networthitemmarket { get; set; }

    [JsonProperty ("networthauctionhouse")]
    public int Networthauctionhouse { get; set; }

    [JsonProperty ("networthcompany")]
    public int Networthcompany { get; set; }

    [JsonProperty ("networthbookie")]
    public int Networthbookie { get; set; }

    [JsonProperty ("networthenlistedcars")]
    public int Networthenlistedcars { get; set; }

    [JsonProperty ("networthloan")]
    public int Networthloan { get; set; }

    [JsonProperty ("networthunpaidfees")]
    public int Networthunpaidfees { get; set; }

    [JsonProperty ("racingskill")]
    public int Racingskill { get; set; }

    [JsonProperty ("raceswon")]
    public int Raceswon { get; set; }

    [JsonProperty ("racesentered")]
    public int Racesentered { get; set; }

    [JsonProperty ("racingpointsearned")]
    public int Racingpointsearned { get; set; }

    [JsonProperty ("specialammoused")]
    public int Specialammoused { get; set; }

    [JsonProperty ("cityitemsbought")]
    public int Cityitemsbought { get; set; }

    [JsonProperty ("hollowammoused")]
    public int Hollowammoused { get; set; }

    [JsonProperty ("tracerammoused")]
    public int Tracerammoused { get; set; }

    [JsonProperty ("piercingammoused")]
    public int Piercingammoused { get; set; }

    [JsonProperty ("incendiaryammoused")]
    public int Incendiaryammoused { get; set; }

    [JsonProperty ("attackswonabroad")]
    public int Attackswonabroad { get; set; }

    [JsonProperty ("defendslostabroad")]
    public int Defendslostabroad { get; set; }

    [JsonProperty ("rankedwarringwins")]
    public int Rankedwarringwins { get; set; }

    [JsonProperty ("retals")]
    public int Retals { get; set; }

    [JsonProperty ("elo")]
    public int Elo { get; set; }

    [JsonProperty ("strength")]
    public int Strength { get; set; }

    [JsonProperty ("defense")]
    public int Defense { get; set; }

    [JsonProperty ("speed")]
    public int Speed { get; set; }

    [JsonProperty ("dexterity")]
    public int Dexterity { get; set; }

    [JsonProperty ("totalstats")]
    public int Totalstats { get; set; }

    [JsonProperty ("manuallabor")]
    public int Manuallabor { get; set; }

    [JsonProperty ("intelligence")]
    public int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public int Endurance { get; set; }

    [JsonProperty ("totalworkingstats")]
    public int Totalworkingstats { get; set; }

    [JsonProperty ("jobpointsused")]
    public int Jobpointsused { get; set; }

    [JsonProperty ("reviveskill")]
    public int Reviveskill { get; set; }

    [JsonProperty ("itemslooted")]
    public int Itemslooted { get; set; }

    [JsonProperty ("rankedwarhits")]
    public int Rankedwarhits { get; set; }

    [JsonProperty ("raidhits")]
    public int Raidhits { get; set; }

    [JsonProperty ("territoryclears")]
    public int Territoryclears { get; set; }

    [JsonProperty ("criminaloffenses")]
    public int Criminaloffenses { get; set; }

    [JsonProperty ("theft")]
    public int Theft { get; set; }

    [JsonProperty ("vandalism")]
    public int Vandalism { get; set; }

    [JsonProperty ("fraud")]
    public int Fraud { get; set; }

    [JsonProperty ("counterfeiting")]
    public int Counterfeiting { get; set; }

    [JsonProperty ("illicitservices")]
    public int Illicitservices { get; set; }

    [JsonProperty ("cybercrime")]
    public int Cybercrime { get; set; }

    [JsonProperty ("extortion")]
    public int Extortion { get; set; }

    [JsonProperty ("illegalproduction")]
    public int Illegalproduction { get; set; }

    [JsonProperty ("eastereggs")]
    public int Eastereggs { get; set; }

    [JsonProperty ("eastereggsused")]
    public int Eastereggsused { get; set; }

    [JsonProperty ("refills")]
    public int Refills { get; set; }
}
