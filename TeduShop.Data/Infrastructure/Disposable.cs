using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class Disposable : IDisposable //IDisposable is a interface in C#. Cho phep tu dong huy cai dat cac phuong thuc
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }
       
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        // Override this to despose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}
