﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84
{
    /// <summary>
    /// Instruction Set Basisklasse
    /// </summary>
    public abstract class BaseOperation
    {
        /// <summary>
        /// Register file address (0x00 to 0x7F)
        /// </summary>
        protected RegisterByte f;

                /// <summary>
        /// Working register (accumulator)
        /// </summary>
        protected WorkingRegister W;

        /// <summary>
        /// /Bit address within an 8-bit file register
        /// </summary>
        protected RegisterByte b;

        /// <summary>
        /// Literal field, constant data or label
        /// </summary>
        protected int k;

        /// <summary>
        /// Destination select;
        /// d = 0:store result in W
        /// d = 1: store result in file register f.
        /// Default is d = 1
        /// </summary>
        protected bool d;

        /// <summary>
        /// Program Counter
        /// </summary>
        protected ProgramCounter PC;

        /// <summary>
        /// Time-out bit
        /// </summary>
        protected bool TO;

        /// <summary>
        /// Power-down bit
        /// </summary>
        protected bool PD;

        public BaseOperation(RegisterByte f = null, WorkingRegister W = null, RegisterByte b = null, int k = 0, bool d = true, ProgramCounter PC = null, bool TO = false, bool PD = false)
        {
            this.f = f;
            this.W = W;
            this.b = b;
            this.k = k;
            this.d = d;
            this.PC = PC;
            this.TO = TO;
            this.PD = PD;
        }
    }
}