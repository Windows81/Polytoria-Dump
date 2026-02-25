namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x2000009")]
public static class Longs
{
	[Token(Token = "0x4000006")]
	private static readonly Byte[] DeBruijnTZ; //Field offset: 0x0

	[Address(RVA = "0x10BD460", Offset = "0x10BC660", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000035")]
	private static Longs() { }

	[Address(RVA = "0x10BD220", Offset = "0x10BC420", Length = "0xE6")]
	[CalledBy(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "DegreeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "BitLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000031")]
	public static int NumberOfLeadingZeros(long i) { }

	[Address(RVA = "0x10BD360", Offset = "0x10BC560", Length = "0xD4")]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000032")]
	public static ulong Reverse(ulong i) { }

	[Address(RVA = "0x10BD310", Offset = "0x10BC510", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000033")]
	public static ulong ReverseBytes(ulong i) { }

	[Address(RVA = "0x10BD440", Offset = "0x10BC640", Length = "0x1A")]
	[CalledBy(Type = typeof(KeccakDigest), Member = "KeccakPermutation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[CLSCompliant(False)]
	[Token(Token = "0x6000034")]
	public static ulong RotateLeft(ulong i, int distance) { }

}

