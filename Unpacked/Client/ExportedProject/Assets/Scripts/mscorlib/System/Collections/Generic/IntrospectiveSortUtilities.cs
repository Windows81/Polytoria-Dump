namespace System.Collections.Generic;

[Token(Token = "0x20005F7")]
internal static class IntrospectiveSortUtilities
{

	[Address(RVA = "0x1444CA0", Offset = "0x1443EA0", Length = "0x11")]
	[CalledBy(Type = "System.Array+SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6002BD5")]
	internal static int FloorLog2PlusOne(int n) { }

	[Address(RVA = "0x1444CC0", Offset = "0x1443EC0", Length = "0x66")]
	[CalledBy(Type = "System.Array+SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002BD6")]
	internal static void ThrowOrIgnoreBadComparer(object comparer) { }

}

