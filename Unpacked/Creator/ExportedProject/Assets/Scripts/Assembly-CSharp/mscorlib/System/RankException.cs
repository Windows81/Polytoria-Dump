namespace System;

[Token(Token = "0x2000127")]
public class RankException : SystemException
{

	[Address(RVA = "0x14BE530", Offset = "0x14BD730", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000951")]
	public RankException() { }

	[Address(RVA = "0x14BE5C0", Offset = "0x14BD7C0", Length = "0x61")]
	[CalledBy(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(object), typeof(IComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Array), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Array), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Array), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int), typeof(int), typeof(IComparer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Array), Member = "InternalArray__ICollection_Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Array), Member = "InternalArray__IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000952")]
	public RankException(string message) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000953")]
	protected RankException(SerializationInfo info, StreamingContext context) { }

}

