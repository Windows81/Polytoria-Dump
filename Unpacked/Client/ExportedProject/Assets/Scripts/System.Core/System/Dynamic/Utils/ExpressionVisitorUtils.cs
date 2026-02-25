namespace System.Dynamic.Utils;

[Token(Token = "0x2000242")]
internal static class ExpressionVisitorUtils
{

	[Address(RVA = "0x15D34D0", Offset = "0x15D26D0", Length = "0x2AD")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitInvocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvocationExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodCallExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AA4")]
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }

	[Address(RVA = "0x15D3780", Offset = "0x15D2980", Length = "0x295")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000AA2")]
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	[Address(RVA = "0x15D3A20", Offset = "0x15D2C20", Length = "0x2BA")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IParameterProvider), typeof(string)}, ReturnType = typeof(ParameterExpression[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AA3")]
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

}

