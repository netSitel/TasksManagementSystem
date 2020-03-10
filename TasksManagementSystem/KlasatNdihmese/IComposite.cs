using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManagementSystem.KlasatNdihmese
{
    interface IComposite<T>
    {
       
            T Parent { get; }
            ISet<T> Children { get; }
        
    }
}
