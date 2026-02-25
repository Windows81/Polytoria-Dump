namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000042")]
internal struct HashMapHelper
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000088")]
	internal Byte* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000089")]
	internal TKey* Keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400008A")]
	internal Int32* Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400008B")]
	internal Int32* Buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008C")]
	internal int Count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008D")]
	internal int Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008E")]
	internal int Log2MinGrowth; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008F")]
	internal int BucketCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000090")]
	internal int AllocatedIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000091")]
	internal int FirstFreeIdx; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000092")]
	internal int SizeOfTValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000093")]
	internal AllocatorHandle Allocator; //Field offset: 0x0

	[Token(Token = "0x17000011")]
	internal bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000073")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0xC5BDA0", Offset = "0xC5AFA0", Length = "0x54")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	internal void Dispose() { }

	[Address(RVA = "0xC5BE00", Offset = "0xC5B000", Length = "0xED")]
	[CalledBy(Type = typeof(NativeHashMapDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashMapDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	internal static void Free(HashMapHelper<TKey>* data) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000073")]
	internal bool get_IsCreated() { }

}

