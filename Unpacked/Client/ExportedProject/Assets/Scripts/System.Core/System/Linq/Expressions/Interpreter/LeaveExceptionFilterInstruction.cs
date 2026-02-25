namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E6")]
internal sealed class LeaveExceptionFilterInstruction : Instruction
{
	[Token(Token = "0x40001DB")]
	internal static readonly LeaveExceptionFilterInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000150")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A5160", Offset = "0x15A4360", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600056C")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x15A50F0", Offset = "0x15A42F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600056F")]
	private static LeaveExceptionFilterInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056B")]
	private LeaveExceptionFilterInstruction() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056D")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A5160", Offset = "0x15A4360", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600056C")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600056E")]
	public virtual int Run(InterpretedFrame frame) { }

}

