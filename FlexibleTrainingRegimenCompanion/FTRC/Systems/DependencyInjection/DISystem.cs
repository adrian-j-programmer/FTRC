using System;
using System.Collections.Generic;
using System.Text;

namespace FTRC.Systems.DependencyInjection
{
    public static class DISystem
    {

        public static Queue<object> PendingDependencies { get; set; } = new Queue<object>();
    }
}
