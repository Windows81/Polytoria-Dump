namespace MoonSharp.Interpreter.DataStructs;

[Token(Token = "0x200016B")]
internal class LinkedListIndex
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CE")]
	private LinkedList<TValue> m_LinkedList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CF")]
	private Dictionary<TKey, LinkedListNode`1<TValue>> m_Map; //Field offset: 0x0

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D64")]
	public LinkedListIndex`2(LinkedList<TValue> linkedList) { }

	[Address(RVA = "0xCEA4E0", Offset = "0xCE96E0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDF60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D67")]
	public void Add(TKey key, TValue value) { }

	[Address(RVA = "0xCEA5D0", Offset = "0xCE97D0", Length = "0x23")]
	[CalledBy(Type = typeof(Table), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6A")]
	public void Clear() { }

	[Address(RVA = "0xCEA720", Offset = "0xCE9920", Length = "0x25")]
	[CalledBy(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D69")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0xCEA8F0", Offset = "0xCE9AF0", Length = "0x4C")]
	[CalledBy(Type = typeof(Table), Member = "PerformTableSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataStructs.LinkedListIndex`2<T, TablePair>", "T", typeof(DynValue), typeof(DynValue), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Table), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Table), Member = "NextKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(System.Nullable`1<MoonSharp.Interpreter.TablePair>))]
	[CalledBy(Type = typeof(Table), Member = "get_Length", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D65")]
	public LinkedListNode<TValue> Find(TKey key) { }

	[Address(RVA = "0xCEA940", Offset = "0xCE9B40", Length = "0x135")]
	[CalledBy(Type = typeof(Table), Member = "PerformTableRemove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataStructs.LinkedListIndex`2<T, TablePair>", "T", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE3C0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D68")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0xCEB280", Offset = "0xCEA480", Length = "0x188")]
	[CalledBy(Type = typeof(Table), Member = "PerformTableSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataStructs.LinkedListIndex`2<T, TablePair>", "T", typeof(DynValue), typeof(DynValue), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDF60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D66")]
	public TValue Set(TKey key, TValue value) { }

}

