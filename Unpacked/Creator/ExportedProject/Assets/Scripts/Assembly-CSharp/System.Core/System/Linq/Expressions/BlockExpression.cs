namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
[Token(Token = "0x2000058")]
public class BlockExpression : Expression
{

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700003B")]
	internal override int ExpressionCount
	{
		[Address(RVA = "0x1592970", Offset = "0x1591B70", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000208")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x17000037")]
	public ReadOnlyCollection<Expression> Expressions
	{
		[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000201")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000039")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE030", Offset = "0x3CD230", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000205")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700003A")]
	public virtual Type Type
	{
		[Address(RVA = "0x15929A0", Offset = "0x1591BA0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000206")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000038")]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[Address(RVA = "0x110B970", Offset = "0x110AB70", Length = "0x14")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000202")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x1592920", Offset = "0x1591B20", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000203")]
	internal BlockExpression() { }

	[Address(RVA = "0x15926B0", Offset = "0x15918B0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000204")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x1592970", Offset = "0x1591B70", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000208")]
	internal override int get_ExpressionCount() { }

	[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000201")]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[Address(RVA = "0x3CE030", Offset = "0x3CD230", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000205")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x15929A0", Offset = "0x1591BA0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000206")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x110B970", Offset = "0x110AB70", Length = "0x14")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000202")]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	[Address(RVA = "0x15926E0", Offset = "0x15918E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000207")]
	internal override Expression GetExpression(int index) { }

	[Address(RVA = "0x1592710", Offset = "0x1591910", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000209")]
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x1592740", Offset = "0x1591940", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600020A")]
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[Address(RVA = "0x1592790", Offset = "0x1591990", Length = "0x15C")]
	[CalledBy(Type = typeof(Block2), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block3), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block4), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block5), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Scope1), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020C")]
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }

	[Address(RVA = "0x15928F0", Offset = "0x1591AF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600020B")]
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

