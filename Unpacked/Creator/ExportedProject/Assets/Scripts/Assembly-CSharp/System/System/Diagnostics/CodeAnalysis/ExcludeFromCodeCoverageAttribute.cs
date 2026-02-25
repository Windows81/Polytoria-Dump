namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(749, Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200010D")]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066D")]
	public ExcludeFromCodeCoverageAttribute() { }

}

