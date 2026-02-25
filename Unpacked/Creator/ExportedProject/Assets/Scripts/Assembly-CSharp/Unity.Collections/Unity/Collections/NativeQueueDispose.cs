namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x200002B")]
internal struct NativeQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000062")]
	public UnsafeQueue<Int32>* m_QueueData; //Field offset: 0x0

	[Address(RVA = "0x18207C0", Offset = "0x181F9C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public void Dispose() { }

}

