namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000362")]
public class Context
{
	[ContextStatic]
	[Token(Token = "0x4000E46")]
	private static Object[] local_slots; //Field offset: 0x0
	[Token(Token = "0x4000E47")]
	private static IMessageSink default_server_context_sink; //Field offset: 0x8
	[Token(Token = "0x4000E4B")]
	private static int global_count; //Field offset: 0x10
	[Token(Token = "0x4000E4D")]
	private static LocalDataStoreMgr _localDataStoreMgr; //Field offset: 0x18
	[Token(Token = "0x4000E4E")]
	private static DynamicPropertyCollection global_dynamic_properties; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E42")]
	private int domain_id; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E43")]
	private int context_id; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E44")]
	private UIntPtr static_data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E45")]
	private UIntPtr data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E48")]
	private IMessageSink server_context_sink_chain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E49")]
	private IMessageSink client_context_sink_chain; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E4A")]
	private List<IContextProperty> context_properties; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E4C")]
	private LocalDataStoreHolder _localDataStore; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E4F")]
	private DynamicPropertyCollection context_dynamic_properties; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E50")]
	private ContextCallbackObject callback_object; //Field offset: 0x50

	[Token(Token = "0x170002F1")]
	public override int ContextID
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AEE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002F2")]
	public override IContextProperty[] ContextProperties
	{
		[Address(RVA = "0x1364EE0", Offset = "0x13640E0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6001AEF")]
		 get { } //Length: 96
	}

