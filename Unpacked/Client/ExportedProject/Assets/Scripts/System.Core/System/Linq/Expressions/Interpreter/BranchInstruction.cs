namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DC")]
internal class BranchInstruction : OffsetInstruction
{
	[Token(Token = "0x40001CB")]
	private static Instruction[][][] s_caches; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CC")]
	internal readonly bool _hasResult; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40001CD")]
	internal readonly bool _hasValue; //Field offset: 0x19

	[Token(Token = "0x17000136")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x1592DB0", Offset = "0x1591FB0", Length = "0x2B0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600052D")]
		 get { } //Length: 688
	}

	[Token(Token = "0x17000138")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x1593070", Offset = "0x1592270", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000531")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000137")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1593080", Offset = "0x1592280", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000530")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000139")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000532")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1592D40", Offset = "0x1591F40", Length = "0x23")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600052E")]
	internal BranchInstruction() { }

	[Address(RVA = "0x1592D70", Offset = "0x1591F70", Length = "0x3E")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600052F")]
	public BranchInstruction(bool hasResult, bool hasValue) { }

	[Address(RVA = "0x1592DB0", Offset = "0x1591FB0", Length = "0x2B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600052D")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x1593070", Offset = "0x1592270", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000531")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x1593080", Offset = "0x1592280", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000530")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15930B0", Offset = "0x15922B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000532")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000533")]
	public virtual int Run(InterpretedFrame frame) { }

}

