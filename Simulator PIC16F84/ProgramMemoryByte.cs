﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84
{
    public class ProgramMemoryByte
    {
        private byte value;

        public ProgramMemoryByte()
        {
            value = 0;
        }

        public byte Value {
            get { return value; }
            set { this.value = value; }
        }
    }
}
