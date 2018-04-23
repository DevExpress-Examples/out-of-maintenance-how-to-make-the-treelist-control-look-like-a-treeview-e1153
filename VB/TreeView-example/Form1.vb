Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace TreeView_example
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            treeList1.ForceInitialize()

            treeList1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight
            treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText
            treeList1.OptionsBehavior.Editable = False

            treeList1.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView
        End Sub
    End Class
End Namespace
