namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x200039F")]
internal class ClientContextReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EB5")]
	private IMessageSink _replySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EB6")]
	private Context _context; //Field offset: 0x18

	[Address(RVA = "0x2F6040", Offset = "0x2F5240", Length = "0x4E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BE6")]
	public ClientContextReplySink(Context ctx, IMessageSink replySink) { }

	[Address(RVA = "0x137BF60", Offset = "0x137B160", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001BE8")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x137BFA0", Offset = "0x137B1A0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001BE7")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