	[Token(Token = "0x170002F0")]
	public static Context DefaultContext
	{
		[Address(RVA = "0x1364F40", Offset = "0x1364140", Length = "0x7")]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AED")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002F6")]
	internal bool HasDynamicSinks
	{
		[Address(RVA = "0x1364F50", Offset = "0x1364150", Length = "0x41")]
		[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AF8")]
		internal get { } //Length: 65
	}

	[Token(Token = "0x170002F7")]
	internal bool HasExitSinks
	{
		[Address(RVA = "0x1364FA0", Offset = "0x13641A0", Length = "0x16D")]
		[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
		[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AF9")]
		internal get { } //Length: 365
	}

	[Token(Token = "0x170002F5")]
	internal static bool HasGlobalDynamicSinks
	{
		[Address(RVA = "0x1365110", Offset = "0x1364310", Length = "0xA1")]
		[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AF6")]
		internal get { } //Length: 161
	}

	[Token(Token = "0x170002F3")]
	internal bool IsDefaultContext
	{
		[Address(RVA = "0x55FC50", Offset = "0x55EE50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AF0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002F8")]
	private LocalDataStore MyLocalStore
	{
		[Address(RVA = "0x13651C0", Offset = "0x13643C0", Length = "0x171")]
		[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(LocalDataStoreHolder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6001B05")]
		private get { } //Length: 369
	}

	[Token(Token = "0x170002F4")]
	internal bool NeedsContextSink
	{
		[Address(RVA = "0x1365340", Offset = "0x1364540", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001AF1")]
		internal get { } //Length: 229
	}

	[Address(RVA = "0x1364DE0", Offset = "0x1363FE0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B0C")]
	private static Context() { }

	[Address(RVA = "0x1364E60", Offset = "0x1364060", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4A0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AEB")]
	public Context() { }

	[Address(RVA = "0x1362FF0", Offset = "0x13621F0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "AllocateDataSlot", ReturnType = typeof(LocalDataStoreSlot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B06")]
	public static LocalDataStoreSlot AllocateDataSlot() { }

	[Address(RVA = "0x1363050", Offset = "0x1362250", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "AllocateNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LocalDataStoreSlot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B07")]
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	[Address(RVA = "0x13630C0", Offset = "0x13622C0", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001B01")]
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	[Address(RVA = "0x1363250", Offset = "0x1362450", Length = "0x6BC")]
	[CalledBy(Type = typeof(ContextLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6001B03")]
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	[Address(RVA = "0x1363910", Offset = "0x1362B10", Length = "0x165")]
	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StackBuilderSink), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001B00")]
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	[Address(RVA = "0x1363A80", Offset = "0x1362C80", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B04")]
	public void DoCallBack(CrossContextDelegate deleg) { }

	[Address(RVA = "0x1363BB0", Offset = "0x1362DB0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001AEC")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1363C40", Offset = "0x1362E40", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "FreeNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B08")]
	public static void FreeNamedDataSlot(string name) { }

	[Address(RVA = "0x1363CB0", Offset = "0x1362EB0", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AFC")]
	public override void Freeze() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AEE")]
	public override int get_ContextID() { }

	[Address(RVA = "0x1364EE0", Offset = "0x13640E0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6001AEF")]
	public override IContextProperty[] get_ContextProperties() { }

	[Address(RVA = "0x1364F40", Offset = "0x1364140", Length = "0x7")]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AED")]
	public static Context get_DefaultContext() { }

	[Address(RVA = "0x1364F50", Offset = "0x1364150", Length = "0x41")]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AF8")]
	internal bool get_HasDynamicSinks() { }

	[Address(RVA = "0x1364FA0", Offset = "0x13641A0", Length = "0x16D")]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AF9")]
	internal bool get_HasExitSinks() { }

	[Address(RVA = "0x1365110", Offset = "0x1364310", Length = "0xA1")]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AF6")]
	internal static bool get_HasGlobalDynamicSinks() { }

	[Address(RVA = "0x55FC50", Offset = "0x55EE50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AF0")]
	internal bool get_IsDefaultContext() { }

	[Address(RVA = "0x13651C0", Offset = "0x13643C0", Length = "0x171")]
	[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(LocalDataStoreHolder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001B05")]
	private LocalDataStore get_MyLocalStore() { }

	[Address(RVA = "0x1365340", Offset = "0x1364540", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AF1")]
	internal bool get_NeedsContextSink() { }

	[Address(RVA = "0x1363E60", Offset = "0x1363060", Length = "0x187")]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(EnvoyTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(EnvoyTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001AFF")]
	internal IMessageSink GetClientContextSinkChain() { }

	[Address(RVA = "0x1363FF0", Offset = "0x13631F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(LocalDataStore))]
	[Calls(Type = typeof(LocalDataStore), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B0A")]
	public static object GetData(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x1364030", Offset = "0x1363230", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001AF4")]
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	[Address(RVA = "0x13641E0", Offset = "0x13633E0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LocalDataStoreSlot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B09")]
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	[Address(RVA = "0x1364250", Offset = "0x1363450", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001AFA")]
	public override IContextProperty GetProperty(string name) { }

	[Address(RVA = "0x13643C0", Offset = "0x13635C0", Length = "0x1A3")]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ConstructionLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001AFE")]
	internal IMessageSink GetServerContextSinkChain() { }

	[Address(RVA = "0x1364570", Offset = "0x1363770", Length = "0x91")]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AF7")]
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1364610", Offset = "0x1363810", Length = "0x11B")]
	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AF5")]
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1364730", Offset = "0x1363930", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4A0")]
	[Token(Token = "0x6001AE9")]
	private static void RegisterContext(Context ctx) { }

	[Address(RVA = "0x1364740", Offset = "0x1363940", Length = "0x1F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicProperty)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001AF2")]
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	[Address(RVA = "0x1364940", Offset = "0x1363B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C4C0")]
	[Token(Token = "0x6001AEA")]
	private static void ReleaseContext(Context ctx) { }

	[Address(RVA = "0x1364950", Offset = "0x1363B50", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(LocalDataStore))]
	[Calls(Type = typeof(LocalDataStore), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B0B")]
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	[Address(RVA = "0x13649A0", Offset = "0x1363BA0", Length = "0x1D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001AFB")]
	public override void SetProperty(IContextProperty prop) { }

	[Address(RVA = "0x1364B80", Offset = "0x1363D80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Token(Token = "0x6001B02")]
	internal static Context SwitchToContext(Context newContext) { }

	[Address(RVA = "0x1364B90", Offset = "0x1363D90", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001AFD")]
	public virtual string ToString() { }

	[Address(RVA = "0x1364BE0", Offset = "0x1363DE0", Length = "0x1F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "UnregisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001AF3")]
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

}

