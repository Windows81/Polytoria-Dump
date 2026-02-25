namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000149")]
internal abstract class Instruction
{

	[Token(Token = "0x17000180")]
	public override int ConsumedContinuations
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000669")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700017E")]
	public override int ConsumedStack
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000667")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000183")]
	public int ContinuationsBalance
	{
		[Address(RVA = "0x15B5F40", Offset = "0x15B5140", Length = "0x48")]
		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600066C")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000184")]
	public abstract string InstructionName
	{
		[Token(Token = "0x600066E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000181")]
	public override int ProducedContinuations
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600066A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700017F")]
	public override int ProducedStack
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000668")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000182")]
	public int StackBalance
	{
		[Address(RVA = "0x15B5F90", Offset = "0x15B5190", Length = "0x48")]
		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600066B")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000672")]
	protected Instruction() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000669")]
	public override int get_ConsumedContinuations() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000667")]
	public override int get_ConsumedStack() { }

	[Address(RVA = "0x15B5F40", Offset = "0x15B5140", Length = "0x48")]
	[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600066C")]
	public int get_ContinuationsBalance() { }

	[Token(Token = "0x600066E")]
	public abstract string get_InstructionName() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066A")]
	public override int get_ProducedContinuations() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000668")]
	public override int get_ProducedStack() { }

	[Address(RVA = "0x15B5F90", Offset = "0x15B5190", Length = "0x48")]
	[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600066B")]
	public int get_StackBalance() { }

	[Address(RVA = "0x2C1690", Offset = "0x2C0890", Length = "0x13")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000671")]
	protected static void NullCheck(object o) { }

	[Token(Token = "0x600066D")]
	public abstract int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x144B590", Offset = "0x144A790", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000670")]
	public override string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x15B5EE0", Offset = "0x15B50E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600066F")]
	public virtual string ToString() { }

}

