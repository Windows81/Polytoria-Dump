namespace System.Runtime.InteropServices;

[AttributeUsage(5597, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x200043C")]
public sealed class ComVisibleAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A8")]
	internal bool _val; //Field offset: 0x10

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F76")]
	public ComVisibleAttribute(bool visibility) { }

}

