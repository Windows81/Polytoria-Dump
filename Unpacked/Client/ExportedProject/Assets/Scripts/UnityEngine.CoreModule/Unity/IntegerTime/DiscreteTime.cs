namespace Unity.IntegerTime;

[Token(Token = "0x2000018")]
public struct DiscreteTime : IEquatable<DiscreteTime>, IFormattable, IComparable<DiscreteTime>
{
	[Token(Token = "0x400001E")]
	public static readonly DiscreteTime Zero; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	public static readonly DiscreteTime MinValue; //Field offset: 0x8
	[Token(Token = "0x4000020")]
	public static readonly DiscreteTime MaxValue; //Field offset: 0x10
	[Token(Token = "0x4000021")]
	private static readonly int TicksPerSecondBits; //Field offset: 0x18
	[Token(Token = "0x4000022")]
	private static readonly int NonPow2TpsBits; //Field offset: 0x1C
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	public long Value; //Field offset: 0x0

	[Address(RVA = "0x1926C30", Offset = "0x1925E30", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000049")]
	private static DiscreteTime() { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	private DiscreteTime(long v, int _) { }

	[Address(RVA = "0x1926DE0", Offset = "0x1925FE0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000038")]
	public DiscreteTime(float v) { }

	[Address(RVA = "0x1926D70", Offset = "0x1925F70", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000039")]
	public DiscreteTime(double v) { }

	[Address(RVA = "0x1926A80", Offset = "0x1925C80", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[IsReadOnly]
	[Token(Token = "0x6000048")]
	public override int CompareTo(DiscreteTime other) { }

	[Address(RVA = "0xF67EA0", Offset = "0xF670A0", Length = "0x9")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000043")]
	public override bool Equals(DiscreteTime rhs) { }

	[Address(RVA = "0x1926A90", Offset = "0x1925C90", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6000044")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public static DiscreteTime FromTicks(long v) { }

	[Address(RVA = "0x1926B20", Offset = "0x1925D20", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[IsReadOnly]
	[Token(Token = "0x6000045")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1926E50", Offset = "0x1926050", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000041")]
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x1926EC0", Offset = "0x19260C0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	public static float op_Explicit(DiscreteTime d) { }

	[Address(RVA = "0x1926EA0", Offset = "0x19260A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003D")]
	public static double op_Explicit(DiscreteTime d) { }

	[Address(RVA = "0x1926EF0", Offset = "0x19260F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003F")]
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x1926EE0", Offset = "0x19260E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000040")]
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x1926F00", Offset = "0x1926100", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003E")]
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x1926F10", Offset = "0x1926110", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000042")]
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x1926BC0", Offset = "0x1925DC0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6000046")]
	public virtual string ToString() { }

	[Address(RVA = "0x1926B30", Offset = "0x1925D30", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6000047")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

