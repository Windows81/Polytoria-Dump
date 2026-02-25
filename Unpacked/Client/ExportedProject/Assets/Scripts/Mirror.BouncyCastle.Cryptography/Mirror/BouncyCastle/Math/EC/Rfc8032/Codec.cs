namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

[Token(Token = "0x2000052")]
internal static class Codec
{

	[Address(RVA = "0x1139590", Offset = "0x1138790", Length = "0x6B")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036D")]
	internal static uint Decode32(Byte[] bs, int off) { }

	[Address(RVA = "0x11394C0", Offset = "0x11386C0", Length = "0xCA")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scalar25519), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scalar448), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600036E")]
	internal static void Decode32(Byte[] bs, int bsOff, UInt32[] n, int nOff, int nLen) { }

}

