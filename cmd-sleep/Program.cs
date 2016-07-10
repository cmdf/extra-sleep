using System;
using System.Threading;

namespace orez.osleep {
	class Program {
		static void Main(string[] args) {
			oParams p = new oParams(args);
			TimeSpan t = new TimeSpan(p.Days, p.Hours, p.Minutes, p.Seconds, p.Milliseconds);
			Thread.Sleep(t);
		}
	}
}
