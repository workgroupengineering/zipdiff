﻿namespace ZipDiff
{
	using CommandLine;

	public class Options
	{
		[Option('c', "comparecrcvalues", Required = false, HelpText = "Compare CRC values")]
		public bool CompareCrcValues { get; set; }

		[Option('t', "comparetimestamps", Required = false, HelpText = "Compare timestamps")]
		public bool CompareTimestamps { get; set; }

		[Option('e', "exitwitherrorondifference", Required = false, HelpText = "If a difference is found then exit with error 1")]
		public bool ExitWithErrorOnDifference { get; set; }

		[Option('1', "file1", Required = true, HelpText = "<filename> first file to compare")]
		public string File1 { get; set; }

		[Option('2', "file2", Required = true, HelpText = "<filename> second file to compare")]
		public string File2 { get; set; }

		[Option('i', "ignorecase", Required = false, HelpText = "Performs case-insensitive string comparison")]
		public bool IgnoreCase { get; set; }

		[Option('o', "outputfile", Required = false, HelpText = "Output filename")]
		public string OutputFile { get; set; }

		[Option('r', "regex", Required = false, HelpText = "Regular expression to match files to exclude")]
		public string RegExPattern { get; set; }

		[Option('v', "verbose", Required = false, HelpText = "Verbose mode")]
		public bool Verbose { get; set; }
	}
}