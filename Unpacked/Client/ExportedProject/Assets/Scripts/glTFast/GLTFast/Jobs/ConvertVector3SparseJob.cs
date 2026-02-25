namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000130")]
internal struct ConvertVector3SparseJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400041D")]
	public Void* indexBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400041E")]
	public FunctionPointer<GetIndexDelegate> indexConverter; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400041F")]
	public int inputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000420")]
	public Void* input; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000421")]
	public FunctionPointer<GetFloat3Delegate> valueConverter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ReadOnly]
	[Token(Token = "0x4000422")]
	public int outputByteStride; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000423")]
	public float3* result; //Field offset: 0x30

	[Address(RVA = "0x108C6D0", Offset = "0x108B8D0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FunctionPointer`1), Member = "get_Invoke", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000362")]
	public override void Execute(int i) { }

}

