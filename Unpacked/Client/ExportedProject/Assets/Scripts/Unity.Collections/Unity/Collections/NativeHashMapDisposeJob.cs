namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x2000025")]
internal struct NativeHashMapDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005C")]
	internal NativeHashMapDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1820740", Offset = "0x181F940", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public override void Execute() { }

}

