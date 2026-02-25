namespace Unity.Collections;

[NativeClass(null)]
[Token(Token = "0x2000042")]
internal struct NativeArrayDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B5")]
	internal NativeArrayDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1939360", Offset = "0x1938560", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public override void Execute() { }

	[Address(RVA = "0x19393B0", Offset = "0x19385B0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IJobExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArrayDisposeJob)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x60000AA")]
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

