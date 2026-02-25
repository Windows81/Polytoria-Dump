namespace System.Collections.Generic;

[Token(Token = "0x20005E8")]
internal static class EnumerableHelpers
{

	[Address(RVA = "0x69ED90", Offset = "0x69DF90", Length = "0x218")]
	[CalledBy(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6B")]
	internal static T[] ToArray(IEnumerable<T> source) { }

}

