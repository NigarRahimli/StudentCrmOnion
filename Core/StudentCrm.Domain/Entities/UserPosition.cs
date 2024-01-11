using StudentCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Domain.Entities
{
    public class UserPosition : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}
