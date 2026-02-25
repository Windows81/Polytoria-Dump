namespace System.Runtime.Versioning;

[AttributeUsage(108, AllowMultiple = False, Inherited = False)]
[Token(Token = "0x2000003")]
internal sealed class NonVersionableAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public NonVersionableAttribute() { }

}

