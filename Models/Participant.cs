using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DashboardAPI.Models
{
    public class Participant
    {

        [Key]
        public int? ParticipantId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int pwd {get; set;}

    }

 
}

        