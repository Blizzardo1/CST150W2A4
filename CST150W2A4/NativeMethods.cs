using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W2A4
{
    internal static class NativeMethods
    {
        private const string User32 = "User32.dll";

        /// <summary>
        /// Basic import of a Unicode Message Box
        /// </summary>
        /// <param name="hWnd">The parent handle</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <param name="options">Any options to pass to the message box, controlling the buttons and icon</param>
        /// <returns>An <see cref="int"/> result of the current dialog state of the MessageBox</returns>
        [DllImport(User32, EntryPoint = "MessageBoxW", CharSet = CharSet.Unicode)]
        private static extern int MsgBox(IntPtr hWnd, string text, string caption, int options);

        /// <summary>
        /// A WIN32 Unicode MessageBox
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <param name="buttons">The message box buttons</param>
        /// <param name="icon">The message box icon</param>
        /// <returns>The <see cref="DialogResult"/> from the current dialog state of the MessageBox</returns>
        public static DialogResult MessageBox(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) =>
            (DialogResult)MsgBox(owner.Handle, text, caption, (int)buttons | (int)icon);

        /// <summary>
        /// Displays an error message
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <returns>The <see cref="DialogResult"/> from the current dialog state of the MessageBox</returns>
        public static DialogResult Error(IWin32Window owner, string text, string caption) => MessageBox(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// Asks the user a question
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <returns>The <see cref="DialogResult"/> from the current dialog state of the MessageBox</returns>
        public static DialogResult Question(IWin32Window owner, string text, string caption) => MessageBox(owner, text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Displays a warning message
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <returns>The <see cref="DialogResult"/> from the current dialog state of the MessageBox</returns>
        public static DialogResult Warning(IWin32Window owner, string text, string caption) => MessageBox(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        /// <summary>
        /// Displays an error with the ability to abort, retry, or fail.
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="text">The text body</param>
        /// <param name="caption">The message box title</param>
        /// <returns>The <see cref="DialogResult"/> from the current dialog state of the MessageBox</returns>
        public static DialogResult AbortRetry(IWin32Window owner, string text, string caption) => MessageBox(owner, text, caption, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
    }
}
