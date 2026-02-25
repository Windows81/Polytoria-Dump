namespace System.Linq.Expressions;

[Token(Token = "0x200009C")]
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015E")]
	private object _arg0; //Field offset: 0x20

	[Token(Token = "0x170000AE")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A43C0", Offset = "0x15A35C0", Length = "0x32")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DD")]
	public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DF")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x15A4250", Offset = "0x15A3450", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60003DE")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x15A42F0", Offset = "0x15A34F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IArgumentProvider), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E0")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A4300", Offset = "0x15A3500", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Token(Token = "0x60003E1")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

