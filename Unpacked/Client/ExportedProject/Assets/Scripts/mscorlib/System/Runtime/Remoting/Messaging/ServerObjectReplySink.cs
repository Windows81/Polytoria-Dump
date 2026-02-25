namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003BD")]
internal class ServerObjectReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F09")]
	private IMessageSink _replySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F0A")]
	private ServerIdentity _identity; //Field offset: 0x18

	[Address(RVA = "0x2F6040", Offset = "0x2F5240", Length = "0x4E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CB4")]
	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink) { }

	[Address(RVA = "0x13966D0", Offset = "0x13958D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001CB6")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1396710", Offset = "0x1395910", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CB5")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

