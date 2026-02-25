namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000129")]
internal struct MemCopyJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400040A")]
	public long bufferSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400040B")]
	public Void* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400040C")]
	public Void* result; //Field offset: 0x10

	[Address(RVA = "0x1092F40", Offset = "0x1092140", Length = "0x13")]
	[CalledBy(Type = "Unity.Jobs.IJobExtensions+JobStruct`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Token(Token = "0x600035B")]
	public override void Execute() { }

}

