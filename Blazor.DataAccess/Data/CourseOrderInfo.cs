using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.DataAccess.Data
{
    public class CourseOrderInfo
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string StripeSessionId { get; set; }
        public decimal CoursePrice { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public bool IsPaymentSuccessfull { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
