namespace System.Linq;

[Token(Token = "0x2000030")]
internal class OrderedEnumerable : OrderedEnumerable<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007D")]
	internal OrderedEnumerable<TElement> parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007E")]
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007F")]
	internal IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000080")]
	internal bool descending; //Field offset: 0x0

	[Address(RVA = "0xE5DAB0", Offset = "0xE5CCB0", Length = "0x101")]
	[CalledBy(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(OrderedEnumerable`1), Member = "System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = "System.Linq.IOrderedEnumerable`1<TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	internal OrderedEnumerable`2(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Address(RVA = "0xE5D910", Offset = "0xE5CB10", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EnumerableSorter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool), "System.Linq.EnumerableSorter`1<TElement>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000114")]
	internal virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

}

