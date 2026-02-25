namespace System;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[Token(Token = "0x2000115")]
public sealed class NonSerializedAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600089F")]
	public NonSerializedAttribute() { }

}

