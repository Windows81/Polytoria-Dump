namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
[Token(Token = "0x2000198")]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	[Token(Token = "0x4000681")]
	private static Dictionary<String, Object> type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x4000682")]
	private static Dictionary<String, Object> assembly_resolve_in_progress; //Field offset: 0x80000008
	[ThreadStatic]
	[Token(Token = "0x4000683")]
	private static Dictionary<String, Object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000010
	[Token(Token = "0x4000680")]
	private static string _process_guid; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067F")]
	private IntPtr _mono_app_domain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000684")]
	private object _evidence; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000685")]
	private object _granted; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000686")]
	private int _principalPolicy; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000687")]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000688")]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000689")]
	private EventHandler DomainUnload; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400068A")]
	private EventHandler ProcessExit; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400068B")]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400068C")]
	private ResolveEventHandler TypeResolve; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400068D")]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400068E")]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400068F")]
	private object _domain_manager; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000690")]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000691")]
	private object _activation; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000692")]
	private object _applicationIdentity; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000693")]
	private List<String> compatibility_switch; //Field offset: 0x98

	[Token(Token = "0x14000003")]
	public override event EventHandler DomainUnload
	{
		[Address(RVA = "0x14EFC10", Offset = "0x14EEE10", Length = "0x9E")]
		[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EC8")]
		 add { } //Length: 158
		[Address(RVA = "0x14EFD70", Offset = "0x14EEF70", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EC9")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[Address(RVA = "0x14EFCB0", Offset = "0x14EEEB0", Length = "0x9E")]
		[CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000ECA")]
		 add { } //Length: 158
		[Address(RVA = "0x14EFE10", Offset = "0x14EF010", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000ECB")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000146")]
	public static AppDomain CurrentDomain
	{
		[Address(RVA = "0x14EFD50", Offset = "0x14EEF50", Length = "0x5")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214C80")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA6")]
	private AppDomain() { }

	[Address(RVA = "0x14EFC10", Offset = "0x14EEE10", Length = "0x9E")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EC8")]
	public override void add_DomainUnload(EventHandler value) { }

	[Address(RVA = "0x14EFCB0", Offset = "0x14EEEB0", Length = "0x9E")]
	[CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000ECA")]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[Address(RVA = "0x14EE5D0", Offset = "0x14ED7D0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AssemblyLoadEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EC1")]
	private void DoAssemblyLoad(Assembly assembly) { }

	[Address(RVA = "0x14EE660", Offset = "0x14ED860", Length = "0x387")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolveEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000EC2")]
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	[Address(RVA = "0x14EE9F0", Offset = "0x14EDBF0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EC5")]
	private void DoDomainUnload() { }

	[Address(RVA = "0x14EEA20", Offset = "0x14EDC20", Length = "0x160")]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResolveEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000EC4")]
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	[Address(RVA = "0x14EEB90", Offset = "0x14EDD90", Length = "0x314")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolveEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000EC3")]
	internal Assembly DoTypeResolve(string name) { }

	[Address(RVA = "0x14EFD50", Offset = "0x14EEF50", Length = "0x5")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214C80")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA9")]
	public static AppDomain get_CurrentDomain() { }

	[Address(RVA = "0x14EEEB0", Offset = "0x14EE0B0", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGrid", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.PlatformAutoDetector", Member = "AutoDetectPlatformFlags", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetAllAssemblyTypes", ReturnType = "System.Collections.Generic.IEnumerable`1<Type>")]
	[CalledBy(Type = "Battlehub.Reflection", Member = "GetAssignableFromTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.Type[]")]
	[CalledBy(Type = "SoftMasking.MaterialReplacer", Member = "CollectGlobalReplacers", ReturnType = "System.Collections.Generic.IEnumerable`1<IMaterialReplacer>")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213D70")]
	[Token(Token = "0x6000EAB")]
	public override Assembly[] GetAssemblies() { }

	[Address(RVA = "0x14EEEC0", Offset = "0x14EE0C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213D70")]
	[Token(Token = "0x6000EAA")]
	private Assembly[] GetAssemblies(bool refOnly) { }

	[Address(RVA = "0x14EFD50", Offset = "0x14EEF50", Length = "0x5")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214C80")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA8")]
	private static AppDomain getCurDomain() { }

	[Address(RVA = "0x14EEED0", Offset = "0x14EE0D0", Length = "0x5")]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213E10")]
	[Token(Token = "0x6000EAC")]
	public override object GetData(string name) { }

	[Address(RVA = "0x14EFD60", Offset = "0x14EEF60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Token(Token = "0x6000EBF")]
	private int getDomainID() { }

	[Address(RVA = "0x14EFC00", Offset = "0x14EEE00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA7")]
	private string getFriendlyName() { }

	[Address(RVA = "0x14EEEE0", Offset = "0x14EE0E0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214C80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(string), typeof(Type)}, ReturnType = typeof(ObjRef))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EC6")]
	internal Byte[] GetMarshalledDomainObjRef() { }

	[Address(RVA = "0x14EEFA0", Offset = "0x14EE1A0", Length = "0xA1")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214200")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000EBC")]
	internal static string GetProcessGuid() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAD")]
	public virtual object InitializeLifetimeService() { }

	[Address(RVA = "0x14EF050", Offset = "0x14EE250", Length = "0x5")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802141E0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB8")]
	internal static Context InternalGetContext() { }

	[Address(RVA = "0x14EF050", Offset = "0x14EE250", Length = "0x5")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802141E0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB9")]
	internal static Context InternalGetDefaultContext() { }

	[Address(RVA = "0x14EF060", Offset = "0x14EE260", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214200")]
	[Token(Token = "0x6000EBA")]
	internal static string InternalGetProcessGuid(string newguid) { }

	[Address(RVA = "0x12F3760", Offset = "0x12F2960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EBD")]
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	[Address(RVA = "0x14EF070", Offset = "0x14EE270", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214220")]
	[Token(Token = "0x6000EB6")]
	internal static void InternalPopDomainRef() { }

	[Address(RVA = "0x14EF080", Offset = "0x14EE280", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214240")]
	[Token(Token = "0x6000EB5")]
	internal static void InternalPushDomainRefByID(int domain_id) { }

	[Address(RVA = "0x14EF090", Offset = "0x14EE290", Length = "0x5")]
	[CalledBy(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CalledBy(Type = typeof(Context), Member = "SwitchToContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[CalledBy(Type = typeof(Context), Member = "DoCallBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CrossContextDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ContextLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214260")]
	[Token(Token = "0x6000EB7")]
	internal static Context InternalSetContext(Context context) { }

	[Address(RVA = "0x14EF0B0", Offset = "0x14EE2B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214280")]
	[Token(Token = "0x6000EB4")]
	private static AppDomain InternalSetDomain(AppDomain context) { }

	[Address(RVA = "0x14EF0A0", Offset = "0x14EE2A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142A0")]
	[Token(Token = "0x6000EB3")]
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	[Address(RVA = "0x14EF0C0", Offset = "0x14EE2C0", Length = "0x177")]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214C80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214240")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142A0")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(Exception&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214220")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000EBB")]
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, Object[] args) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x6000EA5")]
	internal static bool IsAppXModel() { }

	[Address(RVA = "0x14EF240", Offset = "0x14EE440", Length = "0x16")]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[Token(Token = "0x6000EBE")]
	public bool IsFinalizingForUnload() { }

	[Address(RVA = "0x14EF280", Offset = "0x14EE480", Length = "0x11D")]
	[CalledBy(Type = typeof(Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142C0")]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EB2")]
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x14EF3A0", Offset = "0x14EE5A0", Length = "0x12B")]
	[CalledBy(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142C0")]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EB1")]
	public override Assembly Load(string assemblyString) { }

	[Address(RVA = "0x14EF4D0", Offset = "0x14EE6D0", Length = "0x5E7")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assembly), Member = "LoadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142C0")]
	[Calls(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("Use an overload that does not take an Evidence parameter")]
	[Token(Token = "0x6000EB0")]
	public override Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	[Address(RVA = "0x14EF270", Offset = "0x14EE470", Length = "0xB")]
	[CalledBy(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[Token(Token = "0x6000EAF")]
	public override Assembly Load(AssemblyName assemblyRef) { }

	[Address(RVA = "0x14EF260", Offset = "0x14EE460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802142C0")]
	[Token(Token = "0x6000EAE")]
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x14EFAC0", Offset = "0x14EECC0", Length = "0x138")]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CADMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "DeserializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream), typeof(IMethodCallMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CADMethodReturnMessage), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(CADMethodReturnMessage))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EC7")]
	internal void ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg, out Byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[Address(RVA = "0x14EFD70", Offset = "0x14EEF70", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EC9")]
	public override void remove_DomainUnload(EventHandler value) { }

	[Address(RVA = "0x14EFE10", Offset = "0x14EF010", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000ECB")]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	[Address(RVA = "0x14EFC00", Offset = "0x14EEE00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EC0")]
	public virtual string ToString() { }

}

