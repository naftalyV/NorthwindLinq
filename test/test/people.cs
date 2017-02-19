using System.Collections.Generic;

namespace test
{
   public  class people
    {
        public int id { get; set; }
        public virtual ICollection<person> person { get; set; }
    }
}