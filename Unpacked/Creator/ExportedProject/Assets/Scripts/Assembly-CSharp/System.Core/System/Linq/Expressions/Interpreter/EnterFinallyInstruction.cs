namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E1")]
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x40001D6")]
	private static readonly EnterFinallyInstruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000145")]
	public virtual int ConsumedContinuations
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000551")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000143")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1597120", Offset = "0x1596320", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600054F")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000144")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000550")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15970B0", Offset = "0x15962B0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000554")]
	private static EnterFinallyInstruction() { }

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054E")]
	private EnterFinallyInstruction(int labelIndex) { }

	[Address(RVA = "0x1596F00", Offset = "0x1596100", Length = "0x101")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000552")]
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000551")]
	public virtual int get_ConsumedContinuations() { }

	[Address(RVA = "0x1597120", Offset = "0x1596320", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600054F")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000550")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x1597010", Offset = "0x1596210", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "IsJumpHappened", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InterpretedFrame), Member = "SetStackDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushPendingContinuation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000553")]
	public virtual int Run(InterpretedFrame frame) { }

}

