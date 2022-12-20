﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace Dan_Daniela_Lab7.Models
{

    public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }
        public string ShopDetails { get { return ShopName + " " + Adress; } }

        [OneToMany]
        public List<ShopList> ShopList { get; set; }

    }
}