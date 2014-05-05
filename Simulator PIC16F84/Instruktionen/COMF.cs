﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84.Instruktionen
{
    public class COMF : BaseOperation
    {

        //COMF Complement f
        //Syntax: [ label ] COMF f,d
        //Operands: 0 ≤ f ≤ 127
        //d ∈ [0,1]
        //Operation: ~(f) → (destination)
        //Status Affected: Z
        //Description: The contents of register ’f’ are 
        //complemented. If ’d’ is 0, the 
        //result is stored in W. If ’d’ is 1, the 
        //result is stored back in register ’f’


        public COMF(int f, bool d, WorkingRegister W)
        {
            this.f = f;
            this.d = d;

            execute(W);

        }

        protected override void execute(WorkingRegister W)
        {
            W.Value.GetRegisterMap().SetZeroBit();

            var reverseResult = ~(W.Value.GetRegisterMap().RegisterList[f].Value);

            if (d)
            {
                W.Value.GetRegisterMap().RegisterList[f].Value = reverseResult;
            }
            else
            {
                W.Value.Value = reverseResult;
            } 
        }
    }
}
