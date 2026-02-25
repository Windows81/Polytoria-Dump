namespace System;

[IsReadOnly]
[Token(Token = "0x2000006")]
public struct Half : IComparable, IComparable<Half>, IEquatable<Half>
{
	[Token(Token = "0x4000006")]
	private const NumberStyles DefaultParseStyle = 231; //Field offset: 0x0
	[Token(Token = "0x400001A")]
	private const ushort PositiveZeroBits = 0; //Field offset: 0x0
	[Token(Token = "0x400001B")]
	private const ushort NegativeZeroBits = 32768; //Field offset: 0x0
	[Token(Token = "0x400001C")]
	private const ushort EpsilonBits = 1; //Field offset: 0x0
	[Token(Token = "0x400001D")]
	private const ushort PositiveInfinityBits = 31744; //Field offset: 0x0
	[Token(Token = "0x400001E")]
	private const ushort NegativeInfinityBits = 64512; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	private const ushort PositiveQNaNBits = 32256; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	internal const int SignificandLength = 11; //Field offset: 0x0
	[Token(Token = "0x4000020")]
	private const ushort NegativeQNaNBits = 65024; //Field offset: 0x0
	[Token(Token = "0x4000022")]
	private const ushort MaxValueBits = 31743; //Field offset: 0x0
	[Token(Token = "0x4000023")]
	private const ushort PositiveOneBits = 15360; //Field offset: 0x0
	[Token(Token = "0x4000024")]
	private const ushort NegativeOneBits = 48128; //Field offset: 0x0
	[Token(Token = "0x4000025")]
	private const ushort SmallestNormalBits = 1024; //Field offset: 0x0
	[Token(Token = "0x4000026")]
	private const ushort EBits = 16752; //Field offset: 0x0
	[Token(Token = "0x4000027")]
	private const ushort PiBits = 16968; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	private const ushort MinValueBits = 64511; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	internal const int TrailingSignificandLength = 10; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	internal const ushort MaxTrailingSignificand = 1023; //Field offset: 0x0
	[Token(Token = "0x4000016")]
	internal const ushort MinTrailingSignificand = 0; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	internal const ushort SignMask = 32768; //Field offset: 0x0
	[Token(Token = "0x4000008")]
	internal const int SignShift = 15; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	internal const byte ShiftedSignMask = 1; //Field offset: 0x0
	[Token(Token = "0x400000A")]
	internal const ushort BiasedExponentMask = 31744; //Field offset: 0x0
	[Token(Token = "0x400000B")]
	internal const int BiasedExponentShift = 10; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	internal const int BiasedExponentLength = 5; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	internal const byte ShiftedBiasedExponentMask = 31; //Field offset: 0x0
	[Token(Token = "0x400000E")]
	internal const ushort TrailingSignificandMask = 1023; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	internal const byte MinSign = 0; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	internal const byte MaxSign = 1; //Field offset: 0x0
	[Token(Token = "0x4000011")]
	internal const byte MinBiasedExponent = 0; //Field offset: 0x0
	[Token(Token = "0x4000012")]
	internal const byte MaxBiasedExponent = 31; //Field offset: 0x0
	[Token(Token = "0x4000013")]
	internal const byte ExponentBias = 15; //Field offset: 0x0
	[Token(Token = "0x4000014")]
	internal const sbyte MinExponent = -14; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	internal const sbyte MaxExponent = 15; //Field offset: 0x0
	[Token(Token = "0x4000028")]
	private const ushort TauBits = 17992; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000029")]
	internal readonly ushort _value; //Field offset: 0x0

