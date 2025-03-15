using MaterialSkin.Controls;

namespace BookstoreManagementSystemUI.Forms
{
  public partial class frmSplashScreen : MaterialForm
  {
    public frmSplashScreen()
    {
      InitializeComponent();
      tmrSplashScreenTimer.Enabled = true;
      mpbSplashScreenProgress.Enabled = true;
      mpbSplashScreenProgress.Value = 0;
      tmrSplashScreenTimer.Start();
    }

    /// <summary>
    /// This event is triggered periodically, incrementing the progress bar and closing the form when the progress reaches 100%.
    /// </summary>
    private void tmrSplashScreenTimer_Tick(object sender, EventArgs e)
    {
      if (mpbSplashScreenProgress.Value == 100)
      {
        tmrSplashScreenTimer.Stop();
        this.Close();
      }
      else
      {
        mpbSplashScreenProgress.Increment(1);
      }
    }
  }
}
