namespace Mirror.BouncyCastle.Math.EC.Rfc7748;

[Token(Token = "0x2000063")]
public static class X448
{

	[Address(RVA = "0x116C710", Offset = "0x116B910", Length = "0xE")]
	[CalledBy(Type = typeof(X448PrivateKeyParameters), Member = "GeneratePublicKey", ReturnType = typeof(X448PublicKeyParameters))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003D9")]
	public static void GeneratePublicKey(Byte[] k, int kOff, Byte[] r, int rOff) { }

	[Address(RVA = "0x116C720", Offset = "0x116B920", Length = "0x286")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Ed448), Member = "ScalarMultBaseXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Encode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003DA")]
	public static void ScalarMultBase(Byte[] k, int kOff, Byte[] r, int rOff) { }

}

