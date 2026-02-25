namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Token(Token = "0x200014F")]
internal static class GcmUtilities
{
	[Token(Token = "0x2000150")]
	public struct FieldElement
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C3")]
		internal ulong n0; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002C4")]
		internal ulong n1; //Field offset: 0x8

	}


	[Address(RVA = "0x11EB3D0", Offset = "0x11EA5D0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C75")]
	internal static void AsBytes(ulong x0, ulong x1, Byte[] z) { }

	[Address(RVA = "0x11EB410", Offset = "0x11EA610", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C76")]
	internal static void AsBytes(ref FieldElement x, Byte[] z) { }

	[Address(RVA = "0x11EB450", Offset = "0x11EA650", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x6000C77")]
	internal static void AsFieldElement(Byte[] x, out FieldElement z) { }

	[Address(RVA = "0x11EB490", Offset = "0x11EA690", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C78")]
	internal static void DivideP(ref FieldElement x, out FieldElement z) { }

	[Address(RVA = "0x11EB4D0", Offset = "0x11EA6D0", Length = "0x127")]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6000C82")]
	private static ulong ImplMul64(ulong x, ulong y) { }

	[Address(RVA = "0x11EB640", Offset = "0x11EA840", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C79")]
	internal static void Multiply(Byte[] x, Byte[] y) { }

	[Address(RVA = "0x11EB6E0", Offset = "0x11EA8E0", Length = "0x1DC")]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BasicGcmExponentiator), Member = "ExponentiateX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicGcmMultiplier), Member = "MultiplyH", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Longs), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(GcmUtilities), Member = "ImplMul64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x6000C7A")]
	internal static void Multiply(ref FieldElement x, ref FieldElement y) { }

	[Address(RVA = "0x11EB600", Offset = "0x11EA800", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C7B")]
	internal static void MultiplyP7(ref FieldElement x) { }

	[Address(RVA = "0x11EB8C0", Offset = "0x11EAAC0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C74")]
	internal static void One(out FieldElement x) { }

	[Address(RVA = "0x11EB8E0", Offset = "0x11EAAE0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128Rev", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(UInt64&)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x6000C7C")]
	internal static void Square(ref FieldElement x) { }

	[Address(RVA = "0x11EBB90", Offset = "0x11EAD90", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C7D")]
	internal static void Xor(Byte[] x, Byte[] y) { }

	[Address(RVA = "0x11EB9B0", Offset = "0x11EABB0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C7E")]
	internal static void Xor(Byte[] x, Byte[] y, int yOff) { }

	[Address(RVA = "0x11EBB30", Offset = "0x11EAD30", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7F")]
	internal static void Xor(Byte[] x, Byte[] y, int yOff, int yLen) { }

	[Address(RVA = "0x11EBAA0", Offset = "0x11EACA0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C80")]
	internal static void Xor(Byte[] x, int xOff, Byte[] y, int yOff, int len) { }

	[Address(RVA = "0x11EB990", Offset = "0x11EAB90", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C81")]
	internal static void Xor(ref FieldElement x, ref FieldElement y, out FieldElement z) { }

}

