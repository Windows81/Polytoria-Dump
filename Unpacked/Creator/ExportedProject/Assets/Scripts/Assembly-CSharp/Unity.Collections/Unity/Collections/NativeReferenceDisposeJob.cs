namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x200002E")]
internal struct NativeReferenceDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	internal NativeReferenceDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1820800", Offset = "0x181FA00", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public override void Execute() { }

}

