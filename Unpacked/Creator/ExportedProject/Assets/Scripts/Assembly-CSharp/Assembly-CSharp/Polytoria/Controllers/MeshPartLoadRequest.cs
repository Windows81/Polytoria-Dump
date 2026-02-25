namespace Polytoria.Controllers;

[Token(Token = "0x2000411")]
public struct MeshPartLoadRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400112B")]
	public int assetID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400112C")]
	public MeshPart meshPart; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400112D")]
	public Action onComplete; //Field offset: 0x10

	[Address(RVA = "0x4004F0", Offset = "0x3FF6F0", Length = "0x3C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4A")]
	public MeshPartLoadRequest(int assetID, MeshPart meshPart, Action onLoadComplete = null) { }

}

