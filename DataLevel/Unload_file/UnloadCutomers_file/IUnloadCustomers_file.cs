﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public interface IUnloadCustomers_file
    {
        void UnloadCustomersToFile(string text,string path);
    }
}