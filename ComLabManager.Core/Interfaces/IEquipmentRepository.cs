
using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetAll();
        Equipment GetByAssetTag(string assetTag);
        void Add(Equipment equipment);
        void Update(Equipment equipment);
        void Delete(int id);
    }
}
