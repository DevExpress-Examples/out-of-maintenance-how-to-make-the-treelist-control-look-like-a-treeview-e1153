using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_example {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            treeList1.ForceInitialize();

            treeList1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText;
            treeList1.OptionsBehavior.Editable = false;

            treeList1.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
        }
    }
}
