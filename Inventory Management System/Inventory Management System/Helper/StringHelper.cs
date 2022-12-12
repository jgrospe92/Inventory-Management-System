using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Helper
{

    public class StringHelper
    {
        public static string[] prepSize(string rawSize)
        {
            String removeSpaces = rawSize.Trim().Replace(" ", "");
            string[] splitString = removeSpaces.Split('x');
            return splitString;
        }
    }
  
}
