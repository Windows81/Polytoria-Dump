namespace System.Linq;

[Token(Token = "0x2000031")]
internal abstract class EnumerableSorter
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	protected EnumerableSorter`1() { }

	[Token(Token = "0x6000116")]
	internal abstract int CompareKeys(int index1, int index2) { }

	[Token(Token = "0x6000115")]
	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	[Address(RVA = "0xAE1410", Offset = "0xAE0610", Length = "0x255")]
	[CalledBy(Type = typeof(EnumerableSorter`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement[]", typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000118")]
	private void QuickSort(Int32[] map, int left, int right) { }

	[Address(RVA = "0xAE1EF0", Offset = "0xAE10F0", Length = "0xDA")]
	[CalledBy(Type = "System.Linq.OrderedEnumerable`1+<GetEnumerator>d__1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000117")]
	internal Int32[] Sort(TElement[] elements, int count) { }

}

