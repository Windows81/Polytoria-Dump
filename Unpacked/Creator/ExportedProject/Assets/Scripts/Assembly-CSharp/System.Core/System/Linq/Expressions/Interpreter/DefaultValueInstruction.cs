namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F5")]
internal sealed class DefaultValueInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F2")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x17000162")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1595AA0", Offset = "0x1594CA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000161")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A1")]
	internal DefaultValueInstruction(Type type) { }

	[Address(RVA = "0x1595AA0", Offset = "0x1594CA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60005A3")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A2")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x1595A00", Offset = "0x1594C00", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005A4")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x1595A40", Offset = "0x1594C40", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A5")]
	public virtual string ToString() { }

}

