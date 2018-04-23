Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace CustomNumericMeasureUnitsCalculatorSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            DataContext = GenerateData(10000)
        End Sub

        Private Function GenerateData(ByVal count As Integer) As List(Of DataPoint)
            Dim points As New List(Of DataPoint)(count)
            Dim generator As New Random()
            For i As Integer = 0 To count - 1
                points.Add(New DataPoint With {.X = i, .Y = generator.NextDouble()})
            Next i
            Return points
        End Function
    End Class

    Public Class DataPoint
        Public Property X() As Double
        Public Property Y() As Double
    End Class
End Namespace
