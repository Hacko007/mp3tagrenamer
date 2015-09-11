using System.Windows.Forms;

namespace Mp3TagEditor.UI
{
	partial class MovableButton
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		
		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UseVisualStyleBackColor = true;

			this.MouseDown += new MouseEventHandler(MovableButton_MouseDown);
			this.MouseMove += new MouseEventHandler(MovableButton_MouseMove);
			this.MouseUp += new MouseEventHandler(MovableButton_MouseUp);
		}

		#endregion
	}
}
