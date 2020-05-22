using Core.Application.Base;
using Core.DATA;
using System;

namespace Core.Factory
{
    public class ApplicationFactory : IDisposable
    {
        #region Propiedades

        protected AmericaVirtualEntities _context = null;

        #endregion

        #region Constructor

        public ApplicationFactory()
        {
            _context = new AmericaVirtualEntities();
        }

        public ApplicationFactory(AmericaVirtualEntities context)
        {
            _context = context;
        }

        #endregion

        public virtual T GetApplication<T>()
            where T : BaseApplication, new()
        {
            T ret = BaseApplication.GetInstante<T>();

            ret.Context = _context;

            return ret;
        }

        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _context = null;

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

    }
}

