namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E3")]
internal sealed class EnterFaultInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x40001D8")]
	private static readonly EnterFaultInstruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000148")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1596ED0", Offset = "0x15960D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600055B")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000149")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1596E60", Offset = "0x1596060", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600055F")]
	private static EnterFaultInstruction() { }

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055A")]
	private EnterFaultInstruction(int labelIndex) { }

	[Address(RVA = "0x1596CD0", Offset = "0x1595ED0", Length = "0x101")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600055D")]
	internal static EnterFaultInstruction Create(int labelIndex) { }

	[Address(RVA = "0x1596ED0", Offset = "0x15960D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600055B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055C")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x1596DE0", Offset = "0x1595FE0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "SetStackDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushPendingContinuation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600055E")]
	public virtual int Run(InterpretedFrame frame) { }

}

