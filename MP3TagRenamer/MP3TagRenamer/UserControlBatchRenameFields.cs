using System;
using System.Windows.Forms;

namespace Mp3TagEditor.UI
{
	public partial class UserControlBatchRenameFields : UserControl
	{
		public event EventHandler UpdateClicked;

		public bool UpdateAlbum { get { return m_CheckBoxAlbum.Checked; } }
		public bool UpdateArtist { get { return m_CheckBoxArtist.Checked; } }
		public bool UpdateGanre { get { return m_CheckBoxGanre.Checked; } }
		public bool UpdateYear { get { return m_CheckBoxYear.Checked; } }

		public string Album { get { return m_TextBoxAlbum.Text; } set { m_TextBoxAlbum.Text = value; } }
		public string Artist { get { return m_TextBoxArtist.Text; } set { m_TextBoxArtist.Text = value; } }
		public string Ganre 
		{
			get { return m_ComboBoxGanre.Text; } 
			set { m_ComboBoxGanre.Text= value; } 
		}
		public short? Year 
		{ 
			get 
			{
				if (string.IsNullOrEmpty(m_TextBoxYear.Text.Trim()))
					return (short?)null;
				else
				{
					short y;
					if (short.TryParse(m_TextBoxYear.Text, out y)) {
						return y;
					}
					else
					{
						return (short?)null;
					}
				}
			} 
			set { m_TextBoxYear.Text = value.ToString(); } 
		}
		
		public string YearText
		{
			set { m_TextBoxYear.Text = value; }
		}

		public UserControlBatchRenameFields()
		{
			InitializeComponent();
		}

		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			if (UpdateClicked != null)
			{
				UpdateClicked(this, e);
			}

		}

		internal void UpdateFields(BatchFieldsInfo bachFieldsInfo)
		{
			Album = bachFieldsInfo.Album;
			Artist = bachFieldsInfo.Artist;
			Ganre = bachFieldsInfo.Ganre;
			YearText = bachFieldsInfo.Year;
		}
	}

	public struct BatchFieldsInfo
	{
		public string Album { get; set; }
		public string Artist { get; set; }
		public string Ganre { get; set; }
		public string Year { get; set; }
	}

}
