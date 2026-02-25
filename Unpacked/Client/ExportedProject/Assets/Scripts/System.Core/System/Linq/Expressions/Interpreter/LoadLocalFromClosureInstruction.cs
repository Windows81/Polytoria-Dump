namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000190")]
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001A8")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15D6D20", Offset = "0x15D5F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600086D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001A7")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086B")]
	internal LoadLocalFromClosureInstruction(int index) { }

	[Address(RVA = "0x15D6D20", Offset = "0x15D5F20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600086D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086C")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15D6C30", Offset = "0x15D5E30", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600086E")]
	public virtual int Run(InterpretedFrame frame) { }

}

