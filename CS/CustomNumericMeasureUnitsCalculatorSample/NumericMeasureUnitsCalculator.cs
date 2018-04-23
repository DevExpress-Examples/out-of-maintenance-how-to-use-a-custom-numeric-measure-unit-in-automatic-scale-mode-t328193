#region #InterfaceImpl
using DevExpress.Xpf.Charts;
using System;
using System.Collections.Generic;

namespace CustomNumericMeasureUnitsCalculatorSample {
    class NumericMeasureUnitsCalculator : INumericMeasureUnitsCalculator {
        public double CalculateMeasureUnit(
                IEnumerable<Series> series,
                double axisLength,
                int pixelsPerUnit,
                double visualMin,
                double visualMax,
                double wholeMin,
                double wholeMax) {
            return Math.Max(1, Math.Ceiling((visualMax - visualMin) / 20.0));
        }
    }
}
#endregion #InterfaceImpl