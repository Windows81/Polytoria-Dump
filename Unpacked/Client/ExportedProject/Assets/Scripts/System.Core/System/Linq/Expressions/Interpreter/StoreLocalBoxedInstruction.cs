namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000195")]
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001B3")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000884")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001B4")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15E3F20", Offset = "0x15E3120", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000885")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000883")]
	internal StoreLocalBoxedInstruction(int index) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000884")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15E3F20", Offset = "0x15E3120", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000885")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15E3E20", Offset = "0x15E3020", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000886")]
	public virtual int Run(InterpretedFrame frame) { }

}

