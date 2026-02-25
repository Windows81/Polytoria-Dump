namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200003E")]
internal struct UnsafeQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000081")]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000082")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x1821340", Offset = "0x1820540", Length = "0x92")]
	[CalledBy(Type = typeof(UnsafeQueueDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	public void Dispose() { }

}

