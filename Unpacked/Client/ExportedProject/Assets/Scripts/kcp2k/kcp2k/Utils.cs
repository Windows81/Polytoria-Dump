namespace kcp2k;

[Token(Token = "0x2000018")]
public static class Utils
{

	[Address(RVA = "0x10A3C30", Offset = "0x10A2E30", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000086")]
	public static int Clamp(int value, int min, int max) { }

	[Address(RVA = "0x10A3C50", Offset = "0x10A2E50", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600008A")]
	public static int Decode16U(Byte[] p, int offset, out ushort value) { }

	[Address(RVA = "0x10A3CA0", Offset = "0x10A2EA0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600008C")]
	public static int Decode32U(Byte[] p, int offset, out uint value) { }

	[Address(RVA = "0x10A3D20", Offset = "0x10A2F20", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000088")]
	public static int Decode8u(Byte[] p, int offset, out byte value) { }

	[Address(RVA = "0x10A3D50", Offset = "0x10A2F50", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000089")]
	public static int Encode16U(Byte[] p, int offset, ushort value) { }

	[Address(RVA = "0x10A3DA0", Offset = "0x10A2FA0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600008B")]
	public static int Encode32U(Byte[] p, int offset, uint value) { }

	[Address(RVA = "0x10A3E10", Offset = "0x10A3010", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000087")]
	public static int Encode8u(Byte[] p, int offset, byte value) { }

	[Address(RVA = "0x10A3E40", Offset = "0x10A3040", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public static int TimeDiff(uint later, uint earlier) { }

}

