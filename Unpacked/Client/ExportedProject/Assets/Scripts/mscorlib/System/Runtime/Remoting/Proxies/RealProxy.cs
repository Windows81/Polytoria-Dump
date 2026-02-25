namespace System.Runtime.Remoting.Proxies;

[ComVisible(True)]
[Token(Token = "0x2000358")]
public abstract class RealProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E1F")]
	private Type class_to_proxy; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E20")]
	internal Context _targetContext; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E21")]
	internal MarshalByRefObject _server; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E22")]
	private int _targetDomainId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E23")]
	internal string _targetUri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E24")]
	internal Identity _objectIdentity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E25")]
	private object _objTP; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E26")]
	private object _stubData; //Field offset: 0x48

	[Token(Token = "0x170002E4")]
	internal Identity ObjectIdentity
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AAF")]
		internal get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AB0")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1075A40", Offset = "0x1074C40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA8")]
	protected RealProxy() { }

	[Address(RVA = "0x136C600", Offset = "0x136B800", Length = "0xA8")]
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
	[Token(Token = "0x6001AA9")]
	protected RealProxy(Type classToProxy) { }

	[Address(RVA = "0x136C420", Offset = "0x136B620", Length = "0xC4")]
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
	[Token(Token = "0x6001AAA")]
	internal RealProxy(Type classToProxy, ClientIdentity identity) { }

	[Address(RVA = "0x136C4F0", Offset = "0x136B6F0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AAB")]
	protected RealProxy(Type classToProxy, IntPtr stub, object stubData) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AB5")]
	protected void AttachServer(MarshalByRefObject s) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AAF")]
	internal Identity get_ObjectIdentity() { }

	[Address(RVA = "0x136B230", Offset = "0x136A430", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AB7")]
	internal object GetAppDomainTarget() { }

	[Address(RVA = "0x136B360", Offset = "0x136A560", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AAE")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x136B3D0", Offset = "0x136A5D0", Length = "0x88")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "get_TypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "CanCastTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C460")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AAD")]
	public Type GetProxiedType() { }

	[Address(RVA = "0x136B460", Offset = "0x136A660", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001AB4")]
	public override object GetTransparentProxy() { }

	[Address(RVA = "0x136B590", Offset = "0x136A790", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C460")]
	[Token(Token = "0x6001AAC")]
	private static Type InternalGetProxyType(object transparentProxy) { }

	[Address(RVA = "0x136B5A0", Offset = "0x136A7A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C480")]
	[Token(Token = "0x6001AB3")]
	internal override object InternalGetTransparentProxy(string className) { }

	[Token(Token = "0x6001AB1")]
	public abstract IMessage Invoke(IMessage msg) { }

	[Address(RVA = "0x136B5B0", Offset = "0x136A7B0", Length = "0x835")]
	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MethodCall), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(int), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(LogicalCallContext), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(AsyncResult), Member = "EndInvoke", ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(ConstructionCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsConstructor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(CallType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Exception), Member = "FixRemotingException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001AB2")]
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Object[] out_args) { }

	[Address(RVA = "0x136BDF0", Offset = "0x136AFF0", Length = "0x624")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RemotingServices), Member = "UpdateOutArgObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoMethodMessage), Member = "GetArg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoMethodMessage), Member = "NeedsOutProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Token(Token = "0x6001AB8")]
	private static Object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AB0")]
	internal void set_ObjectIdentity(Identity value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AB6")]
	internal void SetTargetDomain(int domainId) { }

}

