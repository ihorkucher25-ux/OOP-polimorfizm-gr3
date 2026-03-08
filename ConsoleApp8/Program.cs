
namespace ConsoleApp8;

public interface IUniversityMember
{
    string Name { get; set; }
    string MemberId { get; }
    List<string> ActionLog { get; set; }
    void PerformDuties();
}

public class UniversityMember : IUniversityMember
{
    private string _name;
    public string Name 
    {
        get
        {
            return _name;
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            _name = value;
        }
    }
    public string MemberId { get; }
    public List<string> ActionLog { get; set; } = new List<string>();

    public virtual void PerformDuties()
    {
       
        if (ActionLog.Count >= 5)
        {
            throw new Exception("Daily limit of 5 actions reached.");
        }
    }

    public UniversityMember(string name, string id)
    {
        Name = name;
        MemberId = id;
    }
    
}
