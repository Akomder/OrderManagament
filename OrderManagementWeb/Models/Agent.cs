using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagementWeb.Models
{
    [Table("Agents")]
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }

        [Required(ErrorMessage = "Agent Name is required")]
        [StringLength(100)]
        [Display(Name = "Agent Name")]
        public string AgentName { get; set; }

        [Required(ErrorMessage = "Agent Code is required")]
        [StringLength(50)]
        [Display(Name = "Agent Code")]
        public string AgentCode { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public Agent()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
    }
}
