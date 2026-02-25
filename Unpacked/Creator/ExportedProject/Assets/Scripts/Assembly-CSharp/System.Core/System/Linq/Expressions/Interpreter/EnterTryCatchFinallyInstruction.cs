namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DF")]
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D3")]
	private readonly bool _hasFinally; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D4")]
	private TryCatchFinallyHandler _tryHandler; //Field offset: 0x20

	[Token(Token = "0x1700013D")]
	internal TryCatchFinallyHandler Handler
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000540")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700013F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1597720", Offset = "0x1596920", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000546")]
		 get { } //Length: 74
	}

	[Token(Token = "0x1700013E")]
	public virtual int ProducedContinuations
	{
		[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000541")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x15976E0", Offset = "0x15968E0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000542")]
	private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally) { }

	[Address(RVA = "0x1597150", Offset = "0x1596350", Length = "0x4F")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryCatch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000544")]
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	[Address(RVA = "0x15971A0", Offset = "0x15963A0", Length = "0x56")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000543")]
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000540")]
	internal TryCatchFinallyHandler get_Handler() { }

	[Address(RVA = "0x1597720", Offset = "0x1596920", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000546")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000541")]
	public virtual int get_ProducedContinuations() { }

	[Address(RVA = "0x1597200", Offset = "0x1596400", Length = "0x459")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18158E520")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000545")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600053F")]
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	[Address(RVA = "0x1597660", Offset = "0x1596860", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000547")]
	public virtual string ToString() { }

}

