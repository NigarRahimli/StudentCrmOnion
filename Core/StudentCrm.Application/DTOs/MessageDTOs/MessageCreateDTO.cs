using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.MessageDTOs
{
    public class MessageCreateDTO
    {
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
