namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E9")]
internal sealed class ThrowInstruction : Instruction
{
	[Token(Token = "0x40001E1")]
	internal static readonly ThrowInstruction Throw; //Field offset: 0x0
	[Token(Token = "0x40001E2")]
	internal static readonly ThrowInstruction VoidThrow; //Field offset: 0x8
	[Token(Token = "0x40001E3")]
	internal static readonly ThrowInstruction Rethrow; //Field offset: 0x10
	[Token(Token = "0x40001E4")]
	internal static readonly ThrowInstruction VoidRethrow; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E5")]
	private readonly bool _hasResult; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40001E6")]
	private readonly bool _rethrow; //Field offset: 0x11

	[Token(Token = "0x17000159")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000580")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000157")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15AA7F0", Offset = "0x15A99F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600057E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000158")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x1596C90", Offset = "0x1595E90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600057F")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x15AA660", Offset = "0x15A9860", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000583")]
	private static ThrowInstruction() { }

	[Address(RVA = "0x15AA7B0", Offset = "0x15A99B0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600057D")]
	private ThrowInstruction(bool hasResult, bool isRethrow) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000580")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15AA7F0", Offset = "0x15A99F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600057E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x1596C90", Offset = "0x1595E90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600057F")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15AA490", Offset = "0x15A9690", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeWrappedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RethrowException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000581")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x15AA5B0", Offset = "0x15A97B0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeWrappedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000582")]
	private static Exception WrapThrownObject(object thrown) { }

}

