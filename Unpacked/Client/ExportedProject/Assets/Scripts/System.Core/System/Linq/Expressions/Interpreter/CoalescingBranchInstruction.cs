namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DB")]
internal sealed class CoalescingBranchInstruction : OffsetInstruction
{
	[Token(Token = "0x40001CA")]
	private static Instruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000132")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x1594710", Offset = "0x1593910", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000527")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000134")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000529")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000133")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15947A0", Offset = "0x15939A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000528")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000135")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1592C70", Offset = "0x1591E70", Length = "0xE")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052C")]
	public CoalescingBranchInstruction() { }

	[Address(RVA = "0x1594710", Offset = "0x1593910", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000527")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000529")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15947A0", Offset = "0x15939A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000528")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052A")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15946D0", Offset = "0x15938D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052B")]
	public virtual int Run(InterpretedFrame frame) { }

}

