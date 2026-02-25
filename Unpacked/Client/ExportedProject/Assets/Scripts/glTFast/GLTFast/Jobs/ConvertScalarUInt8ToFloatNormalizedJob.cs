namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000146")]
internal struct ConvertScalarUInt8ToFloatNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000472")]
	public Byte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000473")]
	[WriteOnly]
	public NativeArray<Single> result; //Field offset: 0x8

	[Address(RVA = "0x108B7B0", Offset = "0x108A9B0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000379")]
	public override void Execute(int i) { }

}

