namespace System.Linq.Expressions;

[Token(Token = "0x200007F")]
internal static class ExpressionCreator
{

	[Address(RVA = "0xC303B0", Offset = "0xC2F5B0", Length = "0x4E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036F")]
	public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

}

