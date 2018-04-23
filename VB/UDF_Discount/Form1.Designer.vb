Imports Microsoft.VisualBasic
Imports System
Namespace UDF_Discount
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
			Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 25)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Size = New System.Drawing.Size(1040, 568)
			Me.spreadsheetControl1.TabIndex = 0
			' 
			' spreadsheetFormulaBarControl1
			' 
			Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
			Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(890, 20)
			Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBarControl1.TabIndex = 0
			' 
			' spreadsheetNameBoxControl1
			' 
			Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetNameBoxControl1.EditValue = "A1"
			Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
			Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 20)
			Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetNameBoxControl1.TabIndex = 0
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
			Me.splitContainerControl1.Size = New System.Drawing.Size(1040, 20)
			Me.splitContainerControl1.SplitterPosition = 145
			Me.splitContainerControl1.TabIndex = 2
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(0, 20)
			Me.splitterControl1.MinSize = 20
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(1040, 5)
			Me.splitterControl1.TabIndex = 1
			Me.splitterControl1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1040, 593)
			Me.Controls.Add(Me.spreadsheetControl1)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
		Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
	End Class
End Namespace

