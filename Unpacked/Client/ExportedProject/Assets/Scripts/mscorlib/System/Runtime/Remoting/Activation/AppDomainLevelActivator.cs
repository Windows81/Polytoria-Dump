namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000382")]
internal class AppDomainLevelActivator : IActivator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6B")]
	private string _activationUrl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E6C")]
	private IActivator _next; //Field offset: 0x18

	[Token(Token = "0x1700030C")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B66")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B65")]
	public AppDomainLevelActivator(string activationUrl, IActivator next) { }

	[Address(RVA = "0x1358B10", Offset = "0x1357D10", Length = "0x37F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B67")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B66")]
	public override IActivator get_NextActivator() { }

}

