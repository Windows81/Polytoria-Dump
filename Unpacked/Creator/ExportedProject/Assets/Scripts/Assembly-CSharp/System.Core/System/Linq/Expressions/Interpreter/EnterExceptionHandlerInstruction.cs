namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E7")]
internal sealed class EnterExceptionHandlerInstruction : Instruction
{
	[Token(Token = "0x40001DC")]
	internal static readonly EnterExceptionHandlerInstruction Void; //Field offset: 0x0
	[Token(Token = "0x40001DD")]
	internal static readonly EnterExceptionHandlerInstruction NonVoid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DE")]
	private readonly bool _hasValue; //Field offset: 0x10

	[Token(Token = "0x17000152")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x1596C90", Offset = "0x1595E90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000572")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000151")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1596CA0", Offset = "0x1595EA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000571")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000153")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000573")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1596BD0", Offset = "0x1595DD0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000575")]
	private static EnterExceptionHandlerInstruction() { }

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000570")]
	private EnterExceptionHandlerInstruction(bool hasValue) { }

	[Address(RVA = "0x1596C90", Offset = "0x1595E90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000572")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x1596CA0", Offset = "0x1595EA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000571")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000573")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000574")]
	public virtual int Run(InterpretedFrame frame) { }

}

