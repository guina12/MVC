using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turn.DomainException
{
    public class Domain:ApplicationException
    {
      public Domain(string messaage):base(messaage) {

    }
 }
}
