namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000052")]
internal struct UnsafeStreamBlockData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	internal AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BC")]
	internal UnsafeStreamBlock** Blocks; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BD")]
	internal int BlockCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BE")]
	internal Block Ranges; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000BF")]
	internal int RangeCount; //Field offset: 0x38

	[Address(RVA = "0x18213E0", Offset = "0x18205E0", Length = "0x39")]
	[CalledBy(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[Token(Token = "0x6000088")]
	internal void Free(UnsafeStreamBlock* oldBlock) { }

}

