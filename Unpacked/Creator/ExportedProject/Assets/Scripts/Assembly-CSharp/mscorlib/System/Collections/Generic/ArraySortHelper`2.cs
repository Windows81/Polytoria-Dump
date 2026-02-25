namespace System.Collections.Generic;

[Token(Token = "0x20005F9")]
internal class ArraySortHelper
{
	[Token(Token = "0x4001890")]
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; //Field offset: 0x0

	[Token(Token = "0x170006E4")]
	public static ArraySortHelper<TKey, TValue> Default
	{
		[Address(RVA = "0xE7ECD0", Offset = "0xE7DED0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BEF")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xE7EBE0", Offset = "0xE7DDE0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF1")]
	private static ArraySortHelper`2() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF0")]
	public ArraySortHelper`2() { }

	[Address(RVA = "0xE76DF0", Offset = "0xE75FF0", Length = "0x2C2")]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BED")]
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7ECD0", Offset = "0xE7DED0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEF")]
	public static ArraySortHelper<TKey, TValue> get_Default() { }

	[Address(RVA = "0xE78680", Offset = "0xE77880", Length = "0x271")]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "DownHeap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEC")]
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE79250", Offset = "0xE78450", Length = "0x242")]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEE")]
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7AC00", Offset = "0xE79E00", Length = "0x3D1")]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "PickPivotAndPartition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "InsertionSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ED750")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEA")]
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7AFE0", Offset = "0xE7A1E0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE9")]
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7B4C0", Offset = "0xE7A6C0", Length = "0x4BD")]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ED750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEB")]
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7CF70", Offset = "0xE7C170", Length = "0x1F6")]
	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE6")]
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }

	[Address(RVA = "0xE7E860", Offset = "0xE7DA60", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE8")]
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }

	[Address(RVA = "0xE7D870", Offset = "0xE7CA70", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE7")]
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }

}

