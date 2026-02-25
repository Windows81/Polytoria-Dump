namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20001BC")]
public class SortedDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x20001C7")]
	private sealed class <>c__DisplayClass34_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D5")]
		public bool found; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D6")]
		public TValue value; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B24")]
		public <>c__DisplayClass34_0() { }

		[Address(RVA = "0x7FF5A0", Offset = "0x7FE7A0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B25")]
		internal bool <ContainsValue>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001C8")]
	private sealed class <>c__DisplayClass34_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D7")]
		public EqualityComparer<TValue> valueComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D8")]
		public <>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B26")]
		public <>c__DisplayClass34_1() { }

		[Address(RVA = "0x7FF770", Offset = "0x7FE970", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B27")]
		internal bool <ContainsValue>b__1(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	[Token(Token = "0x20001BD")]
	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C6")]
		private Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C7")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x17000214")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0xB34C50", Offset = "0xB33E50", Length = "0xA2")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AEE")]
			 get { } //Length: 162
		}

		[Token(Token = "0x17000215")]
		internal bool NotStartedOrEnded
		{
			[Address(RVA = "0xB34EA0", Offset = "0xB340A0", Length = "0x84")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AEF")]
			internal get { } //Length: 132
		}

		[Token(Token = "0x17000219")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0xB312C0", Offset = "0xB304C0", Length = "0x191")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AF5")]
			private get { } //Length: 401
		}

		[Token(Token = "0x17000217")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0xB31460", Offset = "0xB30660", Length = "0xD4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AF3")]
			private get { } //Length: 212
		}

		[Token(Token = "0x17000218")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0xB31540", Offset = "0xB30740", Length = "0x10F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AF4")]
			private get { } //Length: 271
		}

		[Token(Token = "0x17000216")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB329F0", Offset = "0xB31BF0", Length = "0x2BC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
			[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AF2")]
			private get { } //Length: 700
		}

		[Address(RVA = "0xB34A70", Offset = "0xB33C70", Length = "0x8E")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(SortedSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEB")]
		internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[Address(RVA = "0xB2E410", Offset = "0xB2D610", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AED")]
		public override void Dispose() { }

		[Address(RVA = "0xB34C50", Offset = "0xB33E50", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEE")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0xB34EA0", Offset = "0xB340A0", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEF")]
		internal bool get_NotStartedOrEnded() { }

		[Address(RVA = "0xB2FB60", Offset = "0xB2ED60", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEC")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB30870", Offset = "0xB2FA70", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF0")]
		internal void Reset() { }

		[Address(RVA = "0xB312C0", Offset = "0xB304C0", Length = "0x191")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF5")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0xB31460", Offset = "0xB30660", Length = "0xD4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF3")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0xB31540", Offset = "0xB30740", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF4")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0xB329F0", Offset = "0xB31BF0", Length = "0x2BC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0B10")]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB30870", Offset = "0xB2FA70", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF1")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[Token(Token = "0x20001BE")]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[CompilerGenerated]
		[Token(Token = "0x20001C0")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006CA")]
			public TKey[] array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006CB")]
			public int index; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B08")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x800AC0", Offset = "0x7FFCC0", Length = "0x50")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B09")]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001C1")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006CC")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006CD")]
			public Object[] objects; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B0A")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0x801430", Offset = "0x800630", Length = "0x90")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B0B")]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[Token(Token = "0x20001BF")]
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006C9")]
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			[Token(Token = "0x1700021D")]
			public override TKey Current
			{
				[Address(RVA = "0xB34DD0", Offset = "0xB33FD0", Length = "0xCB")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
				[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
				[DeduplicatedMethod]
				[Token(Token = "0x6000B05")]
				 get { } //Length: 203
			}

			[Token(Token = "0x1700021E")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xB32940", Offset = "0xB31B40", Length = "0xAA")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0C90")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
				[DeduplicatedMethod]
				[Token(Token = "0x6000B06")]
				private get { } //Length: 170
			}

			[Address(RVA = "0xB34B00", Offset = "0xB33D00", Length = "0x75")]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B02")]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0xB2E360", Offset = "0xB2D560", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0960")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B03")]
			public override void Dispose() { }

			[Address(RVA = "0xB34DD0", Offset = "0xB33FD0", Length = "0xCB")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B05")]
			public override TKey get_Current() { }

			[Address(RVA = "0xB2F6F0", Offset = "0xB2E8F0", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A09F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B04")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB32940", Offset = "0xB31B40", Length = "0xAA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0C90")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B06")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0xB31990", Offset = "0xB30B90", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0A80")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B07")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C8")]
		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x1700021A")]
		public override int Count
		{
			[Address(RVA = "0x865B40", Offset = "0x864D40", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AFB")]
			 get { } //Length: 45
		}

		[Token(Token = "0x1700021B")]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AFC")]
			private get { } //Length: 3
		}

		[Token(Token = "0x1700021C")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xCD64F0", Offset = "0xCD56F0", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B01")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x865AC0", Offset = "0x864CC0", Length = "0x7F")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF6")]
		public KeyCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x8575B0", Offset = "0x8567B0", Length = "0x254")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF9")]
		public override void CopyTo(TKey[] array, int index) { }

		[Address(RVA = "0x865B40", Offset = "0x864D40", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFB")]
		public override int get_Count() { }

		[Address(RVA = "0xCCA580", Offset = "0xCC9780", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFD")]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[Address(RVA = "0xCCA5D0", Offset = "0xCC97D0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFE")]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[Address(RVA = "0xCCA620", Offset = "0xCC9820", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFF")]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFC")]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[Address(RVA = "0xCCA580", Offset = "0xCC9780", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B00")]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[Address(RVA = "0x8587C0", Offset = "0x8579C0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF7")]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[Address(RVA = "0xCCAD10", Offset = "0xCC9F10", Length = "0x44C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFA")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0xCD64F0", Offset = "0xCD56F0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B01")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x8587C0", Offset = "0x8579C0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF8")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x20001C6")]
	public sealed class KeyValuePairComparer : Comparer<KeyValuePair`2<TKey, TValue>>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D4")]
		internal IComparer<TKey> keyComparer; //Field offset: 0x0

		[Address(RVA = "0xCDFAD0", Offset = "0xCDECD0", Length = "0x6B")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B22")]
		public KeyValuePairComparer(IComparer<TKey> keyComparer) { }

		[Address(RVA = "0xCDF840", Offset = "0xCDEA40", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B23")]
		public virtual int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[Token(Token = "0x20001C2")]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[CompilerGenerated]
		[Token(Token = "0x20001C4")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D0")]
			public TValue[] array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D1")]
			public int index; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1E")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x800B20", Offset = "0x7FFD20", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1F")]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001C5")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D2")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D3")]
			public Object[] objects; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B20")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0x801380", Offset = "0x800580", Length = "0xAC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B21")]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[Token(Token = "0x20001C3")]
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006CF")]
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			[Token(Token = "0x17000222")]
			public override TValue Current
			{
				[Address(RVA = "0xB34D00", Offset = "0xB33F00", Length = "0xCB")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
				[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
				[DeduplicatedMethod]
				[Token(Token = "0x6000B1B")]
				 get { } //Length: 203
			}

			[Token(Token = "0x17000223")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xB33590", Offset = "0xB32790", Length = "0xDA")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0BC0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
				[DeduplicatedMethod]
				[Token(Token = "0x6000B1C")]
				private get { } //Length: 218
			}

			[Address(RVA = "0xB34B00", Offset = "0xB33D00", Length = "0x75")]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B18")]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0xB2E360", Offset = "0xB2D560", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0960")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B19")]
			public override void Dispose() { }

			[Address(RVA = "0xB34D00", Offset = "0xB33F00", Length = "0xCB")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1B")]
			public override TValue get_Current() { }

			[Address(RVA = "0xB2F6F0", Offset = "0xB2E8F0", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A09F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1A")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB33590", Offset = "0xB32790", Length = "0xDA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0D60")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0BC0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1C")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0xB31990", Offset = "0xB30B90", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800A0A80")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B1D")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CE")]
		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x1700021F")]
		public override int Count
		{
			[Address(RVA = "0x865B40", Offset = "0x864D40", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B11")]
			 get { } //Length: 45
		}

		[Token(Token = "0x17000220")]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B12")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000221")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x864EE0", Offset = "0x8640E0", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B17")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x865AC0", Offset = "0x864CC0", Length = "0x7F")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0C")]
		public ValueCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x8575B0", Offset = "0x8567B0", Length = "0x254")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0F")]
		public override void CopyTo(TValue[] array, int index) { }

		[Address(RVA = "0x865B40", Offset = "0x864D40", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B11")]
		public override int get_Count() { }

		[Address(RVA = "0x857A00", Offset = "0x856C00", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B13")]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[Address(RVA = "0x857A50", Offset = "0x856C50", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B14")]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[Address(RVA = "0x858240", Offset = "0x857440", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "ContainsValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B15")]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B12")]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[Address(RVA = "0x857A00", Offset = "0x856C00", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B16")]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[Address(RVA = "0x8587C0", Offset = "0x8579C0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0D")]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[Address(RVA = "0x858DC0", Offset = "0x857FC0", Length = "0x44C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B10")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x864EE0", Offset = "0x8640E0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B17")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x8587C0", Offset = "0x8579C0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C3")]
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C4")]
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C5")]
	private TreeSet<KeyValuePair`2<TKey, TValue>> _set; //Field offset: 0x0

	[Token(Token = "0x1700020B")]
	public override int Count
	{
		[Address(RVA = "0xF1A850", Offset = "0xF19A50", Length = "0x2D")]
		[CalledBy(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(SortedSet`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD2")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700020A")]
	public override TValue Item
	{
		[Address(RVA = "0xF1A8C0", Offset = "0xF19AC0", Length = "0x135")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD0")]
		 get { } //Length: 309
		[Address(RVA = "0xF1B190", Offset = "0xF1A390", Length = "0x1B0")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SortedSet`1), Member = "UpdateVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD1")]
		 set { } //Length: 432
	}

	[Token(Token = "0x1700020C")]
	public KeyCollection<TKey, TValue> Keys
	{
		[Address(RVA = "0xF1AF10", Offset = "0xF1A110", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD3")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000209")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACF")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700020D")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF187F0", Offset = "0xF179F0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5860")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD4")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000210")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF18830", Offset = "0xF17A30", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5900")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD7")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700020E")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF187F0", Offset = "0xF179F0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5860")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD5")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000211")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF18830", Offset = "0xF17A30", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5900")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD8")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000213")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF18AC0", Offset = "0xF17CC0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE9")]
		private get { } //Length: 73
	}

	[Token(Token = "0x17000212")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0xF197D0", Offset = "0xF189D0", Length = "0x1A8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE3")]
		private get { } //Length: 424
		[Address(RVA = "0xF19DA0", Offset = "0xF18FA0", Length = "0x2BA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(SortedDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE4")]
		private set { } //Length: 698
	}

	[Token(Token = "0x1700020F")]
	public ValueCollection<TKey, TValue> Values
	{
		[Address(RVA = "0xF1B0F0", Offset = "0xF1A2F0", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD6")]
		 get { } //Length: 154
	}

	[Address(RVA = "0xF1A590", Offset = "0xF19790", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyValuePairComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACA")]
	public SortedDictionary`2() { }

	[Address(RVA = "0xF1A670", Offset = "0xF19870", Length = "0xD2")]
	[CalledBy(Type = typeof(HttpEncoder), Member = "InitEntities", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyValuePairComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACB")]
	public SortedDictionary`2(IComparer<TKey> comparer) { }

	[Address(RVA = "0xF16D60", Offset = "0xF15F60", Length = "0xB3")]
	[CalledBy(Type = typeof(HttpEncoder), Member = "InitEntities", ReturnType = typeof(void))]
	[CallerCount(Count = 252)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD9")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0xF17100", Offset = "0xF16300", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADA")]
	public override void Clear() { }

	[Address(RVA = "0xF17440", Offset = "0xF16640", Length = "0xB5")]
	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.Generic.ICollection<TKey>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADB")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0xF17870", Offset = "0xF16A70", Length = "0x19C")]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.Generic.ICollection<TValue>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADC")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0xF17A40", Offset = "0xF16C40", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADD")]
	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0xF1A850", Offset = "0xF19A50", Length = "0x2D")]
	[CalledBy(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SortedSet`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD2")]
	public override int get_Count() { }

	[Address(RVA = "0xF1A8C0", Offset = "0xF19AC0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD0")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0xF1AF10", Offset = "0xF1A110", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD3")]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[Address(RVA = "0xF1B0F0", Offset = "0xF1A2F0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD6")]
	public ValueCollection<TKey, TValue> get_Values() { }

	[Address(RVA = "0xF17AB0", Offset = "0xF16CB0", Length = "0x3D")]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADE")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0xF17AF0", Offset = "0xF16CF0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE6")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0xF17BA0", Offset = "0xF16DA0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE0")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0xF1B190", Offset = "0xF1A390", Length = "0x1B0")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SortedSet`1), Member = "UpdateVersion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD1")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xF17F80", Offset = "0xF17180", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACC")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF18060", Offset = "0xF17260", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACD")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACF")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0xF18440", Offset = "0xF17640", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(SortedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACE")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF187F0", Offset = "0xF179F0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5860")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD4")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF18830", Offset = "0xF17A30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5900")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD7")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF18870", Offset = "0xF17A70", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADF")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xF187F0", Offset = "0xF179F0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5860")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD5")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF18830", Offset = "0xF17A30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5900")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD8")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF18990", Offset = "0xF17B90", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE2")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xF18AC0", Offset = "0xF17CC0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE9")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF18F30", Offset = "0xF18130", Length = "0x30F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE5")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0xF197D0", Offset = "0xF189D0", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE3")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0xF192D0", Offset = "0xF184D0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE7")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0xF19480", Offset = "0xF18680", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE8")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0xF19DA0", Offset = "0xF18FA0", Length = "0x2BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(SortedDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE4")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0xF18870", Offset = "0xF17A70", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEA")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF1A060", Offset = "0xF19260", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE1")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

