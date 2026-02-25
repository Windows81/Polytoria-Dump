namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000144")]
internal struct ConvertMatricesJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400046E")]
	public float4x4* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400046F")]
	[WriteOnly]
	public float4x4* result; //Field offset: 0x8

	[Address(RVA = "0x108AB30", Offset = "0x1089D30", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000377")]
	public override void Execute(int i) { }

}

