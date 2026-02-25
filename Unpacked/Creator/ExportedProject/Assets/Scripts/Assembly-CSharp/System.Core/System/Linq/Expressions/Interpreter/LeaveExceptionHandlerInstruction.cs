namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E8")]
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x40001DF")]
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E0")]
	private readonly bool _hasValue; //Field offset: 0x18

	[Token(Token = "0x17000155")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000578")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000154")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A53A0", Offset = "0x15A45A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000577")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000156")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000579")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x15A5330", Offset = "0x15A4530", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600057C")]
	private static LeaveExceptionHandlerInstruction() { }

	[Address(RVA = "0x15976E0", Offset = "0x15968E0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000576")]
	private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue) { }

	[Address(RVA = "0x15A5190", Offset = "0x15A4390", Length = "0x141")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600057A")]
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000578")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A53A0", Offset = "0x15A45A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000577")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000579")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15A52E0", Offset = "0x15A44E0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600057B")]
	public virtual int Run(InterpretedFrame frame) { }

}

