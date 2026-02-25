namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
[Token(Token = "0x200004C")]
internal struct UnsafeParallelHashMapDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000AB")]
	public UnsafeParallelHashMapData* Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000AC")]
	public AllocatorHandle Allocator; //Field offset: 0x8

	[Address(RVA = "0x18211B0", Offset = "0x18203B0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000084")]
	public override void Execute() { }

}

