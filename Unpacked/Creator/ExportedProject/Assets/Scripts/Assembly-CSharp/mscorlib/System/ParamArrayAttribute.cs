namespace System;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000122")]
public sealed class ParamArrayAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092A")]
	public ParamArrayAttribute() { }

}

