namespace System.Linq;

[Token(Token = "0x200002E")]
internal abstract class OrderedEnumerable : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000078")]
		private TElement <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000079")]
		public OrderedEnumerable<TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007A")]
		private Buffer<TElement> <buffer>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		private Int32[] <map>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007C")]
		private int <i>5__4; //Field offset: 0x0

		[Token(Token = "0x1700001F")]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000110")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000020")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x810BF0", Offset = "0x80FDF0", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000112")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600010D")]
		public <GetEnumerator>d__1(int <>1__state) { }

		[Address(RVA = "0x80FA20", Offset = "0x80EC20", Length = "0x176")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Buffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(EnumerableSorter`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement[]", typeof(int)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600010F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000110")]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

		[Address(RVA = "0x810BF0", Offset = "0x80FDF0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000112")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000111")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600010E")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000076")]
	internal IEnumerable<TElement> source; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	protected OrderedEnumerable`1() { }

	[Token(Token = "0x6000109")]
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

	[Address(RVA = "0xE5D410", Offset = "0xE5C610", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
	[Token(Token = "0x6000108")]
	public override IEnumerator<TElement> GetEnumerator() { }

	[Address(RVA = "0xE5D7D0", Offset = "0xE5C9D0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x6052C0", Offset = "0x6044C0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010B")]
	private override IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

