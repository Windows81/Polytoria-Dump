namespace System.Runtime.Remoting;

[Token(Token = "0x200034C")]
internal class DisposerReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E04")]
	private IMessageSink _next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E05")]
	private IDisposable _disposable; //Field offset: 0x18

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A70")]
	public DisposerReplySink(IMessageSink next, IDisposable disposable) { }

	[Address(RVA = "0x1366A80", Offset = "0x1365C80", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001A72")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1366AC0", Offset = "0x1365CC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A71")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

