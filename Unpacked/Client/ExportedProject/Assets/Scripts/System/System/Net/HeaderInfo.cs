namespace System.Net;

[Token(Token = "0x200024A")]
internal class HeaderInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000973")]
	internal readonly bool IsRequestRestricted; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000974")]
	internal readonly bool IsResponseRestricted; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000975")]
	internal readonly HeaderParser Parser; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000976")]
	internal readonly string HeaderName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000977")]
	internal readonly bool AllowMultiValues; //Field offset: 0x28

	[Address(RVA = "0x17DD640", Offset = "0x17DC840", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB4")]
	internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

