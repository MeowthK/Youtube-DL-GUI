enum ButtonType
{
    MINIMIZE,
    MAXIMIZE,
    CLOSE,
    UNDEFINED
};

namespace VidDownloader
{
    /// <summary>
    /// XDesign by MeowthK(kennotbeccin@gmail.com)
    /// - Modifies default form and stylizes it a bit.
    /// </summary>
    public partial class XDesign : System.Windows.Forms.Form
    {
        // wnd drag magic
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport( "user32.dll" )]
        public static extern int SendMessage( System.IntPtr hWnd, int Msg, int wParam, int lParam );
        [System.Runtime.InteropServices.DllImport( "user32.dll" )]
        public static extern bool ReleaseCapture();

        private int borderRadius = 15;
        private System.Drawing.Color frameColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
        private System.Drawing.SizeF stringSize;
        private System.Drawing.RectangleF closeButtonPos;
        private ButtonType hoveredButton = ButtonType.UNDEFINED;

        private void OverridePadding()
        {
            var p = this.Padding;

            p.Left += borderRadius;
            p.Right += borderRadius;
            p.Bottom += borderRadius;

            this.Padding = p;
        }

        public System.Drawing.Color BorderColor { get { return frameColor; } set { frameColor = value; this.Invalidate(); } }

