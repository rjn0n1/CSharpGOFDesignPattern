using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class ThreadSafeLogger //can not be exgtended.
    {
        static readonly Lazy<ThreadSafeLogger> _logger = new Lazy<ThreadSafeLogger>(() => new ThreadSafeLogger());

        private ThreadSafeLogger() { } //no instantiation

        public static ThreadSafeLogger Instance { get { return _logger.Value; } } //on demand create an instance 
    }
}
