namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005EA")]
internal class LowLevelDictionary
{
	[Token(Token = "0x20005EC")]
	private sealed class DefaultComparer : IEqualityComparer<T>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B81")]
		public DefaultComparer`1() { }

		[Address(RVA = "0x9E5680", Offset = "0x9E4880", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B7F")]
		public override bool Equals(T x, T y) { }

		[Address(RVA = "0x9E5AB0", Offset = "0x9E4CB0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B80")]
		public override int GetHashCode(T obj) { }

	}

	[Token(Token = "0x20005EB")]
	private sealed class Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001872")]
		public TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001873")]
		public TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001874")]
		public Entry<TKey, TValue> _next; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B7E")]
		public Entry() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186E")]
	private Entry<TKey, TValue>[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186F")]
	private int _numEntries; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001870")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001871")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0

	[Token(Token = "0x170006D4")]
	public TKey Item
	{
		[Address(RVA = "0xE04DF0", Offset = "0xE03FF0", Length = "0x224")]
		[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LowLevelDictionary`2), Member = "ExpandBuckets", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B77")]
		 set { } //Length: 548
	}

	[Address(RVA = "0xE048B0", Offset = "0xE03AB0", Length = "0xE5")]
	[CalledBy(Type = typeof(DebuggerSupport), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B75")]
	public LowLevelDictionary`2() { }

	[Address(RVA = "0xE04AA0", Offset = "0xE03CA0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B76")]
	public LowLevelDictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xE03580", Offset = "0xE02780", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B78")]
	public void Clear(int capacity = 17) { }

	[Address(RVA = "0xE035E0", Offset = "0xE027E0", Length = "0x14C")]
	[CalledBy(Type = typeof(LowLevelDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LowLevelDictionary`2), Member = "UncheckedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "System.Collections.Generic.LowLevelDictionary`2<TKey, TValue>+Entry<TKey, TValue>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7C")]
	private void ExpandBuckets() { }

	[Address(RVA = "0xE03BF0", Offset = "0xE02DF0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7A")]
	private Entry<TKey, TValue> Find(TKey key) { }

	[Address(RVA = "0xE03E60", Offset = "0xE03060", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7D")]
	private int GetBucket(TKey key, int numBuckets = 0) { }

	[Address(RVA = "0xE04300", Offset = "0xE03500", Length = "0x133")]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B79")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0xE04DF0", Offset = "0xE03FF0", Length = "0x224")]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "ExpandBuckets", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B77")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xE04440", Offset = "0xE03640", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D89A0")]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "ExpandBuckets", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7B")]
	private Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }

}

