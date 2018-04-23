#Region "#InterfaceImpl"
Imports DevExpress.Xpf.Charts

Namespace CustomNumericMeasureUnitsCalculatorSample
    Friend Class NumericMeasureUnitsCalculator
        Implements INumericMeasureUnitsCalculator

        Public Function CalculateMeasureUnit(
                ByVal series As IEnumerable(Of Series),
                ByVal axisLength As Double,
                ByVal pixelsPerUnit As Integer,
                ByVal visualMin As Double,
                ByVal visualMax As Double,
                ByVal wholeMin As Double,
                ByVal wholeMax As Double) As Double Implements INumericMeasureUnitsCalculator.CalculateMeasureUnit
            Return Math.Max(1, Math.Ceiling((visualMax - visualMin) / 20.0))
        End Function
    End Class
End Namespace
#End Region '"#InterfaceImpl"