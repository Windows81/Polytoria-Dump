namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000381")]
internal class ActivationServices
{
	[Token(Token = "0x4000E6A")]
	private static IActivator _constructionActivator; //Field offset: 0x0

	[Token(Token = "0x1700030B")]
	private static IActivator ConstructionActivator
	{
		[Address(RVA = "0x1358910", Offset = "0x1357B10", Length = "0xA0")]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B5D")]
		private get { } //Length: 160
	}

	[Address(RVA = "0x1357930", Offset = "0x1356B30", Length = "0x1B8")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ActivationServices), Member = "RemoteActivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(RemotingProxy), Member = "AttachIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B5E")]
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	[Address(RVA = "0x1357AF0", Offset = "0x1356CF0", Length = "0x5")]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FormatterServices), Member = "nativeGetUninitializedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4E0")]
	[Token(Token = "0x6001B63")]
	public static object AllocateUninitializedClassInstance(Type type) { }

	[Address(RVA = "0x1357B00", Offset = "0x1356D00", Length = "0x859")]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ActivationServices), Member = "get_ConstructionActivator", ReturnType = typeof(IActivator))]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructionCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6001B60")]
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Object[] activationAttributes) { }

	[Address(RVA = "0x1358360", Offset = "0x1357560", Length = "0xF6")]
	[CalledBy(Type = typeof(ServerContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ActivationServices), Member = "AllocateUninitializedClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002140")]
	[Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B61")]
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0x1358460", Offset = "0x1357660", Length = "0x3D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsRemotelyActivatedClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ActivatedClientTypeEntry))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsWellKnownClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(WellKnownClientTypeEntry))]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001B62")]
	public static object CreateProxyForType(Type type) { }

	[Address(RVA = "0x1358840", Offset = "0x1357A40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C520")]
	[Token(Token = "0x6001B64")]
	public static void EnableProxyActivation(Type type, bool enable) { }

	[Address(RVA = "0x1358910", Offset = "0x1357B10", Length = "0xA0")]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B5D")]
	private static IActivator get_ConstructionActivator() { }

	[Address(RVA = "0x1358850", Offset = "0x1357A50", Length = "0xAF")]
	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B5F")]
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

}

