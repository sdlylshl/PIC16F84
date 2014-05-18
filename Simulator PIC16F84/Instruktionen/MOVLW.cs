﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84.Instruktionen
{
    public class MOVLW : BaseOperation
    {
        //MOVLW              Move Literal to W
        //--------------------------------------
        //Syntax:           [label] MOVLW k
        //Operands:         0 <= k <= 255
        //Operation:        k -> (W)
        //Status Affected:  None
        //Description:      The eight-bit literal ’k’ is loaded
        //                  into W register. The don’t cares
        //                  will assemble as 0’s.

        public MOVLW(byte k, WorkingRegister W, RegisterFileMap Reg) : base(Reg)
        {
            this.k = k;

            execute(W);
        }

        protected void execute(WorkingRegister W)
        {
            W.Value.Value = k;
        }

        protected override void execute(WorkingRegister W, RegisterFileMap Reg)
        {
            throw new NotImplementedException();
        }
    }
}
