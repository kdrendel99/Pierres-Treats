using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string TreatName { get; set; }

    // public virtual WebsiteUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}