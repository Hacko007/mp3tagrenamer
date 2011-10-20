using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FindDuplicateMp3s
{
  public partial class SearchedDirectory : UserControl
  {
    public SearchedDirectory()
    {
      InitializeComponent();
    }

    public string Path
    {
      get
      {
        string path = m_TextBoxPath.Text.Length > 3 && m_TextBoxPath.Text.EndsWith("\\")
                        ? m_TextBoxPath.Text.Substring(0, m_TextBoxPath.Text.Length - 1)
                        : m_TextBoxPath.Text;

        return !string.IsNullOrWhiteSpace(path) && Directory.Exists(path)
                 ? path
                 : null;
      }
      set
      {
        m_TextBoxPath.Text = value;
        InvokePathChanged();
      }
    }

    public bool IncludeSubDirectory
    {
      get { return m_CheckBoxIncludSubSirectories.Checked; }
      set { m_CheckBoxIncludSubSirectories.Checked = value; }
    }

    public event EventHandler PathChanged;

    public event EventHandler RemoveClicked;


    public void InvokePathChanged()
    {
      if (PathChanged != null)
      {
        PathChanged(this, EventArgs.Empty);
      }
    }

    private void OnRemoveClick(object sender, EventArgs e)
    {
      if (RemoveClicked != null)
      {
        RemoveClicked(this, e);
      }
    }

    private void OnBrowseClick(object sender, EventArgs e)
    {
      m_FolderBrowserDialog.SelectedPath = Path;
      if (m_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        Path = m_FolderBrowserDialog.SelectedPath;
      }
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
      Validate(false);
      InvokePathChanged();
    }

    private void OnPathValidating(object sender, CancelEventArgs e)
    {
      m_ErrorProvider.SetError(m_TextBoxPath, "");
      if (!string.IsNullOrWhiteSpace(m_TextBoxPath.Text) && !Directory.Exists(m_TextBoxPath.Text))
      {
        m_ErrorProvider.SetError(m_TextBoxPath, "Directory do not exists");
      }
    }

    public override string ToString()
    {
      return IncludeSubDirectory + "##" + Path;
    }

    private void OnCheckedChanged(object sender, EventArgs e)
    {
      InvokePathChanged();
    }
  }
}