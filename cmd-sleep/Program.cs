using System;
using System.Threading;

namespace orez.osleep {
	class Program {

		// static method
		/// <summary>
		/// I am right here, but i don't know here.
		/// : Watch Dogs 2 Trailer
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			oParams p = new oParams(args);
			TimeSpan t = new TimeSpan(p.Days, p.Hours, p.Minutes, p.Seconds, p.Milliseconds);
			Thread.Sleep(t);
		}
	}
}
