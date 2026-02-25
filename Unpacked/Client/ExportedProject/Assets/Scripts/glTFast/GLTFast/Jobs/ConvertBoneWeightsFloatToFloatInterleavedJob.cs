namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000132")]
internal struct ConvertBoneWeightsFloatToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000428")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000429")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400042A")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400042B")]
	public float4* result; //Field offset: 0x18

	[Address(RVA = "0x108A4D0", Offset = "0x10896D0", Length = "0x44")]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000364")]
	public override void Execute(int i, int count) { }

}

