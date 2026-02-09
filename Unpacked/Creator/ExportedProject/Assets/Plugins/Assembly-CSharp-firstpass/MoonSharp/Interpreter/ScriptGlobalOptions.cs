using System;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter
{
	public class ScriptGlobalOptions
	{
		public CustomConvertersCollection CustomConverters { get; set; }

		public IPlatformAccessor Platform { get; set; }

		public bool RethrowExceptionNested { get; set; }

		public FuzzySymbolMatchingBehavior FuzzySymbolMatching { get; set; }

		public Func<Exception, bool> ShouldPCallCatchException { get; set; }

		internal ScriptGlobalOptions()
		{
		}
	}
}
