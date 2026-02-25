namespace System.Collections.Generic;

[Token(Token = "0x20005F8")]
internal class ArraySortHelper
{
	[Token(Token = "0x400188F")]
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper; //Field offset: 0x0

	[Token(Token = "0x170006E3")]
	public static ArraySortHelper<T> Default
	{
		[Address(RVA = "0xAFF840", Offset = "0xAFEA40", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BE3")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xAFF750", Offset = "0xAFE950", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE5")]
	private static ArraySortHelper`1() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE4")]
	public ArraySortHelper`1() { }

	[Address(RVA = "0xAFB040", Offset = "0xAFA240", Length = "0x144")]
	[CalledBy(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "InternalBinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD8")]
	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[Address(RVA = "0xAFB620", Offset = "0xAFA820", Length = "0x25B")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE1")]
	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }

	[Address(RVA = "0xAFF840", Offset = "0xAFEA40", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE3")]
	public static ArraySortHelper<T> get_Default() { }

	[Address(RVA = "0xAFBAA0", Offset = "0xAFACA0", Length = "0x252")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "DownHeap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE0")]
	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xAFBF60", Offset = "0xAFB160", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE2")]
	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xAFC480", Offset = "0xAFB680", Length = "0x190")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDA")]
	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[Address(RVA = "0xAFC9C0", Offset = "0xAFBBC0", Length = "0x3A0")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "PickPivotAndPartition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007BF50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007C980")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDE")]
	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }

	[Address(RVA = "0xAFD1E0", Offset = "0xAFC3E0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDD")]
	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }

	[Address(RVA = "0xAFDB30", Offset = "0xAFCD30", Length = "0x3E0")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007C980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007CB30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDF")]
	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xAFDF20", Offset = "0xAFD120", Length = "0x213")]
	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007C550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD7")]
	public void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }

	[Address(RVA = "0xAFE4A0", Offset = "0xAFD6A0", Length = "0x136")]
	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007C550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD9")]
	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }

	[Address(RVA = "0xAFF5E0", Offset = "0xAFE7E0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDC")]
	private static void Swap(T[] a, int i, int j) { }

	[Address(RVA = "0xAFF430", Offset = "0xAFE630", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BDB")]
	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }

}

