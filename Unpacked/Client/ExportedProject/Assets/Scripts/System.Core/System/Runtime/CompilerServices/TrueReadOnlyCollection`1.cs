namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000239")]
internal sealed class TrueReadOnlyCollection : ReadOnlyCollection<T>
{

	[Address(RVA = "0x100F7E0", Offset = "0x100E9E0", Length = "0x14")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<T>", "System.Func`2<T, T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "ToReadOnlyCollection", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<T>", typeof(string)}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "Visit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessorArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(EmptyReadOnlyCollection`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7E")]
	public TrueReadOnlyCollection`1(T[] list) { }

}

