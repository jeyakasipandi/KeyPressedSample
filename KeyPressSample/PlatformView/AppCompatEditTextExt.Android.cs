#if ANDROID
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using Java.Lang;
#endif
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPressSample
{
    internal class AppCompatEditTextExt : AppCompatEditText
    {

        /// <summary>
        /// 
        /// </summary>

        public override bool DispatchKeyEventPreIme(KeyEvent e)
        {
            if (e.KeyCode == Keycode.Del && e.Action == KeyEventActions.Down)
            {
                // The delete key was pressed
                // Handle the delete key press event here

                return true; // Return true to consume the event
            }


            return base.DispatchKeyEventPreIme(e);
        }

      

        public override bool OnKeyPreIme(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Del && e.Action == KeyEventActions.Down)
            {
                // The delete key was pressed
                // Handle the delete key press event here

                return true; // Return true to consume the event
            }

            return base.OnKeyPreIme(keyCode, e);
        }

       
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCompatEditTextExt"/> class.
        /// </summary>
        /// <param name="context"></param>
        public AppCompatEditTextExt(Context context) : base(context)
        {
            this.EditorAction += AppCompatEditTextExt_EditorAction;
          
               // this.SetOnKeyListener(new CustomKeyListener());
           
        }

        private void AppCompatEditTextExt_EditorAction(object? sender, EditorActionEventArgs e)
        {

            if (e.ActionId == ImeAction.None)
            {
                // Delete key was pressed
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCompatEditTextExt"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="attrs">The attributes.</param>
        public AppCompatEditTextExt(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCompatEditTextExt"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="attrs">The attributes.</param>
        /// <param name="defStyleAttr">The default style attributes. </param>
        public AppCompatEditTextExt(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCompatEditTextExt"/> class.
        /// </summary>
        /// <param name="javaReference">The java reference.</param>
        /// <param name="transfer">The transfer.</param>
        protected AppCompatEditTextExt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        #endregion

       
    }

    //public class CustomKeyListener : Java.Lang.Object, Android.Views.View.IOnKeyListener
    //{
    //    public CustomKeyListener(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
    //    {
    //    }

    //    public CustomKeyListener()
    //    {
    //    }

    //    public bool OnKey(Android.Views.View v, [GeneratedEnum] Keycode keyCode, KeyEvent e)
    //    {
    //        if (keyCode == Keycode.Del && e.Action == KeyEventActions.Down)
    //        {
    //            // Delete key was pressed
    //            return true;
    //        }

    //        return false;
    //    }
    //}


}
