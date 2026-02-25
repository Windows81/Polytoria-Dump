namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E4")]
internal sealed class LeaveFaultInstruction : Instruction
{
	[Token(Token = "0x40001D9")]
	internal static readonly Instruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700014B")]
	public virtual int ConsumedContinuations
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000562")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014A")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000561")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A5470", Offset = "0x15A4670", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000563")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x15A5400", Offset = "0x15A4600", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000565")]
	private static LeaveFaultInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000560")]
	private LeaveFaultInstruction() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000562")]
	public virtual int get_ConsumedContinuations() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000561")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A5470", Offset = "0x15A4670", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000563")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A53D0", Offset = "0x15A45D0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PopPendingContinuation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000564")]
	public virtual int Run(InterpretedFrame frame) { }

}

