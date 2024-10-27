using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_System.Classes
{
    [Table("Users")]
    public abstract class POSUser
    {
        [Key]
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public int UserType { get; set; }  // 0 = crew, 1 = team lead, 2 = manager

        public abstract string Role { get; }

        protected POSUser(int userID, string password, string name)
        {
            UserID = userID;
            Password = password;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} - {Role}";
        }
    }

    public class Crew : POSUser
    {
        public override string Role => "Crew";

        public Crew(int userID, string password, string name)
            : base(userID, password, name) { }
    }

    public class TeamLead : POSUser
    {
        public override string Role => "Team Lead";

        public TeamLead(int userID, string password, string name)
            : base(userID, password, name) { }
    }

    public class Manager : POSUser
    {
        public override string Role => "Manager";

        public Manager(int userID, string password, string name)
            : base(userID, password, name) { }
    }
}
