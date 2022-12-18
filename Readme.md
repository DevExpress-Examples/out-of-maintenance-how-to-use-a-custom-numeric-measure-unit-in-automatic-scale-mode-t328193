<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570255/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328193)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


