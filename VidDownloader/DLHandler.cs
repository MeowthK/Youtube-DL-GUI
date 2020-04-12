using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace VidDownloader
{
    public static class DLHandler
    {
        public static void Download( object sender, EventArgs e )
        {
            var pControls = ( sender as Control ).FindForm().Controls;
            var tbLink = pControls.Find( "tbLink", false )[ 0 ] as TextBox;
            var tbOutputControl = pControls.Find("tbConsoleOutput", false)[0] as TextBox;

            if ( tbLink.Text == string.Empty )
            {
                MessageBox.Show( "Link must not be empty.", "Empty URL" );
                return;
            }

            var tbLoc = pControls.Find( "tbDestLoc", false )[ 0 ] as TextBox;

            var pre_args = "-f best ";
            foreach ( CBArg args in ArgControls.Args )
            {
                if ( args.Checked )
                    pre_args += args.Arg + " ";
            }

            var cor = new ConsoleOutputRedirector(tbOutputControl, ArgControls.yt_dl_args, tbLoc.Text, pre_args + tbLink.Text);
            cor.ExecuteCommand();
        }
    }
}
