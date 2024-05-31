using System;
using System.ComponentModel.DataAnnotations;

namespace test_hyundai_backend.Models
{
    public class TaskList
    {
        [Key]
        public int Id { get; set; }
        public string task { get; set; } = string.Empty;
    }
}

