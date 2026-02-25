namespace Unity.Collections;

[NativeContainer]
[Token(Token = "0x200002D")]
internal struct NativeReferenceDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000064")]
	internal Void* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000065")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x1820800", Offset = "0x181FA00", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public void Dispose() { }

}

