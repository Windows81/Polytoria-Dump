namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000384")]
internal class ContextLevelActivator : IActivator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6D")]
	private IActivator m_NextActivator; //Field offset: 0x10

	[Token(Token = "0x1700030E")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B6C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B6B")]
	public ContextLevelActivator(IActivator next) { }

	[Address(RVA = "0x1362AA0", Offset = "0x1361CA0", Length = "0x2E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Context), Member = "CreateNewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B6D")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B6C")]
	public override IActivator get_NextActivator() { }

}

