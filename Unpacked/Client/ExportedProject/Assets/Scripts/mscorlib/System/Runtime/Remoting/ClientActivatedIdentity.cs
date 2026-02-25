namespace System.Runtime.Remoting;

[Token(Token = "0x2000349")]
internal class ClientActivatedIdentity : ServerIdentity
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E03")]
	private MarshalByRefObject _targetThis; //Field offset: 0x70

	[Address(RVA = "0x135EF90", Offset = "0x135E190", Length = "0x61")]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Type), typeof(string)}, ReturnType = typeof(ClientActivatedIdentity))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A63")]
	public ClientActivatedIdentity(string objectUri, Type objectType) { }

	[Address(RVA = "0x135EDD0", Offset = "0x135DFD0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A68")]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A64")]
	public MarshalByRefObject GetServerObject() { }

	[Address(RVA = "0x135EE90", Offset = "0x135E090", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A66")]
	public virtual void OnLifetimeExpired() { }

	[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A65")]
	public void SetClientProxy(MarshalByRefObject obj) { }

	[Address(RVA = "0x135EEF0", Offset = "0x135E0F0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A67")]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

