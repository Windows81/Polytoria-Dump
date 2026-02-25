namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003BB")]
internal class ServerContextTerminatorSink : IMessageSink
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CB0")]
	public ServerContextTerminatorSink() { }

	[Address(RVA = "0x13964F0", Offset = "0x13956F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CAF")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x13965B0", Offset = "0x13957B0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CAE")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

