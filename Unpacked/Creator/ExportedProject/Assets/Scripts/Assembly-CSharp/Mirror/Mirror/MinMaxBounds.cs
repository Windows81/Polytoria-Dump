namespace Mirror;

[Token(Token = "0x200001F")]
public struct MinMaxBounds : IEquatable<Bounds>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004B")]
	public Vector3 min; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400004C")]
	public Vector3 max; //Field offset: 0xC

	[Address(RVA = "0x12518A0", Offset = "0x1250AA0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000AC")]
	public void Encapsulate(Vector3 point) { }

	[Address(RVA = "0x1251910", Offset = "0x1250B10", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000AD")]
	public void Encapsulate(MinMaxBounds bounds) { }

	[Address(RVA = "0x12519C0", Offset = "0x1250BC0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1251AD0", Offset = "0x1250CD0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B1")]
	public bool Equals(MinMaxBounds other) { }

	[Address(RVA = "0x1251B50", Offset = "0x1250D50", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B2")]
	public override bool Equals(Bounds other) { }

	[Address(RVA = "0x1251C00", Offset = "0x1250E00", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(int))]
	[Token(Token = "0x60000B3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1251D50", Offset = "0x1250F50", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000AE")]
	public static bool op_Equality(MinMaxBounds lhs, Bounds rhs) { }

	[Address(RVA = "0x1251E40", Offset = "0x1251040", Length = "0x115")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000AF")]
	public static bool op_Inequality(MinMaxBounds lhs, Bounds rhs) { }

	[Address(RVA = "0x1251CB0", Offset = "0x1250EB0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000B4")]
	public virtual string ToString() { }

}

