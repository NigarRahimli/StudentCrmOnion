﻿using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.SatisfactionDTOs
{
    public class SatisfactionDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        Student Student { get; set; }
        public int Rating { get; set; }
        public string Message { get; set; }
    }
}
