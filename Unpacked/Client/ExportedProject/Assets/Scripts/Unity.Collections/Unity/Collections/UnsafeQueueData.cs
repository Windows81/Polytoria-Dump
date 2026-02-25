namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200003C")]
internal struct UnsafeQueueData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007A")]
	public IntPtr m_FirstBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007B")]
	public IntPtr m_LastBlock; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007C")]
	public int m_MaxItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400007D")]
	public int m_CurrentRead; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007E")]
	public Byte* m_CurrentWriteBlockTLS; //Field offset: 0x18

	[Address(RVA = "0x1821290", Offset = "0x1820490", Length = "0x91")]
	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public static void DeallocateQueue(UnsafeQueueData* data, AllocatorHandle allocator) { }

}

