Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
            Dim tl As TreeList = TryCast(sender, TreeList)
            If e.Node.Equals(tl.FocusedNode) Then
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)
                Dim textSize As Size = e.Appearance.CalcTextSize(e.Cache, e.CellText, e.Bounds.Width).ToSize()
                Dim rect As New Rectangle(e.EditViewInfo.ContentRect.Left, e.EditViewInfo.ContentRect.Top, textSize.Width, textSize.Height)
                e.Cache.FillRectangle(SystemBrushes.Highlight, rect)
                e.Cache.DrawString(e.CellText, e.Appearance.Font, SystemBrushes.HighlightText, rect, e.Appearance.GetStringFormat())
                e.Handled = True
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            treeList1.OptionsBehavior.Editable = False
            treeList1.OptionsView.ShowColumns = False
            treeList1.OptionsView.ShowIndicator = False
            treeList1.OptionsView.ShowHorzLines = False
            treeList1.OptionsView.ShowVertLines = False

        End Sub
    End Class
End Namespace