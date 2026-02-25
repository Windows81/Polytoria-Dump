namespace System.Linq.Expressions;

[Token(Token = "0x2000092")]
internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014C")]
	private readonly Expression _instance; //Field offset: 0x18

	[Address(RVA = "0x15A49E0", Offset = "0x15A3BE0", Length = "0x82")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AE")]
	public InstanceMethodCallExpression(MethodInfo method, Expression instance) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AF")]
	internal virtual Expression GetInstance() { }

}

