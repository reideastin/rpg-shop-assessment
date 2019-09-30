﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_shop_simulator_assement
{
    class Weapons : Item
    {
        private int _damage;

        int GetDamage()
        {
            return _damage;
        }

        public Weapons(string name, int cost, int damage, string description) : base(name,cost,description)
        {
            _damage = damage;

        }

        public override void Printitem()
        {
            string name = _name;
            string description = _description;
            int cost = _cost;

            Console.Write(name + "\n" + description + "\nThis Item cost " + cost + " Gold." + "\nThis item does " + _damage + " Damage.");
        }
    }
}
