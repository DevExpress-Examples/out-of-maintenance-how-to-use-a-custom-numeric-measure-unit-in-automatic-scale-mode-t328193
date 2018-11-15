<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/CustomNumericMeasureUnitsCalculatorSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomNumericMeasureUnitsCalculatorSample/MainWindow.xaml))**
* [NumericMeasureUnitsCalculator.cs](./CS/CustomNumericMeasureUnitsCalculatorSample/NumericMeasureUnitsCalculator.cs) (VB: [NumericMeasureUnitsCalculator.vb](./VB/CustomNumericMeasureUnitsCalculatorSample/NumericMeasureUnitsCalculator.vb))
<!-- default file list end -->
# How to: use a custom numeric measure unit in Automatic scale mode


This example demonstrates how to specify a custom numeric measure unit in <strong>Automatic</strong> scale mode.


<h3>Description</h3>

To do this, assign an object of a class implementing the&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsINumericMeasureUnitsCalculatortopic">INumericMeasureUnitsCalculator</a>&nbsp;interface to the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticNumericScaleOptions_AutomaticMeasureUnitsCalculatortopic">AutomaticMeasureUnitsCalculator</a>&nbsp;property of an <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsAutomaticNumericScaleOptionstopic">AutomaticNumericScaleOptions</a>&nbsp;object assigned to <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_NumericScaleOptionstopic">AxisX2D.NumericScaleOptions</a>.

<br/>


