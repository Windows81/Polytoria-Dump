namespace Mirror.BouncyCastle.Math.EC.Rfc7748;

[Token(Token = "0x2000061")]
public static class X25519
{

	[Address(RVA = "0x1167AD0", Offset = "0x1166CD0", Length = "0xE")]
	[CalledBy(Type = typeof(X25519PrivateKeyParameters), Member = "GeneratePublicKey", ReturnType = typeof(X25519PublicKeyParameters))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003B2")]
	public static void GeneratePublicKey(Byte[] k, int kOff, Byte[] r, int rOff) { }

	[Address(RVA = "0x1167AE0", Offset = "0x1166CE0", Length = "0x3D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Ed25519), Member = "ScalarMultBaseYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Encode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B3")]
	public static void ScalarMultBase(Byte[] k, int kOff, Byte[] r, int rOff) { }

}

