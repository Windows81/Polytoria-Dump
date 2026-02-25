namespace MoonSharp.Interpreter;

[Token(Token = "0x2000049")]
public sealed class DynValue
{
	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private sealed class <>c
	{
		[Token(Token = "0x40001DF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001E0")]
		public static Func<DynValue, Boolean> <>9__54_0; //Field offset: 0x8
		[Token(Token = "0x40001E1")]
		public static Func<DynValue, String> <>9__77_0; //Field offset: 0x10
		[Token(Token = "0x40001E2")]
		public static Func<DynValue, String> <>9__78_0; //Field offset: 0x18
		[Token(Token = "0x40001E3")]
		public static Func<DynValue, String> <>9__79_0; //Field offset: 0x20
		[Token(Token = "0x40001E4")]
		public static Func<DynValue, String> <>9__79_1; //Field offset: 0x28

		[Address(RVA = "0x3141D0", Offset = "0x3133D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600051F")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000520")]
		public <>c() { }

		[Address(RVA = "0x313B40", Offset = "0x312D40", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000521")]
		internal bool <NewTupleNested>b__54_0(DynValue v) { }

		[Address(RVA = "0x313D50", Offset = "0x312F50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000523")]
		internal string <ToDebugPrintString>b__78_0(DynValue t) { }

		[Address(RVA = "0x313D50", Offset = "0x312F50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000522")]
		internal string <ToPrintString>b__77_0(DynValue t) { }

		[Address(RVA = "0x313D20", Offset = "0x312F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000524")]
		internal string <ToString>b__79_0(DynValue t) { }

		[Address(RVA = "0x313D20", Offset = "0x312F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000525")]
		internal string <ToString>b__79_1(DynValue t) { }

	}

	[Token(Token = "0x40001D4")]
	private static int s_RefIDCounter; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40001DB")]
	private static DynValue <Void>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x40001DC")]
	private static DynValue <Nil>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Token(Token = "0x40001DD")]
	private static DynValue <True>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x40001DE")]
	private static DynValue <False>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D5")]
	private int m_RefID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001D6")]
	private int m_HashCode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D7")]
	private bool m_ReadOnly; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D8")]
	private double m_Number; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D9")]
	private object m_Object; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DA")]
	private DataType m_Type; //Field offset: 0x30

	[Token(Token = "0x1700009A")]
	public bool Boolean
	{
		[Address(RVA = "0x2FBB70", Offset = "0x2FAD70", Length = "0x16")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SerializationExtensions), Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Instruction), Member = "DumpValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DynValue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004DD")]
		 get { } //Length: 22
	}

	[Token(Token = "0x1700009C")]
	public CallbackFunction Callback
	{
		[Address(RVA = "0x2FBB90", Offset = "0x2FAD90", Length = "0x44")]
		[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004DF")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000098")]
	public Coroutine Coroutine
	{
		[Address(RVA = "0x2FBBE0", Offset = "0x2FADE0", Length = "0x72")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "status", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004DB")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170000A4")]
	public private static DynValue False
	{
		[Address(RVA = "0x2FBC60", Offset = "0x2FAE60", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000503")]
		 get { } //Length: 79
		[Address(RVA = "0x2FC090", Offset = "0x2FB290", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000504")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000095")]
	public Closure Function
	{
		[Address(RVA = "0x2FBCB0", Offset = "0x2FAEB0", Length = "0x72")]
		[CalledBy(Type = typeof(EventMemberDescriptor), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DebugModule), Member = "upvalueid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DebugModule), Member = "getupvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Processor), Member = "PushClrToScriptStackFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallStackItemFlags), typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(EventMemberDescriptor), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DebugModule), Member = "setupvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Script), Member = "RecycleCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Script), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Stream)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(DebugModule), Member = "upvaluejoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170000A2")]
	public private static DynValue Nil
	{
		[Address(RVA = "0x2FBD30", Offset = "0x2FAF30", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60004FF")]
		 get { } //Length: 79
		[Address(RVA = "0x2FC100", Offset = "0x2FB300", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000500")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000096")]
	public double Number
	{
		[Address(RVA = "0x2F5B10", Offset = "0x2F4D10", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000A0")]
	public bool ReadOnly
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000093")]
	public int ReferenceID
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700009B")]
	public string String
	{
		[Address(RVA = "0x2FBD90", Offset = "0x2FAF90", Length = "0x1A")]
		[CallerCount(Count = 96)]
		[Token(Token = "0x60004DE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000099")]
	public Table Table
	{
		[Address(RVA = "0x2FBDB0", Offset = "0x2FAFB0", Length = "0x72")]
		[CallerCount(Count = 76)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700009D")]
	public TailCallData TailCallData
	{
		[Address(RVA = "0x2FBE30", Offset = "0x2FB030", Length = "0x72")]
		[CalledBy(Type = typeof(Processor), Member = "Internal_CheckForTailRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(BasicModule), Member = "tostring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004E0")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170000A3")]
	public private static DynValue True
	{
		[Address(RVA = "0x2FBEB0", Offset = "0x2FB0B0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000501")]
		 get { } //Length: 79
		[Address(RVA = "0x2FC170", Offset = "0x2FB370", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000502")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000097")]
	public DynValue[] Tuple
	{
		[Address(RVA = "0x2FBF00", Offset = "0x2FB100", Length = "0x3A")]
		[CalledBy(Type = typeof(Processor), Member = "GetStoreValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Processor), Member = "Internal_AdjustTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>)}, ReturnType = typeof(DynValue[]))]
		[CalledBy(Type = typeof(Processor), Member = "CreateArgsListForFunctionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>))]
		[CalledBy(Type = typeof(Processor), Member = "ExecIterPrep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Processor), Member = "ExecExpTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Processor), Member = "ExecIterUpd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SerializationExtensions), Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DynValue), Member = "NewTupleNested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(BasicModule), Member = "select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 40)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000094")]
	public DataType Type
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D7")]
		 get { } //Length: 174
	}

	[Token(Token = "0x1700009F")]
	public UserData UserData
	{
		[Address(RVA = "0x2FBF40", Offset = "0x2FB140", Length = "0x72")]
		[CallerCount(Count = 59)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004E2")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170000A1")]
	public private static DynValue Void
	{
		[Address(RVA = "0x2FBFC0", Offset = "0x2FB1C0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60004FD")]
		 get { } //Length: 79
		[Address(RVA = "0x2FC1E0", Offset = "0x2FB3E0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60004FE")]
		private set { } //Length: 110
	}

	[Token(Token = "0x1700009E")]
	public YieldRequest YieldRequest
	{
		[Address(RVA = "0x2FC010", Offset = "0x2FB210", Length = "0x72")]
		[CalledBy(Type = typeof(Processor), Member = "Coroutine_Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004E1")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x2FB7F0", Offset = "0x2FA9F0", Length = "0x30E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000505")]
	private static DynValue() { }

	[Address(RVA = "0x2FBB00", Offset = "0x2FAD00", Length = "0x6A")]
	[CalledBy(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "NewTupleNested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600051E")]
	public DynValue() { }

	[Address(RVA = "0x2F8480", Offset = "0x2F7680", Length = "0x14")]
	[CalledBy(Type = typeof(LiteralExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ParseJsonNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(Script)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DynValue), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x60004F9")]
	public DynValue AsReadOnly() { }

	[Address(RVA = "0x2F8620", Offset = "0x2F7820", Length = "0x9A")]
	[CalledBy(Type = typeof(Processor), Member = "AssignLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ExecStoreUpv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "AssignGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugModule), Member = "setupvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000510")]
	public void Assign(DynValue value) { }

	[Address(RVA = "0x2F84A0", Offset = "0x2F76A0", Length = "0x171")]
	[CalledBy(Type = typeof(Processor), Member = "ExecIncr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000517")]
	internal void AssignNumber(double num) { }

	[Address(RVA = "0x2F86C0", Offset = "0x2F78C0", Length = "0x4B")]
	[CalledBy(Type = typeof(Processor), Member = "ExecNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(UnaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecCNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableModule), Member = "LuaComparerToClrComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "JumpBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecShortCircuitingOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BasicModule), Member = "assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "SortComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600050D")]
	public bool CastToBool() { }

	[Address(RVA = "0x2F8710", Offset = "0x2F7910", Length = "0x10C")]
	[CalledBy(Type = typeof(Processor), Member = "ExecNeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TableModule), Member = "GetTableLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringModule), Member = "char", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OsTimeModule), Member = "GetTimeTableField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecMod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecToNum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Processor), Member = "ExecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Token(Token = "0x600050C")]
	public Nullable<Double> CastToNumber() { }

	[Address(RVA = "0x2F8820", Offset = "0x2F7A20", Length = "0xA9")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecConcat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BasicModule), Member = "collectgarbage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "__index_callback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "HandleDefaultStreamSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(StandardFileType)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600050B")]
	public string CastToString() { }

	[Address(RVA = "0x2F88D0", Offset = "0x2F7AD0", Length = "0x3C9")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLOptInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLOptInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(UInt32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckStringStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "ArgAsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "CheckUserDataType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TypeValidationFlags)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(UInt32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = "get_Value", ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "BadArgumentNoValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "BadArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(DataType), typeof(bool)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600051C")]
	public DynValue CheckType(string funcName, DataType desiredType, int argNum = -1, TypeValidationFlags flags = 2) { }

	[Address(RVA = "0x69E140", Offset = "0x69D340", Length = "0x169")]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsUserData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = typeof(IoModule), Member = "GetDefaultFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(StandardFileType)}, ReturnType = typeof(FileUserDataBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "BadArgumentUserData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600051D")]
	public T CheckUserDataType(string funcName, int argNum = -1, TypeValidationFlags flags = 2) { }

	[Address(RVA = "0x2F8CC0", Offset = "0x2F7EC0", Length = "0xD8")]
	[CalledBy(Type = typeof(DynValue), Member = "AsReadOnly", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "CloneAsWritable", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004FB")]
	public DynValue Clone(bool readOnly) { }

	[Address(RVA = "0x2F8CB0", Offset = "0x2F7EB0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60004FA")]
	public DynValue Clone() { }

	[Address(RVA = "0x2F8CA0", Offset = "0x2F7EA0", Length = "0xA")]
	[CalledBy(Type = typeof(Processor), Member = "ExecIncr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ExecArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynValue), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x60004FC")]
	public DynValue CloneAsWritable() { }

	[Address(RVA = "0x2F8DA0", Offset = "0x2F7FA0", Length = "0x2F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(DynValue), Member = "get_Coroutine", ReturnType = typeof(Coroutine))]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600050A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F90D0", Offset = "0x2F82D0", Length = "0x8")]
	[CalledBy(Type = typeof(EnumerableWrapper), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(HardwiredMethodMemberDescriptor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FileUserDataBase), Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000518")]
	public static DynValue FromObject(Script script, object obj) { }

	[Address(RVA = "0x2FBB70", Offset = "0x2FAD70", Length = "0x16")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationExtensions), Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Instruction), Member = "DumpValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004DD")]
	public bool get_Boolean() { }

	[Address(RVA = "0x2FBB90", Offset = "0x2FAD90", Length = "0x44")]
	[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004DF")]
	public CallbackFunction get_Callback() { }

	[Address(RVA = "0x2FBBE0", Offset = "0x2FADE0", Length = "0x72")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "status", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004DB")]
	public Coroutine get_Coroutine() { }

	[Address(RVA = "0x2FBC60", Offset = "0x2FAE60", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000503")]
	public static DynValue get_False() { }

	[Address(RVA = "0x2FBCB0", Offset = "0x2FAEB0", Length = "0x72")]
	[CalledBy(Type = typeof(DebugModule), Member = "upvaluejoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Script), Member = "RecycleCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Processor), Member = "PushClrToScriptStackFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallStackItemFlags), typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugModule), Member = "getupvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "upvalueid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "setupvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004D8")]
	public Closure get_Function() { }

	[Address(RVA = "0x2FBD30", Offset = "0x2FAF30", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60004FF")]
	public static DynValue get_Nil() { }

	[Address(RVA = "0x2F5B10", Offset = "0x2F4D10", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D9")]
	public double get_Number() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E3")]
	public bool get_ReadOnly() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D6")]
	public int get_ReferenceID() { }

	[Address(RVA = "0x2FBD90", Offset = "0x2FAF90", Length = "0x1A")]
	[CallerCount(Count = 96)]
	[Token(Token = "0x60004DE")]
	public string get_String() { }

	[Address(RVA = "0x2FBDB0", Offset = "0x2FAFB0", Length = "0x72")]
	[CallerCount(Count = 76)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004DC")]
	public Table get_Table() { }

	[Address(RVA = "0x2FBE30", Offset = "0x2FB030", Length = "0x72")]
	[CalledBy(Type = typeof(Processor), Member = "Internal_CheckForTailRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BasicModule), Member = "tostring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004E0")]
	public TailCallData get_TailCallData() { }

	[Address(RVA = "0x2FBEB0", Offset = "0x2FB0B0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000501")]
	public static DynValue get_True() { }

	[Address(RVA = "0x2FBF00", Offset = "0x2FB100", Length = "0x3A")]
	[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "NewTupleNested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DynValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DynValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationExtensions), Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecIterUpd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ExecExpTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ExecIterPrep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "CreateArgsListForFunctionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_AdjustTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>)}, ReturnType = typeof(DynValue[]))]
	[CalledBy(Type = typeof(Processor), Member = "GetStoreValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x60004DA")]
	public DynValue[] get_Tuple() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D7")]
	public DataType get_Type() { }

	[Address(RVA = "0x2FBF40", Offset = "0x2FB140", Length = "0x72")]
	[CallerCount(Count = 59)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004E2")]
	public UserData get_UserData() { }

	[Address(RVA = "0x2FBFC0", Offset = "0x2FB1C0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60004FD")]
	public static DynValue get_Void() { }

	[Address(RVA = "0x2FC010", Offset = "0x2FB210", Length = "0x72")]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004E1")]
	public YieldRequest get_YieldRequest() { }

	[Address(RVA = "0x2F90E0", Offset = "0x2F82E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x600050E")]
	public IScriptPrivateResource GetAsPrivateResource() { }

	[Address(RVA = "0x2F9120", Offset = "0x2F8320", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000509")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2F92E0", Offset = "0x2F84E0", Length = "0x159")]
	[CalledBy(Type = typeof(UnaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MetaTableModule), Member = "rawlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000511")]
	public DynValue GetLength() { }

	[Address(RVA = "0x2F9480", Offset = "0x2F8680", Length = "0x11")]
	[CallerCount(Count = 64)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000512")]
	public bool IsNil() { }

	[Address(RVA = "0x2F9440", Offset = "0x2F8640", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "CreateExplosion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(bool), typeof(DynValue), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InsertService+<>c__DisplayClass5_0", Member = "<Model>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), "System.Object[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Table), Member = "PerformTableSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataStructs.LinkedListIndex`2<T, TablePair>", "T", typeof(DynValue), typeof(DynValue), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Bit32Module), Member = "extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Bit32Module), Member = "replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000516")]
	public bool IsNilOrNan() { }

	[Address(RVA = "0x2F94A0", Offset = "0x2F86A0", Length = "0x11")]
	[CalledBy(Type = typeof(Table), Member = "PerformTableSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataStructs.LinkedListIndex`2<T, TablePair>", "T", typeof(DynValue), typeof(DynValue), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "GetBinaryMetamethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_InvokeUnaryMetaMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OsSystemModule), Member = "exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OsTimeModule), Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "rep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FileUserDataBase), Member = "lines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000513")]
	public bool IsNotNil() { }

	[Address(RVA = "0x2F94C0", Offset = "0x2F86C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000515")]
	public bool IsNotVoid() { }

	[Address(RVA = "0x2F94D0", Offset = "0x2F86D0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000514")]
	public bool IsVoid() { }

	[Address(RVA = "0x2F94E0", Offset = "0x2F86E0", Length = "0xB6")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E5")]
	public static DynValue NewBoolean(bool v) { }

	[Address(RVA = "0x2F9660", Offset = "0x2F8860", Length = "0x148")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MultiDispatchLessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "ipairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "GetGetterCallbackAsDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MultiDispatchEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MultiDispatchLessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryIndexOnExtMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventFacade), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StandardEnumUserDataDescriptor), Member = "FillMemberList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumerableWrapper), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EnumerableWrapper), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterModuleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004EC")]
	public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null) { }

	[Address(RVA = "0x2F95A0", Offset = "0x2F87A0", Length = "0xB9")]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "GetCallbackAsDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004ED")]
	public static DynValue NewCallback(CallbackFunction function) { }

	[Address(RVA = "0x2F97B0", Offset = "0x2F89B0", Length = "0xB9")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Recycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Processor), typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004EB")]
	public static DynValue NewClosure(Closure function) { }

	[Address(RVA = "0x2F9870", Offset = "0x2F8A70", Length = "0xB9")]
	[CalledBy(Type = typeof(Processor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Table), typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Recycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Processor), typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "running", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004EA")]
	public static DynValue NewCoroutine(Coroutine coroutine) { }

	[Address(RVA = "0x2F9930", Offset = "0x2F8B30", Length = "0xE9")]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004F5")]
	internal static DynValue NewForcedYieldReq() { }

	[Address(RVA = "0x2F9A20", Offset = "0x2F8C20", Length = "0x96")]
	[CalledBy(Type = typeof(Processor), Member = "AssignLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "ExecStoreUpv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "GetStoreValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "ExecArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "AssignGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004E4")]
	public static DynValue NewNil() { }

	[Address(RVA = "0x2F9AC0", Offset = "0x2F8CC0", Length = "0xB6")]
	[CallerCount(Count = 96)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004E6")]
	public static DynValue NewNumber(double num) { }

	[Address(RVA = "0x2F9B80", Offset = "0x2F8D80", Length = "0x6E")]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UserData), Member = "GetDescriptionOfRegisteredTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(TableConstructor), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ArrayMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004EF")]
	public static DynValue NewPrimeTable() { }

	[Address(RVA = "0x2F9D90", Offset = "0x2F8F90", Length = "0xFF")]
	[CalledBy(Type = typeof(OsSystemModule), Member = "remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OsSystemModule), Member = "rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004E9")]
	public static DynValue NewString(string format, Object[] args) { }

	[Address(RVA = "0x2F9CB0", Offset = "0x2F8EB0", Length = "0xD9")]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004E8")]
	public static DynValue NewString(StringBuilder sb) { }

	[Address(RVA = "0x2F9BF0", Offset = "0x2F8DF0", Length = "0xB9")]
	[CallerCount(Count = 110)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004E7")]
	public static DynValue NewString(string str) { }

	[Address(RVA = "0x2F9E90", Offset = "0x2F9090", Length = "0x7B")]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(ModuleRegister), Member = "CreateModuleNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x60004F0")]
	public static DynValue NewTable(Script script) { }

	[Address(RVA = "0x2FA030", Offset = "0x2F9230", Length = "0xB9")]
	[CalledBy(Type = typeof(DebugModule), Member = "getregistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule_Globals), Member = "pack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "pack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OsTimeModule), Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MetaTableModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(JsonModule), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "GetGenericSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToTrivialDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ParseJsonValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(Script)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ObjectValueConverter), Member = "SerializeObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "MakeClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Table)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ModuleRegister), Member = "CreateModuleNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "NewPrimeTable", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004EE")]
	public static DynValue NewTable(Table table) { }

	[Address(RVA = "0x2F9F10", Offset = "0x2F9110", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004F1")]
	public static DynValue NewTable(Script script, DynValue[] arrayValues) { }

	[Address(RVA = "0x2FA0F0", Offset = "0x2F92F0", Length = "0x11F")]
	[CalledBy(Type = typeof(LoadModule), Member = "dofile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004F2")]
	public static DynValue NewTailCallReq(DynValue tailFn, DynValue[] args) { }

	[Address(RVA = "0x2FA210", Offset = "0x2F9410", Length = "0xB9")]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F3")]
	public static DynValue NewTailCallReq(TailCallData tailCallData) { }

	[Address(RVA = "0x2FA6D0", Offset = "0x2F98D0", Length = "0x155")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F6")]
	public static DynValue NewTuple(DynValue[] values) { }

	[Address(RVA = "0x2FA2D0", Offset = "0x2F94D0", Length = "0x3F7")]
	[CalledBy(Type = typeof(LuaState), Member = "GetReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DynValue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60004F7")]
	public static DynValue NewTupleNested(DynValue[] values) { }

	[Address(RVA = "0x2FA830", Offset = "0x2F9A30", Length = "0xB9")]
	[CalledBy(Type = typeof(UserData), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IUserDataDescriptor)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(UserData), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(UserData), Member = "CreateStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUserDataDescriptor)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(UserData), Member = "CreateStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F8")]
	public static DynValue NewUserData(UserData userData) { }

	[Address(RVA = "0x2FA8F0", Offset = "0x2F9AF0", Length = "0x102")]
	[CalledBy(Type = typeof(CoroutineModule), Member = "yield", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004F4")]
	public static DynValue NewYieldReq(DynValue[] args) { }

	[Address(RVA = "0x2FC090", Offset = "0x2FB290", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000504")]
	private static void set_False(DynValue value) { }

	[Address(RVA = "0x2FC100", Offset = "0x2FB300", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000500")]
	private static void set_Nil(DynValue value) { }

	[Address(RVA = "0x2FC170", Offset = "0x2FB370", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000502")]
	private static void set_True(DynValue value) { }

	[Address(RVA = "0x2FC1E0", Offset = "0x2FB3E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60004FE")]
	private static void set_Void(DynValue value) { }

	[Address(RVA = "0x2FAA00", Offset = "0x2F9C00", Length = "0x38B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LuaTypeExtensions), Member = "ToLuaTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(RefIdObject), Member = "FormatTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000507")]
	public string ToDebugPrintString() { }

	[Address(RVA = "0x2FADB0", Offset = "0x2F9FB0", Length = "0x7")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.TableConversions+<>c", Member = "<ConvertTableToType>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.TableConversions+<>c", Member = "<ConvertTableToType>b__3_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.TableConversions+<>c", Member = "<ConvertTableToType>b__3_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.TableConversions+<>c", Member = "<ConvertTableToType>b__3_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass50_0", Member = "<MultiDispatchLessThanOrEqual>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass51_0", Member = "<MultiDispatchLessThan>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass53_0", Member = "<MultiDispatchEqual>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000519")]
	public object ToObject() { }

	[Address(RVA = "0x2FAD90", Offset = "0x2F9F90", Length = "0x1D")]
	[CalledBy(Type = typeof(DynValue), Member = "ToObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x600051A")]
	public object ToObject(Type desiredType) { }

	[Address(RVA = "0x69E2B0", Offset = "0x69D4B0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DynValue), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600051B")]
	public T ToObject() { }

	[Address(RVA = "0x2FADC0", Offset = "0x2F9FC0", Length = "0x3C5")]
	[CalledBy(Type = typeof(CallbackArguments), Member = "AsStringUsingMeta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(<>c), Member = "<ToPrintString>b__77_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(<>c), Member = "<ToDebugPrintString>b__78_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLAddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaLBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BasicModule), Member = "assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "tostring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableModule), Member = "concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LuaTypeExtensions), Member = "ToLuaTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RefIdObject), Member = "FormatTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000506")]
	public string ToPrintString() { }

	[Address(RVA = "0x2FB190", Offset = "0x2FA390", Length = "0x12D")]
	[CallerCount(Count = 60)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600050F")]
	public DynValue ToScalar() { }

	[Address(RVA = "0x2FB2C0", Offset = "0x2FA4C0", Length = "0x4F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValue), Member = "get_Tuple", ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "get_Coroutine", ReturnType = typeof(Coroutine))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000508")]
	public virtual string ToString() { }

}

