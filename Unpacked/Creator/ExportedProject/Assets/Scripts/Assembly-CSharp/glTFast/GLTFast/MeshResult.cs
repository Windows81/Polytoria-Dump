namespace GLTFast;

[IsReadOnly]
[Token(Token = "0x2000044")]
public struct MeshResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000167")]
	public readonly int meshIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000168")]
	public readonly Int32[] primitiveIndices; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000169")]
	public readonly Int32[] materialIndices; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016A")]
	public readonly Mesh mesh; //Field offset: 0x18

	[Address(RVA = "0x1076BD0", Offset = "0x1075DD0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600012D")]
	public MeshResult(int meshIndex, Int32[] primitiveIndices, Int32[] materialIndices, Mesh mesh) { }

}

