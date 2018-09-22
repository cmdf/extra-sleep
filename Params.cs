namespace App {
	class Params {

		// data
		/// <summary>
		/// Days to sleep.
		/// </summary>
		public int Days;
		/// <summary>
		/// Hours to sleep.
		/// </summary>
		public int Hours;
		/// <summary>
		/// Minutes to sleep.
		/// </summary>
		public int Minutes;
		/// <summary>
		/// Seconds to sleep.
		/// </summary>
		public int Seconds;
		/// <summary>
		/// Milliseconds to sleep.
		/// </summary>
		public int Milliseconds;


		// constructor
		/// <summary>
		/// Get parameters from input arguments.
		/// </summary>
		/// <param name="args">Input arguments.</param>
		public Params(string[] args) {
			double v = 0;
			for (int i = 0; i < args.Length; i++) {
				switch (args[i]) {
					case "-d":
					case "--days":
						double.TryParse(args[++i], out v);
						Days = (int)v;
						break;
					case "-h":
					case "--hours":
						int.TryParse(args[++i], out Hours);
						break;
					case "-m":
					case "--minutes":
						int.TryParse(args[++i], out Minutes);
						break;
					case "-s":
					case "--seconds":
						int.TryParse(args[++i], out Seconds);
						break;
					default:
						int.TryParse(args[i], out Milliseconds);
						break;
				}
			}
		}
	}
}
