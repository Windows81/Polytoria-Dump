namespace UnityEngine.Bindings;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001DA")]
[VisibleToOtherModules]
internal struct ManagedSpanWrapper
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000678")]
	public readonly Void* begin; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000679")]
	public readonly int length; //Field offset: 0x8

	[Address(RVA = "0xCE3150", Offset = "0xCE2350", Length = "0x8")]
	[CallerCount(Count = 311)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C86")]
	public ManagedSpanWrapper(Void* begin, int length) { }

}

