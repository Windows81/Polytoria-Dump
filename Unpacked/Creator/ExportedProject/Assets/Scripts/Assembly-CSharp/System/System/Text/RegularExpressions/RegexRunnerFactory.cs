namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F9")]
public abstract class RegexRunnerFactory
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000606")]
	protected RegexRunnerFactory() { }

	[Token(Token = "0x6000607")]
	protected private abstract RegexRunner CreateInstance() { }

}

