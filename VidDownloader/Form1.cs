using System;

namespace VidDownloader
{
    public partial class Form1 : XDesign
    {
        public Form1()
        {
            InitializeComponent();

            Load += ( obj, ev ) =>
            {
                ArgControls.GetArgs( ArgContainer );

                btnDestLoc.Click += DLLocationHandler.GetDownloadLocation;
                btnDownload.Click += DLHandler.Download;

                tbConsoleOutput.TextChanged += MoveScrollDown;
            };
        }

        private void MoveScrollDown(object sender, EventArgs e)
        {
            // Scroll down TextBox whenever Console is updating its output
            tbConsoleOutput.SelectionStart = tbConsoleOutput.TextLength;
            tbConsoleOutput.ScrollToCaret();
        }

        protected override bool ProcessCmdKey( ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData )
        {
            // fixes ctrl+backspace bug (Empty box appears if this is removed)
            if ( keyData.ToString() == "Back, Control" )
                return true;

            return base.ProcessCmdKey( ref msg, keyData );
        }
    }
}
