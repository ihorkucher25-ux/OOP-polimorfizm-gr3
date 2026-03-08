namespace ConsoleApp8;

public interface IUniversityMember
{
    string Name { get; set; }
    string MemberId { get; }
    List<string> ActionLog { get; set; }
    void PerformDuties();
}

