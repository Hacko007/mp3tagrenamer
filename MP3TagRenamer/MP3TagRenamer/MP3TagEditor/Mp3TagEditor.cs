using System;
using System.ComponentModel;
using System.Windows.Forms;

using HundredMilesSoftware.UltraID3Lib;

namespace Mp3TagEditor.UI.MP3TagEditor
{
    public partial class Mp3TagEditor : Form
    {
        public Mp3TagEditor( UltraID3 ultra_id3 )
        {
            InitializeComponent();

            this.Ultra_ID3 = ultra_id3;
            my_iD3v23TagBindingSource.Add( ultra_id3.ID3v2Tag );
            my_iD3v1TagBindingSource.Add(ultra_id3.ID3v1Tag );
        }

        private void Button_Close_Click( object sender, EventArgs e )
        {
            Ultra_ID3.Write();
            this.Close();
        }

        private void Button_Update_Click( object sender, EventArgs e )
        {
            Ultra_ID3.Write();
            this.Close();
        }

        private void Button_Undo_Click( object sender, EventArgs e )
        {
            string path = Ultra_ID3.FileName;
            Ultra_ID3.Read(path);
            this.my_iD3v23TagBindingSource.Clear();
            this.my_iD3v1TagBindingSource.Clear();
            this.my_iD3v23TagBindingSource.Add( Ultra_ID3.ID3v2Tag );
            this.my_iD3v1TagBindingSource.Add( Ultra_ID3.ID3v1Tag );
        }

        private void Button_Cancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }


        [Bindable(true)]
        public ID3v1Tag ID3_V1_Tag
        {
            get { return Ultra_ID3.ID3v1Tag; }
            set { Ultra_ID3.ID3v1Tag = value; }
        }


        private UltraID3 ultra_id3;

        [Bindable( true )]
        public UltraID3 Ultra_ID3
        {
            get { return ultra_id3; }
            set { ultra_id3 = value; }
        }

    }
}