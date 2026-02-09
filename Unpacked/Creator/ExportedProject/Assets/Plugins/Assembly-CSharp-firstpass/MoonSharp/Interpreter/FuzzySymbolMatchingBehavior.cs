using System;

namespace MoonSharp.Interpreter
{
	[Flags]
	public enum FuzzySymbolMatchingBehavior
	{
		None = 0,
		UpperFirstLetter = 1,
		Camelify = 2,
		PascalCase = 4
	}
}
