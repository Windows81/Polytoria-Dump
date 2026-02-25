namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021E")]
internal sealed class TypeEqualsInstruction : Instruction
{
	[Token(Token = "0x400039D")]
	public static readonly TypeEqualsInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700020B")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A0A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700020D")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15E6AA0", Offset = "0x15E5CA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000A0C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700020C")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A0B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15E6A30", Offset = "0x15E5C30", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0F")]
	private static TypeEqualsInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0D")]
	private TypeEqualsInstruction() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15E6AA0", Offset = "0x15E5CA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000A0C")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0B")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15E69D0", Offset = "0x15E5BD0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A0E")]
	public virtual int Run(InterpretedFrame frame) { }

}

