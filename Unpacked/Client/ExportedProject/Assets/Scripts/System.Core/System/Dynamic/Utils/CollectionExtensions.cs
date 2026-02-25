namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x200023E")]
internal static class CollectionExtensions
{

	[Address(RVA = "0x686B80", Offset = "0x685D80", Length = "0x93")]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000A8B")]
	public static T[] RemoveFirst(T[] array) { }

	[Address(RVA = "0x686C20", Offset = "0x685E20", Length = "0x90")]
	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000A8C")]
	public static T[] RemoveLast(T[] array) { }

	[Address(RVA = "0x687370", Offset = "0x686570", Length = "0x1BD")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "SameElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>&", "System.Collections.Generic.IReadOnlyList`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(ParameterExpression[])}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ParameterExpression[])}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "ToReadOnlyCollection", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000A8D")]
	public static ReadOnlyCollection<T> ToReadOnly(IEnumerable<T> enumerable) { }

}

