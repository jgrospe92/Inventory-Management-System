using Inventory_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Controllers
{
    internal interface DataAccessObject<T>
    {
        T get<A>();
        List<T> getAll();
        void insert();
        void update();
        void delete();

    }
}
