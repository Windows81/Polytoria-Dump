namespace System.Runtime.Remoting.Proxies;

[Token(Token = "0x2000359")]
internal class RemotingProxy : RealProxy, IRemotingTypeInfo
{
	[Token(Token = "0x4000E27")]
	private static MethodInfo _cache_GetTypeMethod; //Field offset: 0x0
	[Token(Token = "0x4000E28")]
	private static MethodInfo _cache_GetHashCodeMethod; //Field offset: 0x8
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E29")]
	private IMessageSink _sink; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E2A")]
	private bool _hasEnvoySink; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E2B")]
	private ConstructionCall _ctorCall; //Field offset: 0x60

	[Token(Token = "0x170002E5")]
	public override string TypeName
	{
		[Address(RVA = "0x136FA70", Offset = "0x136EC70", Length = "0x11E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6001ABE")]
		 get { } //Length: 286
	}

	[Address(RVA = "0x136F760", Offset = "0x136E960", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AC1")]
	private static RemotingProxy() { }

	[Address(RVA = "0x136F870", Offset = "0x136EA70", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AB9")]
	internal RemotingProxy(Type type, ClientIdentity identity) { }

	[Address(RVA = "0x136F980", Offset = "0x136EB80", Length = "0xE6")]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ProxyAttribute), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MarshalByRefObject))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001ABA")]
	internal RemotingProxy(Type type, string activationUrl, Object[] activationAttributes) { }

	[Address(RVA = "0x136EB80", Offset = "0x136DD80", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodCall), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001ABD")]
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	[Address(RVA = "0x136EC60", Offset = "0x136DE60", Length = "0x2EF")]
	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ClientIdentity), Member = "set_ClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001ABC")]
	internal void AttachIdentity(Identity identity) { }

	[Address(RVA = "0x136EF50", Offset = "0x136E150", Length = "0x26E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001ABF")]
	public override bool CanCastTo(Type fromType, object o) { }

	[Address(RVA = "0x136F1C0", Offset = "0x136E3C0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001AC0")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x136FA70", Offset = "0x136EC70", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001ABE")]
	public override string get_TypeName() { }

	[Address(RVA = "0x136F2A0", Offset = "0x136E4A0", Length = "0x4BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(CallType))]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(int), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001ABB")]
	public virtual IMessage Invoke(IMessage request) { }

}

