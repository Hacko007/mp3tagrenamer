using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mp3TagEditor.UI
{
	public partial class FormComposePressets : Form
	{
		
		private MovableButton MovingButton;
		public FormComposePressets()
		{
			InitializeComponent();
			buttonAlbum.Tag = UserControlTrackList.RE_ALBUM;
			buttonArtist.Tag = UserControlTrackList.RE_ARTIS;
			buttonYear.Tag = UserControlTrackList.RE_YEAR;
			buttonTitle.Tag = UserControlTrackList.RE_TITLE;
			buttonTrackNr.Tag = UserControlTrackList.RE_TRACKNR;			
			buttonSeparator.Tag = " - ";
			buttonFolderSeparator.Tag = @"\\";
			
		}

		public string Path
		{
			get { return textBoxPath.Text; }
			set { textBoxPath.Text = value; }
		}
		public string RegExp
		{
			get { return textBoxResult.Text; }
			set { textBoxResult.Text = value; }
		}

		private void FlowLayoutPanel_DragDrop(object sender, DragEventArgs e)
		{
			MovableButton mb = e.Data.GetData(typeof(MovableButton)) as MovableButton;
			if (mb != null) {
				mb = new MovableButton() { Text = mb.Text, Tag = mb.Tag };
				mb.MouseDown += new MouseEventHandler(InsideButton_MouseDown);
				Point p = this.m_FlowLayoutPanel.PointToClient(new Point(e.X, e.Y));
				Control buttonBefore = this.m_FlowLayoutPanel.GetChildAtPoint( p );
				if (buttonBefore == null)
				{
					m_FlowLayoutPanel.Controls.Add(mb);
				}
				else
				{
					int index = m_FlowLayoutPanel.Controls.IndexOf(buttonBefore);
					Console.WriteLine(index);
					m_FlowLayoutPanel.Controls.Add(mb);
					m_FlowLayoutPanel.Controls.SetChildIndex(mb, index );
					m_FlowLayoutPanel.Controls.SetChildIndex(buttonBefore, index + 1);					
				}
			}
		}


		private void FlowLayoutPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(MovableButton)))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		

		private void FlowLayoutPanel_DragLeave(object sender, EventArgs e)
		{
			if (ButtonExistsInPanel(MovingButton)) {
				m_FlowLayoutPanel.Controls.Remove(MovingButton);
			}
		}

		
		private bool ButtonExistsInPanel(MovableButton button) 
		{
			if (button == null) return false;

			foreach (Control item in m_FlowLayoutPanel.Controls)
			{
				MovableButton mb = item as MovableButton;
				if (mb == null) continue;

				if (button.Text.Equals(mb.Text)) {
					return true;
				}
			}
			return false;
		}

		private void FlowLayoutPanel_MouseDown(object sender, MouseEventArgs e)
		{
			MovingButton = null;
		}

		void InsideButton_MouseDown(object sender, MouseEventArgs e)
		{
			MovingButton = sender as MovableButton;
		}

		private void ButtonTag_Click(object sender, EventArgs e)
		{
			MovableButton mb = sender as MovableButton;
			if (mb != null) {
				mb = new MovableButton() { Text = mb.Text, Tag = mb.Tag };
				mb.MouseDown += new MouseEventHandler(InsideButton_MouseDown);
				m_FlowLayoutPanel.Controls.Add(mb);
			}		
		}

		private void ButtonClear_Click(object sender, EventArgs e)
		{
			m_FlowLayoutPanel.Controls.Clear();
		}

		private void FlowLayoutPanel_ControlChange(object sender, ControlEventArgs e)
		{
			textBoxResult.Text = "";
			foreach (Control item in m_FlowLayoutPanel.Controls)
			{
				MovableButton mb = item as MovableButton;
				if (mb != null && mb.Tag != null) {
					textBoxResult.Text += mb.Tag.ToString();
				}
			}			
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void buttonTest_Click(object sender, EventArgs e)
		{
			labelTest.Text = UserControlTrackList.ExtracFromFNameTest(textBoxResult.Text, Path);
		}


	}
}
