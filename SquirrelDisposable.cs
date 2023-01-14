using System;

namespace SquirrelInheritable
{
    public class SquirrelDisposable : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
        internal bool Disposed { get; private set; }
    
        protected virtual void Dispose(bool disposing)
        {
            Disposed = true;
        }
    }
}