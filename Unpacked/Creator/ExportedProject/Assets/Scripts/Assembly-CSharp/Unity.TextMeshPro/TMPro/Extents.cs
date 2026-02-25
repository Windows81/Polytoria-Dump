namespace TMPro;

[Token(Token = "0x2000026")]
public struct Extents
{
	[Token(Token = "0x40000DB")]
	internal static Extents zero; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	internal static Extents uninitialized; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DD")]
	public Vector2 min; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DE")]
	public Vector2 max; //Field offset: 0x8

	[Address(RVA = "0x1888DD0", Offset = "0x1887FD0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000145")]
	private static Extents() { }

	[Address(RVA = "0x880C70", Offset = "0x87FE70", Length = "0x8")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	public Extents(Vector2 min, Vector2 max) { }

	[Address(RVA = "0x1888BF0", Offset = "0x1887DF0", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000144")]
	public virtual string ToString() { }

}

