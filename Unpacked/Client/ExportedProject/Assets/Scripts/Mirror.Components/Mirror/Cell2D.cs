namespace Mirror;

[Token(Token = "0x200000F")]
internal struct Cell2D
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000030")]
	internal readonly int q; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000031")]
	internal readonly int r; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	internal Cell2D(int q, int r) { }

	[Address(RVA = "0x120B310", Offset = "0x120A510", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000041")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x120B3A0", Offset = "0x120A5A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000042")]
	public virtual int GetHashCode() { }

}

