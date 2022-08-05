using System.Collections.Generic;
namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string ModelNumber { get; set; }
    public virtual ICollection<RepairLicense> JoinEntities { get; set; }
    public Machine()
    {
      this.JoinEntities = new HashSet<RepairLicense>();
    }
  }
}