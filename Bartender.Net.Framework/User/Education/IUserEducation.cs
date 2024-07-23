namespace Bartender.Net.Framework.User.Education;

public interface IUserEducation : IBartenderEntity {
    List<int> EducationCompleted { get; set; }
    int EducationCurrent { get; set; }
    int EducationTimeleft { get; set; }
}