using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VidDownloader
{
    public static class ArgControls
    {
        private static Control root = null;
        private static CBArg[] argCtls = null;
        public static string yt_dl_args { get; set; }

        public static void GetArgs( Control root )
        {
            // Get youtube-dl.exe from executing directory
            yt_dl_args = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//youtube-dl.exe";

            if ( !System.IO.File.Exists( yt_dl_args ) )
            {
                MessageBox.Show( "youtube-dl.exe not found! Exiting...", "Dependency error" );
                Application.Exit();
            }

            // Set root control that contains CBArgs
            ArgControls.root = root;
            var ctlList = new List<CBArg>();

            GetCtlArgs( root.Controls, ctlList );
            argCtls = ctlList.ToArray();
        }

        private static void GetCtlArgs( Control.ControlCollection root, List<CBArg> ctlList )
        {
            // Find all CBArgs in root
            foreach ( Control ctl in root )
            {
                if ( ctl is CBArg )
                    ctlList.Add( ctl as CBArg );

                if ( ctl.HasChildren )
                    GetCtlArgs( ctl.Controls, ctlList );
            }
        }

        public static Control[] Args { get { return argCtls; } }
    }
}
