namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000449")]
public sealed class ComCompatibleVersionAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001211")]
	internal int _major; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001212")]
	internal int _minor; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001213")]
	internal int _build; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001214")]
	internal int _revision; //Field offset: 0x1C

	[Address(RVA = "0x13B6650", Offset = "0x13B5850", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F84")]
	public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) { }

}

