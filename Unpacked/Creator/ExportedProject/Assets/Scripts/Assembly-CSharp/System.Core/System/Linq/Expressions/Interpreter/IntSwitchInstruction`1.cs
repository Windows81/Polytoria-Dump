namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EA")]
internal sealed class IntSwitchInstruction : Instruction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E7")]
	private readonly Dictionary<T, Int32> _cases; //Field offset: 0x0

	[Token(Token = "0x1700015B")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000586")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0xC9DA50", Offset = "0xC9CC50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000585")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000584")]
	internal IntSwitchInstruction`1(Dictionary<T, Int32> cases) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000586")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0xC9DA50", Offset = "0xC9CC50", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000585")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0xC9D790", Offset = "0xC9C990", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000587")]
	public virtual int Run(InterpretedFrame frame) { }

}

