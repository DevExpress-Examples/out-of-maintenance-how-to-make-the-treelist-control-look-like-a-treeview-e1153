
# How to make the TreeList control look like a TreeView

The TreeList control provides support for a TreeView visual style, in which the control mimics the appearance of the .NET standard TreeView control. Starting from version **17.2**, the TreeView visual style can be enabled using the single setting - [ViewStyle](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ViewStyle.property).
## _**If you still prefer the custom approach described below, please clarify why the built-in solution is not suitable for you. Just click  [here](https://www.devexpress.com/Support/Center/Question/Create)  to submit a ticket to our Support Center.**_
In versions prior to 17.2, you can emulate the TreeView visual style as follows

* Hide column headers (set [OptionsView.ShowColumns](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsView.ShowColumns.property) to False).
* Hide the indicator panel (set [OptionsView.ShowIndicator](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsView.ShowIndicator.property) to False).
* Hide the horizontal and vertical lines between cells (set [OptionsView.ShowHorzLines](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsView.ShowHorzLines.property) and [OptionsView.ShowVertLines](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsView.ShowVertLines.property) to False).
