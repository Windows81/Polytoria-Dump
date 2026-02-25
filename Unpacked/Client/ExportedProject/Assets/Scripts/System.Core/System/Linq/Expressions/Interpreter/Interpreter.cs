namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000151")]
internal sealed class Interpreter
{
	[Token(Token = "0x4000289")]
	internal static readonly object NoValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028A")]
	private readonly InstructionArray _instructions; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400028B")]
	internal readonly Object[] _objects; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400028C")]
	internal readonly RuntimeLabel[] _labels; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400028D")]
	internal readonly DebugInfo[] _debugInfos; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400028E")]
	private readonly string <Name>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400028F")]
	private readonly int <LocalCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000290")]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x1700018E")]
	internal int ClosureSize
	{
		[Address(RVA = "0x15B74A0", Offset = "0x15B66A0", Length = "0x47")]
		[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "get_ConsumedStack", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Token(Token = "0x6000712")]
		internal get { } //Length: 71
	}

	[Token(Token = "0x17000190")]
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000714")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700018F")]
	internal InstructionArray Instructions
	{
		[Address(RVA = "0xB08130", Offset = "0xB07330", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000713")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x1700018D")]
	internal int LocalCount
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000711")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700018C")]
	internal string Name
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000710")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x15B7350", Offset = "0x15B6550", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000716")]
	private static Interpreter() { }

	[Address(RVA = "0x15B73D0", Offset = "0x15B65D0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600070F")]
	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[Address(RVA = "0x15B74A0", Offset = "0x15B66A0", Length = "0x47")]
	[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "get_ConsumedStack", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Token(Token = "0x6000712")]
	internal int get_ClosureSize() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000714")]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[Address(RVA = "0xB08130", Offset = "0xB07330", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000713")]
	internal InstructionArray get_Instructions() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000711")]
	internal int get_LocalCount() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000710")]
	internal string get_Name() { }

	[Address(RVA = "0x15B72E0", Offset = "0x15B64E0", Length = "0x6F")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000715")]
	public void Run(InterpretedFrame frame) { }

}

