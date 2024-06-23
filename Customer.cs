using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Online_Banking_Portal.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;

        public string ContactNo { get; set; } = null!;

        public string EmailId { get; set; } = null!;

        public string? Address { get; set; }

        public DateTime Dob { get; set; }

        public string Gender { get; set; } = null!;
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

        public virtual ICollection<LoanApplication> LoanApplications { get; set; } = new List<LoanApplication>();

        public virtual ICollection<Payee> Payees { get; set; } = new List<Payee>();
    }
}
