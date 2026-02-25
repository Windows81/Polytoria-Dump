namespace MoonSharp.Interpreter.Tree.Expressions;

[Token(Token = "0x200009F")]
internal class BinaryOperatorExpression : Expression
{
	[Token(Token = "0x20000A2")]
	private class LinkedList
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000341")]
		public Node Nodes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000342")]
		public Node Last; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000343")]
		public Operator OperatorMask; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077D")]
		public LinkedList() { }

	}

	[Token(Token = "0x20000A1")]
	private class Node
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033D")]
		public Expression Expr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400033E")]
		public Operator Op; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400033F")]
		public Node Prev; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000340")]
		public Node Next; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077C")]
		public Node() { }

	}

	[Flags]
	[Token(Token = "0x20000A0")]
	private enum Operator
	{
		NotAnOperator = 0,
		Or = 1,
		And = 2,
		Less = 4,
		Greater = 8,
		LessOrEqual = 16,
		GreaterOrEqual = 32,
		NotEqual = 64,
		Equal = 128,
		StrConcat = 256,
		Add = 512,
		Sub = 1024,
		Mul = 4096,
		Div = 8192,
		Mod = 16384,
		Power = 32768,
	}

	[Token(Token = "0x4000322")]
	private const Operator POWER = 32768; //Field offset: 0x0
	[Token(Token = "0x4000323")]
	private const Operator MUL_DIV_MOD = 28672; //Field offset: 0x0
	[Token(Token = "0x4000324")]
	private const Operator ADD_SUB = 1536; //Field offset: 0x0
	[Token(Token = "0x4000325")]
	private const Operator STRCAT = 256; //Field offset: 0x0
	[Token(Token = "0x4000326")]
	private const Operator COMPARES = 252; //Field offset: 0x0
	[Token(Token = "0x4000327")]
	private const Operator LOGIC_AND = 2; //Field offset: 0x0
	[Token(Token = "0x4000328")]
	private const Operator LOGIC_OR = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000329")]
	private Expression m_Exp1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400032A")]
	private Expression m_Exp2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400032B")]
	private Operator m_Operator; //Field offset: 0x30

	[Address(RVA = "0x319870", Offset = "0x318A70", Length = "0x65")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "PrioritizeLeftAssociative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Node), typeof(ScriptLoadingContext), typeof(Operator)}, ReturnType = typeof(Node))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "PrioritizeRightAssociative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Node), typeof(ScriptLoadingContext), typeof(Operator)}, ReturnType = typeof(Node))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000775")]
	private BinaryOperatorExpression(Expression exp1, Expression exp2, Operator op, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x317E50", Offset = "0x317050", Length = "0x128")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600076C")]
	public static void AddExpressionToChain(object chain, Expression exp) { }

	[Address(RVA = "0x317F80", Offset = "0x317180", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000770")]
	private static void AddNode(LinkedList list, Node node) { }

	[Address(RVA = "0x318020", Offset = "0x317220", Length = "0x274")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600076D")]
	public static void AddOperatorToChain(object chain, Token op) { }

	[Address(RVA = "0x3182F0", Offset = "0x3174F0", Length = "0x44")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600076B")]
	public static object BeginOperatorChain() { }

	[Address(RVA = "0x318340", Offset = "0x317540", Length = "0x7F")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "CreateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LinkedList), typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600076E")]
	public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x3183C0", Offset = "0x3175C0", Length = "0x2A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Operator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000778")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x318670", Offset = "0x317870", Length = "0x95")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600076F")]
	public static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x318710", Offset = "0x317910", Length = "0x191")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "CommitOperatorChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "PrioritizeRightAssociative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Node), typeof(ScriptLoadingContext), typeof(Operator)}, ReturnType = typeof(Node))]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "PrioritizeLeftAssociative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Node), typeof(ScriptLoadingContext), typeof(Operator)}, ReturnType = typeof(Node))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000771")]
	private static Expression CreateSubTree(LinkedList list, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x318EE0", Offset = "0x3180E0", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "CastToBool", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "EvalComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(Operator)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CastToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "EvalArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000779")]
	public virtual DynValue Eval(ScriptExecutionContext context) { }

	[Address(RVA = "0x3188B0", Offset = "0x317AB0", Length = "0x280")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Math), Member = "IEEERemainder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = "get_Value", ReturnType = typeof(double))]
	[Calls(Type = typeof(DynValue), Member = "CastToNumber", ReturnType = typeof(System.Nullable`1<System.Double>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600077A")]
	private double EvalArithmetic(DynValue v1, DynValue v2) { }

	[Address(RVA = "0x318B40", Offset = "0x317D40", Length = "0x396")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "EvalComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(Operator)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = "EvalComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(Operator)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600077B")]
	private bool EvalComparison(DynValue l, DynValue r, Operator op) { }

	[Address(RVA = "0x319190", Offset = "0x318390", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000777")]
	private static OpCode OperatorToOpCode(Operator op) { }

	[Address(RVA = "0x319340", Offset = "0x318540", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000774")]
	private static Operator ParseBinaryOperator(Token token) { }

	[Address(RVA = "0x319540", Offset = "0x318740", Length = "0x16C")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "CreateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LinkedList), typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Operator), typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000772")]
	private static Node PrioritizeLeftAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind) { }

	[Address(RVA = "0x3196B0", Offset = "0x3188B0", Length = "0x19B")]
	[CalledBy(Type = typeof(BinaryOperatorExpression), Member = "CreateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LinkedList), typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BinaryOperatorExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Operator), typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000773")]
	private static Node PrioritizeRightAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind) { }

	[Address(RVA = "0x319850", Offset = "0x318A50", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000776")]
	private static bool ShouldInvertBoolean(Operator op) { }

}

