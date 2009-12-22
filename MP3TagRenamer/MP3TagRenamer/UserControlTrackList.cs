﻿using System;
using System.Windows.Forms;
using HundredMilesSoftware.UltraID3Lib;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace MP3TagRenamer
{
	public partial class UserControlTrackList : UserControl
	{
		public delegate void BatchFieldsInfoHandler(object sender, BatchFieldsInfo bachFieldsInfo);
		public event BatchFieldsInfoHandler BatchFieldsUpdated;
		public event EventHandler TrackListRowEnter;

		public UserControlTrackList()
		{
			InitializeComponent();
			m_DataGridViewTrackList.DataError += DataGridViewTrackList_DataError;
			m_VisitedDirsPaths = new Hashtable();
			m_UserControlFolderSelector.ActualPathCahnged += FolderSelector_ActualPathCahnged;
		}


		public string ID3V1Text { get; set; }
		public string ID3V2Text { get; set; }
		public string SelectedTracksPath { get; set; }
        
        public string ActualPath
        {
            get
            {
                if (m_UserControlFolderSelector == null) return "";
                return m_UserControlFolderSelector.ActualPath;
            }
        }

        public string[] VisitedPaths
        {
            get
            {
                if (m_UserControlFolderSelector == null) return new string[] { "" };
                return m_UserControlFolderSelector.Paths;
            }
        }


		public void FixTitle(string title)
		{
			if (title.Length == 0) return;

			Regex regExp = new Regex(title);

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					uid3.Title = regExp.Replace(uid3.Title, "");

					uid3.Write();
				}
				catch { }

			}
			m_DataGridViewTrackList.Refresh();
		}

		public void RemoveText(string text)
		{
			if (text.Length == 0) return;

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					uid3.Comments = uid3.Comments.Replace(text, "");
					uid3.Title = uid3.Title.Replace(text, "");

					uid3.Write();
				}
				catch { }

			}
			m_DataGridViewTrackList.Refresh();
		}


		/// <summary>
		/// Set track number to all tracks in datagirdview by extracing it from 
		/// title or file name
		/// </summary>		
		public void GetTrackNrFronTitle()
		{
			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{

				/// TODO: Remove year first
				try
				{
					short trackNr = -1;

					string titleVal = GetTrackNr(uid3.Title);

					if (titleVal == "")
					{
						/// 
						/// Didn't found it in title
						/// try in file name
						/// 
						FileInfo fi = new FileInfo(uid3.FileName);
						string fname = fi.Name.Replace(".mp3", "").Replace(".MP3", "");

						titleVal = GetTrackNr(fname);
					}


					if (titleVal != "" && short.TryParse(titleVal, out trackNr))
					{
						if (trackNr > -1)
						{
							/// Write result to track
							uid3.TrackNum = trackNr;
							uid3.ID3v1Tag.SetTrackNum(titleVal);
							uid3.ID3v2Tag.SetTrackNum(titleVal);
							uid3.Write();
						}
					}

				}
				catch { }
			}
			m_DataGridViewTrackList.Refresh();
		}

        /// <summary>
        /// Get Track number from input string. 
        /// It takes first string that contains 1 or 2 digits and raturns it.
        /// If nothing is found empty string is returnd
        /// </summary>
        /// <param name="titelOrFname">Title or File name</param>
        /// <returns>returns first string that contains 1 or 2 digits.
        /// If nothing is found empty string is returnd</returns>
        private static string GetTrackNr( string titelOrFname )
        {

            string val = "";

            Regex rx
                       = new Regex( @"\d{1,4}",
                       System.Text.RegularExpressions.RegexOptions.Singleline );

            MatchCollection matchs = rx.Matches( titelOrFname );

            if( matchs.Count > 0 )
            {

                /// skip year


                if( matchs.Count > 1 &&
                    matchs[0].Value.Length > 2 &&
                    matchs[1].Value.Length < 3 )
                {
                    val = matchs[1].Value;

                } else if( ( matchs.Count == 1 ) ||
                    ( matchs.Count > 1 &&
                    matchs[0].Value.Length < 3 &&
                    matchs[1].Value.Length > 2 ) )
                {
                    val = matchs[0].Value;
                }

            }

            return val;
        }
		public delegate void EmptyMethodCaller();

		/// <summary>
		/// Clear all comments in all tracks in datagridview
		/// </summary>
		public void ClearComments()
		{
			EmptyMethodCaller asyncMethod = new EmptyMethodCaller(ClearCommentsAsync);
			asyncMethod.BeginInvoke(new AsyncCallback(RefreshDataGrid), asyncMethod);
		}
		/// <summary>
		/// Clear all comments in all tracks in datagridview
		/// </summary>		
		private void ClearCommentsAsync()
		{
            lock(m_BindingSourceUltraID3.SyncRoot)
            {
				foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
				{
					try
					{
						uid3.Comments = "";
						uid3.ID3v1Tag.Comments = "";
						uid3.ID3v2Tag.Comments = "";
						uid3.Write();
					}
					catch { }
				}
			}
		}

		private void RefreshDataGrid(IAsyncResult ar)
		{
			EmptyMethodCaller emptyMethodCaller = (EmptyMethodCaller)ar.AsyncState;
			emptyMethodCaller.EndInvoke(ar);
			SafeRefreshDataGrid();
		}

		private void SafeRefreshDataGrid()
		{
			if (m_DataGridViewTrackList.InvokeRequired)
			{				
				this.Invoke(new EmptyMethodCaller(SafeRefreshDataGrid));
			}
			else
			{
				m_DataGridViewTrackList.Refresh();
			}
		}

		public void UpdateAllTracks(UserControlBatchRenameFields renameFields)
		{
			bool udateAlbum = renameFields.UpdateAlbum;
			string albumText = renameFields.Album;

			bool updateArtist = renameFields.UpdateArtist;
			string artistText = renameFields.Artist;

			bool updateGanre = renameFields.UpdateGanre;
			string ganreText = renameFields.Ganre;

			bool upateYear = renameFields.UpdateYear;
			short? year = renameFields.Year;

			foreach (UltraID3 uid3 in m_BindingSourceUltraID3)
			{
				try
				{
					if (udateAlbum)
					{
						uid3.Album = albumText;
						uid3.ID3v1Tag.Album = albumText;
						uid3.ID3v2Tag.Album = albumText;
					}
					if (updateArtist)
					{
						uid3.Artist = artistText;
						uid3.ID3v1Tag.Artist = artistText;
						uid3.ID3v2Tag.Artist = artistText;
					}

					if (updateGanre)
					{
						 try
                        {
                             uid3.Genre = ganreText;
                        }catch { }
                        try
                        {
                            uid3.ID3v1Tag.SetGenre(ganreText);
                        }catch{}
						 try
                        {
                             uid3.ID3v2Tag.Genre = ganreText;
                        }
                         catch { }
					}

					if (upateYear)
					{
						uid3.Year = year;
						uid3.ID3v1Tag.Year = year;
						uid3.ID3v2Tag.Year = year;
					}

					uid3.Write();
				}
				catch { }

			}

			m_DataGridViewTrackList.Refresh();
		}



		void FolderSelector_ActualPathCahnged(object o, string path)
		{
			this.m_ActivePath = path;
			this.FillDataGrid();
		}


		private void FillDataGrid()
		{
			EmptyMethodCaller asyncMethod = FillDataGridAsync;
			asyncMethod.BeginInvoke(RefreshDataGrid, asyncMethod);
		}
	

		private void FillDataGridAsync()
		{
			if (m_DataGridViewTrackList.InvokeRequired)
			{
				this.Invoke(new EmptyMethodCaller(FillDataGridAsync));
				return;
			}
			
			try
			{
				batchCounting_Artist = new Hashtable();
				batchCounting_Album = new Hashtable();
				batchCounting_Ganre = new Hashtable();
				batchCounting_Year = new Hashtable();

				if (Directory.Exists(m_ActivePath))
				{
					lock (m_BindingSourceUltraID3.SyncRoot)
					{


						m_BindingSourceUltraID3.Clear();

						foreach (string mp3File in
								Directory.GetFiles(
								   m_ActivePath,
									"*.mp3",
									SearchOption.AllDirectories))
						{
							try
							{
								UltraID3 uId3 = new UltraID3();                                
								if (uId3.Size == 0) continue;
								uId3.Read(mp3File);
								m_BindingSourceUltraID3.Add(uId3);

								UpdateBestMatch(batchCounting_Album, uId3.Album);
								UpdateBestMatch(batchCounting_Artist, uId3.Artist);
								UpdateBestMatch(batchCounting_Ganre, uId3.Genre);
								UpdateBestMatch(batchCounting_Year, uId3.Year.ToString());

							}
							catch { }
						}

						this.FillBachFields();
					}
				}
			}
			catch { }
		}
		private static void UpdateBestMatch(Hashtable batchCounting, string uId3Value)
		{
			try
			{
				/// Update statistics
				/// 
				if (batchCounting.ContainsKey(uId3Value))
				{
					batchCounting[uId3Value] = ((int)batchCounting[uId3Value]) + 1;
				}
				else
				{
					batchCounting.Add(uId3Value, 1);
				}
			}
			catch { }
		}

		private void FillBachFields()
		{
			if (BatchFieldsUpdated != null)
			{
				BatchFieldsInfo info = new BatchFieldsInfo();
				try
				{
					info.Album = GetBestMatch(this.batchCounting_Album);
					info.Artist = GetBestMatch(this.batchCounting_Artist);
					info.Year = GetBestMatch(this.batchCounting_Year);
					info.Ganre = GetBestMatch(this.batchCounting_Ganre);
				}
				catch { }
				BatchFieldsUpdated(this, info);
			}
		}


		private static string GetBestMatch(Hashtable hashTable)
		{
			int temp = 0;
			string bestMatch = "";
			try
			{
				foreach (string key in hashTable.Keys)
				{
					if (key != "" && ((int)hashTable[key]) > temp)
					{
						temp = (int)hashTable[key];
						bestMatch = key;
					}
				}
			}
			catch { }

			return bestMatch;
		}

		private void DataGridView_MP3s_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				UltraID3 uid3 = (UltraID3)m_BindingSourceUltraID3[e.RowIndex];
				string nl = Environment.NewLine;
				ID3V1Text =
					string.Format(@"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ",
			 uid3.ID3v1Tag.Title,
			 uid3.ID3v1Tag.Artist,
			 uid3.ID3v1Tag.Album,
			 uid3.ID3v1Tag.GenreName,
			 uid3.ID3v1Tag.Year);


				ID3V2Text =
					string.Format(@"Title:  {0}
Artist: {1}
Album:  {2} 
Ganre:  {3}
Year:   {4} ",
			 uid3.ID3v2Tag.Title,
			 uid3.ID3v2Tag.Artist,
			 uid3.ID3v2Tag.Album,
			 uid3.ID3v2Tag.Genre,
			 uid3.ID3v2Tag.Year);


				string path = (string)m_DataGridViewTrackList.Rows[e.RowIndex].Cells[dataGridViewTextBoxColumn10.Name].Value;

				SelectedTracksPath = path;
				OnTrackListRowEnter();
			}
			catch { }
		}


		private void DataGridView_MP3s_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//string path = (string)m_DataGridViewTrackList.Rows[e.RowIndex].Cells[dataGridViewTextBoxColumn10.Name].Value;
				
				//SelectedTracksPath = path;
				//OnTrackListRowEnter();

				if (m_DataGridViewTrackList.Columns[e.ColumnIndex] == this.dataGridViewImageColumn1)
				{

					Process mp3PlayerProcess = new Process();

					mp3PlayerProcess.StartInfo.FileName = "\"" + SelectedTracksPath + "\"";
					mp3PlayerProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					mp3PlayerProcess.StartInfo.UseShellExecute = true;
					mp3PlayerProcess.Start();


				}
				else if (m_DataGridViewTrackList.Columns[e.ColumnIndex] == this.dataGridViewTextBoxColumn10)
				{
					UltraID3 uid = new UltraID3();
					uid.Read(SelectedTracksPath);
					new MP3TagEditor.Mp3TagEditor(uid).ShowDialog();
				}
			}
			catch { }

		}

		private void OnTrackListRowEnter()
		{
			if (TrackListRowEnter != null)
			{
				TrackListRowEnter(this, EventArgs.Empty);
			}
		}


		public void ExtractFRomFName(string userRegExpString)
		{
			string regExpr = GetRegExpFromInput( userRegExpString);

			foreach (DataGridViewRow dr in m_DataGridViewTrackList.SelectedRows)
			{

				UltraID3 uid3 = (UltraID3)m_BindingSourceUltraID3[dr.Index];
				UpdateInfoFromFileName(uid3, regExpr, userRegExpString);
			}
			m_DataGridViewTrackList.Refresh();
		}


		/// <summary>
		/// Regex alias
		/// </summary>
		public const string RE_ARTIS = "#artist#";
		public const string RE_ALBUM = "#album#";
		public const string RE_YEAR = "#year#";
		public const string RE_TITLE = "#title#";
		public const string RE_TRACKNR = "#tracknr#";

		private static void UpdateInfoFromFileName(UltraID3 uid3, string regExpr, string userRegExpString)
		{
			try
			{
				Regex trackinfoRegexp = new Regex(regExpr, RegexOptions.Singleline);				
				///TODO: string _t = ComboBox_ExtractTagsFromFNmane.Text;

				SortedList ht = new SortedList();
				if (userRegExpString.IndexOf(RE_ARTIS) != -1) ht.Add(userRegExpString.IndexOf(RE_ARTIS), RE_ARTIS);
				if (userRegExpString.IndexOf(RE_TRACKNR) != -1) ht.Add(userRegExpString.IndexOf(RE_TRACKNR), RE_TRACKNR);
				if (userRegExpString.IndexOf(RE_ALBUM) != -1) ht.Add(userRegExpString.IndexOf(RE_ALBUM), RE_ALBUM);
				if (userRegExpString.IndexOf(RE_YEAR) != -1) ht.Add(userRegExpString.IndexOf(RE_YEAR), RE_YEAR);
				if (userRegExpString.IndexOf(RE_TITLE) != -1) ht.Add(userRegExpString.IndexOf(RE_TITLE), RE_TITLE);



				foreach (Match m in trackinfoRegexp.Matches(uid3.FileName))
				{
					IEnumerator enHt = ht.Keys.GetEnumerator();

					for (int i = 1; i < m.Groups.Count; i++)
					{
						enHt.MoveNext();
						int key = (int)enHt.Current;
						Group g = m.Groups[i];
						try
						{
							switch (ht[key].ToString())
							{
								case RE_TITLE:
									uid3.Title = g.Value;
									uid3.ID3v1Tag.Title = g.Value;
									uid3.ID3v2Tag.Title = g.Value;
									break;

								case RE_ARTIS:
									uid3.Artist = g.Value;
									uid3.ID3v1Tag.Artist = g.Value;
									uid3.ID3v2Tag.Artist = g.Value;
									break;

								case RE_ALBUM:
									uid3.Album = g.Value;
									uid3.ID3v1Tag.Album = g.Value;
									uid3.ID3v2Tag.Album = g.Value;
									break;

								case RE_TRACKNR:
									try{
                                        uid3.SetTrackNum(g.Value);
                                    }catch{}
									try{
                                        uid3.ID3v1Tag.SetTrackNum(g.Value);
                                    }
                                    catch { } 
                                    try
                                    {
                                        uid3.ID3v2Tag.SetTrackNum(g.Value);
                                    }
                                    catch { }
							        break;

								case RE_YEAR:
									uid3.SetYear(g.Value);
									uid3.ID3v1Tag.SetYear(g.Value);
									uid3.ID3v2Tag.SetYear(g.Value);
									break;

							}
						}
						catch { }

					}
				}
				uid3.Write();
			}
			catch { }
		}

		/// <summary>
		/// Gets regular expretion that is used to extract info from file name
		/// </summary>
		/// <returns>Returns string - regular expretion that is used to extract info from file name</returns>
		public static string GetRegExpFromInput(string userRegExpString)
		{
			string regExp = "";
			try
			{
				///@"#artist# - #tracknr# - #album# - #year# - #title#"
				///
				///TODO: Label_Regextpresult.Text = "";

				///TODO: string _t = ComboBox_ExtractTagsFromFNmane.Text;

				/// TODO: errorhandling if properties not set
				string albumRgx = global::MP3TagRenamer.Properties.Settings.Default.regex_album;
				string artistRgx = global::MP3TagRenamer.Properties.Settings.Default.regex_artist;
				string titleRgx = global::MP3TagRenamer.Properties.Settings.Default.regex_titel;
				string tracknrRgx = global::MP3TagRenamer.Properties.Settings.Default.regex_tracknr;
				string yearRgx = global::MP3TagRenamer.Properties.Settings.Default.regex_year;



				/// TODO: upisi redosljed grupa u Match objektu 
				/// 
				string _t2 = userRegExpString;
				if (userRegExpString.Contains(RE_ARTIS))
				{
					_t2 = userRegExpString.Replace(RE_ARTIS, "(" + artistRgx + ")");
				}
				if (userRegExpString.Contains(RE_TRACKNR))
				{
					_t2 = _t2.Replace(RE_TRACKNR, "(" + tracknrRgx + ")");
				}
				if (userRegExpString.Contains(RE_ALBUM))
				{
					_t2 = _t2.Replace(RE_ALBUM, "(" + albumRgx + ")");
				}
				if (userRegExpString.Contains(RE_TITLE))
				{
					_t2 = _t2.Replace(RE_TITLE, "(" + titleRgx + ")");
				}
				if (userRegExpString.Contains(RE_YEAR))
				{
					_t2 = _t2.Replace(RE_YEAR, "(" + yearRgx + ")");
				}

				regExp = _t2;

			}
			catch
			{
				return "";
			}
			return regExp;

		}

		public static string ExtracFromFNameTest(string userRegExpString, string selectedTracksPath)
		{
			string resultString = "";
			try
			{
				//if (m_DataGridViewTrackList.SelectedRows.Count == 0) return "";

				//SelectedTracksPath = m_DataGridViewTrackList.SelectedRows[0].Cells[dataGridViewTextBoxColumn10.Name].Value.ToString();
				//OnTrackListRowEnter();

				string t2 = GetRegExpFromInput(userRegExpString);
				Regex trackinfoRegexp = new Regex(t2, RegexOptions.Singleline);
				//resultString = _t2 + Environment.NewLine;				

				SortedList ht = new SortedList();
				if (userRegExpString.IndexOf(RE_ARTIS) != -1) ht.Add(userRegExpString.IndexOf(RE_ARTIS), RE_ARTIS);
				if (userRegExpString.IndexOf(RE_TRACKNR) != -1) ht.Add(userRegExpString.IndexOf(RE_TRACKNR), RE_TRACKNR);
				if (userRegExpString.IndexOf(RE_ALBUM) != -1) ht.Add(userRegExpString.IndexOf(RE_ALBUM), RE_ALBUM);
				if (userRegExpString.IndexOf(RE_YEAR) != -1) ht.Add(userRegExpString.IndexOf(RE_YEAR), RE_YEAR);
				if (userRegExpString.IndexOf(RE_TITLE) != -1) ht.Add(userRegExpString.IndexOf(RE_TITLE), RE_TITLE);



				foreach (Match m in trackinfoRegexp.Matches(selectedTracksPath))
				{
					// Label_Regextpresult.Text += m.Value + @"%" + m.Groups.Count + @"|";
					IEnumerator enHt = ht.Keys.GetEnumerator();

					for (int i = 1; i < m.Groups.Count; i++)
					{
						enHt.MoveNext();
						int key = (int)enHt.Current;
						Group g = m.Groups[i];
						resultString += string.Format("{0,-10} : {1}{2}" ,  ht[key] , g.Value , Environment.NewLine);
					}
				}
			}
			catch { }
			return resultString;
		}

		private void BindingSourceUltraID3_DataError(object sender, BindingManagerDataErrorEventArgs e)
		{

		}
		void DataGridViewTrackList_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			m_ActivePath = m_UserControlFolderSelector.ActualPath;
			FillDataGrid();
		}


 

	}
}
