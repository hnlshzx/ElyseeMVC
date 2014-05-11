using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysee.Domain.IAggregate
{
    public interface IEntity
    {
        Guid id { get; set; }
    }
}
