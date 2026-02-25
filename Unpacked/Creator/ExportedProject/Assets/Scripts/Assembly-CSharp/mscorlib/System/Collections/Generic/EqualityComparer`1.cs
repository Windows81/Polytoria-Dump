namespace System.Collections.Generic;

[Token(Token = "0x20005FE")]
[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer : IEqualityComparer, IEqualityComparer<T>
{
	[Token(Token = "0x4001892")]
	private static EqualityComparer<T> defaultComparer; //Field offset: 0x0

	[Token(Token = "0x170006E6")]
	public static EqualityComparer<T> Default
	{
		[Address(RVA = "0xB5DB10", Offset = "0xB5CD10", Length = "0x10C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C03")]
		 get { } //Length: 268
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0B")]
	protected EqualityComparer`1() { }

	[Address(RVA = "0xB450B0", Offset = "0xB442B0", Length = "0xA9C")]
	[CalledBy(Type = typeof(Array), Member = "IndexOfImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ByteEqualityComparer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InternalStringComparer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectEqualityComparer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C04")]
	private static EqualityComparer<T> CreateComparer() { }

	[Token(Token = "0x6002C05")]
	public abstract bool Equals(T x, T y) { }

	[Address(RVA = "0xB5DB10", Offset = "0xB5CD10", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C03")]
	public static EqualityComparer<T> get_Default() { }

	[Token(Token = "0x6002C06")]
	public abstract int GetHashCode(T obj) { }

	[Address(RVA = "0xB5A8B0", Offset = "0xB59AB0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C07")]
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0xB5ADE0", Offset = "0xB59FE0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C08")]
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0xB5B480", Offset = "0xB5A680", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0A")]
	private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	[Address(RVA = "0xB5C020", Offset = "0xB5B220", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C09")]
	private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}

