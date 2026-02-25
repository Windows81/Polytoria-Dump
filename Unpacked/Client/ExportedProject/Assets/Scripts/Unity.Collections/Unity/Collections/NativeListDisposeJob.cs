namespace Unity.Collections;

[BurstCompile]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200002A")]
internal struct NativeListDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	internal NativeListDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1820780", Offset = "0x181F980", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeList`1<Int32>*)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	public override void Execute() { }

}

