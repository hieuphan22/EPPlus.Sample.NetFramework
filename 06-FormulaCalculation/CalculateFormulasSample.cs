﻿/*************************************************************************************************
  Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/24/2020         Jan Källman & Mats Alm       Initial release EPPlus 5
 *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusSamples.FormulaCalculation
{
    /// <summary>
    /// Sample 17 demonstrates the formula calculation engine of EPPlus.
    /// </summary>
    static class CalculateFormulasSample
    {
        private static CalculateExistingWorkbook CalculateExistingWorkbook = new CalculateExistingWorkbook();

        private static BuildAndCalculateWorkbook BuildAndCalculateWorkbook = new BuildAndCalculateWorkbook();

        private static AddFormulaFunction AddFormulaFunction = new AddFormulaFunction();

        public static void Run()
        {
            CalculateExistingWorkbook.Run();
            BuildAndCalculateWorkbook.Run();
            AddFormulaFunction.Run();
        }

    }
}
