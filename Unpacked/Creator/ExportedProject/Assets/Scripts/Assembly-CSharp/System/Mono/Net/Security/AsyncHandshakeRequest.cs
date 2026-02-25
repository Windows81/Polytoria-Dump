namespace Mono.Net.Security;

[Token(Token = "0x200004E")]
internal class AsyncHandshakeRequest : AsyncProtocolRequest
{

	[Address(RVA = "0x15ECF10", Offset = "0x15EC110", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncProtocolRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000CA")]
	public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) { }

	[Address(RVA = "0x15ECEE0", Offset = "0x15EC0E0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperationStatus), typeof(bool)}, ReturnType = typeof(AsyncOperationStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CB")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

