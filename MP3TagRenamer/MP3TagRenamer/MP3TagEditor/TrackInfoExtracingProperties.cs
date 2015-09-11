using System;
using System.Windows.Forms;

namespace Mp3TagEditor.UI.MP3TagEditor
{
    public partial class TrackInfoExtracingProperties : Form
    {
        public TrackInfoExtracingProperties()
        {
            InitializeComponent();
        }

        private void Button_Update_Click( object sender , EventArgs e )
        {
            this.Close();
        }
    }
}