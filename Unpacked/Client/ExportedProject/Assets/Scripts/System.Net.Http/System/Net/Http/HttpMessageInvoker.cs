namespace System.Net.Http;

[Token(Token = "0x2000013")]
public class HttpMessageInvoker : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000054")]
	 HttpMessageHandler handler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000055")]
	private readonly bool disposeHandler; //Field offset: 0x18

	[Address(RVA = "0x16112F0", Offset = "0x16104F0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000057")]
	public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler) { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public override void Dispose() { }

	[Address(RVA = "0x16112A0", Offset = "0x16104A0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000059")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x160C800", Offset = "0x160BA00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

