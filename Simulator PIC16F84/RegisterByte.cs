﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84
{
    public class RegisterByte
    {
        private byte value;
        private int index;
        private RegisterFileMap registerFileMap;

        public event EventHandler<int> RegisterChanged;

        public RegisterByte(ref RegisterFileMap registerFileMap, int index)
        {
            value = 0;
            this.index = index;
            this.registerFileMap = registerFileMap;
        }

        public byte Value {
            get { return value; }
            set
            {
                    this.value = value;
                    if (this.RegisterChanged != null)
                    {
                        this.RegisterChanged(this, index);
                    }
            }
        }

        public RegisterFileMap GetRegisterMap()
        {
            return registerFileMap;
        }


        public void ClearRegister()
        {
            value = 0;
        }

        public int DecrementRegister()
        {
            return value - 1;
        }

        public int IncrementRegister()
        {
            return value + 1;
        }

        public bool IsBitSet(int pos)
        {
            return ( ( ( value >> pos ) & 0x1 ) == 0x1 );
        }

        public byte FormComplement()
        {
            return ((byte) ((int) value ^ 0xff));
        }
    }

}
