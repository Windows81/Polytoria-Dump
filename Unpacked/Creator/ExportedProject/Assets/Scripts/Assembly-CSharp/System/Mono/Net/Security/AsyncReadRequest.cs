namespace Mono.Net.Security;

[Token(Token = "0x2000050")]
internal class AsyncReadRequest : AsyncReadOrWriteRequest
{

	[Address(RVA = "0x15ED610", Offset = "0x15EC810", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D1")]
	public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15ED590", Offset = "0x15EC790", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D2")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

