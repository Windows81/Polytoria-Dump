namespace System.Numerics;

[IsReadOnly]
[Token(Token = "0x2000002")]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	[Token(Token = "0x2000003")]
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2,
	}

	[Token(Token = "0x4000003")]
	private static readonly BigInteger s_bnMinInt; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	private static readonly BigInteger s_bnOneInt; //Field offset: 0x10
	[Token(Token = "0x4000005")]
	private static readonly BigInteger s_bnZeroInt; //Field offset: 0x20
	[Token(Token = "0x4000006")]
	private static readonly BigInteger s_bnMinusOneInt; //Field offset: 0x30
	[Token(Token = "0x4000007")]
	private static readonly Byte[] s_success; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	internal readonly int _sign; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000002")]
	internal readonly UInt32[] _bits; //Field offset: 0x8

	[Token(Token = "0x17000001")]
	public static BigInteger MinusOne
	{
		[Address(RVA = "0x16249D0", Offset = "0x1623BD0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x1623B80", Offset = "0x1622D80", Length = "0x28C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001D")]
	private static BigInteger() { }

	[Address(RVA = "0x1623E10", Offset = "0x1623010", Length = "0x1D9")]
	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6000006")]
	internal BigInteger(UInt32[] value, bool negative) { }

	[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	internal BigInteger(int n, UInt32[] rgu) { }

	[Address(RVA = "0x1624950", Offset = "0x1623B50", Length = "0x80")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000001")]
	public BigInteger(int value) { }

	[Address(RVA = "0x1623FF0", Offset = "0x16231F0", Length = "0xE4")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000003")]
	public BigInteger(Byte[] value) { }

	[Address(RVA = "0x16240E0", Offset = "0x16232E0", Length = "0x195")]
	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000002")]
	public BigInteger(long value) { }

	[Address(RVA = "0x1624280", Offset = "0x1623480", Length = "0x6C7")]
	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000004")]
	public BigInteger(ReadOnlySpan<Byte> value, bool isUnsigned = false, bool isBigEndian = false) { }

	[Address(RVA = "0x16228E0", Offset = "0x1621AE0", Length = "0x1B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000012")]
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[Address(RVA = "0x1622AA0", Offset = "0x1621CA0", Length = "0x1BC")]
	[CalledBy(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000B")]
	public override int CompareTo(BigInteger other) { }

	[Address(RVA = "0x1622C60", Offset = "0x1621E60", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600000C")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x1622E90", Offset = "0x1622090", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000009")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1622D70", Offset = "0x1621F70", Length = "0x111")]
	[CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000A")]
	public override bool Equals(BigInteger other) { }

	[Address(RVA = "0x16249D0", Offset = "0x1623BD0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000007")]
	public static BigInteger get_MinusOne() { }

	[Address(RVA = "0x1622F40", Offset = "0x1622140", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001C")]
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	[Address(RVA = "0x1622FB0", Offset = "0x16221B0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000008")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1623010", Offset = "0x1622210", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001B")]
	private static bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	[Address(RVA = "0x1624A30", Offset = "0x1623C30", Length = "0x206")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001A")]
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x1624C40", Offset = "0x1623E40", Length = "0x121")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Token(Token = "0x6000017")]
	public static int op_Explicit(BigInteger value) { }

	[Address(RVA = "0x1624D90", Offset = "0x1623F90", Length = "0x23")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000014")]
	public static BigInteger op_Implicit(byte value) { }

	[Address(RVA = "0x1624D70", Offset = "0x1623F70", Length = "0x20")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000015")]
	public static BigInteger op_Implicit(int value) { }

	[Address(RVA = "0x1624DC0", Offset = "0x1623FC0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000016")]
	public static BigInteger op_Implicit(long value) { }

	[Address(RVA = "0x1624DE0", Offset = "0x1623FE0", Length = "0x34E")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000018")]
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	[Address(RVA = "0x1625130", Offset = "0x1624330", Length = "0x505")]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumericsHelpers), Member = "DangerousMakeTwosComplement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000019")]
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	[Address(RVA = "0x16230E0", Offset = "0x16222E0", Length = "0x219")]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000013")]
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[Address(RVA = "0x16233C0", Offset = "0x16225C0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000011")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x1623300", Offset = "0x1622500", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000010")]
	public virtual string ToString() { }

	[Address(RVA = "0x16234C0", Offset = "0x16226C0", Length = "0x54A")]
	[CalledBy(Type = typeof(BigInteger), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "TryWriteOrCountBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	private Byte[] TryGetBytes(GetBytesMode mode, Span<Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	[Address(RVA = "0x1623A10", Offset = "0x1622C10", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetBytesMode), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600000D")]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

	[Address(RVA = "0x1623AD0", Offset = "0x1622CD0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetBytesMode), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000E")]
	internal bool TryWriteOrCountBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

}

