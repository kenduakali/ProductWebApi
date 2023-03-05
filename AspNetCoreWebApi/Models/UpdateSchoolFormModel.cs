using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApi.Models
{
    public class UpdateSchoolFormModel
    {
        [Required]
        [StringLength(32, MinimumLength = 3)]
        public string? SchoolName { get; set; }

        [Required]
        public DateTime EstablishedAt { get; set; }
    }
}
