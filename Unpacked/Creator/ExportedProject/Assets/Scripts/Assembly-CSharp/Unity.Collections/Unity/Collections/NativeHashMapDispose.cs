namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000024")]
internal struct NativeHashMapDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400005A")]
	internal UnsafeHashMap<Int32, Int32>* m_HashMapData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005B")]
	internal AllocatorHandle m_Allocator; //Field offset: 0x8

	[Address(RVA = "0x1820740", Offset = "0x181F940", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004E")]
	internal void Dispose() { }

}

