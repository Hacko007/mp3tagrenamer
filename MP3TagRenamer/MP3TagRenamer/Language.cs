using System;
using System.Threading;
using System.Windows.Forms;

using Mp3TagEditor.UI.Properties;

namespace Mp3TagEditor.UI
{
  public partial class Language : UserControl
  {
    public Language()
    {
      InitializeComponent();
      InitializeLanguageMenu();
    }

    private void InitializeLanguageMenu()
    {
      try
      {
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.LanguageUsed );
        m_RadioButtonEnglish.Checked = true;
        m_RadioButtonSwedish.Checked = false;
        m_RadioButtonBosnian.Checked = false;
        switch( Settings.Default.LanguageUsed )
        {
          case "bs-Latn-BA":
            m_RadioButtonBosnian.Checked = true;
            break;
          case "sv-SE":
            m_RadioButtonSwedish.Checked = true;
            break;
          default:
            m_RadioButtonEnglish.Checked = true;
            break;
        }
        m_LabelRestart.Visible = false;
      }
      catch
      {
      }
    }


    private void ToEnglish()
    {
      Settings.Default.LanguageUsed = "en-GB";
      Settings.Default.Save();
      RestartApplication();
    }

    private void ToSwedish()
    {
      Settings.Default.LanguageUsed = "sv-SE";
      Settings.Default.Save();
      RestartApplication();
    }

    private void ToBosnian()
    {
      Settings.Default.LanguageUsed = "bs-Latn-BA";
      Settings.Default.Save();
      RestartApplication();
    }


    private void RestartApplication()
    {
      m_LabelRestart.Visible = true;
    }

    private void OnLanguageChange(object sender, EventArgs e)
    {
      if (m_RadioButtonEnglish.Checked)
      {
        ToEnglish();
      }
      else if (m_RadioButtonSwedish.Checked)
      {
        ToSwedish();
      }
      else if (m_RadioButtonBosnian.Checked)
      {
        ToBosnian();
      }
    }
  }
}