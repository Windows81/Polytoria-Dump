namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x2000005")]
public static class Bytes
{

	[Address(RVA = "0x10B8B80", Offset = "0x10B7D80", Length = "0x68")]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "Xor512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "E", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "g_N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000024")]
	public static void XorTo(int len, Byte[] x, Byte[] z) { }

}

