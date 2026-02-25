namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000124")]
internal sealed class LoadStaticFieldInstruction : FieldInstruction
{

	[Token(Token = "0x1700016C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A5690", Offset = "0x15A4890", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600060C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700016D")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060B")]
	public LoadStaticFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x15A5690", Offset = "0x15A4890", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600060C")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060D")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15A5640", Offset = "0x15A4840", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600060E")]
	public virtual int Run(InterpretedFrame frame) { }

}

