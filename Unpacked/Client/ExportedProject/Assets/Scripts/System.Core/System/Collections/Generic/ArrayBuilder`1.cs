namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x2000249")]
internal struct ArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DC")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DD")]
	private int _count; //Field offset: 0x0

	[Address(RVA = "0xAF76D0", Offset = "0xAF68D0", Length = "0x6D")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF5")]
	public ArrayBuilder`1(int capacity) { }

	[Address(RVA = "0xAF7180", Offset = "0xAF6380", Length = "0x122")]
	[CalledBy(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF6")]
	public T[] ToArray() { }

	[Address(RVA = "0xAF73B0", Offset = "0xAF65B0", Length = "0x3E")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF7")]
	public void UncheckedAdd(T item) { }

}

