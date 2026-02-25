namespace MoonSharp.Interpreter;

[Token(Token = "0x2000063")]
public class ScriptExecutionContext : IScriptPrivateResource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021F")]
	private Processor m_Processor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000220")]
	private CallbackFunction m_Callback; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000221")]
	private bool <IsDynamicExecution>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000222")]
	private SourceRef <CallingLocation>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170000CC")]
	public object AdditionalData
	{
		[Address(RVA = "0x309060", Offset = "0x308260", Length = "0x13")]
		[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+<>c__DisplayClass29_0", Member = "<gmatch_aux_2>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000627")]
		 get { } //Length: 19
		[Address(RVA = "0x3091A0", Offset = "0x3083A0", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000628")]
		 set { } //Length: 114
	}

	[Token(Token = "0x170000CB")]
	public private SourceRef CallingLocation
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000625")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000626")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000CD")]
	public Table CurrentGlobalEnv
	{
		[Address(RVA = "0x309080", Offset = "0x308280", Length = "0x10D")]
		[CalledBy(Type = typeof(LoadModule), Member = "loadsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(LoadModule), Member = "loadfilesafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(LoadModule), Member = "GetSafeDefaultEnv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(Table))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
		[Calls(Type = typeof(Processor), Member = "GetGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000634")]
		 get { } //Length: 269
	}

	[Token(Token = "0x170000CA")]
	public private bool IsDynamicExecution
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000623")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000624")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000CE")]
	public override Script OwnerScript
	{
		[Address(RVA = "0x308F00", Offset = "0x308100", Length = "0x1B")]
		[CallerCount(Count = 54)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000636")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x308FE0", Offset = "0x3081E0", Length = "0x73")]
	[CalledBy(Type = typeof(Processor), Member = "RefreshDebugger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecRet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000622")]
	internal ScriptExecutionContext(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = false) { }

	[Address(RVA = "0x3087F0", Offset = "0x3079F0", Length = "0x28D")]
	[CalledBy(Type = typeof(ScriptExecutionContext), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "GetMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "CannotYield", ReturnType = typeof(ScriptRuntimeException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000630")]
	public DynValue Call(DynValue func, DynValue[] args) { }

	[Address(RVA = "0x308A80", Offset = "0x307C80", Length = "0xB3")]
	[CalledBy(Type = typeof(StringModule), Member = "match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "gsub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "gmatch_aux_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LuaState), Member = "GetReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062F")]
	public DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, Int32> callback) { }

	[Address(RVA = "0x308C10", Offset = "0x307E10", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "GetGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000631")]
	public DynValue EvaluateSymbol(SymbolRef symref) { }

	[Address(RVA = "0x308B40", Offset = "0x307D40", Length = "0xCC")]
	[CalledBy(Type = typeof(SymbolRefExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "GetGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000632")]
	public DynValue EvaluateSymbolByName(string symbol) { }

	[Address(RVA = "0x308CD0", Offset = "0x307ED0", Length = "0x1E")]
	[CalledBy(Type = typeof(SymbolRefExpression), Member = "FindDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000633")]
	public SymbolRef FindSymbolByName(string symbol) { }

	[Address(RVA = "0x309060", Offset = "0x308260", Length = "0x13")]
	[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib+<>c__DisplayClass29_0", Member = "<gmatch_aux_2>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000627")]
	public object get_AdditionalData() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000625")]
	public SourceRef get_CallingLocation() { }

	[Address(RVA = "0x309080", Offset = "0x308280", Length = "0x10D")]
	[CalledBy(Type = typeof(LoadModule), Member = "loadsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "loadfilesafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "GetSafeDefaultEnv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(Table))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(Processor), Member = "GetGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000634")]
	public Table get_CurrentGlobalEnv() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000623")]
	public bool get_IsDynamicExecution() { }

	[Address(RVA = "0x308F00", Offset = "0x308100", Length = "0x1B")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000636")]
	public override Script get_OwnerScript() { }

	[Address(RVA = "0x308CF0", Offset = "0x307EF0", Length = "0x24")]
	[CalledBy(Type = typeof(TableModule), Member = "SortComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Processor), Member = "GetBinaryMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600062C")]
	public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName) { }

	[Address(RVA = "0x308D20", Offset = "0x307F20", Length = "0x1B")]
	[CalledBy(Type = typeof(BasicModule), Member = "error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "running", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "status", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600062E")]
	public Coroutine GetCallingCoroutine() { }

	[Address(RVA = "0x308EC0", Offset = "0x3080C0", Length = "0x1E")]
	[CalledBy(Type = typeof(MetaTableModule), Member = "setmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "GetTableLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Processor), Member = "GetMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600062A")]
	public DynValue GetMetamethod(DynValue value, string metamethod) { }

	[Address(RVA = "0x308D40", Offset = "0x307F40", Length = "0x17F")]
	[CalledBy(Type = typeof(BasicModule), Member = "tostring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "ipairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "GetMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600062B")]
	public DynValue GetMetamethodTailCall(DynValue value, string metamethod, DynValue[] args) { }

	[Address(RVA = "0x308EE0", Offset = "0x3080E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Processor), Member = "GetMetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000629")]
	public Table GetMetatable(DynValue value) { }

	[Address(RVA = "0x308F00", Offset = "0x308100", Length = "0x1B")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600062D")]
	public Script GetScript() { }

	[Address(RVA = "0x308F20", Offset = "0x308120", Length = "0xB1")]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000635")]
	public void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception) { }

	[Address(RVA = "0x3091A0", Offset = "0x3083A0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000628")]
	public void set_AdditionalData(object value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000626")]
	private void set_CallingLocation(SourceRef value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000624")]
	private void set_IsDynamicExecution(bool value) { }

}

