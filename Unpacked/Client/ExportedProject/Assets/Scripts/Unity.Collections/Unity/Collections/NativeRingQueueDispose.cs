namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x200002F")]
internal struct NativeRingQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000067")]
	public UnsafeRingQueue<Int32>* m_QueueData; //Field offset: 0x0

	[Address(RVA = "0x1820840", Offset = "0x181FA40", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeRingQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public void Dispose() { }

}

