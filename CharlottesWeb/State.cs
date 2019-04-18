using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlottesWeb {
    public static class State {
        private static int _Counts;

        public static int Counts {
            get { return _Counts; }
            set { _Counts = value; }
        }

    }
}