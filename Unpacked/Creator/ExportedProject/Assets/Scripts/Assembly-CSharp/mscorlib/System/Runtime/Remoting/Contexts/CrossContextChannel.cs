namespace System.Runtime.Remoting.Contexts;

[Token(Token = "0x2000366")]
internal class CrossContextChannel : IMessageSink
{
	[Token(Token = "0x2000367")]
	private class ContextRestoreSink : IMessageSink
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E54")]
		private IMessageSink _next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E55")]
		private Context _context; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E56")]
		private IMessage _call; //Field offset: 0x20

		[Address(RVA = "0x1013590", Offset = "0x1012790", Length = "0x6B")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B19")]
		public ContextRestoreSink(IMessageSink next, Context context, IMessage call) { }

		[Address(RVA = "0x1362D90", Offset = "0x1361F90", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B1B")]
		public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

		[Address(RVA = "0x1362DD0", Offset = "0x1361FD0", Length = "0x21F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813572E0")]
		[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B1A")]
		public override IMessage SyncProcessMessage(IMessage msg) { }

	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B18")]
	public CrossContextChannel() { }

	[Address(RVA = "0x1366340", Offset = "0x1365540", Length = "0x3BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181357330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001B17")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1366700", Offset = "0x1365900", Length = "0x378")]
	[CalledBy(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Context), Member = "GetServerContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181357330")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001B16")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

