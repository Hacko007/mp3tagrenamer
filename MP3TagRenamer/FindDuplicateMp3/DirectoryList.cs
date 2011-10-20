using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FindDuplicateMp3s.Properties;

namespace FindDuplicateMp3s
{
  public partial class DirectoryList : UserControl
  {
    private const string Separator = "##";

    public DirectoryList()
    {
      InitializeComponent();
      AddDirectory();
    }


    public ListDictionary SelectedFolders
    {
      get
      {
        var pathList = new ListDictionary();
        foreach (SearchedDirectory control in m_DirectoriesFlowLayoutPanel.Controls)
        {
          if (control.Path == null)
          {
            continue;
          }

          // Check for duplicate paths
          bool duplicate = false;
          foreach (DictionaryEntry entry in pathList)
          {
            if (control.IncludeSubDirectory)
            {
              // control.Path is parent
              if (IsSubdirectory(control.Path, (string) entry.Key))
              {
                pathList.Remove(entry.Key);
                break;
              }
            }

            if ((bool) entry.Value) // Incuded subdirectories
            {
              // we have a parent
              if (IsSubdirectory(entry.Key.ToString(), control.Path))
              {
                duplicate = true;
                break;
              }
            }
          }

          // Add if new path
          if (!duplicate && !pathList.Contains(control.Path))
          {
            pathList.Add(control.Path, control.IncludeSubDirectory);
          }
        }

        return pathList;
      }
    }

    public event EventHandler SelectedFoldersChanged;

    /// <summary>
    ///   Indicates if <paramref name = "subPath" /> is subdirectory of <paramref name = "parentPath" />.
    /// </summary>
    /// <param name = "parentPath"></param>
    /// <param name = "subPath"></param>
    /// <returns>true if <paramref name = "subPath" /> is subdirectory of <paramref name = "parentPath" />,
    ///   false otherwise</returns>
    private static bool IsSubdirectory(string parentPath, string subPath)
    {
      parentPath = parentPath.EndsWith("\\") ? parentPath.Substring(0, parentPath.Length - 1) : parentPath;
      subPath = subPath.EndsWith("\\") ? subPath.Substring(0, subPath.Length - 1) : subPath;

      return
        Directory.EnumerateDirectories(parentPath).Select(path => path != null ? path.ToLower() : null).Contains(
          subPath.ToLower());
    }


    private void OnAddSearchDirClick(object sender, EventArgs e)
    {
      AddDirectory();
    }

    private SearchedDirectory AddDirectory()
    {
      var dir = new SearchedDirectory();
      dir.PathChanged += OnPathChanged;
      dir.RemoveClicked += OnRemoveDirectoryClicked;
      m_DirectoriesFlowLayoutPanel.Controls.Add(dir);
      return dir;
    }

    private void OnPathChanged(object sender, EventArgs e)
    {
      InvokeSelectedFoldersChanged();
      SaveSettings();
    }

    public void InvokeSelectedFoldersChanged()
    {
      if (SelectedFoldersChanged != null)
      {
        SelectedFoldersChanged(this, EventArgs.Empty);
      }
    }

    private void OnRemoveDirectoryClicked(object sender, EventArgs e)
    {
      if (sender != null)
      {
        m_DirectoriesFlowLayoutPanel.Controls.Remove(sender as Control);
        InvokeSelectedFoldersChanged();
      }
    }

    public void OnLoad()
    {
      LoadSettings();
    }

    public void OnClosing()
    {
      SaveSettings();
    }


    private void LoadSettings()
    {
      try
      {
        var savedFolders = Settings.Default.SelectedFolders;
        if (savedFolders == null)
        {
          return;
        }
        m_DirectoriesFlowLayoutPanel.Controls.Clear();
        foreach (string boolAndPath in savedFolders)
        {
          var dirControl = AddDirectory();

          dirControl.IncludeSubDirectory = bool.Parse(boolAndPath.Substring(0, boolAndPath.IndexOf(Separator)));
          dirControl.Path = boolAndPath.Substring(boolAndPath.IndexOf(Separator) + Separator.Length);
        }
      }
      catch
      {
      }
    }

    private void SaveSettings()
    {
      try
      {
        Settings.Default.SelectedFolders = new StringCollection();
        foreach (DictionaryEntry selectedFolder in SelectedFolders)
        {
          Settings.Default.SelectedFolders.Add(selectedFolder.Value + Separator + selectedFolder.Key);
        }
        Settings.Default.Save();
      }
      catch
      {
      }
    }
  }

}