namespace System.Runtime.Remoting;

[Token(Token = "0x200033C")]
internal abstract class Identity
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DC2")]
	protected string _objectUri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DC3")]
	protected IMessageSink _channelSink; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DC4")]
	protected IMessageSink _envoySink; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DC5")]
	private DynamicPropertyCollection _clientDynamicProperties; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DC6")]
	private DynamicPropertyCollection _serverDynamicProperties; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DC7")]
	protected ObjRef _objRef; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DC8")]
	private bool _disposed; //Field offset: 0x40

	[Token(Token = "0x170002BF")]
	public IMessageSink ChannelSink
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019CF")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002C4")]
	public DynamicPropertyCollection ClientDynamicProperties
	{
		[Address(RVA = "0x13676A0", Offset = "0x13668A0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60019D7")]
		 get { } //Length: 188
	}

	[Token(Token = "0x170002C3")]
	public bool Disposed
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D5")]
		 get { } //Length: 5
		[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C0")]
	public IMessageSink EnvoySink
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C5")]
	public bool HasServerDynamicSinks
	{
		[Address(RVA = "0x1367760", Offset = "0x1366960", Length = "0x41")]
		[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019D8")]
		 get { } //Length: 65
	}

	[Token(Token = "0x170002C2")]
	public bool IsConnected
	{
		[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170002C1")]
	public string ObjectUri
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D2")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60019D3")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019CD")]
	public Identity(string objectUri) { }

	[Token(Token = "0x60019CE")]
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019CF")]
	public IMessageSink get_ChannelSink() { }

	[Address(RVA = "0x13676A0", Offset = "0x13668A0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60019D7")]
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D5")]
	public bool get_Disposed() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D1")]
	public IMessageSink get_EnvoySink() { }

	[Address(RVA = "0x1367760", Offset = "0x1366960", Length = "0x41")]
	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019D8")]
	public bool get_HasServerDynamicSinks() { }

	[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D4")]
	public bool get_IsConnected() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D2")]
	public string get_ObjectUri() { }

	[Address(RVA = "0x1367560", Offset = "0x1366760", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019D9")]
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1367600", Offset = "0x1366800", Length = "0x91")]
	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ServerObjectReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019DA")]
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D0")]
	public void set_ChannelSink(IMessageSink value) { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D6")]
	public void set_Disposed(bool value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019D3")]
	public void set_ObjectUri(string value) { }

}

