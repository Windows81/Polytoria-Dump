namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D1")]
internal sealed class ArrayLengthInstruction : Instruction
{
	[Token(Token = "0x40001BB")]
	public static readonly ArrayLengthInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700011F")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000121")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15916A0", Offset = "0x15908A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004F3")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000120")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1591630", Offset = "0x1590830", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F6")]
	private static ArrayLengthInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F4")]
	private ArrayLengthInstruction() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F1")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15916A0", Offset = "0x15908A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004F3")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F2")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15915B0", Offset = "0x15907B0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F5")]
	public virtual int Run(InterpretedFrame frame) { }

}

