﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.GroupDTOs
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string GroupNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
