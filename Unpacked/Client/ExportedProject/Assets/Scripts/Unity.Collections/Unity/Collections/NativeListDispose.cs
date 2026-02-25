namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000029")]
internal struct NativeListDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000060")]
	public UntypedUnsafeList* m_ListData; //Field offset: 0x0

	[Address(RVA = "0x1820780", Offset = "0x181F980", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeList`1<Int32>*)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	public void Dispose() { }

}

