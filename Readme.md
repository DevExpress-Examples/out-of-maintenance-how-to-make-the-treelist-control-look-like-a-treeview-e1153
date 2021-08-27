<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637933/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1153)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to make the TreeList control look like a TreeView

<p><strong>Important note.</strong></p>
<p>The TreeList control provides support for a TreeView visual style, in which the control mimics the appearance of the .NET standard TreeView control. Starting from version 17.2, the TreeView visual style can be enabled using the single setting - TreeList.ViewStyle.

  ## ***If the built-in [ViewStyle](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ViewStyle.property) setting does not suit you, we will be happy to find the most appropriate solution for you if you describe your real-life scenario. Just click   [here](https://www.devexpress.com/Support/Center/Question/Create) to submit a ticket to our Support Center.***
In versions prior to 17.2, you can emulate the TreeView visual style as follows
  
* Hide column headers (set OptionsView.ShowColumns to False).
* Hide the indicator panel (set OptionsView.ShowIndicator to False).
* Hide the horizontal and vertical lines between cells (set OptionsView.ShowHorzLines and OptionsView.ShowVertLines to False).</p>
