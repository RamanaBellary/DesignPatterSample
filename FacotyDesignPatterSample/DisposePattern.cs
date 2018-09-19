using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample
{
    public class DisposePattern : IDisposable
    {
        bool isDisposed;

        ~DisposePattern()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposed)
                return;

            if (isDisposing)
            {
                //Free Managed Resources.
            }

            //Free UnManaged Resources.

            isDisposed = true;
        }
    }
}
