namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
[Token(Token = "0x2000045")]
internal struct UnsafeDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000095")]
	public Void* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000096")]
	public AllocatorHandle Allocator; //Field offset: 0x8

	[Address(RVA = "0x1821100", Offset = "0x1820300", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600007A")]
	public override void Execute() { }

}

