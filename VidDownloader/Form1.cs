using System;

namespace VidDownloader
{
    public partial class Form1 : XDesign
    {
        private bool isScrolledDown = true;

        public Form1()
        {
            InitializeComponent();

            Load += ( obj, ev ) =>
            {
                ArgControls.GetArgs( ArgContainer );

                btnDestLoc.Click += DLLocationHandler.GetDownloadLocation;
                btnDownload.Click += DLHandler.Download;

                tbConsoleOutput.TextChanged += MoveScrollDown;
                tbConsoleOutput.MouseDown += GetMousePos;
            };
        }
        
        private void GetMousePos(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            isScrolledDown = e.Y >= tbConsoleOutput.Height / 2;
        }

        private void MoveScrollDown(object sender, EventArgs e)
        {
            // Scroll down TextBox whenever Console is updating its output
            if (isScrolledDown)
            {
                tbConsoleOutput.SelectionStart = tbConsoleOutput.TextLength;
                tbConsoleOutput.ScrollToCaret();
            }
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
