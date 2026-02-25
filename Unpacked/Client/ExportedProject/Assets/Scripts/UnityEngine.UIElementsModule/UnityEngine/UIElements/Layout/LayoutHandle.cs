namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[Token(Token = "0x20005B8")]
internal struct LayoutHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014C2")]
	public readonly int Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40014C3")]
	public readonly int Version; //Field offset: 0x4

	[Token(Token = "0x17000A33")]
	public static LayoutHandle Undefined
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028C3")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C4")]
	internal LayoutHandle(int index, int version) { }

	[Address(RVA = "0x19412E0", Offset = "0x19404E0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C5")]
	public bool Equals(LayoutHandle other) { }

	[Address(RVA = "0x1BAA190", Offset = "0x1BA9390", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028C6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C3")]
	public static LayoutHandle get_Undefined() { }

	[Address(RVA = "0x1B174C0", Offset = "0x1B166C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C7")]
	public virtual int GetHashCode() { }

}

