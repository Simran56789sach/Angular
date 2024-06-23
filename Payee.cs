using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Banking_Portal.Entities
{
    public class Payee
    {
        public int PayeeId { get; set; }

        public int CustomerId { get; set; }

        public string PayeeName { get; set; } = null!;

        public string PayeeAccountNo { get; set; } = null!;

        public string PayeeIfsccode { get; set; } = null!;

        public virtual Customer? Customer { get; set; } = null!;
    }
}
