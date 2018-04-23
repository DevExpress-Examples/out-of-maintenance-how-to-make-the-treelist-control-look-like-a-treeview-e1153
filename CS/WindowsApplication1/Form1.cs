using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTreeList;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

        private void treeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e) {
            TreeList tl = sender as TreeList;
            if (e.Node == tl.FocusedNode) {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                Size textSize = e.Appearance.CalcTextSize(e.Cache, e.CellText, e.Bounds.Width).ToSize();
                Rectangle rect = new Rectangle(e.EditViewInfo.ContentRect.Left,
                    e.EditViewInfo.ContentRect.Top, textSize.Width, textSize.Height);
                e.Cache.FillRectangle(SystemBrushes.Highlight, rect);
                e.Cache.DrawString(e.CellText, e.Appearance.Font, SystemBrushes.HighlightText, rect, e.Appearance.GetStringFormat());
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