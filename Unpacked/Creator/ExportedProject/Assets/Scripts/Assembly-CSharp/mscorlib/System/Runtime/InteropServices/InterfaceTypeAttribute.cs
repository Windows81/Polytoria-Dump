namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Interface (1024), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000438")]
public sealed class InterfaceTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A1")]
	internal ComInterfaceType _val; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F73")]
	public InterfaceTypeAttribute(ComInterfaceType interfaceType) { }

}

