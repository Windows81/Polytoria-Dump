namespace MoonSharp.Interpreter;

[Token(Token = "0x200007B")]
public class Script : IScriptPrivateResource
{
	[CompilerGenerated]
	[Token(Token = "0x200007C")]
	private sealed class <>c
	{
		[Token(Token = "0x400026E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400026F")]
		public static Func<Instruction, String> <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x314320", Offset = "0x313520", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006A3")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A4")]
		public <>c() { }

		[Address(RVA = "0x313D70", Offset = "0x312F70", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006A6")]
		internal void <.cctor>b__68_0(string s) { }

		[Address(RVA = "0x313EA0", Offset = "0x3130A0", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006A7")]
		internal string <.cctor>b__68_1(string s) { }

		[Address(RVA = "0x313D20", Offset = "0x312F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A5")]
		internal string <SignalByteCodeChange>b__27_0(Instruction s) { }

	}

	[Token(Token = "0x4000261")]
	public const string VERSION = "2.0.0.0"; //Field offset: 0x0
	[Token(Token = "0x4000262")]
	public const string LUA_VERSION = "5.2"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000269")]
	private static readonly ScriptOptions <DefaultOptions>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400026B")]
	private static readonly ScriptGlobalOptions <GlobalOptions>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000263")]
	private Processor m_MainProcessor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000264")]
	private ByteCode m_ByteCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000265")]
	private List<SourceCode> m_Sources; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000266")]
	private Table m_GlobalTable; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000267")]
	private IDebugger m_Debugger; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000268")]
	private Table[] m_TypeMetatables; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400026A")]
	private ScriptOptions <Options>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400026C")]
	private PerformanceStatistics <PerformanceStats>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400026D")]
	private Table <Registry>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x170000DD")]
	public bool DebuggerEnabled
	{
		[Address(RVA = "0x30F830", Offset = "0x30EA30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Processor), Member = "get_DebuggerEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000692")]
		 get { } //Length: 29
		[Address(RVA = "0x30F930", Offset = "0x30EB30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Processor), Member = "set_DebuggerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000693")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170000D8")]
	public static ScriptOptions DefaultOptions
	{
		[Address(RVA = "0x30F850", Offset = "0x30EA50", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000676")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000DA")]
	public static ScriptGlobalOptions GlobalOptions
	{
		[Address(RVA = "0x30F8A0", Offset = "0x30EAA0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000679")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000DC")]
	public Table Globals
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E0")]
	private override Script MoonSharp.Interpreter.IScriptPrivateResource.OwnerScript
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A1")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170000D9")]
	public private ScriptOptions Options
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000677")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000678")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000DB")]
	public private PerformanceStatistics PerformanceStats
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600067A")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600067B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000DF")]
	public private Table Registry
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600069E")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600069F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000DE")]
	public int SourceCodeCount
	{
		[Address(RVA = "0x30F8F0", Offset = "0x30EAF0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000696")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x30F1E0", Offset = "0x30E3E0", Length = "0x31C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PlatformAutoDetector), Member = "GetDefaultScriptLoader", ReturnType = typeof(IScriptLoader))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformAutoDetector), Member = "GetDefaultPlatform", ReturnType = typeof(IPlatformAccessor))]
	[Calls(Type = typeof(CustomConvertersCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60006A2")]
	private static Script() { }

	[Address(RVA = "0x30F500", Offset = "0x30E700", Length = "0xD")]
	[CalledBy(Type = typeof(DynValueMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000674")]
	public Script() { }

	[Address(RVA = "0x30F510", Offset = "0x30E710", Length = "0x316")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Script), Member = "RunFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RunString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "WarmUp", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ByteCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PerformanceStatistics), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Processor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Table), typeof(ByteCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ModuleRegister), Member = "RegisterCoreModules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(CoreModules)}, ReturnType = typeof(Table))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000675")]
	public Script(CoreModules coreModules) { }

	[Address(RVA = "0x30C200", Offset = "0x30B400", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "set_DebuggerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Processor), Member = "AttachDebugger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Script), Member = "SignalSourceCodeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "SignalByteCodeChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000694")]
	public void AttachDebugger(IDebugger debugger) { }

	[Address(RVA = "0x30C850", Offset = "0x30BA50", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068C")]
	public DynValue Call(DynValue function, Object[] args) { }

	[Address(RVA = "0x30C400", Offset = "0x30B600", Length = "0x15C")]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Closure), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Closure), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Closure), Member = "<GetDelegate>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600068E")]
	public DynValue Call(object function, Object[] args) { }

	[Address(RVA = "0x30C360", Offset = "0x30B560", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x600068D")]
	public DynValue Call(object function) { }

	[Address(RVA = "0x30C970", Offset = "0x30BB70", Length = "0x55")]
	[CalledBy(Type = typeof(ReplInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "load_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x600068A")]
	public DynValue Call(DynValue function) { }

	[Address(RVA = "0x30C560", Offset = "0x30B760", Length = "0x2E6")]
	[CalledBy(Type = typeof(TableModule), Member = "GetTableLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsStringUsingMeta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Closure), Member = "Call", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ScriptExecutionContext), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "DoString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "DoStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "DoFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RunFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RunString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecIterPrep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableModule), Member = "SortComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(int))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(DynValue[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "GetMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Processor), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackFunction)}, ReturnType = typeof(ScriptExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600068B")]
	public DynValue Call(DynValue function, DynValue[] args) { }

	[Address(RVA = "0x30C9D0", Offset = "0x30BBD0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069C")]
	public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant) { }

	[Address(RVA = "0x30CAB0", Offset = "0x30BCB0", Length = "0x27D")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Closure)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600068F")]
	public DynValue CreateCoroutine(DynValue function) { }

	[Address(RVA = "0x30CD30", Offset = "0x30BF30", Length = "0x67")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000691")]
	public DynValue CreateCoroutine(object function) { }

	[Address(RVA = "0x30CDA0", Offset = "0x30BFA0", Length = "0x98")]
	[CalledBy(Type = typeof(DynamicExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069D")]
	internal ScriptExecutionContext CreateDynamicExecutionContext(CallbackFunction func = null) { }

	[Address(RVA = "0x30CE40", Offset = "0x30C040", Length = "0xF5")]
	[CalledBy(Type = typeof(ReplInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValueMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicModule), Member = "eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynamicModule), Member = "prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SourceCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Loader_Fast), Member = "LoadDynamicExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode)}, ReturnType = typeof(DynamicExprExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069B")]
	public DynamicExpression CreateDynamicExpression(string code) { }

	[Address(RVA = "0x30CF40", Offset = "0x30C140", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000686")]
	public DynValue DoFile(string filename, Table globalContext = null, string codeFriendlyName = null) { }

	[Address(RVA = "0x30CFB0", Offset = "0x30C1B0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000685")]
	public DynValue DoStream(Stream stream, Table globalContext = null, string codeFriendlyName = null) { }

	[Address(RVA = "0x30D020", Offset = "0x30C220", Length = "0x63")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "LuaRequire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.ModuleScript", typeof(Script)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ExecuteScriptInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), "Polytoria.Datamodel.BaseScript"}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000684")]
	public DynValue DoString(string code, Table globalContext = null, string codeFriendlyName = null) { }

	[Address(RVA = "0x30D090", Offset = "0x30C290", Length = "0x2AF")]
	[CalledBy(Type = typeof(StringModule), Member = "dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(UndisposableStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000682")]
	public void Dump(DynValue function, Stream stream) { }

	[Address(RVA = "0x30F830", Offset = "0x30EA30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Processor), Member = "get_DebuggerEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000692")]
	public bool get_DebuggerEnabled() { }

	[Address(RVA = "0x30F850", Offset = "0x30EA50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000676")]
	public static ScriptOptions get_DefaultOptions() { }

	[Address(RVA = "0x30F8A0", Offset = "0x30EAA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000679")]
	public static ScriptGlobalOptions get_GlobalOptions() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067C")]
	public Table get_Globals() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000677")]
	public ScriptOptions get_Options() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600067A")]
	public PerformanceStatistics get_PerformanceStats() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600069E")]
	public Table get_Registry() { }

	[Address(RVA = "0x30F8F0", Offset = "0x30EAF0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000696")]
	public int get_SourceCodeCount() { }

	[Address(RVA = "0x30D340", Offset = "0x30C540", Length = "0x27E")]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(Table))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A0")]
	public static string GetBanner(string subproduct = null) { }

	[Address(RVA = "0x30D5C0", Offset = "0x30C7C0", Length = "0x51")]
	[CalledBy(Type = typeof(Processor), Member = "ListenDebugger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ResetBreakPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebuggerAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ToggleBreakPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebuggerAction), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SourceRef), Member = "FormatLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000695")]
	public SourceCode GetSourceCode(int sourceCodeID) { }

	[Address(RVA = "0x30D620", Offset = "0x30C820", Length = "0x3A")]
	[CalledBy(Type = typeof(Processor), Member = "GetMetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(Processor), Member = "ExecEq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MetaTableModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000698")]
	public Table GetTypeMetatable(DataType type) { }

	[Address(RVA = "0x30D660", Offset = "0x30C860", Length = "0x5AC")]
	[CalledBy(Type = typeof(Script), Member = "DoFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RunFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RequireModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "loadfile_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "dofile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5870")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000683")]
	public DynValue LoadFile(string filename, Table globalContext = null, string friendlyFilename = null) { }

	[Address(RVA = "0x30DC10", Offset = "0x30CE10", Length = "0x217")]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterScriptField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(object), typeof(Table), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "MakeClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Script), Member = "SignalByteCodeChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "SignalSourceCodeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Loader_Fast), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SourceCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067D")]
	public DynValue LoadFunction(string code, Table globalTable = null, string funcFriendlyName = null) { }

	[Address(RVA = "0x30DE30", Offset = "0x30D030", Length = "0x374")]
	[CalledBy(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "DoStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Script), Member = "SignalByteCodeChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "SignalSourceCodeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(SourceCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Script), Member = "MakeClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "IsDumpStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UndisposableStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000681")]
	public DynValue LoadStream(Stream stream, Table globalTable = null, string codeFriendlyName = null) { }

	[Address(RVA = "0x30E1B0", Offset = "0x30D3B0", Length = "0x2F3")]
	[CalledBy(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "DoString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RunString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "WarmUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "load_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SourceCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Loader_Fast), Member = "LoadChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Script), Member = "SignalByteCodeChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "MakeClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "SignalSourceCodeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000680")]
	public DynValue LoadString(string code, Table globalTable = null, string codeFriendlyName = null) { }

	[Address(RVA = "0x30E4B0", Offset = "0x30D6B0", Length = "0x422")]
	[CalledBy(Type = typeof(Script), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Closure), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(int), typeof(SymbolRef[]), typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.DynValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "FindMeta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000689")]
	private DynValue MakeClosure(int address, Table envTable = null) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A1")]
	private override Script MoonSharp.Interpreter.IScriptPrivateResource.get_OwnerScript() { }

	[Address(RVA = "0x30E8F0", Offset = "0x30DAF0", Length = "0x1B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Coroutine), Member = "get_State", ReturnType = typeof(CoroutineState))]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Recycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Processor), typeof(Closure)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000690")]
	public DynValue RecycleCoroutine(Coroutine coroutine, DynValue function) { }

	[Address(RVA = "0x30EAB0", Offset = "0x30DCB0", Length = "0x135")]
	[CalledBy(Type = typeof(LoadModule), Member = "__require_clr_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000697")]
	public DynValue RequireModule(string modname, Table globalContext = null) { }

	[Address(RVA = "0x30EBF0", Offset = "0x30DDF0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Script), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoreModules)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000687")]
	public static DynValue RunFile(string filename) { }

	[Address(RVA = "0x30ECB0", Offset = "0x30DEB0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Script), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoreModules)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000688")]
	public static DynValue RunString(string code) { }

	[Address(RVA = "0x30F930", Offset = "0x30EB30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Processor), Member = "set_DebuggerEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000693")]
	public void set_DebuggerEnabled(bool value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000678")]
	private void set_Options(ScriptOptions value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600067B")]
	private void set_PerformanceStats(PerformanceStatistics value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600069F")]
	private void set_Registry(Table value) { }

	[Address(RVA = "0x30ED70", Offset = "0x30DF70", Length = "0x135")]
	[CalledBy(Type = typeof(DebugModule), Member = "setmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000699")]
	public void SetTypeMetatable(DataType type, Table metatable) { }

	[Address(RVA = "0x30EEB0", Offset = "0x30E0B0", Length = "0x1E2")]
	[CalledBy(Type = typeof(Script), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "AttachDebugger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600067E")]
	private void SignalByteCodeChange() { }

	[Address(RVA = "0x30F0A0", Offset = "0x30E2A0", Length = "0xBD")]
	[CalledBy(Type = typeof(Script), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "AttachDebugger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600067F")]
	private void SignalSourceCodeChange(SourceCode source) { }

	[Address(RVA = "0x30F160", Offset = "0x30E360", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Script), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoreModules)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069A")]
	public static void WarmUp() { }

}

