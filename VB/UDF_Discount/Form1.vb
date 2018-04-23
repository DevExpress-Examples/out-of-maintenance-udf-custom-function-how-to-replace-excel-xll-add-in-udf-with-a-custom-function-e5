Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace UDF_Discount
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
'			#Region "#AddFunction"
			Dim udfFunction As New DiscountFunction()
			If (Not spreadsheetControl1.Document.CustomFunctions.Contains(udfFunction.Name)) Then
				spreadsheetControl1.Document.CustomFunctions.Add(udfFunction)
			End If
'			#End Region ' #AddFunction

			AddHandler spreadsheetControl1.DocumentLoaded, AddressOf spreadsheetControl1_DocumentLoaded
			spreadsheetControl1.LoadDocument("Discount.xlsx")

		End Sub

		Private Sub spreadsheetControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
'			#Region "#GetExistingCells"
			Dim existingCells As IEnumerable(Of DevExpress.Spreadsheet.Cell) = spreadsheetControl1.ActiveWorksheet.GetExistingCells()
			spreadsheetControl1.Document.BeginUpdate()
			For Each cell As DevExpress.Spreadsheet.Cell In existingCells
				If cell.HasFormula Then
					' The worksheet references functions from the DiscountXLL.MyFunctions xll Add-in. 
					' The name prefix is removed leaving only the function name.
					cell.Formula = cell.Formula.Replace("_xll.DiscountXLL.MyFunctions.", String.Empty)
				End If
			Next cell
			spreadsheetControl1.Document.EndUpdate()
'			#End Region ' #GetExistingCells 
			spreadsheetControl1.ActiveWorksheet.ScrollToRow(0)
		End Sub
	End Class
End Namespace
