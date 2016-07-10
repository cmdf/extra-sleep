namespace orez.osleep {
	class oParams {

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
		public oParams(string[] args) {
			for (int i = 0; i < args.Length; i++) {
				switch (args[i]) {
					case "-d":
					case "--days":
						int.TryParse(args[++i], out Days);
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
