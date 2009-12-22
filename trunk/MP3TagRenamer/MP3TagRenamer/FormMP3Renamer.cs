using System;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace MP3TagRenamer
{
    public partial class MainForm : Form
    {
        private UserControlCompareDuplicates m_CompareDuplicates;
            
        public MainForm()
        {
            InitializeCulture();            
            InitializeComponent();
            InitializeLanguageMenu();
			SetRealRegExpLabel();
			ResetRegExpComboBox();
			m_UserControlBatchRenameFields.UpdateClicked += Button_UpdateBatch_Click;
			m_UserControlTrackList.BatchFieldsUpdated += UserControlTrackList_BatchFieldsUpdated;
			m_UserControlTrackList.TrackListRowEnter += UserControlTrackList_TrackListRowEnter;
        }
        private static void InitializeCulture()
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.LanguageUsed);               
            }
            catch { }
        }
        
        private void InitializeLanguageMenu()
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.LanguageUsed);
                englishToolStripMenuItem.Checked = false;
                svenskaToolStripMenuItem.Checked = false;
                bosniskaToolStripMenuItem.Checked = false;
                switch (Properties.Settings.Default.LanguageUsed)
                {
                    case "bs-Latn-BA":
                        bosniskaToolStripMenuItem.Checked = true;
                        break;
                    case "sv-SE":
                        svenskaToolStripMenuItem.Checked = true;
                        break;
                    default:
                        englishToolStripMenuItem.Checked = true;
                        break;
                }
            }
            catch { }
        }

		private void ResetRegExpComboBox()
		{
			string[] regExps = 
				new[]{	
					"#artist# - #tracknr# - #album# - #year# - #title#",
					"#artist# - #album# - #year# - #tracknr# - #title#",
					"#artist# - #tracknr# - #album# - #title#",
					"#artist# - #tracknr# - #title#",
					"#artist# - #title#",
					"#title#"};
			this.ComboBox_ExtractTagsFromFNmane.Items.AddRange(regExps);
			if (Properties.Settings.Default.RegExpHistoryList != null
				&& Properties.Settings.Default.RegExpHistoryList.Count > 0) {
					ComboBox_ExtractTagsFromFNmane.Items.Clear();
					ComboBox_ExtractTagsFromFNmane.Items.AddRange(Properties.Settings.Default.RegExpHistoryList.ToArray());
			}
		}
		

		void UserControlTrackList_TrackListRowEnter(object sender, EventArgs e)
		{
			my_label_ID3V1.Text = m_UserControlTrackList.ID3V1Text;
			my_label_ID3V2.Text = m_UserControlTrackList.ID3V2Text;
			TextBox_TestPath.Text = m_UserControlTrackList.SelectedTracksPath;
		}

		void UserControlTrackList_BatchFieldsUpdated(object sender, BatchFieldsInfo bachFieldsInfo)
		{
			m_UserControlBatchRenameFields.UpdateFields(bachFieldsInfo);
		}


        private void Button_fixTitle_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.FixTitle(my_textBox_fixTitle.Text);			
        }

        private void Button_removeText_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.RemoveText(my_textBox_removeText.Text);			
        }

        /// <summary>
        /// Set track number to all tracks in datagirdview by extracing it from 
        /// title or file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GetTrackNrFronTitle_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.GetTrackNrFronTitle();			
        }

        /// <summary>
        /// Clear all comments in all tracks in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ClearComments_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.ClearComments();			
        }

        private void Button_UpdateBatch_Click( object sender, EventArgs e )
        {
			m_UserControlTrackList.UpdateAllTracks(m_UserControlBatchRenameFields);		    			
        }


        private void About_Click( object sender, EventArgs e )
        {
            new FormAboutBox().ShowDialog(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.LastUsedPath = m_UserControlTrackList.ActualPath;
                if (Properties.Settings.Default.VisitedPaths == null)
                    Properties.Settings.Default.VisitedPaths = new System.Collections.Specialized.StringCollection();
				Properties.Settings.Default.VisitedPaths.AddRange(m_UserControlTrackList.VisitedPaths);

				ArrayList regExps = new ArrayList();
				//for (int i = 0; i < ComboBox_ExtractTagsFromFNmane.Items.Count; i++)
				//{
					regExps.AddRange(ComboBox_ExtractTagsFromFNmane.Items);
				//}
				Properties.Settings.Default.RegExpHistoryList = new ArrayList();
				Properties.Settings.Default.RegExpHistoryList.AddRange(regExps);

                Properties.Settings.Default.Save();
            }
            catch 
            {
                
            }
        }        

        #region Extracing info from file name    

		private void SetRealRegExpLabel()
		{
			m_LabelRealRexExpression.Text = "Real RegExp:" +  UserControlTrackList.GetRegExpFromInput(ComboBox_ExtractTagsFromFNmane.Text);
		}

		private void Button_ExtracFromFNameTEST_Click(object sender, EventArgs e)
		{
			SetRealRegExpLabel();
			Label_Regextpresult.Text = UserControlTrackList.ExtracFromFNameTest(ComboBox_ExtractTagsFromFNmane.Text, m_UserControlTrackList.SelectedTracksPath);
		}

        private void Button_ExtractFRomFName_Click( object sender , EventArgs e )
        {
			SetRealRegExpLabel();
			m_UserControlTrackList.ExtractFRomFName(ComboBox_ExtractTagsFromFNmane.Text);
        }

        #endregion


        #region ToolStripMenu Items Click Events
        private void ToolStripMenuItem_FindDuplicates_Click(object sender, EventArgs e)
        {

            this.toolStripContainer1.ContentPanel.Controls.Clear();
            if (m_CompareDuplicates == null)
                m_CompareDuplicates = new UserControlCompareDuplicates();
            this.toolStripContainer1.ContentPanel.Controls.Add(this.m_CompareDuplicates);
            m_CompareDuplicates.Dock = DockStyle.Fill;
        }

        private void ToolStripMenuItem_RenamingClick(object sender, EventArgs e)
        {
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(y_splitContainer_Main);
            My_TabControl_BatchRen.SelectedTab = m_TabPageRenaming;


        }
        private void BatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(y_splitContainer_Main);
            My_TabControl_BatchRen.SelectedTab = m_TabPageBatch;

        }
        #endregion ToolStripMenu Items Click Events


		private void Button_regexp_properties_Click(object sender, EventArgs e)
		{
			new MP3TagEditor.TrackInfoExtracingProperties().ShowDialog();
		}

		private void ComboBox_ExtractTagsFromFNmane_TextChanged(object sender, EventArgs e)
		{
			SetRealRegExpLabel();
		}

		private void ButtonAddRemovePressets_Click(object sender, EventArgs e)
		{
			FormComposePressets pressets = new FormComposePressets() { Path = TextBox_TestPath.Text };
			if (pressets.ShowDialog() == DialogResult.OK) {
				ComboBox_ExtractTagsFromFNmane.Items.Add(pressets.RegExp);
				ComboBox_ExtractTagsFromFNmane.SelectedItem = pressets.RegExp;
			}
		}

		private void ButtonSuggest_Click(object sender, EventArgs e)
		{

		}

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LanguageUsed = "en-GB";
            Properties.Settings.Default.Save();
            RestartApplication( );   
        }

        private void svenskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LanguageUsed = "sv-SE";
            Properties.Settings.Default.Save();
            RestartApplication( ); 
        }

        private void bosniskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LanguageUsed = "bs-Latn-BA";
            Properties.Settings.Default.Save();
            RestartApplication();              
        }

		
        private void RestartApplication( )
        {
            MessageBox.Show(this, "You need to restart application!", "Language change", MessageBoxButtons.OK);
        }

    }
}