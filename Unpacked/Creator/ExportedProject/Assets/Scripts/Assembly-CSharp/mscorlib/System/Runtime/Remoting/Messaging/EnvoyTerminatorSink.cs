namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A3")]
internal class EnvoyTerminatorSink : IMessageSink
{
	[Token(Token = "0x4000EBF")]
	public static EnvoyTerminatorSink Instance; //Field offset: 0x0

	[Address(RVA = "0x137E540", Offset = "0x137D740", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C05")]
	private static EnvoyTerminatorSink() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C04")]
	public EnvoyTerminatorSink() { }

	[Address(RVA = "0x137E460", Offset = "0x137D660", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C03")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x137E4E0", Offset = "0x137D6E0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C02")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

