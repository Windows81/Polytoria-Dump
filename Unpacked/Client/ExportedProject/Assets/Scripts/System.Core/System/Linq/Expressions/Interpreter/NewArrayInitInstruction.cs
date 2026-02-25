namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000CC")]
internal sealed class NewArrayInitInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B4")]
	private readonly Type _elementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B5")]
	private readonly int _elementCount; //Field offset: 0x18

	[Token(Token = "0x17000111")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000113")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A7380", Offset = "0x15A6580", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000112")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x13B9AE0", Offset = "0x13B8CE0", Length = "0x42")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D7")]
	internal NewArrayInitInstruction(Type elementType, int elementCount) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D8")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A7380", Offset = "0x15A6580", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004DA")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D9")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15A72F0", Offset = "0x15A64F0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DB")]
	public virtual int Run(InterpretedFrame frame) { }

}

