
using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IEquipmentRepository
    {
       List<Equipment> GetAllEquipment();
        
    }
}
