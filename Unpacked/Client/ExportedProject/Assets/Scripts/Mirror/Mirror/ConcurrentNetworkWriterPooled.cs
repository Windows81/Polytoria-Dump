namespace Mirror;

[Token(Token = "0x200008A")]
public sealed class ConcurrentNetworkWriterPooled : NetworkWriter, IDisposable
{

	[Address(RVA = "0x1288D40", Offset = "0x1287F40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriter), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	public ConcurrentNetworkWriterPooled() { }

	[Address(RVA = "0x1288C80", Offset = "0x1287E80", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000479")]
	public override void Dispose() { }

}

