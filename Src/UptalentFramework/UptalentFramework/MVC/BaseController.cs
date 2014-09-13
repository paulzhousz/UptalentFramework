using System;
using System.Web.Mvc;
using UptalentFramework.Localization;

namespace UptalentFramework.MVC
{
    public abstract class BaseController:Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            // invoke the localization logic
            LocalizationControllerHelper.OnBeginExecuteCore(this);

            // invoke the base method
            return base.BeginExecuteCore(callback, state);
        }
    }
}