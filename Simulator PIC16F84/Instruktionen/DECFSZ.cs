﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84.Instruktionen
{
    public class DECFSZ : BaseOperation
    {
        //DECFSZ            Decrement f, Skip if 0
        //--------------------------------------
        //Syntax:           [label] DECFSZ f,d
        //Operands:         0 <= f <= 127
        //                  d e [0,1]
        //Operation:        (f) - 1 -> (destination)
        //                  skip if result = 0
        //Status Affected:  None
        //Description:      The contents of register 'f' are
        //                  decremented. If 'd' is 0, the result
        //                  is placed in the W register. If 'd' is
        //                  1, the result is placed back in
        //                  register 'f'.
        //                  If the result is 1, the next instruc-
        //                  tion is executed. If the result is 0,
        //                  then a NOP is executed instead,
        //                  making it a 2TCY instruction.


        public DECFSZ(int f, bool d, WorkingRegister W, ProgramCounter PC)
        {
            this.f = f;
            this.d = d;

            execute(W, PC);
        }

        protected void execute(WorkingRegister W, ProgramCounter PC)
        {
            var result = W.Value.GetRegisterMap().RegisterList[f].DecrementRegister();
            if (d)
                W.Value.GetRegisterMap().RegisterList[f].Value = (sbyte)result;
            else
                W.Value.Value = (sbyte)result;

            if (result == 0)
            {
                PC.Counter.Value++;
                NOP Operation = new NOP();
            }
         }




        protected override void execute(WorkingRegister W)
        {
            throw new NotImplementedException();
        }
    }
}
