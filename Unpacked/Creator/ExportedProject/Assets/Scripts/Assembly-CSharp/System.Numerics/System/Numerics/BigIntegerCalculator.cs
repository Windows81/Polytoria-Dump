namespace System.Numerics;

[Token(Token = "0x2000004")]
internal static class BigIntegerCalculator
{
	[Token(Token = "0x400000C")]
	private static int ReducerThreshold; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static int SquareThreshold; //Field offset: 0x4
	[Token(Token = "0x400000E")]
	private static int AllocationThreshold; //Field offset: 0x8
	[Token(Token = "0x400000F")]
	private static int MultiplyThreshold; //Field offset: 0xC

	[Address(RVA = "0x1622860", Offset = "0x1621A60", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000025")]
	private static BigIntegerCalculator() { }

	[Address(RVA = "0x1622290", Offset = "0x1621490", Length = "0xCD")]
	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001E")]
	public static UInt32[] Add(UInt32[] left, uint right) { }

	[Address(RVA = "0x1622360", Offset = "0x1621560", Length = "0x17C")]
	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001F")]
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x16221E0", Offset = "0x16213E0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000020")]
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x16224E0", Offset = "0x16216E0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000024")]
	public static int Compare(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x16227A0", Offset = "0x16219A0", Length = "0xB0")]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000021")]
	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	[Address(RVA = "0x1622560", Offset = "0x1621760", Length = "0x185")]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000022")]
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x16226F0", Offset = "0x16218F0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000023")]
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

}

