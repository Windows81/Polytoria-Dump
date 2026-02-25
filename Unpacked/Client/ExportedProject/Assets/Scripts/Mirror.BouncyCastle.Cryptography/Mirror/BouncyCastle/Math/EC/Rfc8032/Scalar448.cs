namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

[Token(Token = "0x2000060")]
internal static class Scalar448
{
	[Token(Token = "0x40000F9")]
	private static readonly UInt32[] L; //Field offset: 0x0
	[Token(Token = "0x40000FA")]
	private static readonly UInt32[] LSq; //Field offset: 0x8

	[Address(RVA = "0x115D3B0", Offset = "0x115C5B0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003B1")]
	private static Scalar448() { }

	[Address(RVA = "0x115D290", Offset = "0x115C490", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codec), Member = "Decode32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003AF")]
	internal static void Decode(Byte[] k, UInt32[] n) { }

	[Address(RVA = "0x115D2C0", Offset = "0x115C4C0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nat), Member = "CAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "ShiftDownBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B0")]
	internal static void ToSignedDigits(int bits, UInt32[] x, UInt32[] z) { }

}

