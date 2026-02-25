namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000209")]
internal sealed class PopInstruction : Instruction
{
	[Token(Token = "0x400038A")]
	internal static readonly PopInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x170001F8")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001F9")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15E08A0", Offset = "0x15DFAA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60009CB")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x15E0830", Offset = "0x15DFA30", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009CD")]
	private static PopInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C9")]
	private PopInstruction() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CA")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15E08A0", Offset = "0x15DFAA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009CB")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15E0800", Offset = "0x15DFA00", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009CC")]
	public virtual int Run(InterpretedFrame frame) { }

}