        public int BorderRadius { get { return borderRadius; }
            set {
                if ( value >= 0 )
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        public XDesign()
        {
            InitializeComponent();

            OverridePadding();
            DoubleBuffered = true;
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        [System.ComponentModel.Browsable( false )]
        public new System.Windows.Forms.FormBorderStyle FormBorderStyle { get { return base.FormBorderStyle; } }

        private ButtonType GetButtonType( System.Drawing.Point e )
        {
            if ( e.Y >= closeButtonPos.Top && e.Y <= closeButtonPos.Bottom )
            {
                if ( e.X >= closeButtonPos.Left && e.X <= closeButtonPos.Right )
                    return ButtonType.CLOSE;
                else if ( this.MaximizeBox && e.X >= closeButtonPos.Left - closeButtonPos.Width && e.X <= closeButtonPos.Right - closeButtonPos.Width )
                    return ButtonType.MAXIMIZE;
                else if ( this.MinimizeBox && e.X >= closeButtonPos.Left - closeButtonPos.Width * 2 && e.X <= closeButtonPos.Right - closeButtonPos.Width * 2 )
                    return ButtonType.MINIMIZE;
            }

            return ButtonType.UNDEFINED;
        }

        protected override void OnTextChanged( System.EventArgs e )
        {
            this.Invalidate();
        }

        protected override void OnPaddingChanged( System.EventArgs e )
        {
            this.Invalidate();
        }

        protected override void OnMouseDoubleClick( System.Windows.Forms.MouseEventArgs e )
        {
            var radius = borderRadius / 2f;

            if ( this.MaximizeBox && e.X >= this.Padding.Left - radius - 1 && e.X <= this.Width - this.Padding.Right + radius && e.Y <= this.Padding.Top - 1 )
            {
                this.WindowState = this.WindowState == System.Windows.Forms.FormWindowState.Normal ? System.Windows.Forms.FormWindowState.Maximized : System.Windows.Forms.FormWindowState.Normal;
                this.Invalidate();
            }
        }

        protected override void OnPaint( System.Windows.Forms.PaintEventArgs e )
        {
            var radius = borderRadius / 2f;
            var pixelOffset = 0.5f;

            using ( var gp = new System.Drawing.Drawing2D.GraphicsPath() )
            {
                if ( borderRadius > 0 )
                {
                    gp.AddLine( System.Math.Abs( this.Padding.Left - radius - 1 ), this.Padding.Top - pixelOffset, this.Width - this.Padding.Right + radius, this.Padding.Top - pixelOffset );
                    //gp.AddLine( this.Width - this.Padding.Right + radius, this.Padding.Top - 1, this.Width - this.Padding.Right + radius, this.Height - this.Padding.Bottom - radius );
                    gp.AddArc( System.Math.Abs( this.Width - this.Padding.Right - radius ), System.Math.Abs( this.Height - this.Padding.Bottom - radius ), borderRadius, borderRadius, 0, 90 );
                    gp.AddArc( System.Math.Abs( this.Padding.Left - radius - 1 ), System.Math.Abs( this.Height - this.Padding.Bottom - radius ), borderRadius, borderRadius, 90, 90 );
                    //gp.AddLine( this.Padding.Left - radius - 1, this.Height - this.Padding.Bottom - radius - 1, this.Padding.Left - radius - 1, this.Padding.Top );
                    gp.CloseFigure();
                }
                else
                {
                    var innerRect = new System.Drawing.RectangleF( System.Math.Abs( this.Padding.Left - 1 ), this.Padding.Top - pixelOffset, this.Width - ( this.Padding.Left + this.Padding.Right ), System.Math.Abs( this.Height - ( this.Padding.Top + this.Padding.Bottom ) ) );
                    gp.AddRectangle( innerRect );
                }

                gp.AddRectangle( new System.Drawing.Rectangle( -1, -1, this.Width + 1, this.Height + 1 ) );

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath( new System.Drawing.SolidBrush( frameColor ), gp );
            }

            var sf = new System.Drawing.StringFormat();
            sf.LineAlignment = System.Drawing.StringAlignment.Center;

            var rectF = new System.Drawing.RectangleF( this.Padding.Left - radius - 1, 0, this.Width, this.Padding.Top - ( this.Padding.Left - radius ) );
            stringSize = e.Graphics.MeasureString( this.Text, this.Font, ( int ) rectF.Width );

            var alpha = TopMost ? 255 : 150;
            var clr = System.Drawing.Color.FromArgb( alpha, 255, 255, 255 );
            var closeHoverColor = System.Drawing.Color.FromArgb( 236, 112, 99 );
            var maximizeHoverColor = System.Drawing.Color.FromArgb( 93, 173, 226 );
            var minimizeHoverColor = System.Drawing.Color.FromArgb( 248, 196, 113 );

            e.Graphics.FillRectangle( new System.Drawing.SolidBrush( clr ), rectF.X, rectF.Y, stringSize.Width, rectF.Height );
            e.Graphics.DrawString( this.Text, this.Font, System.Drawing.Brushes.Black, rectF, sf );

            var btnPad = 5f;
            var rectBounds = new System.Drawing.RectangleF( this.Width - this.Padding.Right + radius - rectF.Height, 0, rectF.Height, rectF.Height );
            closeButtonPos = rectBounds;
            e.Graphics.FillRectangle( hoveredButton == ButtonType.CLOSE ? new System.Drawing.SolidBrush( closeHoverColor ) : System.Drawing.Brushes.White, rectBounds );
            e.Graphics.DrawLine( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Top + btnPad, rectBounds.Right - btnPad, rectBounds.Bottom - btnPad );
            e.Graphics.DrawLine( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Bottom - btnPad, rectBounds.Right - btnPad, rectBounds.Top + btnPad );

            rectBounds.X -= rectF.Height;

            if ( MaximizeBox )
            {
                e.Graphics.FillRectangle( hoveredButton == ButtonType.MAXIMIZE ? new System.Drawing.SolidBrush( maximizeHoverColor ) : System.Drawing.Brushes.White, rectBounds );

                if ( this.WindowState == System.Windows.Forms.FormWindowState.Normal )
                    e.Graphics.DrawRectangle( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Top + btnPad, rectBounds.Width - btnPad * 2, rectBounds.Height - btnPad * 2 );
                else if ( this.WindowState == System.Windows.Forms.FormWindowState.Maximized )
                {
                    e.Graphics.DrawRectangle( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Top + btnPad, rectBounds.Width - btnPad * 2, rectBounds.Height - btnPad * 2 );
                    e.Graphics.DrawRectangle( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Top + btnPad + ( rectBounds.Top + btnPad ) / 2f, ( rectBounds.Width - btnPad * 2 ) / 2f, ( rectBounds.Height - btnPad * 2 ) / 2f );
                }
            }

            rectBounds.X -= rectF.Height;

            if ( MinimizeBox )
            {
                e.Graphics.FillRectangle( hoveredButton == ButtonType.MINIMIZE ? new System.Drawing.SolidBrush( minimizeHoverColor ) : System.Drawing.Brushes.White, rectBounds );
                e.Graphics.DrawLine( System.Drawing.Pens.Black, rectBounds.Left + btnPad, rectBounds.Bottom - btnPad, rectBounds.Right - btnPad, rectBounds.Bottom - btnPad );
            }
        }

        protected override void OnMouseDown( System.Windows.Forms.MouseEventArgs e )
        {
            int leftBound = this.Padding.Left - borderRadius - 1;

            switch ( GetButtonType( e.Location ) )
            {
                case ButtonType.CLOSE:
                    System.Windows.Forms.Application.Exit();
                    break;

                case ButtonType.MAXIMIZE:
                    this.WindowState = this.WindowState == System.Windows.Forms.FormWindowState.Normal ? System.Windows.Forms.FormWindowState.Maximized : System.Windows.Forms.FormWindowState.Normal;
                    this.Invalidate();
                    break;

                case ButtonType.MINIMIZE:
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    break;
            }

            if ( e.X >= leftBound && e.X <= leftBound + stringSize.Width &&
                 e.Y >= 0 && e.Y <= stringSize.Height )
            {
                TopMost = !TopMost;
                this.Invalidate();
            }

            if ( e.Button == System.Windows.Forms.MouseButtons.Left && WindowState != System.Windows.Forms.FormWindowState.Maximized )
            {
                ReleaseCapture();
                SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
            }
        }

        private bool isPointerOnTop( System.Drawing.Point e )
        {
            return e.Y >= 0 && e.Y <= Padding.Top;
        }

        protected override void OnMouseMove( System.Windows.Forms.MouseEventArgs e )
        {
            hoveredButton = GetButtonType( e.Location );

            if ( isPointerOnTop( e.Location ) )
                this.Invalidate();
        }
    }
}
