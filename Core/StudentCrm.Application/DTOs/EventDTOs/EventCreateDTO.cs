﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.EventDTOs
{
    public class EventCreateDTO
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string Organizator { get; set; }
    }
}
