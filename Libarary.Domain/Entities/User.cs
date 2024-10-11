using Libarary.Domain.Common;
using Libarary.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Libarary.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public int? Age { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [PasswordPropertyText]
        public required string Password { get; set; }
        public required Status UserStatus { get; set; }
        public required Role role { get; set; }
    }
}
