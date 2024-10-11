using Libarary.Domain.Common;
using Libarary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Domain.Entities
{
    public class RequestBook : BaseEntity
    {
        public DateTime RequestDate { get; set; }
        public required Status status { get; set; }
        public int UserId { get; set; }
        public virtual required User user { get; set; }

        public int BookId { get; set; }
        public virtual required Book Book { get; set; }
    }
}
