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
        T get(int id);
        List<T> getAll();
        void insert();
        bool update(int id);
        bool delete(int id);

    }
}
