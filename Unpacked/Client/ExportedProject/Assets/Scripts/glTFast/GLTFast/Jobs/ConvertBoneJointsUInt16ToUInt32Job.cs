namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000142")]
internal struct ConvertBoneJointsUInt16ToUInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000468")]
	public Byte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x4000469")]
	public int inputByteStride; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400046A")]
	[WriteOnly]
	public uint4* result; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x400046B")]
	public int outputByteStride; //Field offset: 0x18

	[Address(RVA = "0x108A430", Offset = "0x1089630", Length = "0x4D")]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForExtensions+ParallelForJobStruct`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000374")]
	public override void Execute(int i) { }

}

