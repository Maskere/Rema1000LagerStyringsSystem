﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000LagerStyringsSystem.Models
{
    public class StorageType
    {

        private int _id = 1;
        private string _name;
        private static int _storageTypeCounter;





        public StorageType(string name)
        {
            _id = _storageTypeCounter;
            _storageTypeCounter++;

        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }


        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
       


    }
}