namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000207")]
internal sealed class LoadObjectInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000388")]
	private readonly object _value; //Field offset: 0x10

	[Token(Token = "0x170001F5")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15D6FC0", Offset = "0x15D61C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60009C0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001F4")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BF")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BE")]
	internal LoadObjectInstruction(object value) { }

	[Address(RVA = "0x15D6FC0", Offset = "0x15D61C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009C0")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BF")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15D6EA0", Offset = "0x15D60A0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009C1")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x15D6F30", Offset = "0x15D6130", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009C2")]
	public virtual string ToString() { }

}

