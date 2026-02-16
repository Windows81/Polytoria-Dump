using System;

namespace MoonSharp.Interpreter
{
	public class ScriptStackOverflowException : ScriptRuntimeException
	{
		public ScriptStackOverflowException()
			: base((Exception)null)
		{
		}
	}
}
