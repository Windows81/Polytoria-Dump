namespace System;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x20000C5")]
public sealed class CLSCompliantAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CF")]
	private bool _compliant; //Field offset: 0x10

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000495")]
	public CLSCompliantAttribute(bool isCompliant) { }

}

