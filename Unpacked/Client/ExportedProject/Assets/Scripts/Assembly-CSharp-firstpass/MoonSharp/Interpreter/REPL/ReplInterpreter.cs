namespace MoonSharp.Interpreter.REPL;

[Token(Token = "0x20000B3")]
public class ReplInterpreter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000366")]
	private Script m_Script; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000367")]
	private string m_CurrentCommand; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000368")]
	private bool <HandleDynamicExprs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000369")]
	private bool <HandleClassicExprsSyntax>k__BackingField; //Field offset: 0x21

	[Token(Token = "0x17000105")]
	public override string ClassicPrompt
	{
		[Address(RVA = "0x329250", Offset = "0x328450", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007D4")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000104")]
	public override string CurrentPendingCommand
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000102")]
	public bool HandleClassicExprsSyntax
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D0")]
		 get { } //Length: 5
		[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000101")]
	public bool HandleDynamicExprs
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CE")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000103")]
	public override bool HasPendingCommand
	{
		[Address(RVA = "0x3292D0", Offset = "0x3284D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60007D2")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x3291F0", Offset = "0x3283F0", Length = "0x52")]
	[CalledBy(Type = typeof(DebugModule), Member = "debug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007CD")]
	public ReplInterpreter(Script script) { }

	[Address(RVA = "0x328DD0", Offset = "0x327FD0", Length = "0x412")]
	[CalledBy(Type = typeof(ReplHistoryInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynamicExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynamicExpression))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D5")]
	public override DynValue Evaluate(string input) { }

	[Address(RVA = "0x329250", Offset = "0x328450", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D4")]
	public override string get_ClassicPrompt() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D3")]
	public override string get_CurrentPendingCommand() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D0")]
	public bool get_HandleClassicExprsSyntax() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CE")]
	public bool get_HandleDynamicExprs() { }

	[Address(RVA = "0x3292D0", Offset = "0x3284D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D2")]
	public override bool get_HasPendingCommand() { }

	[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D1")]
	public void set_HandleClassicExprsSyntax(bool value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CF")]
	public void set_HandleDynamicExprs(bool value) { }

}

