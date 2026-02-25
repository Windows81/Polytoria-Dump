namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x20001D0")]
public class SortedSet : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	[Token(Token = "0x20001D6")]
	private sealed class <>c__DisplayClass52_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070B")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070C")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070D")]
		public T[] array; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFE")]
		public <>c__DisplayClass52_0() { }

		[Address(RVA = "0x8006B0", Offset = "0x7FF8B0", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFF")]
		internal bool <CopyTo>b__0(Node<T> node) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D7")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070E")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070F")]
		public Object[] objects; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C00")]
		public <>c__DisplayClass53_0() { }

		[Address(RVA = "0x800720", Offset = "0x7FF920", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C01")]
		internal bool <System.Collections.ICollection.CopyTo>b__0(Node<T> node) { }

	}

	[Token(Token = "0x20001D5")]
	public struct ElementCount
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000709")]
		internal int UniqueCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070A")]
		internal int UnfoundCount; //Field offset: 0x0

	}

	[Token(Token = "0x20001D4")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		[Token(Token = "0x4000703")]
		private static readonly Node<T> s_dummyNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000704")]
		private SortedSet<T> _tree; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000705")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000706")]
		private Stack<Node<T>> _stack; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000707")]
		private Node<T> _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000708")]
		private bool _reverse; //Field offset: 0x0

		[Token(Token = "0x17000253")]
		public override T Current
		{
			[Address(RVA = "0xAE5CF0", Offset = "0xAE4EF0", Length = "0x59")]
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TKey")]
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
			[CalledBy(Type = typeof(TreeSubSet), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BF8")]
			 get { } //Length: 89
		}

		[Token(Token = "0x17000255")]
		internal bool NotStartedOrEnded
		{
			[Address(RVA = "0xAE5DD0", Offset = "0xAE4FD0", Length = "0x9")]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BFA")]
			internal get { } //Length: 9
		}

		[Token(Token = "0x17000254")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE5240", Offset = "0xAE4440", Length = "0xA4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BF9")]
			private get { } //Length: 164
		}

		[Address(RVA = "0xAE54A0", Offset = "0xAE46A0", Length = "0x114")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NodeColor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFD")]
		private static Enumerator() { }

		[Address(RVA = "0xAE5C00", Offset = "0xAE4E00", Length = "0x97")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF1")]
		internal Enumerator(SortedSet<T> set) { }

		[Address(RVA = "0xAE59A0", Offset = "0xAE4BA0", Length = "0x1BF")]
		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SortedSet`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(SortedSet`1), Member = "Log2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF2")]
		internal Enumerator(SortedSet<T> set, bool reverse) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF7")]
		public override void Dispose() { }

		[Address(RVA = "0xAE5CF0", Offset = "0xAE4EF0", Length = "0x59")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TKey")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[CalledBy(Type = typeof(TreeSubSet), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF8")]
		public override T get_Current() { }

		[Address(RVA = "0xAE5DD0", Offset = "0xAE4FD0", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFA")]
		internal bool get_NotStartedOrEnded() { }

		[Address(RVA = "0xAE36A0", Offset = "0xAE28A0", Length = "0x1B7")]
		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF5")]
		private void Initialize() { }

		[Address(RVA = "0xAE4550", Offset = "0xAE3750", Length = "0x2CE")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TreeSubSet), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF6")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE4950", Offset = "0xAE3B50", Length = "0x120")]
		[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFB")]
		internal void Reset() { }

		[Address(RVA = "0xAE5240", Offset = "0xAE4440", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xAE4FA0", Offset = "0xAE41A0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078F40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFC")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0xAE53B0", Offset = "0xAE45B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF4")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0xAE53F0", Offset = "0xAE45F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF3")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x20001D3")]
	public sealed class Node
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FF")]
		private T <Item>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000700")]
		private Node<T> <Left>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000701")]
		private Node<T> <Right>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000702")]
		private NodeColor <Color>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700024E")]
		public NodeColor Color
		{
			[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDF")]
			 get { } //Length: 5
			[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BE0")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000251")]
		public bool Is2Node
		{
			[Address(RVA = "0xE29520", Offset = "0xE28720", Length = "0xB4")]
			[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BE3")]
			 get { } //Length: 180
		}

		[Token(Token = "0x17000252")]
		public bool Is4Node
		{
			[Address(RVA = "0xE296A0", Offset = "0xE288A0", Length = "0x98")]
			[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BE4")]
			 get { } //Length: 152
		}

		[Token(Token = "0x1700024F")]
		public bool IsBlack
		{
			[Address(RVA = "0x3A2600", Offset = "0x3A1800", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BE1")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000250")]
		public bool IsRed
		{
			[Address(RVA = "0xE29840", Offset = "0xE28A40", Length = "0x8")]
			[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BE2")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700024B")]
		public T Item
		{
			[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BD9")]
			 get { } //Length: 11
			[Address(RVA = "0xE299D0", Offset = "0xE28BD0", Length = "0x12")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDA")]
			 set { } //Length: 18
		}

		[Token(Token = "0x1700024C")]
		public Node<T> Left
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDB")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDC")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700024D")]
		public Node<T> Right
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDD")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BDE")]
			 set { } //Length: 13
		}

		[Address(RVA = "0xE294A0", Offset = "0xE286A0", Length = "0x46")]
		[CalledBy(Type = typeof(Enumerator), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD6")]
		public Node(T item, NodeColor color) { }

		[Address(RVA = "0xE284F0", Offset = "0xE276F0", Length = "0x5")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE5")]
		public void ColorBlack() { }

		[Address(RVA = "0xE28520", Offset = "0xE27720", Length = "0x5")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE6")]
		public void ColorRed() { }

		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDF")]
		public NodeColor get_Color() { }

		[Address(RVA = "0xE29520", Offset = "0xE28720", Length = "0xB4")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE3")]
		public bool get_Is2Node() { }

		[Address(RVA = "0xE296A0", Offset = "0xE288A0", Length = "0x98")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE4")]
		public bool get_Is4Node() { }

		[Address(RVA = "0x3A2600", Offset = "0x3A1800", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE1")]
		public bool get_IsBlack() { }

		[Address(RVA = "0xE29840", Offset = "0xE28A40", Length = "0x8")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE2")]
		public bool get_IsRed() { }

		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD9")]
		public T get_Item() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDB")]
		public Node<T> get_Left() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDD")]
		public Node<T> get_Right() { }

		[Address(RVA = "0xE28550", Offset = "0xE27750", Length = "0x7E")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE7")]
		public TreeRotation GetRotation(Node<T> current, Node<T> sibling) { }

		[Address(RVA = "0xE28670", Offset = "0xE27870", Length = "0x10")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE8")]
		public Node<T> GetSibling(Node<T> node) { }

		[Address(RVA = "0xE286F0", Offset = "0xE278F0", Length = "0x35")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD7")]
		public static bool IsNonNullRed(Node<T> node) { }

		[Address(RVA = "0xE287C0", Offset = "0xE279C0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD8")]
		public static bool IsNullOrBlack(Node<T> node) { }

		[Address(RVA = "0xE28940", Offset = "0xE27B40", Length = "0x2C")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEF")]
		public void Merge2Nodes() { }

		[Address(RVA = "0xE289F0", Offset = "0xE27BF0", Length = "0x2E")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "ReplaceChildOrRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "ReplaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF0")]
		public void ReplaceChild(Node<T> child, Node<T> newChild) { }

		[Address(RVA = "0xE290E0", Offset = "0xE282E0", Length = "0x1C5")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEA")]
		public Node<T> Rotate(TreeRotation rotation) { }

		[Address(RVA = "0xE28C80", Offset = "0xE27E80", Length = "0x4A")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEB")]
		public Node<T> RotateLeft() { }

		[Address(RVA = "0xE28A20", Offset = "0xE27C20", Length = "0x7E")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEC")]
		public Node<T> RotateLeftRight() { }

		[Address(RVA = "0xE28E80", Offset = "0xE28080", Length = "0x4A")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BED")]
		public Node<T> RotateRight() { }

		[Address(RVA = "0xE28CD0", Offset = "0xE27ED0", Length = "0x7E")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEE")]
		public Node<T> RotateRightLeft() { }

		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE0")]
		public void set_Color(NodeColor value) { }

		[Address(RVA = "0xE299D0", Offset = "0xE28BD0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDA")]
		public void set_Item(T value) { }

		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDC")]
		public void set_Left(Node<T> value) { }

		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDE")]
		public void set_Right(Node<T> value) { }

		[Address(RVA = "0xE29360", Offset = "0xE28560", Length = "0x2C")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE9")]
		public void Split4Node() { }

	}

	[Token(Token = "0x20001D1")]
	public sealed class TreeSubSet : SortedSet<T>, ISerializable, IDeserializationCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x20001D2")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006FE")]
			public List<T> toRemove; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BD4")]
			public <>c__DisplayClass9_0() { }

			[Address(RVA = "0x80A050", Offset = "0x809250", Length = "0xA7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BD5")]
			internal bool <Clear>b__0(Node<T> n) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006F9")]
		private SortedSet<T> _underlying; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FA")]
		private T _min; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FB")]
		private T _max; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FC")]
		private bool _lBoundActive; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FD")]
		private bool _uBoundActive; //Field offset: 0x0

		[Token(Token = "0x1700024A")]
		internal virtual T MaxInternal
		{
			[Address(RVA = "0x100F030", Offset = "0x100E230", Length = "0x152")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BC7")]
			internal get { } //Length: 338
		}

		[Token(Token = "0x17000249")]
		internal virtual T MinInternal
		{
			[Address(RVA = "0x100F450", Offset = "0x100E650", Length = "0x152")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000BC6")]
			internal get { } //Length: 338
		}

		[Address(RVA = "0x100E800", Offset = "0x100DA00", Length = "0x139")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "GetViewBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = "System.Collections.Generic.SortedSet`1<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SortedSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SortedSet`1), Member = "FindRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180100F50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC0")]
		public TreeSubSet(SortedSet<T> Underlying, T Min, T Max, bool lowerBoundActive, bool upperBoundActive) { }

		[Address(RVA = "0x100E380", Offset = "0x100D580", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD3")]
		private bool <VersionCheckImpl>b__20_0(Node<T> n) { }

		[Address(RVA = "0x100B130", Offset = "0x100A330", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC1")]
		internal virtual bool AddIfNotPresent(T item) { }

		[Address(RVA = "0x100B7A0", Offset = "0x100A9A0", Length = "0x36D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC9")]
		internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action) { }

		[Address(RVA = "0x100BB10", Offset = "0x100AD10", Length = "0x27A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(SortedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC4")]
		public virtual void Clear() { }

		[Address(RVA = "0x100C0E0", Offset = "0x100B2E0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC2")]
		public virtual bool Contains(T item) { }

		[Address(RVA = "0x100C250", Offset = "0x100B450", Length = "0xB3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC3")]
		internal virtual bool DoRemove(T item) { }

		[Address(RVA = "0x100C4D0", Offset = "0x100B6D0", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "FindNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCA")]
		internal virtual Node<T> FindNode(T item) { }

		[Address(RVA = "0x100F030", Offset = "0x100E230", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC7")]
		internal virtual T get_MaxInternal() { }

		[Address(RVA = "0x100F450", Offset = "0x100E650", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC6")]
		internal virtual T get_MinInternal() { }

		[Address(RVA = "0xAE53F0", Offset = "0xAE45F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD0")]
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x100C720", Offset = "0x100B920", Length = "0x2DD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCE")]
		public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { }

		[Address(RVA = "0x100CE70", Offset = "0x100C070", Length = "0x3BA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "Log2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC8")]
		internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }

		[Address(RVA = "0x100D840", Offset = "0x100CA40", Length = "0x29F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180FE9930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCB")]
		internal virtual int InternalIndexOf(T item) { }

		[Address(RVA = "0x100E160", Offset = "0x100D360", Length = "0x1D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC5")]
		internal virtual bool IsWithinRange(T item) { }

		[Address(RVA = "0xAE53B0", Offset = "0xAE45B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD2")]
		protected virtual void OnDeserialization(object sender) { }

		[Address(RVA = "0xAE53B0", Offset = "0xAE45B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD1")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x100E340", Offset = "0x100D540", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCF")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x100E7E0", Offset = "0x100D9E0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180100F50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCC")]
		internal virtual void VersionCheck() { }

		[Address(RVA = "0x100E390", Offset = "0x100D590", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedSet`1), Member = "FindRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCD")]
		private void VersionCheckImpl() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F3")]
	private Node<T> root; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F4")]
	private IComparer<T> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F5")]
	private int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F6")]
	private int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F7")]
	private object _syncRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F8")]
	private SerializationInfo siInfo; //Field offset: 0x0

	[Token(Token = "0x17000242")]
	public IComparer<T> Comparer
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B94")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000241")]
	public override int Count
	{
		[Address(RVA = "0xF313B0", Offset = "0xF305B0", Length = "0x25")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B93")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000247")]
	public T Max
	{
		[Address(RVA = "0xF31590", Offset = "0xF30790", Length = "0x30")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB8")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000248")]
	internal override T MaxInternal
	{
		[Address(RVA = "0xF31550", Offset = "0xF30750", Length = "0x32")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB9")]
		internal get { } //Length: 50
	}

	[Token(Token = "0x17000245")]
	public T Min
	{
		[Address(RVA = "0xF31810", Offset = "0xF30A10", Length = "0x30")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB6")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000246")]
	internal override T MinInternal
	{
		[Address(RVA = "0xF31660", Offset = "0xF30860", Length = "0x32")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB7")]
		internal get { } //Length: 50
	}

	[Token(Token = "0x17000243")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B95")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000244")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF310B0", Offset = "0xF302B0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B96")]
		private get { } //Length: 107
	}

	[Address(RVA = "0xF31360", Offset = "0xF30560", Length = "0x44")]
	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8D")]
	public SortedSet`1() { }

	[Address(RVA = "0xF312F0", Offset = "0xF304F0", Length = "0x63")]
	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeSubSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", "T", "T", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8E")]
	public SortedSet`1(IComparer<T> comparer) { }

	[Address(RVA = "0xF312B0", Offset = "0xF304B0", Length = "0x31")]
	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8F")]
	protected SortedSet`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF27F60", Offset = "0xF27160", Length = "0x29")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B99")]
	public override bool Add(T item) { }

	[Address(RVA = "0xF27960", Offset = "0xF26B60", Length = "0x5F6")]
	[CalledBy(Type = typeof(TreeSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "RotateLeftRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = "RotateRightLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "Split4Node", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Node), Member = "get_Is4Node", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Node), Member = "get_IsRed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Node), Member = "IsNonNullRed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NodeColor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9B")]
	internal override bool AddIfNotPresent(T item) { }

	[Address(RVA = "0xF28070", Offset = "0xF27270", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B92")]
	internal override bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action) { }

	[Address(RVA = "0xF28400", Offset = "0xF27600", Length = "0x4C7")]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB5")]
	private ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }

	[Address(RVA = "0xF28DF0", Offset = "0xF27FF0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9E")]
	public override void Clear() { }

	[Address(RVA = "0xF293A0", Offset = "0xF285A0", Length = "0x2F")]
	[CalledBy(Type = typeof(TreeSubSet), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9F")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xF28E20", Offset = "0xF28020", Length = "0x229")]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B90")]
	private bool ContainsAllElements(IEnumerable<T> collection) { }

	[Address(RVA = "0xF29770", Offset = "0xF28970", Length = "0x299")]
	[CalledBy(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA1")]
	public void CopyTo(T[] array, int index, int count) { }

	[Address(RVA = "0xF296F0", Offset = "0xF288F0", Length = "0x73")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA0")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xF29A10", Offset = "0xF28C10", Length = "0x590")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "Merge2Nodes", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeRotation)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "GetRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(TreeRotation))]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "get_IsRed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "GetSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "get_Is2Node", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9D")]
	internal override bool DoRemove(T item) { }

	[Address(RVA = "0xF2A530", Offset = "0xF29730", Length = "0x13C")]
	[CalledBy(Type = typeof(TreeSubSet), Member = "FindNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA9")]
	internal override Node<T> FindNode(T item) { }

	[Address(RVA = "0xF2A820", Offset = "0xF29A20", Length = "0x224")]
	[CalledBy(Type = typeof(TreeSubSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", "T", "T", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeSubSet), Member = "VersionCheckImpl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAB")]
	internal Node<T> FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B94")]
	public IComparer<T> get_Comparer() { }

	[Address(RVA = "0xF313B0", Offset = "0xF305B0", Length = "0x25")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B93")]
	public override int get_Count() { }

	[Address(RVA = "0xF31590", Offset = "0xF30790", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB8")]
	public T get_Max() { }

	[Address(RVA = "0xF31550", Offset = "0xF30750", Length = "0x32")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB9")]
	internal override T get_MaxInternal() { }

	[Address(RVA = "0xF31810", Offset = "0xF30A10", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB6")]
	public T get_Min() { }

	[Address(RVA = "0xF31660", Offset = "0xF30860", Length = "0x32")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB7")]
	internal override T get_MinInternal() { }

	[Address(RVA = "0xF2AD10", Offset = "0xF29F10", Length = "0x39")]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeSubSet), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA3")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xF2AD90", Offset = "0xF29F90", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F59A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBC")]
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF2B4B0", Offset = "0xF2A6B0", Length = "0x1CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TreeSubSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", "T", "T", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	public override SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { }

	[Address(RVA = "0xF2B760", Offset = "0xF2A960", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAD")]
	private bool HasEqualComparer(SortedSet<T> other) { }

	[Address(RVA = "0xF2BA30", Offset = "0xF2AC30", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B91")]
	internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }

	[Address(RVA = "0xF2BBC0", Offset = "0xF2ADC0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "RotateLeftRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRightLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA6")]
	private void InsertionBalance(Node<T> current, ref Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent) { }

	[Address(RVA = "0xF2BEC0", Offset = "0xF2B0C0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAA")]
	internal override int InternalIndexOf(T item) { }

	[Address(RVA = "0xF2C200", Offset = "0xF2B400", Length = "0x229")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SortedSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB0")]
	public override bool IsProperSubsetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xF2C680", Offset = "0xF2B880", Length = "0x481")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180F1B9C0")]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SortedSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB2")]
	public override bool IsProperSupersetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xF2D8F0", Offset = "0xF2CAF0", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(SortedSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(SortedSet`1), Member = "IsSubsetOfSortedSetWithSameComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAE")]
	public override bool IsSubsetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xF2D480", Offset = "0xF2C680", Length = "0x28A")]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "IsProperSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180F1B9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAF")]
	private bool IsSubsetOfSortedSetWithSameComparer(SortedSet<T> asSorted) { }

	[Address(RVA = "0xF2E000", Offset = "0xF2D200", Length = "0x421")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180F1B9C0")]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(SortedSet`1), Member = "ContainsAllElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB1")]
	public override bool IsSupersetOf(IEnumerable<T> other) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B98")]
	internal override bool IsWithinRange(T item) { }

	[Address(RVA = "0xF2E430", Offset = "0xF2D630", Length = "0xD")]
	[CalledBy(Type = typeof(TreeSubSet), Member = "InOrderTreeWalk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.TreeWalkPredicate`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBF")]
	private static int Log2(int value) { }

	[Address(RVA = "0xF2E870", Offset = "0xF2DA70", Length = "0x39A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBE")]
	protected override void OnDeserialization(object sender) { }

	[Address(RVA = "0xF2F1F0", Offset = "0xF2E3F0", Length = "0x602")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB4")]
	public override bool Overlaps(IEnumerable<T> other) { }

	[Address(RVA = "0xF2F8E0", Offset = "0xF2EAE0", Length = "0x29")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IDictionary.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeSubSet), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TreeSubSet), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9C")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xF2F910", Offset = "0xF2EB10", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA7")]
	private void ReplaceChildOrRoot(Node<T> parent, Node<T> child, Node<T> newChild) { }

	[Address(RVA = "0xF2FBC0", Offset = "0xF2EDC0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA8")]
	private void ReplaceNode(Node<T> match, Node<T> parentOfMatch, Node<T> successor, Node<T> parentOfSuccessor) { }

	[Address(RVA = "0xF2FCF0", Offset = "0xF2EEF0", Length = "0x449")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SortedSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB3")]
	public override bool SetEquals(IEnumerable<T> other) { }

	[Address(RVA = "0xF27F60", Offset = "0xF27160", Length = "0x29")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9A")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B95")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xF306E0", Offset = "0xF2F8E0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA4")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xF30C50", Offset = "0xF2FE50", Length = "0x45E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F59A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA2")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xF310B0", Offset = "0xF302B0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B96")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF306E0", Offset = "0xF2F8E0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF31190", Offset = "0xF30390", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBD")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0xF311B0", Offset = "0xF303B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF311E0", Offset = "0xF303E0", Length = "0x4")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAC")]
	internal void UpdateVersion() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B97")]
	internal override void VersionCheck() { }

}

