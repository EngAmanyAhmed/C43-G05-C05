﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        private int X;
        internal int Y;
        public int Z;

        void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB();

            TypeB.X = 12; // Valid
            TypeB.Y = 12; // Valid
            TypeB.Z = 12; // Valid
        }
    }
}