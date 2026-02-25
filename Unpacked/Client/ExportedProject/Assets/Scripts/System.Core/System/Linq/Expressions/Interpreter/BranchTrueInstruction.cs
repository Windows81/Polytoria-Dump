namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DA")]
internal sealed class BranchTrueInstruction : OffsetInstruction
{
	[Token(Token = "0x40001C9")]
	private static Instruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x1700012F")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x1593450", Offset = "0x1592650", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000522")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000131")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000524")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000130")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15934E0", Offset = "0x15926E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000523")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1592C70", Offset = "0x1591E70", Length = "0xE")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000526")]
	public BranchTrueInstruction() { }

	[Address(RVA = "0x1593450", Offset = "0x1592650", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000522")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000524")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15934E0", Offset = "0x15926E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000523")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15933E0", Offset = "0x15925E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000525")]
	public virtual int Run(InterpretedFrame frame) { }

}

