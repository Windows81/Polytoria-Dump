namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000145")]
internal struct ConvertScalarInt8ToFloatNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000470")]
	public SByte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000471")]
	[WriteOnly]
	public NativeArray<Single> result; //Field offset: 0x8

	[Address(RVA = "0x108B730", Offset = "0x108A930", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000378")]
	public override void Execute(int i) { }

}

