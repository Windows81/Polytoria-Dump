namespace System.Runtime.Remoting.Proxies;

[AttributeUsage(AttributeTargets::Class (4))]
[ComVisible(True)]
[Token(Token = "0x2000356")]
public class ProxyAttribute : Attribute, IContextAttribute
{

	[Address(RVA = "0x136B0B0", Offset = "0x136A2B0", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A9D")]
	public override MarshalByRefObject CreateInstance(Type serverType) { }

	[Address(RVA = "0x136B1D0", Offset = "0x136A3D0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RealProxy))]
	[Token(Token = "0x6001A9E")]
	public override RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[ComVisible(True)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A9F")]
	public override void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[ComVisible(True)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AA0")]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

