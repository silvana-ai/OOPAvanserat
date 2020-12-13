using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDal
{
    // Design pattern :- Generic Repository pattern
    public interface IRepository<AnyType>
    {
        void SetUnitWork(IUow uow);
        void Add(AnyType obj); // Inmemory addition obj
        void Update(AnyType obj);  // Inmemory updation obj

        // Design pattern :- this kod för Iterator the obj
        IEnumerable<AnyType> Search();
        IEnumerable<AnyType> GetData();
        AnyType GetData(int Index);
        
        void Save(); 

    }
    // Design pattern :- Unit of Work pattern
    public interface IUow
    {
        void Committ();
        void RollBack();
    }
}
