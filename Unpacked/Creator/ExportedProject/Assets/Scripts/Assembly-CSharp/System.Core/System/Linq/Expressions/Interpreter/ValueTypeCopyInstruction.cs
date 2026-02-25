namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000197")]
internal sealed class ValueTypeCopyInstruction : Instruction
{
	[Token(Token = "0x400031D")]
	public static readonly ValueTypeCopyInstruction Instruction; //Field offset: 0x0

	[Token(Token = "0x170001B8")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600088C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001BA")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15EC5D0", Offset = "0x15EB7D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600088E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001B9")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600088D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15EC560", Offset = "0x15EB760", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000891")]
	private static ValueTypeCopyInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000890")]
	public ValueTypeCopyInstruction() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088C")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15EC5D0", Offset = "0x15EB7D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600088E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088D")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15EC510", Offset = "0x15EB710", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "GetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600088F")]
	public virtual int Run(InterpretedFrame frame) { }

}

