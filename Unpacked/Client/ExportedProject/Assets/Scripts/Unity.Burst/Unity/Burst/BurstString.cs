namespace Unity.Burst;

[Token(Token = "0x2000010")]
internal static class BurstString
{
	[Token(Token = "0x2000018")]
	internal enum CutoffMode
	{
		Unique = 0,
		TotalLength = 1,
		FractionLength = 2,
	}

	[Token(Token = "0x2000015")]
	internal struct FormatOptions
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		public NumberFormatKind Kind; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000033")]
		public sbyte AlignAndSize; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000034")]
		public byte Specifier; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000035")]
		public bool Lowercase; //Field offset: 0x3

		[Token(Token = "0x1700000B")]
		public bool Uppercase
		{
			[Address(RVA = "0x181ECD0", Offset = "0x181DED0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000064")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x181ECB0", Offset = "0x181DEB0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) { }

		[Address(RVA = "0x181ECD0", Offset = "0x181DED0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000064")]
		public bool get_Uppercase() { }

		[Address(RVA = "0x181E8E0", Offset = "0x181DAE0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000065")]
		public int GetBase() { }

		[Address(RVA = "0x181E900", Offset = "0x181DB00", Length = "0x3A0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000066")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000013")]
	private struct NumberBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		private readonly Byte* _buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000029")]
		public NumberBufferKind Kind; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400002A")]
		public int DigitsCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002B")]
		public int Scale; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400002C")]
		public readonly bool IsNegative; //Field offset: 0x14

		[Address(RVA = "0x181F260", Offset = "0x181E460", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000061")]
		public NumberBuffer(NumberBufferKind kind, Byte* buffer, int digitsCount, int scale, bool isNegative) { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		public Byte* GetDigitsPointer() { }

	}

	[Token(Token = "0x2000012")]
	private enum NumberBufferKind
	{
		Integer = 0,
		Float = 1,
	}

	[Token(Token = "0x2000014")]
	internal enum NumberFormatKind
	{
		General = 0,
		Decimal = 1,
		DecimalForceSigned = 2,
		Hexadecimal = 3,
	}

	[Token(Token = "0x2000011")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		public PreserveAttribute() { }

	}

	[Token(Token = "0x2000016")]
	internal struct tBigInt
	{
		[CompilerGenerated]
		[Token(Token = "0x2000017")]
		[UnsafeValueType]
		internal struct <m_blocks>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000038")]
			public uint FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		public int m_length; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[FixedBuffer(typeof(uint), 35)]
		[Token(Token = "0x4000037")]
		public <m_blocks>e__FixedBuffer m_blocks; //Field offset: 0x4

		[Address(RVA = "0x181F3F0", Offset = "0x181E5F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000068")]
		public uint GetBlock(int idx) { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000067")]
		public int GetLength() { }

		[Address(RVA = "0x181F400", Offset = "0x181E600", Length = "0x7")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		public bool IsZero() { }

		[Address(RVA = "0x181F410", Offset = "0x181E610", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006B")]
		public void SetU32(uint val) { }

		[Address(RVA = "0x181F430", Offset = "0x181E630", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006A")]
		public void SetU64(ulong val) { }

	}

	[Token(Token = "0x2000019")]
	internal struct tFloatUnion32
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		public float m_floatingPoint; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		public uint m_integer; //Field offset: 0x0

		[Address(RVA = "0x181F460", Offset = "0x181E660", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006D")]
		public uint GetExponent() { }

		[Address(RVA = "0x181F470", Offset = "0x181E670", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006E")]
		public uint GetMantissa() { }

		[Address(RVA = "0x150E200", Offset = "0x150D400", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		public bool IsNegative() { }

	}

	[Token(Token = "0x200001A")]
	internal struct tFloatUnion64
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		public double m_floatingPoint; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		public ulong m_integer; //Field offset: 0x0

		[Address(RVA = "0x181F480", Offset = "0x181E680", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000070")]
		public uint GetExponent() { }

		[Address(RVA = "0x181F490", Offset = "0x181E690", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000071")]
		public ulong GetMantissa() { }

		[Address(RVA = "0x181F4B0", Offset = "0x181E6B0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600006F")]
		public bool IsNegative() { }

	}

	[Token(Token = "0x4000020")]
	private static readonly Char[] SplitByColon; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	private static readonly Byte[] logTable; //Field offset: 0x8
	[Token(Token = "0x4000022")]
	private static readonly UInt32[] g_PowerOf10_U32; //Field offset: 0x10
	[Token(Token = "0x4000023")]
	private static readonly Byte[] InfinityString; //Field offset: 0x18
	[Token(Token = "0x4000024")]
	private static readonly Byte[] NanString; //Field offset: 0x20

	[Address(RVA = "0x181E4E0", Offset = "0x181D6E0", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600005F")]
	private static BurstString() { }

	[Address(RVA = "0x181A230", Offset = "0x1819430", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000046")]
	private static bool AlignLeft(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[Address(RVA = "0x181A270", Offset = "0x1819470", Length = "0x94")]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000045")]
	private static bool AlignRight(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[Address(RVA = "0x181A3E0", Offset = "0x18195E0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Add_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600004D")]
	private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x181A310", Offset = "0x1819510", Length = "0xC5")]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600004E")]
	private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[Address(RVA = "0x181A470", Offset = "0x1819670", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004C")]
	private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x181A4D0", Offset = "0x18196D0", Length = "0x1D4")]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000059")]
	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor) { }

	[Address(RVA = "0x181AC50", Offset = "0x1819E50", Length = "0x85")]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600004F")]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x181ABD0", Offset = "0x1819DD0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000051")]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs) { }

	[Address(RVA = "0x181AAD0", Offset = "0x1819CD0", Length = "0xF1")]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Token(Token = "0x6000050")]
	private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[Address(RVA = "0x181A6B0", Offset = "0x18198B0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000054")]
	private static void BigInt_Multiply10(ref tBigInt pResult) { }

	[Address(RVA = "0x181A6F0", Offset = "0x18198F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000052")]
	private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input) { }

	[Address(RVA = "0x181A760", Offset = "0x1819960", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000053")]
	private static void BigInt_Multiply2(ref tBigInt pResult) { }

	[Address(RVA = "0x181A7B0", Offset = "0x18199B0", Length = "0x317")]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000057")]
	private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent) { }

	[Address(RVA = "0x181ACE0", Offset = "0x1819EE0", Length = "0x269")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000056")]
	private static void BigInt_Pow10(out tBigInt pResult, uint exponent) { }

	[Address(RVA = "0x181AF50", Offset = "0x181A150", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000058")]
	private static void BigInt_Pow2(out tBigInt pResult, uint exponent) { }

	[Address(RVA = "0x181AFB0", Offset = "0x181A1B0", Length = "0x19A")]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x600005A")]
	private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) { }

	[Address(RVA = "0x181B150", Offset = "0x181A350", Length = "0x2B7")]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005E")]
	private static void ConvertDoubleToString(Byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) { }

	[Address(RVA = "0x181B410", Offset = "0x181A610", Length = "0x297")]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005D")]
	private static void ConvertFloatToString(Byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) { }

	[Address(RVA = "0x181B6B0", Offset = "0x181A8B0", Length = "0x1BC")]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(sbyte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(short), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000041")]
	private static void ConvertIntegerToString(Byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) { }

	[Address(RVA = "0x181B870", Offset = "0x181AA70", Length = "0x1A2")]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(short), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ushort), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(sbyte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003F")]
	private static void ConvertUnsignedIntegerToString(Byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) { }

	[Address(RVA = "0x181BA20", Offset = "0x181AC20", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000031")]
	public static void CopyFixedString(Byte* dest, int destLength, Byte* src, int srcLength) { }

	[Address(RVA = "0x181BA50", Offset = "0x181AC50", Length = "0x1322")]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Add_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_DivideWithRemainder_MaxQuotient9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BurstString), Member = "BigInt_ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005B")]
	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, Byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	[Address(RVA = "0x181DBF0", Offset = "0x181CDF0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000039")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DAF0", Offset = "0x181CCF0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Preserve]
	[Token(Token = "0x6000032")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, Byte* src, int srcLength, int formatOptionsRaw) { }

	[Address(RVA = "0x181DF40", Offset = "0x181D140", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000033")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DC70", Offset = "0x181CE70", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000034")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DCF0", Offset = "0x181CEF0", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Preserve]
	[Token(Token = "0x6000035")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DE70", Offset = "0x181D070", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600003E")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	[Address(RVA = "0x181D950", Offset = "0x181CB50", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600003D")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DA20", Offset = "0x181CC20", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600003C")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[Address(RVA = "0x181D880", Offset = "0x181CA80", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600003B")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[Address(RVA = "0x181D740", Offset = "0x181C940", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600003A")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[Address(RVA = "0x181D560", Offset = "0x181C760", Length = "0x1D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Preserve]
	[Token(Token = "0x6000036")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[Address(RVA = "0x181D7C0", Offset = "0x181C9C0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000038")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	[Address(RVA = "0x181DFC0", Offset = "0x181D1C0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x6000037")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[Address(RVA = "0x181CD80", Offset = "0x181BF80", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000043")]
	private static void FormatDecimalOrHexadecimal(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	[Address(RVA = "0x181CE30", Offset = "0x181C030", Length = "0x18D")]
	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000048")]
	private static void FormatGeneral(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) { }

	[Address(RVA = "0x181CFC0", Offset = "0x181C1C0", Length = "0x1E5")]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600005C")]
	private static void FormatInfinityNaN(Byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) { }

	[Address(RVA = "0x181D1B0", Offset = "0x181C3B0", Length = "0x3A4")]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BurstString), Member = "GetLengthForFormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BurstString), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000042")]
	private static void FormatNumber(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) { }

	[Address(RVA = "0x181E710", Offset = "0x181D910", Length = "0x1C9")]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000055")]
	private static tBigInt g_PowerOf10_Big(int i) { }

	[Address(RVA = "0x181E080", Offset = "0x181D280", Length = "0x13F")]
	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000047")]
	private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) { }

	[Address(RVA = "0x181E1C0", Offset = "0x181D3C0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000040")]
	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	[Address(RVA = "0x181E1F0", Offset = "0x181D3F0", Length = "0x169")]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600004B")]
	private static uint LogBase2(uint val) { }

	[Address(RVA = "0x181E360", Offset = "0x181D560", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000049")]
	private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	[Address(RVA = "0x181E480", Offset = "0x181D680", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004A")]
	private static bool ShouldRoundUp(Byte* dig, int i, bool isCorrectlyRounded) { }

	[Address(RVA = "0x181E4B0", Offset = "0x181D6B0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000044")]
	private static byte ValueToIntegerChar(int value, bool uppercase) { }

}

