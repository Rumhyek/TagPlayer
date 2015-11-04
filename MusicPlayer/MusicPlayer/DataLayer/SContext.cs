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

        /// <summary>
        /// Call to set either real data or test data. Right now we only suppport DataContext and TestDataContext
        /// </summary>
        /// <remarks>
        /// The purpose is to set the chosen Context type.
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="context"></param>
        public static void SetContext(IDataLayer context) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the current context or throws an error if it hasn't been set
        /// </summary>
        /// <remarks>
        /// If Context == null throw InvalidOperationException otherwise just return Context
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns></returns>
        public static IDataLayer GetContext()
        {
            throw new NotImplementedException();
        }
    }
}
