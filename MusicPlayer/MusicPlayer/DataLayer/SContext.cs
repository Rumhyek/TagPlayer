using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class SContext
    {
        private static IDataLayer Context { get; set; }

        static void SetContext(IDataLayer context) {
            throw new NotImplementedException();
        }
        static IDataLayer GetContext()
        {
            throw new NotImplementedException();
        }
    }
}
