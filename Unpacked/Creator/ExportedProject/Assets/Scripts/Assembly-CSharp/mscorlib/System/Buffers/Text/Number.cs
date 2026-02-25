namespace System.Buffers.Text;

[Token(Token = "0x200061D")]
internal static class Number
{
	[Token(Token = "0x40018B1")]
	private static readonly UInt64[] s_rgval64Power10; //Field offset: 0x0
	[Token(Token = "0x40018B2")]
	private static readonly SByte[] s_rgexp64Power10; //Field offset: 0x8
	[Token(Token = "0x40018B3")]
	private static readonly UInt64[] s_rgval64Power10By16; //Field offset: 0x10
	[Token(Token = "0x40018B4")]
	private static readonly Int16[] s_rgexp64Power10By16; //Field offset: 0x18

	[Address(RVA = "0x145F410", Offset = "0x145E610", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C90")]
	private static Number() { }

	[Address(RVA = "0x145F5D0", Offset = "0x145E7D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C8E")]
	private static int abs(int value) { }

	[Address(RVA = "0x145EA20", Offset = "0x145DC20", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(UInt32&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002C8B")]
	private static uint DigitsToInt(ReadOnlySpan<Byte> digits, int count) { }

	[Address(RVA = "0x145EAF0", Offset = "0x145DCF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C8C")]
	private static ulong Mul32x32To64(uint a, uint b) { }

	[Address(RVA = "0x145EB00", Offset = "0x145DD00", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002C8D")]
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	[Address(RVA = "0x145EB90", Offset = "0x145DD90", Length = "0x9F")]
	[CalledBy(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Utf8Parser), Member = "TryParseNormalAsFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Double&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C8A")]
	internal static bool NumberBufferToDouble(ref NumberBuffer number, out double value) { }

	[Address(RVA = "0x145EC30", Offset = "0x145DE30", Length = "0x7D3")]
	[CalledBy(Type = typeof(Number), Member = "NumberBufferToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(NumberBuffer), Member = "get_NumDigits", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(UInt32&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C8F")]
	private static double NumberToDouble(ref NumberBuffer number) { }

}

