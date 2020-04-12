using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VidDownloader
{
    public static class DLLocationHandler
    {
       public static void GetDownloadLocation( object sender, EventArgs e )
        {
            using ( FolderBrowserDialog fbd = new FolderBrowserDialog() )
            {
                fbd.Description = "Select Video's Download Destination";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowDialog();

                var tb = ( sender as Control ).FindForm().Controls.Find( "tbDestLoc", false )[ 0 ] as TextBox;
                tb.Text = fbd.SelectedPath;
            }
        }
    }
}
