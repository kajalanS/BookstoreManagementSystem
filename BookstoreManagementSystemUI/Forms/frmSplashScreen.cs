using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
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
            if (mpbSplashScreenProgress.Value == 50)
            {
                GlobalConfig.Process(CheckConnection);
            }
        }

        private void CheckConnection(IDataConnector connector, string arg2)
        {
            try
            {
                var connectionResult = connector.CheckConnection();
                if (connectionResult.Data == false)
                {
                    CloseApp();
                }
            }
            catch (Exception)
            {
                CloseApp();
            }
        }

        private void CloseApp()
        {
            tmrSplashScreenTimer.Stop();
            MaterialMessageBox.Show("There is a connection issue in the system, make sure to check the database connection is active.", "Issue", false);
            Application.Exit();
        }
    }
}
