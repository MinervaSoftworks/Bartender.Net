namespace Bartender.Net.Framework.User.Education;

public interface IUserEducation : IBartenderEntity {
    List<int> EducationCompleted { get; }
    int EducationCurrent { get; }
    int EducationTimeleft { get; }
}