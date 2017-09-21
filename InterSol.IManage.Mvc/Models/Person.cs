using InterSol.IManage.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterSol.IManage.Mvc.Models
{
    public class Person
    {
        public Person()
        {
            this.Accounts = new HashSet<Account>();
        }

        public int PersonId { get; set; }

        [Required]
        [StringLength(IManageConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(IManageConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [StringLength(IManageConsts.IdNumberDigits, ErrorMessage = "Please enter a 13-digit ID number", MinimumLength = IManageConsts.IdNumberDigits)]
        public string IdNumber { get; set; }

        
        public virtual ICollection<Account> Accounts { get; set; }
    }
}