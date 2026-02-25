namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200022E")]
internal sealed class QuoteInstruction : Instruction
{
	[Token(Token = "0x200022F")]
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003B9")]
		private readonly Dictionary<ParameterExpression, LocalVariable> _variables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003BA")]
		private readonly InterpretedFrame _frame; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003BB")]
		private readonly Stack<HashSet`1<ParameterExpression>> _shadowedVars; //Field offset: 0x20

		[Address(RVA = "0x15D23A0", Offset = "0x15D15A0", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A3D")]
		internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

		[Address(RVA = "0x15D1D90", Offset = "0x15D0F90", Length = "0x123")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A42")]
		private IStrongBox GetBox(ParameterExpression variable) { }

		[Address(RVA = "0x15D1EC0", Offset = "0x15D10C0", Length = "0x17F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitBlockExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(BlockExpression)}, ReturnType = typeof(Expression[]))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A3F")]
		protected private virtual Expression VisitBlock(BlockExpression node) { }

		[Address(RVA = "0x15D2040", Offset = "0x15D1240", Length = "0x194")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000A40")]
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		[Address(RVA = "0x7CDD70", Offset = "0x7CCF70", Length = "0x1C3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A3E")]
		protected private virtual Expression VisitLambda(Expression<T> node) { }

		[Address(RVA = "0x15D21E0", Offset = "0x15D13E0", Length = "0x1BC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
		[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A41")]
		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003B7")]
	private readonly Expression _operand; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003B8")]
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; //Field offset: 0x18

	[Token(Token = "0x17000217")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15E0B90", Offset = "0x15DFD90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000A3B")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000216")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A3A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A39")]
	public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	[Address(RVA = "0x15E0B90", Offset = "0x15DFD90", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000A3B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3A")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15E0A50", Offset = "0x15DFC50", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3C")]
	public virtual int Run(InterpretedFrame frame) { }

}

