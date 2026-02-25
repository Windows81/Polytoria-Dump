namespace System.Collections.Generic;

[Token(Token = "0x20005FA")]
[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer : IComparer, IComparer<T>
{
	[Token(Token = "0x4001891")]
	private static Comparer<T> defaultComparer; //Field offset: 0x0

	[Token(Token = "0x170006E5")]
	public static Comparer<T> Default
	{
		[Address(RVA = "0x982D70", Offset = "0x981F70", Length = "0x10C")]
		[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BF2")]
		 get { } //Length: 268
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF6")]
	protected Comparer`1() { }

	[Token(Token = "0x6002BF4")]
	public abstract int Compare(T x, T y) { }

	[Address(RVA = "0x970760", Offset = "0x96F960", Length = "0x520")]
	[CalledBy(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF3")]
	private static Comparer<T> CreateComparer() { }

	[Address(RVA = "0x982D70", Offset = "0x981F70", Length = "0x10C")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF2")]
	public static Comparer<T> get_Default() { }

	[Address(RVA = "0x980C30", Offset = "0x97FE30", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF5")]
	private override int System.Collections.IComparer.Compare(object x, object y) { }

}

