namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000589")]
public sealed class NonEventAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600286D")]
	public NonEventAttribute() { }

}

