namespace MoonSharp.Interpreter.Debugging;

[Token(Token = "0x2000165")]
public class SourceRef
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B3")]
	private bool <IsClrLocation>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005B4")]
	private int <SourceIdx>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B5")]
	private int <FromChar>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40005B6")]
	private int <ToChar>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005B7")]
	private int <FromLine>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005B8")]
	private int <ToLine>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005B9")]
	private bool <IsStepStop>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40005BA")]
	public bool Breakpoint; //Field offset: 0x29
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40005BB")]
	private bool <CannotBreakpoint>k__BackingField; //Field offset: 0x2A

	[Token(Token = "0x170001C2")]
	public private bool CannotBreakpoint
	{
		[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D23")]
		 get { } //Length: 5
		[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D24")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BD")]
	public private int FromChar
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D19")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1A")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BF")]
	public private int FromLine
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1D")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1E")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BB")]
	public private bool IsClrLocation
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D15")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D16")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001C1")]
	public private bool IsStepStop
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D21")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D22")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BC")]
	public private int SourceIdx
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D17")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D18")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001BE")]
	public private int ToChar
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1C")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001C0")]
	public private int ToLine
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D20")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x389320", Offset = "0x388520", Length = "0x5A")]
	[CalledBy(Type = typeof(ForLoopStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[CalledBy(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(bool)}, ReturnType = typeof(SourceRef))]
	[CalledBy(Type = typeof(Token), Member = "GetSourceRefUpTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(bool)}, ReturnType = typeof(SourceRef))]
	[CalledBy(Type = typeof(AssignmentStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssignmentStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Expression), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForEachLoopStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GotoStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IfStatement), Member = "CreateIfBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = "MoonSharp.Interpreter.Tree.Statements.IfStatement+IfBlock")]
	[CalledBy(Type = typeof(RepeatStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhileStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "CreateLambdaBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[CalledBy(Type = typeof(Processor), Member = "Undump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(Table), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D27")]
	public SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop) { }

	[Address(RVA = "0x389380", Offset = "0x388580", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D26")]
	public SourceRef(SourceRef src, bool isStepStop) { }

	[Address(RVA = "0x388910", Offset = "0x387B10", Length = "0x572")]
	[CalledBy(Type = typeof(InterpreterException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "CompileBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "GetSourceCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SourceCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000D2C")]
	public string FormatLocation(Script script, bool forceClassicFormat = false) { }

	[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D23")]
	public bool get_CannotBreakpoint() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D19")]
	public int get_FromChar() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1D")]
	public int get_FromLine() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D15")]
	public bool get_IsClrLocation() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D21")]
	public bool get_IsStepStop() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D17")]
	public int get_SourceIdx() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1B")]
	public int get_ToChar() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1F")]
	public int get_ToLine() { }

	[Address(RVA = "0x388E90", Offset = "0x388090", Length = "0x58")]
	[CalledBy(Type = typeof(Processor), Member = "PushClrToScriptStackFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallStackItemFlags), typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "Debugger_GetCallStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Debugging.WatchItem>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D25")]
	internal static SourceRef GetClrLocation() { }

	[Address(RVA = "0x388EF0", Offset = "0x3880F0", Length = "0xED")]
	[CalledBy(Type = typeof(Processor), Member = "ToggleBreakPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebuggerAction), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D29")]
	internal int GetLocationDistance(int sourceIdx, int line, int col) { }

	[Address(RVA = "0x388FE0", Offset = "0x3881E0", Length = "0x40")]
	[CalledBy(Type = typeof(Processor), Member = "ToggleBreakPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebuggerAction), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D2A")]
	public bool IncludesLocation(int sourceIdx, int line, int col) { }

	[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D24")]
	private void set_CannotBreakpoint(bool value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1A")]
	private void set_FromChar(int value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1E")]
	private void set_FromLine(int value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D16")]
	private void set_IsClrLocation(bool value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D22")]
	private void set_IsStepStop(bool value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D18")]
	private void set_SourceIdx(int value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1C")]
	private void set_ToChar(int value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D20")]
	private void set_ToLine(int value) { }

	[Address(RVA = "0x389020", Offset = "0x388220", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D2B")]
	public SourceRef SetNoBreakPoint() { }

	[Address(RVA = "0x389030", Offset = "0x388230", Length = "0x2E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D28")]
	public virtual string ToString() { }

}

