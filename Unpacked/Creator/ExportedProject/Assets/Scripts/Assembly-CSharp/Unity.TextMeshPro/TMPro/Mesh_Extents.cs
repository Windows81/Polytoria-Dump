namespace TMPro;

[Token(Token = "0x2000027")]
public struct Mesh_Extents
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DF")]
	public Vector2 min; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E0")]
	public Vector2 max; //Field offset: 0x8

	[Address(RVA = "0x880C70", Offset = "0x87FE70", Length = "0x8")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000146")]
	public Mesh_Extents(Vector2 min, Vector2 max) { }

	[Address(RVA = "0x1889750", Offset = "0x1888950", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000147")]
	public virtual string ToString() { }

}

