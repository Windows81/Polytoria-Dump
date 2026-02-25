namespace System.Linq.Expressions;

[Token(Token = "0x200003B")]
internal class MethodBinaryExpression : SimpleBinaryExpression
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000091")]
	private readonly MethodInfo _method; //Field offset: 0x30

	[Address(RVA = "0x158DD40", Offset = "0x158CF40", Length = "0x54")]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000145")]
	internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000146")]
	internal virtual MethodInfo GetMethod() { }

}

