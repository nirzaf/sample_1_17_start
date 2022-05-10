using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sample_1_17 {
  public partial class Form1 : DevExpress.XtraEditors.XtraForm {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      leftGridSource.DataSource = new BindingList<ListItem> {
        new ListItem{Name="One", Category="Great"},
        new ListItem{Name="Two", Category="Enormous"},
        new ListItem{Name="Three", Category="Big"}
      };
    }
  }
}
