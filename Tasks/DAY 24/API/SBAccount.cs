﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Models
{
    public class SBAccount
    {
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        [Required]

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }
        public float CurrentBalance { get; set; }

    }
}
