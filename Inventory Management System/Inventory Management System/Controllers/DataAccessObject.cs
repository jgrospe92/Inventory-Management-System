using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Controllers
{
    internal interface DataAccessObject
    {
        void get();
        void getAll();
        void insert(User user);
        void update();
        void delete();

    }
}
