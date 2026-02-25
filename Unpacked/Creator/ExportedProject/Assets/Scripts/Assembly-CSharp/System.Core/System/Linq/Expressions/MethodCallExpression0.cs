namespace System.Linq.Expressions;

[Token(Token = "0x2000095")]
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
{

	[Token(Token = "0x170000A7")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003BC")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x15A5A70", Offset = "0x15A4C70", Length = "0x65")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BA")]
	public MethodCallExpression0(MethodInfo method) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BC")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x15A5980", Offset = "0x15A4B80", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60003BB")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x15A59D0", Offset = "0x15A4BD0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60003BD")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A5A20", Offset = "0x15A4C20", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	[Token(Token = "0x60003BE")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

