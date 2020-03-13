using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMagic
{
    public class ClipBoardMonitor : NativeWindow
    {

        private const int WM_DESTROY = 0x2;
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30d;

        [DllImport("user32.dll")]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll")]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private IntPtr NextClipBoardViewerHandle;

        public delegate void ClipboardTextUpdateHandler(string txt);
        public delegate void ClipboardUrlUpdateHandler(string url);
        public delegate void ClipboardImageUpdateHandler(Image img);
        public delegate void ClipboardAudioUpdateHandler(System.IO.Stream audioStream);

        public event ClipboardTextUpdateHandler OnClipboardTextUpdate;
        public event ClipboardUrlUpdateHandler OnClipboardUrlUpdate;
        public event ClipboardImageUpdateHandler OnClipboardImageUpdate;
        public event ClipboardAudioUpdateHandler OnClipboardAudioUpdate;

        private string prevClipboardText;
        private Image prevClipboardImage;
        private System.IO.Stream prevClipboardAudio;

        public ClipBoardMonitor()
        {
            prevClipboardText = Clipboard.ContainsText() ? Clipboard.GetText() : null;
            prevClipboardImage = Clipboard.ContainsImage() ? Clipboard.GetImage() : null;
            prevClipboardAudio = Clipboard.ContainsAudio() ? Clipboard.GetAudioStream() : null;
            //Clipboard.ContainsFileDropList()
            //Clipboard.ContainsData(format)

            this.CreateHandle(new CreateParams());
            this.NextClipBoardViewerHandle = SetClipboardViewer(this.Handle);
        }

        protected void clearPrevs()
        {
            prevClipboardText = null;
            prevClipboardImage = null;
            prevClipboardAudio = null;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsText())
                    {
                        string txt = Clipboard.GetText();
                        if (txt == prevClipboardText) break;
                        if (this.IsValidUrl(txt))
                            OnClipboardUrlUpdate?.Invoke(txt);
                        else
                            OnClipboardTextUpdate?.Invoke(txt);
                        clearPrevs();
                        prevClipboardText = txt;
                    }
                    else if (Clipboard.ContainsImage())
                    {
                        var img = Clipboard.GetImage();
                        // dups?
                        OnClipboardImageUpdate?.Invoke(img);
                        clearPrevs();
                        prevClipboardImage = img;
                    }
                    else if (Clipboard.ContainsAudio())
                    {
                        var audioStream = Clipboard.GetAudioStream();
                        // dups?
                        OnClipboardAudioUpdate?.Invoke(audioStream);
                        clearPrevs();
                        prevClipboardAudio = audioStream;
                    }

                    SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);

                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam.Equals(this.NextClipBoardViewerHandle))
                    {
                        this.NextClipBoardViewerHandle = m.LParam;
                    }
                    else if (!this.NextClipBoardViewerHandle.Equals(IntPtr.Zero))
                    {
                        SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                case WM_DESTROY:
                    ChangeClipboardChain(this.Handle, this.NextClipBoardViewerHandle);
                    break;

            }

            base.WndProc(ref m);
        }

        private bool IsValidUrl(string txt)
        {
            Uri uriResult;
            return Uri.TryCreate(txt, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

    } // end of class ClipboardMonitor

} // end of namespace
