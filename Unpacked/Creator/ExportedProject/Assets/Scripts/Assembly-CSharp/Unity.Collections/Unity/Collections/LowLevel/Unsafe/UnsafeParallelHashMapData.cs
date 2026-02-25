namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000049")]
internal struct UnsafeParallelHashMapData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A1")]
	internal Byte* values; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A2")]
	internal Byte* keys; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A3")]
	internal Byte* next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A4")]
	internal Byte* buckets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A5")]
	internal int keyCapacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A6")]
	internal int bucketCapacityMask; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A7")]
	internal int allocatedIndexLength; //Field offset: 0x28

	[Address(RVA = "0x1821220", Offset = "0x1820420", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000081")]
	internal static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorHandle allocator) { }

}

