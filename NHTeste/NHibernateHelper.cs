using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Driver;

namespace NHTeste
{
    using System.Reflection;
    using NHibernate;
    using NHibernate.Cfg;

    namespace NHibernateTest
    {
        public sealed class NHibernateHelper
        {
            private static ISessionFactory SessionFactory;

            private static void OpenSession()
            {
                var configuration = new Configuration();
                configuration.Configure();
                SessionFactory = configuration.BuildSessionFactory();
            }

            public static ISession GetCurrentSession()
            {
                if (SessionFactory == null)
                    NHibernateHelper.OpenSession();
                return SessionFactory.OpenSession();
            }

            public static void CloseSessionFactory()
            {
                if (SessionFactory != null)
                    SessionFactory.Close();
            }
        }
    }
}
