using System;
using System.Windows.Forms;

namespace FindDuplicateMp3s
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void OnLoad( object sender, EventArgs e )
    {
      findDuplicates1.OnLoad();
    }

    private void OnFormClosing( object sender, FormClosingEventArgs e )
    {
      findDuplicates1.OnClosing();
    }
  }
}
