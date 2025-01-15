using Dernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Entities.Concrete
{
    public class BloodType: IEntity
    {
        public string BloodTypeId { get; set; }
        public string TypeName { get; set; }
    }
}
