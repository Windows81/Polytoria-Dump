namespace System.Linq;

[Token(Token = "0x2000032")]
internal class EnumerableSorter : EnumerableSorter<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000081")]
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000082")]
	internal IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000083")]
	internal bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000084")]
	internal EnumerableSorter<TElement> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000085")]
	internal TKey[] keys; //Field offset: 0x0

	[Address(RVA = "0xAE2ED0", Offset = "0xAE20D0", Length = "0x72")]
	[CalledBy(Type = typeof(OrderedEnumerable`2), Member = "GetEnumerableSorter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.EnumerableSorter`1<TElement>"}, ReturnType = "System.Linq.EnumerableSorter`1<TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	internal EnumerableSorter`2(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }

	[Address(RVA = "0xAE20B0", Offset = "0xAE12B0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	internal virtual int CompareKeys(int index1, int index2) { }

	[Address(RVA = "0xAE28F0", Offset = "0xAE1AF0", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	internal virtual void ComputeKeys(TElement[] elements, int count) { }

}

