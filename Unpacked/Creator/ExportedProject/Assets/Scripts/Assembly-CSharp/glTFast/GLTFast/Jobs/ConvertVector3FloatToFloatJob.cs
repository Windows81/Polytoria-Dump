namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012A")]
internal struct ConvertVector3FloatToFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400040D")]
	public float3* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400040E")]
	public float3* result; //Field offset: 0x8

	[Address(RVA = "0x108C460", Offset = "0x108B660", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035C")]
	public override void Execute(int i) { }

}

