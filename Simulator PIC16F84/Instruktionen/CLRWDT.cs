﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_PIC16F84.Instruktionen
{
    public class CLRWDT
    {
        //CLRWDT Clear Watchdog Timer
        //Syntax: [ label ] CLRWDT
        //Operands: None
        //Operation: 00h → WDT
        //0 → WDT prescaler,
        //1 → TO
        //1 → PD
        //Status Affected: TO, PD
        //Description: CLRWDT instruction resets the 
        //Watchdog Timer. It also resets the 
        //prescaler of the WDT. Status bits 
        //TO and PD are set.

        public CLRWDT()
        {
            //TODO
        }
    }
}