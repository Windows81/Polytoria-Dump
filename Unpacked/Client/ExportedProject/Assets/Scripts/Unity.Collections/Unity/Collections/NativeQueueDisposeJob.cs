namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x200002C")]
internal struct NativeQueueDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000063")]
	public NativeQueueDispose Data; //Field offset: 0x0

	[Address(RVA = "0x18207C0", Offset = "0x181F9C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public override void Execute() { }

}

