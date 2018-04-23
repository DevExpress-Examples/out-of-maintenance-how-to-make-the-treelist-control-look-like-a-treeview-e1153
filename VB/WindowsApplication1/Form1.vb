Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraTreeList

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			Dim tl As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			If e.Node Is tl.FocusedNode Then
				e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)
				Dim R As New Rectangle(e.EditViewInfo.ContentRect.Left, e.EditViewInfo.ContentRect.Top, Convert.ToInt32(e.Graphics.MeasureString(e.CellText, e.Appearance.Font).Width-2), e.Appearance.FontHeight)
				e.Graphics.FillRectangle(SystemBrushes.Highlight, R)
				e.Graphics.DrawString(e.CellText, e.Appearance.Font, SystemBrushes.HighlightText, R, e.Appearance.GetStringFormat())
				e.Handled = True
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			treeList1.OptionsBehavior.Editable = False
			treeList1.OptionsView.ShowColumns = False
			treeList1.OptionsView.ShowIndicator = False
			treeList1.OptionsView.ShowHorzLines = False
			treeList1.OptionsView.ShowVertLines = False

		End Sub
	End Class
End Namespace