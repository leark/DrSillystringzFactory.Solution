using System.Collections.Generic;
namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<RepairLicense> JoinEntities { get; set; }
    public Engineer()
    {
      this.JoinEntities = new HashSet<RepairLicense>();
    }
  }
}