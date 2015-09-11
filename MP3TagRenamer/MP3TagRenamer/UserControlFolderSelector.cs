using System;
using System.IO;
using System.Windows.Forms;

namespace Mp3TagEditor.UI
{
    public delegate void ActuelPathChangedHandler(object obj, string path);

	public partial class UserControlFolderSelector : UserControl
	{
		private System.Collections.Hashtable m_VisitedDirsPaths;

		public event ActuelPathChangedHandler ActualPathCahnged;

		public UserControlFolderSelector()
		{
			InitializeComponent();
			m_VisitedDirsPaths = new System.Collections.Hashtable();
			m_ActivPath = "";

			/// 
			/// Load user preferencies
			/// 
			try
			{
				if (string.IsNullOrEmpty(  Properties.Settings.Default.LastUsedPath ) == false
					&& new DirectoryInfo(Properties.Settings.Default.LastUsedPath).Exists)
				{
					ActualPath = Properties.Settings.Default.LastUsedPath;
				}

                if (Properties.Settings.Default.VisitedPaths != null
                    && Properties.Settings.Default.VisitedPaths.Count > 0)
				{
					int i = 0;
					string[] paths = new string[Properties.Settings.Default.VisitedPaths.Count];
					foreach (string path in Properties.Settings.Default.VisitedPaths)
					{
						paths[i++] = path;
					}
					Paths = paths;
				}
			}
			catch { }
		}


		protected void OnActualPathCahnged(string path)
		{
			if (ActualPathCahnged != null)
			{
				ActualPathCahnged(this, path);
			}
		}


		private void ComboBox_Folder_DropDownClosed(object sender, EventArgs e)
		{
			if (my_comboBox_Folder.SelectedIndex > -1
			  && my_comboBox_Folder.SelectedItem.ToString() != m_ActivPath)
			{
				ActualPath = my_comboBox_Folder.SelectedItem.ToString();
			}

		}

		private void ComboBox_Folder_TextChanged(object sender, EventArgs e)
		{
			if (Directory.Exists(my_comboBox_Folder.Text))
			{


			}
			else
			{


				if (my_comboBox_Folder.Text.LastIndexOf("\\") > 0 &&
					Directory.Exists(my_comboBox_Folder.Text.Substring(0, my_comboBox_Folder.Text.LastIndexOf("\\"))))
				{

					string path = my_comboBox_Folder.Text.Substring(0, my_comboBox_Folder.Text.LastIndexOf("\\"));
					string writtenStr = my_comboBox_Folder.Text.Substring(path.Length);

					/// Remeber selection
					int selStart = my_comboBox_Folder.SelectionStart;
					int selLen = my_comboBox_Folder.SelectionLength;

					my_comboBox_Folder.Items.Clear();
					my_comboBox_Folder.Items.Add(path);
					foreach (string subPath in Directory.GetDirectories(path))
					{
						if (subPath.Contains(path + writtenStr))
						{
							my_comboBox_Folder.Items.Add(subPath);
						}
					}
					my_comboBox_Folder.DroppedDown = true;

					my_comboBox_Folder.SelectionStart = selStart;
					my_comboBox_Folder.SelectionLength = selLen;
				}

			}
		}

		private void Button_Browse_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(m_ActivPath)
				&& new DirectoryInfo(m_ActivPath).Exists)
			{
				my_folderBrowserDialog.SelectedPath = m_ActivPath;
			}

			if (my_folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				my_comboBox_Folder.Text = my_folderBrowserDialog.SelectedPath;
				if (m_ActivPath != my_folderBrowserDialog.SelectedPath)
				{
					ActualPath = my_folderBrowserDialog.SelectedPath;
					//this.OnActualPathCahnged(_activ_path);
				}
			}


		}


		private string m_ActivPath;

		/// <summary>
		/// Gets or Sets activ path
		/// </summary>
		public string ActualPath
		{
			get { return m_ActivPath; }
			set
			{
				try
				{
					if (!Directory.Exists(value)) return;

					m_ActivPath = value;
					if (m_ActivPath != null
						&& !my_comboBox_Folder.Items.Contains(m_ActivPath))
					{
						my_comboBox_Folder.Items.Add(m_ActivPath);
					}

					my_comboBox_Folder.SelectedItem = m_ActivPath;

					if (m_ActivPath != null && !m_VisitedDirsPaths.Contains(m_ActivPath))
					{
						m_VisitedDirsPaths.Add(m_ActivPath, m_ActivPath);
					}

					OnActualPathCahnged(m_ActivPath);
				}
				catch { }
			}
		}
		
		public bool ActualPathExists
		{
			get 
			{
				return Directory.Exists(ActualPath);
			}
		}

		/// <summary>
		/// Gets list with all used paths in history
		/// </summary>
		public string[] Paths
		{
			get
			{
				try
				{
					if (m_ActivPath != null && !m_VisitedDirsPaths.ContainsKey(m_ActivPath))
					{
						m_VisitedDirsPaths.Add(m_ActivPath, m_ActivPath);
					}

					int c = 0;
					string[] paths = new string[m_VisitedDirsPaths.Count];
					foreach (string path in m_VisitedDirsPaths.Keys)
					{
						paths[c++] = path;
					}
					return paths;
				}
				catch
				{
					return null;
				}
			}

			set
			{
				try
				{
					string[] paths = value;
					my_comboBox_Folder.Items.Clear();
					if (paths == null) return;

					my_comboBox_Folder.Items.AddRange(paths);

					m_VisitedDirsPaths = new System.Collections.Hashtable();

					for (int i = 0; i < Math.Min(20, paths.Length); i++)
					{
						if (m_VisitedDirsPaths.ContainsKey(m_ActivPath) == false)
						{
							m_VisitedDirsPaths.Add(m_ActivPath, m_ActivPath);
						}
					}
				}
				catch { }
			}

		}

		private void ComboBoxFolder_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (my_comboBox_Folder.SelectedIndex > -1
			 && my_comboBox_Folder.SelectedItem.ToString() != m_ActivPath)
			{
				//ActualPath = my_comboBox_Folder.SelectedItem.ToString();
			}
		}

		private void ComboBoxFolder_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
			{
				ActualPath = my_comboBox_Folder.Text;
				if (ActualPathExists) {
					OnActualPathCahnged(ActualPath);
				}
			}
		}

	}
}
