namespace System.Runtime.InteropServices;

[AttributeUsage(65, AllowMultiple = False)]
[ComVisible(False)]
[Token(Token = "0x2000446")]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001206")]
	internal DllImportSearchPath _paths; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F7D")]
	public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths) { }

}

