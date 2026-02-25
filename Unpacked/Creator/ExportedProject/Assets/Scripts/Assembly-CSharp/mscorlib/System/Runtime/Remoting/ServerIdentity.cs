namespace System.Runtime.Remoting;

[Token(Token = "0x2000348")]
internal abstract class ServerIdentity : Identity
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DFE")]
	protected Type _objectType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DFF")]
	protected MarshalByRefObject _serverObject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E00")]
	protected IMessageSink _serverSink; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E01")]
	protected Context _context; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E02")]
	protected Lease _lease; //Field offset: 0x68

	[Token(Token = "0x170002D5")]
	public Context Context
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A5E")]
		 get { } //Length: 5
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A5F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002D4")]
	public Lease Lease
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A5D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002D3")]
	public Type ObjectType
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A58")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13746C0", Offset = "0x13738C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A57")]
	public ServerIdentity(string objectUri, Context context, Type objectType) { }

	[Token(Token = "0x6001A61")]
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1374080", Offset = "0x1373280", Length = "0x74")]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Type), typeof(string)}, ReturnType = typeof(ClientActivatedIdentity))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001A5C")]
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	[Address(RVA = "0x1374100", Offset = "0x1373300", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypeInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001A5B")]
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x13742F0", Offset = "0x13734F0", Length = "0x92")]
	[CalledBy(Type = typeof(ServerIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MarshalByRefObject), Member = "set_ObjectIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TrackingServices), Member = "NotifyDisconnectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A62")]
	protected void DisposeServerObject() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A5E")]
	public Context get_Context() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A5D")]
	public Lease get_Lease() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A58")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1374390", Offset = "0x1373590", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[Token(Token = "0x6001A5A")]
	public override void OnLifetimeExpired() { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A5F")]
	public void set_Context(Context value) { }

	[Address(RVA = "0x13743A0", Offset = "0x13735A0", Length = "0x31B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A59")]
	public void StartTrackingLifetime(ILease lease) { }

	[Token(Token = "0x6001A60")]
	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

}

