namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000448")]
public sealed class FieldOffsetAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001210")]
	internal int _val; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F83")]
	public FieldOffsetAttribute(int offset) { }

}

