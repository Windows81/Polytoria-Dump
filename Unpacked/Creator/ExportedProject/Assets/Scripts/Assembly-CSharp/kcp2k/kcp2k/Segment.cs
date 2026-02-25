namespace kcp2k;

[Token(Token = "0x2000017")]
internal class Segment
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A0")]
	internal uint conv; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A1")]
	internal uint cmd; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A2")]
	internal uint frg; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000A3")]
	internal uint wnd; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A4")]
	internal uint ts; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A5")]
	internal uint sn; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A6")]
	internal uint una; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000A7")]
	internal uint resendts; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A8")]
	internal int rto; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000A9")]
	internal uint fastack; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AA")]
	internal uint xmit; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AB")]
	internal MemoryStream data; //Field offset: 0x40

	[Address(RVA = "0x10A35A0", Offset = "0x10A27A0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	public Segment() { }

	[Address(RVA = "0x10A32E0", Offset = "0x10A24E0", Length = "0x26B")]
	[CalledBy(Type = typeof(Kcp), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	internal int Encode(Byte[] ptr, int offset) { }

	[Address(RVA = "0x10A3550", Offset = "0x10A2750", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	internal void Reset() { }

}

