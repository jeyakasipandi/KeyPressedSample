using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Handlers;
using System;

namespace KeyPressSample
{
    /// <summary>
    /// The SfInputViewHandler class to access the native entry properties.
    /// </summary>
    public partial class CustomEntryHandler : EntryHandler
    {

        #region Fields

        private AppCompatEditTextExt? textExt;
        private CustomEntry? inputView;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        protected override AppCompatEditText CreatePlatformView()
        {
            if (VirtualView == null)
            {
                throw new InvalidOperationException($"{nameof(VirtualView)} must be set to create a AppCompatEditText");
            }
            else
            {
                inputView = (CustomEntry)this.VirtualView;
            }

            textExt = new AppCompatEditTextExt(Context);
            return textExt;
        }

    }
}
