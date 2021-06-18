using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    // public virtual WebsiteUser { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities {get; }
    
  }
}