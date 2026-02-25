namespace Mirror;

[DefaultMember("Item")]
[Token(Token = "0x200009F")]
public struct Vector4Long
{
	[Token(Token = "0x4000205")]
	public static readonly Vector4Long zero; //Field offset: 0x0
	[Token(Token = "0x4000206")]
	public static readonly Vector4Long one; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000201")]
	public long x; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000202")]
	public long y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000203")]
	public long z; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000204")]
	public long w; //Field offset: 0x18

	[Token(Token = "0x17000083")]
	public long Item
	{
		[Address(RVA = "0x12A5E70", Offset = "0x12A5070", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004F7")]
		 get { } //Length: 197
		[Address(RVA = "0x12A6110", Offset = "0x12A5310", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004F8")]
		 set { } //Length: 197
	}

	[Address(RVA = "0x12A5DF0", Offset = "0x12A4FF0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004FD")]
	private static Vector4Long() { }

	[Address(RVA = "0x12A5E50", Offset = "0x12A5050", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004EF")]
	public Vector4Long(long x, long y, long z, long w) { }

	[Address(RVA = "0x12A5B10", Offset = "0x12A4D10", Length = "0x37")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004FA")]
	public bool Equals(Vector4Long other) { }

	[Address(RVA = "0x12A5A20", Offset = "0x12A4C20", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004FB")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x12A5E70", Offset = "0x12A5070", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004F7")]
	public long get_Item(int index) { }

	[Address(RVA = "0x12A5B50", Offset = "0x12A4D50", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, ReturnType = typeof(int))]
	[Token(Token = "0x60004FC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12A5F40", Offset = "0x12A5140", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004F0")]
	public static Vector4Long op_Addition(Vector4Long a, Vector4Long b) { }

	[Address(RVA = "0x12A5F80", Offset = "0x12A5180", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004F5")]
	public static bool op_Equality(Vector4Long a, Vector4Long b) { }

	[Address(RVA = "0x12A5FC0", Offset = "0x12A51C0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004F6")]
	public static bool op_Inequality(Vector4Long a, Vector4Long b) { }

	[Address(RVA = "0x12A6040", Offset = "0x12A5240", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004F3")]
	public static Vector4Long op_Multiply(Vector4Long a, long n) { }

	[Address(RVA = "0x12A6070", Offset = "0x12A5270", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004F4")]
	public static Vector4Long op_Multiply(long n, Vector4Long a) { }

	[Address(RVA = "0x12A60A0", Offset = "0x12A52A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004F1")]
	public static Vector4Long op_Subtraction(Vector4Long a, Vector4Long b) { }

	[Address(RVA = "0x12A60E0", Offset = "0x12A52E0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004F2")]
	public static Vector4Long op_UnaryNegation(Vector4Long v) { }

	[Address(RVA = "0x12A6110", Offset = "0x12A5310", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004F8")]
	public void set_Item(int index, long value) { }

	[Address(RVA = "0x12A5BF0", Offset = "0x12A4DF0", Length = "0x1FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004F9")]
	public virtual string ToString() { }

}