	[Token(Token = "0x17000007")]
	internal byte BiasedExponent
	{
		[Address(RVA = "0x124EAE0", Offset = "0x124DCE0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000D")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x1700000B")]
	public static Half E
	{
		[Address(RVA = "0x124EAF0", Offset = "0x124DCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600004C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000001")]
	public static Half Epsilon
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	internal sbyte Exponent
	{
		[Address(RVA = "0x124EB00", Offset = "0x124DD00", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000E")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000006")]
	public static Half MaxValue
	{
		[Address(RVA = "0x124EB10", Offset = "0x124DD10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public static Half MinValue
	{
		[Address(RVA = "0x124EB20", Offset = "0x124DD20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000009")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000F")]
	public static Half MultiplicativeIdentity
	{
		[Address(RVA = "0x124EB30", Offset = "0x124DD30", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000059")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public static Half NaN
	{
		[Address(RVA = "0x124EB40", Offset = "0x124DD40", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000008")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000003")]
	public static Half NegativeInfinity
	{
		[Address(RVA = "0x124EB50", Offset = "0x124DD50", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000007")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	public static Half NegativeOne
	{
		[Address(RVA = "0x124EB60", Offset = "0x124DD60", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000E")]
	public static Half NegativeZero
	{
		[Address(RVA = "0xAF6BD0", Offset = "0xAF5DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000010")]
	public static Half One
	{
		[Address(RVA = "0x124EB30", Offset = "0x124DD30", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	public static Half Pi
	{
		[Address(RVA = "0x124EB70", Offset = "0x124DD70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600004D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000002")]
	public static Half PositiveInfinity
	{
		[Address(RVA = "0x124EB80", Offset = "0x124DD80", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000006")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000009")]
	internal ushort Significand
	{
		[Address(RVA = "0x124EB90", Offset = "0x124DD90", Length = "0x23")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000F")]
		internal get { } //Length: 35
	}

	[Token(Token = "0x1700000D")]
	public static Half Tau
	{
		[Address(RVA = "0x124EBC0", Offset = "0x124DDC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600004E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000A")]
	internal ushort TrailingSignificand
	{
		[Address(RVA = "0x124EBD0", Offset = "0x124DDD0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000010")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000011")]
	public static Half Zero
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x124EAB0", Offset = "0x124DCB0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000C")]
	private Half(bool sign, ushort exp, ushort sig) { }

	[Address(RVA = "0x124EAA0", Offset = "0x124DCA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	internal Half(ushort value) { }

	[Address(RVA = "0x124D5D0", Offset = "0x124C7D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000064")]
	public static Half Abs(Half value) { }

	[Address(RVA = "0x124D5E0", Offset = "0x124C7E0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006B")]
	public static Half Acos(Half x) { }

	[Address(RVA = "0x124D650", Offset = "0x124C850", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000023")]
	private static bool AreZero(Half left, Half right) { }

	[Address(RVA = "0x124D670", Offset = "0x124C870", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B2D0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006C")]
	public static Half Asin(Half x) { }

	[Address(RVA = "0x124D780", Offset = "0x124C980", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B560")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	public static Half Atan(Half x) { }

	[Address(RVA = "0x124D6E0", Offset = "0x124C8E0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B7B0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000050")]
	public static Half Atan2(Half y, Half x) { }

	[Address(RVA = "0x124D7F0", Offset = "0x124C9F0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000045")]
	public static Half Ceiling(Half x) { }

	[Address(RVA = "0x124D860", Offset = "0x124CA60", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600005B")]
	public static Half Clamp(Half value, Half min, Half max) { }

	[Address(RVA = "0x124D9B0", Offset = "0x124CBB0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	public override int CompareTo(Half other) { }

	[Address(RVA = "0x124D8D0", Offset = "0x124CAD0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000024")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x124DB20", Offset = "0x124CD20", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600005C")]
	public static Half CopySign(Half value, Half sign) { }

	[Address(RVA = "0x124DB30", Offset = "0x124CD30", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006E")]
	public static Half Cos(Half x) { }

	[Address(RVA = "0x124DBA0", Offset = "0x124CDA0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C3B0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000052")]
	public static Half Cosh(Half x) { }

	[Address(RVA = "0x124DCD0", Offset = "0x124CED0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000027")]
	public override bool Equals(Half other) { }

	[Address(RVA = "0x124DC10", Offset = "0x124CE10", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000026")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x124DD10", Offset = "0x124CF10", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C7A0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000044")]
	public static Half Exp(Half x) { }

	[Address(RVA = "0x124DD80", Offset = "0x124CF80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000011")]
	internal static byte ExtractBiasedExponentFromBits(ushort bits) { }

	[Address(RVA = "0x124DD90", Offset = "0x124CF90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000012")]
	internal static ushort ExtractTrailingSignificandFromBits(ushort bits) { }

	[Address(RVA = "0x124DDA0", Offset = "0x124CFA0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000046")]
	public static Half Floor(Half x) { }

	[Address(RVA = "0x124EAE0", Offset = "0x124DCE0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000D")]
	internal byte get_BiasedExponent() { }

	[Address(RVA = "0x124EAF0", Offset = "0x124DCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004C")]
	public static Half get_E() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public static Half get_Epsilon() { }

	[Address(RVA = "0x124EB00", Offset = "0x124DD00", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000E")]
	internal sbyte get_Exponent() { }

	[Address(RVA = "0x124EB10", Offset = "0x124DD10", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000A")]
	public static Half get_MaxValue() { }

	[Address(RVA = "0x124EB20", Offset = "0x124DD20", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000009")]
	public static Half get_MinValue() { }

	[Address(RVA = "0x124EB30", Offset = "0x124DD30", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	public static Half get_MultiplicativeIdentity() { }

	[Address(RVA = "0x124EB40", Offset = "0x124DD40", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000008")]
	public static Half get_NaN() { }

	[Address(RVA = "0x124EB50", Offset = "0x124DD50", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000007")]
	public static Half get_NegativeInfinity() { }

	[Address(RVA = "0x124EB60", Offset = "0x124DD60", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000069")]
	public static Half get_NegativeOne() { }

	[Address(RVA = "0xAF6BD0", Offset = "0xAF5DD0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public static Half get_NegativeZero() { }

	[Address(RVA = "0x124EB30", Offset = "0x124DD30", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public static Half get_One() { }

	[Address(RVA = "0x124EB70", Offset = "0x124DD70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004D")]
	public static Half get_Pi() { }

	[Address(RVA = "0x124EB80", Offset = "0x124DD80", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000006")]
	public static Half get_PositiveInfinity() { }

	[Address(RVA = "0x124EB90", Offset = "0x124DD90", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000F")]
	internal ushort get_Significand() { }

	[Address(RVA = "0x124EBC0", Offset = "0x124DDC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004E")]
	public static Half get_Tau() { }

	[Address(RVA = "0x124EBD0", Offset = "0x124DDD0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000010")]
	internal ushort get_TrailingSignificand() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public static Half get_Zero() { }

	[Address(RVA = "0x124DE10", Offset = "0x124D010", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x124DE30", Offset = "0x124D030", Length = "0xE")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000019")]
	public static bool IsFinite(Half value) { }

	[Address(RVA = "0x124DE40", Offset = "0x124D040", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001A")]
	public static bool IsInfinity(Half value) { }

	[Address(RVA = "0x124DE80", Offset = "0x124D080", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001B")]
	public static bool IsNaN(Half value) { }

	[Address(RVA = "0x124DE60", Offset = "0x124D060", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001C")]
	internal static bool IsNaNOrZero(Half value) { }

	[Address(RVA = "0x124DEB0", Offset = "0x124D0B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600001D")]
	public static bool IsNegative(Half value) { }

	[Address(RVA = "0x124DEA0", Offset = "0x124D0A0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	public static bool IsNegativeInfinity(Half value) { }

	[Address(RVA = "0x124DEC0", Offset = "0x124D0C0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001F")]
	public static bool IsNormal(Half value) { }

	[Address(RVA = "0x124DEF0", Offset = "0x124D0F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000065")]
	public static bool IsPositive(Half value) { }

	[Address(RVA = "0x124DEE0", Offset = "0x124D0E0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000020")]
	public static bool IsPositiveInfinity(Half value) { }

	[Address(RVA = "0x124DF00", Offset = "0x124D100", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000066")]
	public static bool IsRealNumber(Half value) { }

	[Address(RVA = "0x124DF20", Offset = "0x124D120", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000021")]
	public static bool IsSubnormal(Half value) { }

	[Address(RVA = "0x124DF40", Offset = "0x124D140", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000022")]
	internal static bool IsZero(Half value) { }

	[Address(RVA = "0x124DF50", Offset = "0x124D150", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000051")]
	public static Half Lerp(Half value1, Half value2, Half amount) { }

	[Address(RVA = "0x124DFE0", Offset = "0x124D1E0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000057")]
	public static Half Log(Half x, Half newBase) { }

	[Address(RVA = "0x124E080", Offset = "0x124D280", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F4B0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000056")]
	public static Half Log(Half x) { }

	[Address(RVA = "0x124E1A0", Offset = "0x124D3A0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600005D")]
	public static Half Max(Half x, Half y) { }

	[Address(RVA = "0x124E0F0", Offset = "0x124D2F0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005E")]
	public static Half MaxNumber(Half x, Half y) { }

	[Address(RVA = "0x124E2E0", Offset = "0x124D4E0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600005F")]
	public static Half Min(Half x, Half y) { }

	[Address(RVA = "0x124E230", Offset = "0x124D430", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000060")]
	public static Half MinNumber(Half x, Half y) { }

	[Address(RVA = "0x124E370", Offset = "0x124D570", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000040")]
	internal static Half Negate(Half value) { }

	[Address(RVA = "0x124EBE0", Offset = "0x124DDE0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000041")]
	public static Half op_Addition(Half left, Half right) { }

	[Address(RVA = "0x124EC20", Offset = "0x124DE20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000042")]
	public static Half op_Decrement(Half value) { }

	[Address(RVA = "0x124EC40", Offset = "0x124DE40", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000043")]
	public static Half op_Division(Half left, Half right) { }

	[Address(RVA = "0x124EC80", Offset = "0x124DE80", Length = "0x40")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000017")]
	public static bool op_Equality(Half left, Half right) { }

	[Address(RVA = "0x124EEB0", Offset = "0x124E0B0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003B")]
	public static uint op_Explicit(Half value) { }

	[Address(RVA = "0x124ED40", Offset = "0x124DF40", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000032")]
	public static Half op_Explicit(ulong value) { }

	[Address(RVA = "0x124EE40", Offset = "0x124E040", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Token(Token = "0x600003F")]
	public static float op_Explicit(Half value) { }

	[Address(RVA = "0x124EDA0", Offset = "0x124DFA0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x6000035")]
	public static decimal op_Explicit(Half value) { }

	[Address(RVA = "0x124ED80", Offset = "0x124DF80", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public static short op_Explicit(Half value) { }

	[Address(RVA = "0x124EEE0", Offset = "0x124E0E0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000031")]
	public static Half op_Explicit(uint value) { }

	[Address(RVA = "0x124EF10", Offset = "0x124E110", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public static Half op_Explicit(ushort value) { }

	[Address(RVA = "0x124EF00", Offset = "0x124E100", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600002F")]
	public static Half op_Explicit(float value) { }

	[Address(RVA = "0x124ED80", Offset = "0x124DF80", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public static int op_Explicit(Half value) { }

	[Address(RVA = "0x124EE20", Offset = "0x124E020", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000038")]
	public static long op_Explicit(Half value) { }

	[Address(RVA = "0x124ED20", Offset = "0x124DF20", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public static char op_Explicit(Half value) { }

	[Address(RVA = "0x124ED80", Offset = "0x124DF80", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public static sbyte op_Explicit(Half value) { }

	[Address(RVA = "0x124EF30", Offset = "0x124E130", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002E")]
	public static Half op_Explicit(long value) { }

	[Address(RVA = "0x124EE50", Offset = "0x124E050", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	public static ulong op_Explicit(Half value) { }

	[Address(RVA = "0x124EEA0", Offset = "0x124E0A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600002D")]
	public static Half op_Explicit(int value) { }

	[Address(RVA = "0x124EF40", Offset = "0x124E140", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600002C")]
	public static Half op_Explicit(short value) { }

	[Address(RVA = "0x124ECC0", Offset = "0x124DEC0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600002B")]
	public static Half op_Explicit(decimal value) { }

	[Address(RVA = "0x124EF10", Offset = "0x124E110", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	public static Half op_Explicit(char value) { }

	[Address(RVA = "0x124ED20", Offset = "0x124DF20", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public static ushort op_Explicit(Half value) { }

	[Address(RVA = "0x124ED20", Offset = "0x124DF20", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public static byte op_Explicit(Half value) { }

	[Address(RVA = "0x124EFD0", Offset = "0x124E1D0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000014")]
	public static bool op_GreaterThan(Half left, Half right) { }

	[Address(RVA = "0x124EF60", Offset = "0x124E160", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000016")]
	public static bool op_GreaterThanOrEqual(Half left, Half right) { }

	[Address(RVA = "0x124F060", Offset = "0x124E260", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600003E")]
	public static Half op_Implicit(sbyte value) { }

	[Address(RVA = "0x124F040", Offset = "0x124E240", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600003D")]
	public static Half op_Implicit(byte value) { }

	[Address(RVA = "0x124F080", Offset = "0x124E280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000055")]
	public static Half op_Increment(Half value) { }

	[Address(RVA = "0x124F0A0", Offset = "0x124E2A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000018")]
	public static bool op_Inequality(Half left, Half right) { }

	[Address(RVA = "0x124F150", Offset = "0x124E350", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000013")]
	public static bool op_LessThan(Half left, Half right) { }

	[Address(RVA = "0x124F0E0", Offset = "0x124E2E0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000015")]
	public static bool op_LessThanOrEqual(Half left, Half right) { }

	[Address(RVA = "0x124F1C0", Offset = "0x124E3C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000058")]
	public static Half op_Modulus(Half left, Half right) { }

	[Address(RVA = "0x124F200", Offset = "0x124E400", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600005A")]
	public static Half op_Multiply(Half left, Half right) { }

	[Address(RVA = "0x124F240", Offset = "0x124E440", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x600006A")]
	public static Half op_Subtraction(Half left, Half right) { }

	[Address(RVA = "0x124F280", Offset = "0x124E480", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000071")]
	public static Half op_UnaryNegation(Half value) { }

	[Address(RVA = "0x124F2A0", Offset = "0x124E4A0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public static Half op_UnaryPlus(Half value) { }

	[Address(RVA = "0x124E390", Offset = "0x124D590", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000067")]
	public static Half Pow(Half x, Half y) { }

	[Address(RVA = "0x124E5B0", Offset = "0x124D7B0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004A")]
	public static Half Round(Half x, int digits, MidpointRounding mode) { }

	[Address(RVA = "0x124E4F0", Offset = "0x124D6F0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000048")]
	public static Half Round(Half x, int digits) { }

	[Address(RVA = "0x124E640", Offset = "0x124D840", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000047")]
	public static Half Round(Half x) { }

	[Address(RVA = "0x124E430", Offset = "0x124D630", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000049")]
	public static Half Round(Half x, MidpointRounding mode) { }

	[Address(RVA = "0x124E730", Offset = "0x124D930", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000061")]
	public static int Sign(Half value) { }

	[Address(RVA = "0x124E7C0", Offset = "0x124D9C0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006F")]
	public static Half Sin(Half x) { }

	[Address(RVA = "0x124E830", Offset = "0x124DA30", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D130")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000053")]
	public static Half Sinh(Half x) { }

	[Address(RVA = "0x124E8A0", Offset = "0x124DAA0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000068")]
	public static Half Sqrt(Half x) { }

	[Address(RVA = "0x124E920", Offset = "0x124DB20", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D560")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000070")]
	public static Half Tan(Half x) { }

	[Address(RVA = "0x124E990", Offset = "0x124DB90", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028DD00")]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000054")]
	public static Half Tanh(Half x) { }

	[Address(RVA = "0x124EA00", Offset = "0x124DC00", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000029")]
	public virtual string ToString() { }

	[Address(RVA = "0x124EA30", Offset = "0x124DC30", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004B")]
	public static Half Truncate(Half x) { }

}

