﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DashboardAPI.Models
{
    public class Question
    {
        [Key]
        public int QnId { get; set; }

        [Column(TypeName="nvarchar(250)")]
        public string QnInWords { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option4 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public int Answer { get; set; }

    }
}

