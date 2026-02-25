namespace Mirror;

[DefaultMember("Item")]
[Token(Token = "0x200009E")]
public struct Vector3Long
{
	[Token(Token = "0x40001F9")]
	public static readonly Vector3Long zero; //Field offset: 0x0
	[Token(Token = "0x40001FA")]
	public static readonly Vector3Long one; //Field offset: 0x18
	[Token(Token = "0x40001FB")]
	public static readonly Vector3Long forward; //Field offset: 0x30
	[Token(Token = "0x40001FC")]
	public static readonly Vector3Long back; //Field offset: 0x48
	[Token(Token = "0x40001FD")]
	public static readonly Vector3Long left; //Field offset: 0x60
	[Token(Token = "0x40001FE")]
	public static readonly Vector3Long right; //Field offset: 0x78
	[Token(Token = "0x40001FF")]
	public static readonly Vector3Long up; //Field offset: 0x90
	[Token(Token = "0x4000200")]
	public static readonly Vector3Long down; //Field offset: 0xA8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F6")]
	public long x; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001F7")]
	public long y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F8")]
	public long z; //Field offset: 0x10

	[Token(Token = "0x17000082")]
	public long Item
	{
		[Address(RVA = "0x12A5690", Offset = "0x12A4890", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 182
		[Address(RVA = "0x12A5960", Offset = "0x12A4B60", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004E9")]
		 set { } //Length: 182
	}

	[Address(RVA = "0x12A5500", Offset = "0x12A4700", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004EE")]
	private static Vector3Long() { }

	[Address(RVA = "0x12A5680", Offset = "0x12A4880", Length = "0xC")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E0")]
	public Vector3Long(long x, long y, long z) { }

	[Address(RVA = "0x12A53A0", Offset = "0x12A45A0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004EB")]
	public bool Equals(Vector3Long other) { }

	[Address(RVA = "0x12A52D0", Offset = "0x12A44D0", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004EC")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x12A5690", Offset = "0x12A4890", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004E8")]
	public long get_Item(int index) { }

	[Address(RVA = "0x12A53E0", Offset = "0x12A45E0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(int))]
	[Token(Token = "0x60004ED")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12A5750", Offset = "0x12A4950", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E1")]
	public static Vector3Long op_Addition(Vector3Long a, Vector3Long b) { }

	[Address(RVA = "0x12A5780", Offset = "0x12A4980", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E6")]
	public static bool op_Equality(Vector3Long a, Vector3Long b) { }

	[Address(RVA = "0x12A57E0", Offset = "0x12A49E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E7")]
	public static bool op_Inequality(Vector3Long a, Vector3Long b) { }

	[Address(RVA = "0x12A58D0", Offset = "0x12A4AD0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E4")]
	public static Vector3Long op_Multiply(Vector3Long a, long n) { }

	[Address(RVA = "0x12A58A0", Offset = "0x12A4AA0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E5")]
	public static Vector3Long op_Multiply(long n, Vector3Long a) { }

	[Address(RVA = "0x12A5900", Offset = "0x12A4B00", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E2")]
	public static Vector3Long op_Subtraction(Vector3Long a, Vector3Long b) { }

	[Address(RVA = "0x12A5930", Offset = "0x12A4B30", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E3")]
	public static Vector3Long op_UnaryNegation(Vector3Long v) { }

	[Address(RVA = "0x12A5960", Offset = "0x12A4B60", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004E9")]
	public void set_Item(int index, long value) { }

	[Address(RVA = "0x12A5460", Offset = "0x12A4660", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60004EA")]
	public virtual string ToString() { }

}

