namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E2")]
internal sealed class LeaveFinallyInstruction : Instruction
{
	[Token(Token = "0x40001D7")]
	internal static readonly Instruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000146")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000556")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000147")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A5560", Offset = "0x15A4760", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000557")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x15A54F0", Offset = "0x15A46F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000559")]
	private static LeaveFinallyInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000555")]
	private LeaveFinallyInstruction() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000556")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A5560", Offset = "0x15A4760", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000557")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A54A0", Offset = "0x15A46A0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PopPendingContinuation", ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "IsJumpHappened", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InterpretedFrame), Member = "YieldToPendingContinuation", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000558")]
	public virtual int Run(InterpretedFrame frame) { }

}

