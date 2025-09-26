using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyCripProject.Shared.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        public DateTime ReservationStartDate { get; set; }
        [Required]
        public DateTime ReservationEndDate { get; set; }
        [Required]
        private double ReservationPrice { get; set; }

        public void NewReservation(int reservationId, int guestId, int listingId, DateTime startDate, DateTime endTime, double reservationPrice)
        {
            Reservation reservation = new Reservation();
        }
    }
}
