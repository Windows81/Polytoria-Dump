namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EB")]
internal sealed class StringSwitchInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E8")]
	private readonly Dictionary<String, Int32> _cases; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E9")]
	private readonly StrongBox<Int32> _nullCase; //Field offset: 0x18

	[Token(Token = "0x1700015D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600058A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A8A60", Offset = "0x15A7C60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000589")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000588")]
	internal StringSwitchInstruction(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A8A60", Offset = "0x15A7C60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000589")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A8990", Offset = "0x15A7B90", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600058B")]
	public virtual int Run(InterpretedFrame frame) { }

}

