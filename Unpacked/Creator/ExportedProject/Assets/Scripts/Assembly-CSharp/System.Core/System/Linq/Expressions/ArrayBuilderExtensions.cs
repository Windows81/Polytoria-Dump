namespace System.Linq.Expressions;

[Extension]
[Token(Token = "0x2000065")]
internal static class ArrayBuilderExtensions
{

	[Address(RVA = "0x639540", Offset = "0x638740", Length = "0x81")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000255")]
	public static ReadOnlyCollection<T> ToReadOnly(ArrayBuilder<T> builder) { }

}

