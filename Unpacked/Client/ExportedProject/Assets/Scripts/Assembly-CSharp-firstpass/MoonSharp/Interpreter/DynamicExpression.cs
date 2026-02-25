namespace MoonSharp.Interpreter;

[Token(Token = "0x2000062")]
public class DynamicExpression : IScriptPrivateResource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021B")]
	private DynamicExprExpression m_Exp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400021C")]
	private DynValue m_Constant; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400021D")]
	public readonly string ExpressionCode; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400021E")]
	private Script <OwnerScript>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170000C9")]
	public private override Script OwnerScript
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600061D")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600061E")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2FC680", Offset = "0x2FB880", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000619")]
	internal DynamicExpression(Script S, string strExpr, DynamicExprExpression expr) { }

	[Address(RVA = "0x2FC6F0", Offset = "0x2FB8F0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600061A")]
	internal DynamicExpression(Script S, string strExpr, DynValue constant) { }

	[Address(RVA = "0x2FC350", Offset = "0x2FB550", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000621")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FC3E0", Offset = "0x2FB5E0", Length = "0x136")]
	[CalledBy(Type = typeof(ReplInterpreter), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValueMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Debugger_RefreshWatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynamicExpression)}, ReturnType = typeof(WatchItem))]
	[CalledBy(Type = typeof(DynamicModule), Member = "eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackFunction)}, ReturnType = typeof(ScriptExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061B")]
	public DynValue Evaluate(ScriptExecutionContext context = null) { }

	[Address(RVA = "0x2FC520", Offset = "0x2FB720", Length = "0x112")]
	[CalledBy(Type = typeof(Processor), Member = "Debugger_RefreshWatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynamicExpression)}, ReturnType = typeof(WatchItem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061C")]
	public SymbolRef FindSymbol(ScriptExecutionContext context) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600061D")]
	public override Script get_OwnerScript() { }

	[Address(RVA = "0x2FC640", Offset = "0x2FB840", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000620")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600061F")]
	public bool IsConstant() { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600061E")]
	private void set_OwnerScript(Script value) { }

}

