using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class PreventiveMaintenance
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public string TaskName { get; set; }
        public int FrequencyInDays { get; set; }
        public DateTime? LastCompleted { get; set; }
        public DateTime NextDueDate { get; set; }
        public int? AssignedTo { get; set; }
    }
}
