using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerPortali.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        KariyerPortaliEntities dbContext;

        public KariyerPortaliEntities Init()
        {
            return dbContext ?? (dbContext = new KariyerPortaliEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
