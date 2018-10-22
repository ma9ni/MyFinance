﻿using Data;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MyFinanceContext dataContext;
        public MyFinanceContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new MyFinanceContext();
        }

        protected override void DisposeCore()
        {
            // libérer espace mémoire du context
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
