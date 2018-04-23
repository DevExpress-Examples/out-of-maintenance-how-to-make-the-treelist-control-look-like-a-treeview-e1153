using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.XtraTreeList;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
			DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;
			if(e.Node == tl.FocusedNode) {
				e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
				Rectangle R = new Rectangle(e.EditViewInfo.ContentRect.Left, e.EditViewInfo.ContentRect.Top, Convert.ToInt32(e.Graphics.MeasureString(e.CellText, e.Appearance.Font).Width-2), e.Appearance.FontHeight);
				e.Graphics.FillRectangle(SystemBrushes.Highlight, R);
				e.Graphics.DrawString(e.CellText, e.Appearance.Font, SystemBrushes.HighlightText, R, e.Appearance.GetStringFormat());
				e.Handled = true;
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			treeList1.OptionsBehavior.Editable = false;
			treeList1.OptionsView.ShowColumns = false;
			treeList1.OptionsView.ShowIndicator = false;
			treeList1.OptionsView.ShowHorzLines = false;
			treeList1.OptionsView.ShowVertLines = false;
			
		}
	}
}