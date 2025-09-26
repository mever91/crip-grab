using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyCripProject.Shared.Models
{
    public class Crip
    {
        [Key]
        public int CripId { get; set; }
        [Required]
        public string CripType { get; set; }
        [Required]
        public string CripAdress { get; set; }
        [Required]
        public int CripSize { get; set; }
        [Required]
        public int CripBeds { get; set; }
        [Required]
        public int CripBathrooms { get; set; }
        [Required]
        public string CripRules { get; set; }
        [Required]
        public int CripStars { get; set; }

        public Crip(int cripId, string cripType, string cripAdress, int cripSize, int cripBeds, int cripBathrooms, string cripRules, int cripStars)
        {
            CripId = cripId;
            CripType = cripType;
            CripAdress = cripAdress;
            CripSize = cripSize;
            CripBeds = cripBeds;
            CripBathrooms = cripBathrooms;
            CripRules = cripRules;
            CripStars = cripStars;
        }
    }
}
