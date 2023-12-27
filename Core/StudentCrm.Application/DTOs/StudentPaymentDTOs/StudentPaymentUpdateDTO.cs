﻿using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.StudentPaymentDTOs
{
    public class StudentPaymentUpdateDTO
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}