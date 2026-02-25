namespace Mono.Net.Security;

[Token(Token = "0x2000051")]
internal class AsyncWriteRequest : AsyncReadOrWriteRequest
{

	[Address(RVA = "0x15ED610", Offset = "0x15EC810", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D3")]
	public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15ED620", Offset = "0x15EC820", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D4")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

