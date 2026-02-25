namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DE")]
internal sealed class GotoInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x40001CF")]
	private static readonly GotoInstruction[] s_cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D0")]
	private readonly bool _hasResult; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40001D1")]
	private readonly bool _hasValue; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x40001D2")]
	private readonly bool _labelTargetGetsValue; //Field offset: 0x1A

	[Token(Token = "0x1700013B")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x1593070", Offset = "0x1592270", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000539")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700013A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A2CA0", Offset = "0x15A1EA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000538")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700013C")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600053A")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x15A2BE0", Offset = "0x15A1DE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600053E")]
	private static GotoInstruction() { }

	[Address(RVA = "0x15A2C50", Offset = "0x15A1E50", Length = "0x50")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053B")]
	private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x15A2990", Offset = "0x15A1B90", Length = "0x165")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600053C")]
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x1593070", Offset = "0x1592270", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A2CA0", Offset = "0x15A1EA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000538")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600053A")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15A2B00", Offset = "0x15A1D00", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600053D")]
	public virtual int Run(InterpretedFrame frame) { }

}

