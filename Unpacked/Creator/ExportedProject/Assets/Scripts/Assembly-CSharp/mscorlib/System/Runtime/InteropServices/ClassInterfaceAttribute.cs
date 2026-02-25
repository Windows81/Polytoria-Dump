namespace System.Runtime.InteropServices;

[AttributeUsage(5, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x200043B")]
public sealed class ClassInterfaceAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A7")]
	internal ClassInterfaceType _val; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F75")]
	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType) { }

}

