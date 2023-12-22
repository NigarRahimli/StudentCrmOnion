using StudentCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentCrm.Domain.Entities;

public class Event : BaseEntity
{
    public string Title { get; set; }
    public DateTime EventTime { get; set; }
    public string Location { get; set; }    
    public string Organizator { get; set; }
}
