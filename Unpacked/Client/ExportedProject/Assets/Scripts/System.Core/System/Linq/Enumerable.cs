namespace System.Linq;

[Extension]
[Token(Token = "0x2000018")]
public static class Enumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		public Func<TSource, Boolean> predicate1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000029")]
		public Func<TSource, Boolean> predicate2; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		public <>c__DisplayClass6_0`1() { }

		[Address(RVA = "0x800F40", Offset = "0x800140", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		internal bool <CombinePredicates>b__0(TSource x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002A")]
		public Func<TMiddle, TResult> selector2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002B")]
		public Func<TSource, TMiddle> selector1; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		public <>c__DisplayClass7_0`3() { }

		[Address(RVA = "0x8015E0", Offset = "0x8007E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B9")]
		internal TResult <CombineSelectors>b__0(TSource x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private sealed class <CastIterator>d__99 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000057")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000058")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		private IEnumerable source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		public IEnumerable <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x17000019")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000EC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000EE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E8")]
		public <CastIterator>d__99`1(int <>1__state) { }

		[Address(RVA = "0x7F4A00", Offset = "0x7F3C00", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EB")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x7F41F0", Offset = "0x7F33F0", Length = "0x258")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030E00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F3140")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EA")]
		private override bool MoveNext() { }

		[Address(RVA = "0x7F4450", Offset = "0x7F3650", Length = "0xA8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EF")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EC")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x7F4730", Offset = "0x7F3930", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F0")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000ED")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x7F48C0", Offset = "0x7F3AC0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F2F10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E9")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <DistinctIterator>d__68 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		private Set<TSource> <set>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x17000013")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000014")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CD")]
		public <DistinctIterator>d__68`1(int <>1__state) { }

		[Address(RVA = "0x7F6190", Offset = "0x7F5390", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D0")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x7F5810", Offset = "0x7F4A10", Length = "0x2D6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Set`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TElement>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Set`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F3110")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x7F5AF0", Offset = "0x7F4CF0", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D4")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D1")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x7F5E80", Offset = "0x7F5080", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D5")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x7F6000", Offset = "0x7F5200", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F3290")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <ExceptIterator>d__77 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		private IEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		public IEnumerable<TSource> <>3__second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		private IEnumerable<TSource> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		public IEnumerable<TSource> <>3__first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		private Set<TSource> <set>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x17000015")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000DA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000016")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000DC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D6")]
		public <ExceptIterator>d__77`1(int <>1__state) { }

		[Address(RVA = "0x80EEE0", Offset = "0x80E0E0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D9")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x80D8D0", Offset = "0x80CAD0", Length = "0x5E3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Set`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TElement>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(Set`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BE10")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x80EBA0", Offset = "0x80DDA0", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DD")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DA")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x80EC70", Offset = "0x80DE70", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DE")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x80ED50", Offset = "0x80DF50", Length = "0x9B")]
		[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BC30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <OfTypeIterator>d__97 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000054")]
		private IEnumerable source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000055")]
		public IEnumerable <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000056")]
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x17000017")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000E3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000018")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000E5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DF")]
		public <OfTypeIterator>d__97`1(int <>1__state) { }

		[Address(RVA = "0x8138F0", Offset = "0x812AF0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E2")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x813510", Offset = "0x812710", Length = "0x296")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180032940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BD20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x7F4450", Offset = "0x7F3650", Length = "0xA8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E6")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E3")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x7F4730", Offset = "0x7F3930", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E7")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x8137B0", Offset = "0x8129B0", Length = "0x62")]
		[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BD50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <RangeIterator>d__115 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400005E")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005F")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000060")]
		private int start; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000061")]
		public int <>3__start; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000062")]
		private int count; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000063")]
		public int <>3__count; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000064")]
		private int <i>5__2; //Field offset: 0x2C

		[Token(Token = "0x1700001B")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000F4")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700001C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000F6")]
			private get { } //Length: 33
		}

		[Address(RVA = "0x158E220", Offset = "0x158D420", Length = "0x436")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(TryCatchFinallyHandler), Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F1")]
		public <RangeIterator>d__115(int <>1__state) { }

		[Address(RVA = "0x158E0D0", Offset = "0x158D2D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000F3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x158E110", Offset = "0x158D310", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F7")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F4")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x158E110", Offset = "0x158D310", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F8")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x158E1F0", Offset = "0x158D3F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x158E1B0", Offset = "0x158D3B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60000F5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <RepeatIterator>d__117 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		private TResult element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		public TResult <>3__element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		private int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		public int <>3__count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		private int <i>5__2; //Field offset: 0x0

		[Token(Token = "0x1700001D")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000FC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000FE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F9")]
		public <RepeatIterator>d__117`1(int <>1__state) { }

		[Address(RVA = "0x814B70", Offset = "0x813D70", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x8150D0", Offset = "0x8142D0", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FF")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x815250", Offset = "0x814450", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000100")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <SelectManyIterator>d__17 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		private Func<TSource, IEnumerable`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		public Func<TSource, IEnumerable`1<TResult>> <>3__selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private IEnumerator<TResult> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x1700000F")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000BF")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000010")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x818140", Offset = "0x817340", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C1")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x5D7FB0", Offset = "0x5D71B0", Length = "0x2E")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BA")]
		public <SelectManyIterator>d__17`2(int <>1__state) { }

		[Address(RVA = "0x818590", Offset = "0x817790", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BD")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x818770", Offset = "0x817970", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BE")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x8176B0", Offset = "0x8168B0", Length = "0x3E9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BE40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x817D60", Offset = "0x816F60", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BF")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x817EF0", Offset = "0x8170F0", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x818140", Offset = "0x817340", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x8182E0", Offset = "0x8174E0", Length = "0x163")]
		[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BC90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BBA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <SkipIterator>d__31 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		private int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		public int <>3__count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		private IEnumerator<TSource> <e>5__2; //Field offset: 0x0

		[Token(Token = "0x17000011")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000012")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C4")]
		public <SkipIterator>d__31`1(int <>1__state) { }

		[Address(RVA = "0x819D90", Offset = "0x818F90", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x819510", Offset = "0x818710", Length = "0x2CD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C6")]
		private override bool MoveNext() { }

		[Address(RVA = "0x8150D0", Offset = "0x8142D0", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CB")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x819A90", Offset = "0x818C90", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CC")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x819C00", Offset = "0x818E00", Length = "0x9B")]
		[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BE70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C5")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000019")]
	private abstract class Iterator : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000010")]
		private int threadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000011")]
		internal int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		internal TSource current; //Field offset: 0x0

		[Token(Token = "0x1700000D")]
		public override TSource Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600008C")]
			 get { } //Length: 11
		}

		[Token(Token = "0x1700000E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xCBF410", Offset = "0xCBE610", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000093")]
			private get { } //Length: 43
		}

		[Address(RVA = "0xCBF5C0", Offset = "0xCBE7C0", Length = "0x34")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectListIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectListIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource[]", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource[]", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectListIterator`2", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		public Iterator`1() { }

		[Token(Token = "0x600008D")]
		public abstract Iterator<TSource> Clone() { }

		[Address(RVA = "0xCBF0F0", Offset = "0xCBE2F0", Length = "0xF")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008E")]
		public override void Dispose() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		public override TSource get_Current() { }

		[Address(RVA = "0xCBF1E0", Offset = "0xCBE3E0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		public override IEnumerator<TSource> GetEnumerator() { }

		[Token(Token = "0x6000090")]
		public abstract bool MoveNext() { }

		[Token(Token = "0x6000091")]
		public abstract IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0xCBF370", Offset = "0xCBE570", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000094")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xCBF410", Offset = "0xCBE610", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000093")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000095")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Token(Token = "0x6000092")]
		public abstract IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001B")]
	private class WhereArrayIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000016")]
		private TSource[] source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000018")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x9316E0", Offset = "0x9308E0", Length = "0x5A")]
		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009C")]
		public WhereArrayIterator`1(TSource[] source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x930F20", Offset = "0x930120", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x9313B0", Offset = "0x9305B0", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61EC00", Offset = "0x61DE00", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x931620", Offset = "0x930820", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001A")]
	private class WhereEnumerableIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000015")]
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x9316E0", Offset = "0x9308E0", Length = "0x5A")]
		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000096")]
		public WhereEnumerableIterator`1(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x930F20", Offset = "0x930120", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x931B90", Offset = "0x930D90", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = "Dispose", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		public virtual void Dispose() { }

		[Address(RVA = "0x9321A0", Offset = "0x9313A0", Length = "0x1D7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61EC00", Offset = "0x61DE00", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x932BD0", Offset = "0x931DD0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001C")]
	private class WhereListIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		private List<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001B")]
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x9316E0", Offset = "0x9308E0", Length = "0x5A")]
		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		public WhereListIterator`1(List<TSource> source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x930F20", Offset = "0x930120", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A2")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x933390", Offset = "0x932590", Length = "0x11D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A3")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61EC00", Offset = "0x61DE00", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x9334B0", Offset = "0x9326B0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001E")]
	private class WhereSelectArrayIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		private TSource[] source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000021")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x934BF0", Offset = "0x933DF0", Length = "0x7C")]
		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AC")]
		public WhereSelectArrayIterator`2(TSource[] source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x933710", Offset = "0x932910", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AD")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x933B70", Offset = "0x932D70", Length = "0xDD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AE")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61ED40", Offset = "0x61DF40", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AF")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x934A10", Offset = "0x933C10", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B0")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	[Token(Token = "0x200001D")]
	private class WhereSelectEnumerableIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001C")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001D")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x934BF0", Offset = "0x933DF0", Length = "0x7C")]
		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A6")]
		public WhereSelectEnumerableIterator`2(IEnumerable<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x933710", Offset = "0x932910", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A7")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x9353A0", Offset = "0x9345A0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1<Char>", Member = "Dispose", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		public virtual void Dispose() { }

		[Address(RVA = "0x935E40", Offset = "0x935040", Length = "0x1ED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61ED40", Offset = "0x61DF40", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x937FB0", Offset = "0x9371B0", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AB")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	[Token(Token = "0x200001F")]
	private class WhereSelectListIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		private List<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x934BF0", Offset = "0x933DF0", Length = "0x7C")]
		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		public WhereSelectListIterator`2(List<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x933710", Offset = "0x932910", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x938300", Offset = "0x937500", Length = "0x126")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x61ED40", Offset = "0x61DF40", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x9398A0", Offset = "0x938AA0", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}


	[Address(RVA = "0x69F270", Offset = "0x69E470", Length = "0x1D1")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumeration", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UxmlTypeRestriction"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler+<>c", Member = "<CompileSwitchExpression>b__56_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchCase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600007F")]
	public static bool All(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x69F450", Offset = "0x69E650", Length = "0x237")]
	[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<LoadImage>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600007E")]
	public static bool Any(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x69F950", Offset = "0x69EB50", Length = "0x13F")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", "System.Func`2<String, String>"}, ReturnType = "UnityEngine.EnumData")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.MethodMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.GenericMethodMemberDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Serialization.SerializationExtensions", Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.ListViewDragger", Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = "UnityEngine.UIElements.StartDragArgs")]
	[CalledBy(Type = "UnityEngine.UIElements.ListViewDragger", Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Serialization.SerializationExtensions", Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table", typeof(bool), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600007D")]
	public static bool Any(IEnumerable<TSource> source) { }

	[Address(RVA = "0x69FE50", Offset = "0x69F050", Length = "0xEF")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "PasteFromClipboard", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.Statements.ForEachLoopStatement", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Execution.ScriptLoadingContext", "MoonSharp.Interpreter.Tree.Token", "MoonSharp.Interpreter.Tree.Token"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetMemberAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TType", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<TType, TValue>>"}, ReturnType = "System.Attribute[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600006E")]
	public static IEnumerable<TResult> Cast(IEnumerable source) { }

	[Address(RVA = "0x69FD30", Offset = "0x69EF30", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<CastIterator>d__99`1))]
	[Token(Token = "0x600006F")]
	private static IEnumerable<TResult> CastIterator(IEnumerable source) { }

	[Address(RVA = "0x6A02C0", Offset = "0x69F4C0", Length = "0xDC")]
	[CalledBy(Type = typeof(WhereEnumerableIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(WhereArrayIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(WhereListIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	private static Func<TSource, Boolean> CombinePredicates(Func<TSource, Boolean> predicate1, Func<TSource, Boolean> predicate2) { }

	[Address(RVA = "0x6A0720", Offset = "0x69F920", Length = "0xDC")]
	[CalledBy(Type = typeof(WhereSelectEnumerableIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CalledBy(Type = typeof(WhereSelectArrayIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CalledBy(Type = typeof(WhereSelectListIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	private static Func<TSource, TResult> CombineSelectors(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }

	[Address(RVA = "0x6A14D0", Offset = "0x6A06D0", Length = "0x344")]
	[CalledBy(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000083")]
	public static bool Contains(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x6A1820", Offset = "0x6A0A20", Length = "0x10A")]
	[CalledBy(Type = "UnityEngine.UIElements.CollectionViewController", Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListViewDragger", Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = "UnityEngine.UIElements.StartDragArgs")]
	[CalledBy(Type = "UnityEngine.UIElements.ListViewDragger", Member = "GetPreviousAndNextItemsIgnoringDraggedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000082")]
	public static bool Contains(IEnumerable<TSource> source, TSource value) { }

	[Address(RVA = "0x6A2140", Offset = "0x6A1340", Length = "0x26E")]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "get_numPlayers", ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "CheckReadyToBegin", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "ReadyStatusChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000081")]
	public static int Count(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x6A1C50", Offset = "0x6A0E50", Length = "0x1F2")]
	[CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "EnsureValidState", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "GetFirstActiveToggle", ReturnType = "UnityEngine.UI.Toggle")]
	[CalledBy(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", "System.Func`2<String, String>"}, ReturnType = "UnityEngine.EnumData")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.ExtensionMethodsRegistry", Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "MoonSharp.Interpreter.InteropAccessMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader", Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ContextualMenuPopulateEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumeration", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UxmlTypeRestriction"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader", Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000080")]
	public static int Count(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6A25F0", Offset = "0x6A17F0", Length = "0xDE")]
	[CalledBy(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", "System.Func`2<String, String>"}, ReturnType = "UnityEngine.EnumData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000062")]
	public static IEnumerable<TSource> Distinct(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6A24D0", Offset = "0x6A16D0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<DistinctIterator>d__68`1))]
	[Token(Token = "0x6000063")]
	private static IEnumerable<TSource> DistinctIterator(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x6A3070", Offset = "0x6A2270", Length = "0x2D4")]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "SimpleJSON.JSONNode")]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "SimpleJSON.JSONNode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000076")]
	public static TSource ElementAt(IEnumerable<TSource> source, int index) { }

	[Address(RVA = "0x6A2A80", Offset = "0x6A1C80", Length = "0x298")]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = "Battlehub.UIControls.ItemContainer")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "UnityEngine.RectTransform")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000077")]
	public static TSource ElementAtOrDefault(IEnumerable<TSource> source, int index) { }

	[Address(RVA = "0x371B60", Offset = "0x370D60", Length = "0x75")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public static IEnumerable<TResult> Empty() { }

	[Address(RVA = "0x6A38C0", Offset = "0x6A2AC0", Length = "0x126")]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000064")]
	public static IEnumerable<TSource> Except(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[Address(RVA = "0x6A3750", Offset = "0x6A2950", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<ExceptIterator>d__77`1))]
	[Token(Token = "0x6000065")]
	private static IEnumerable<TSource> ExceptIterator(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x6A4F40", Offset = "0x6A4140", Length = "0x1BB")]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800026B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Error), Member = "NoMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000071")]
	public static TSource First(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x6A4D10", Offset = "0x6A3F10", Length = "0x22F")]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = "SimpleJSON.JSONNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B110")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800026B0")]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000070")]
	public static TSource First(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6A40D0", Offset = "0x6A32D0", Length = "0x279")]
	[CalledBy(Type = "namudev.PropertyGrid", Member = "AppendProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000073")]
	public static TSource FirstOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x6A4350", Offset = "0x6A3550", Length = "0x224")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeBindingsUpdater", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoFootstep", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "PasteFromClipboard", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "Battlehub.UIControls.ItemContainer")]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000072")]
	public static TSource FirstOrDefault(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6A5720", Offset = "0x6A4920", Length = "0x30F")]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "UnityEngine.EventSystems.IDropHandler.OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.Utils.Strong", Member = "MethodInfo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, Delegate>>"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "AddKerningPair", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Statements.GotoStatement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Statements.LabelStatement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "CurrentFunctionHasVarArgs", ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "MoonSharp.Interpreter.SymbolRef")]
	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "MoonSharp.Interpreter.SymbolRef")]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "PopFunction", ReturnType = "MoonSharp.Interpreter.Execution.RuntimeScopeFrame")]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "PopBlock", ReturnType = "MoonSharp.Interpreter.Execution.RuntimeScopeBlock")]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "PushBlock", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.BuildTimeScope", Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "MoonSharp.Interpreter.SymbolRef")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800026B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000074")]
	public static TSource Last(IEnumerable<TSource> source) { }

	[Address(RVA = "0x1574880", Offset = "0x1573A80", Length = "0x240")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "get_maxIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyboardNavigationOperation", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600008A")]
	public static int Max(IEnumerable<Int32> source) { }

	[Address(RVA = "0x6A5A90", Offset = "0x6A4C90", Length = "0x53")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Instance>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000089")]
	public static int Min(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[Address(RVA = "0x1574AD0", Offset = "0x1573CD0", Length = "0x240")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "get_minIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyboardNavigationOperation", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerable), Member = "Min", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000088")]
	public static int Min(IEnumerable<Int32> source) { }

	[Address(RVA = "0x6A5B60", Offset = "0x6A4D60", Length = "0xC6")]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = "System.Attribute[]")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeView", Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Object[]", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeView", Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "set_SelectedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "set_SelectedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase", Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.Attribute[]")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "ResolveDefaultAccessModeForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.InteropAccessMode", typeof(Type)}, ReturnType = "MoonSharp.Interpreter.InteropAccessMode")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "MoonSharp.Interpreter.InteropAccessMode", typeof(string), "MoonSharp.Interpreter.Interop.IUserDataDescriptor"}, ReturnType = "MoonSharp.Interpreter.Interop.IUserDataDescriptor")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor", Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardUserDataDescriptor", Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.StandardEnumUserDataDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.String[]", "System.Object[]", typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor", Member = "MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.PropertyTableAssigner", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetMetaNamesFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "System.Collections.Generic.List`1<String>")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetVisibilityFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600006C")]
	public static IEnumerable<TResult> OfType(IEnumerable source) { }

	[Address(RVA = "0x69FD30", Offset = "0x69EF30", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<OfTypeIterator>d__97`1))]
	[Token(Token = "0x600006D")]
	private static IEnumerable<TResult> OfTypeIterator(IEnumerable source) { }

	[Address(RVA = "0x6A5DF0", Offset = "0x6A4FF0", Length = "0x8B")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600005F")]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x6A5E80", Offset = "0x6A5080", Length = "0x9A")]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Print", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Linq.OrderedEnumerable`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Object>), typeof(System.Collections.Generic.IComparer`1<System.Object>), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000060")]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1574DA0", Offset = "0x1573FA0", Length = "0xB8")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListViewController", Member = "ClearItems", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000078")]
	public static IEnumerable<Int32> Range(int start, int count) { }

	[Address(RVA = "0x1574D20", Offset = "0x1573F20", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<RangeIterator>d__115))]
	[Token(Token = "0x6000079")]
	private static IEnumerable<Int32> RangeIterator(int start, int count) { }

	[Address(RVA = "0x6A6210", Offset = "0x6A5410", Length = "0xD9")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "EditScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.BaseScript"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "TestGame", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "RandomString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	public static IEnumerable<TResult> Repeat(TResult element, int count) { }

	[Address(RVA = "0x6A6070", Offset = "0x6A5270", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<RepeatIterator>d__117`1))]
	[Token(Token = "0x600007B")]
	private static IEnumerable<TResult> RepeatIterator(TResult element, int count) { }

	[Address(RVA = "0x6A6850", Offset = "0x6A5A50", Length = "0x37D")]
	[CallerCount(Count = 66)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000058")]
	public static IEnumerable<TResult> Select(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }

	[Address(RVA = "0x6A6610", Offset = "0x6A5810", Length = "0x113")]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600005B")]
	public static IEnumerable<TResult> SelectMany(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[Address(RVA = "0x6A6410", Offset = "0x6A5610", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<SelectManyIterator>d__17`2))]
	[Token(Token = "0x600005C")]
	private static IEnumerable<TResult> SelectManyIterator(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[Address(RVA = "0x6A72E0", Offset = "0x6A64E0", Length = "0x4C")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.X509CertificateImplBtls"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000066")]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[Address(RVA = "0x6A7330", Offset = "0x6A6530", Length = "0x476")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B1D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000067")]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x6A97A0", Offset = "0x6A89A0", Length = "0x252")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetVisibilityFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "MoonSharp.Interpreter.InteropAccessMode", typeof(string), "MoonSharp.Interpreter.Interop.IUserDataDescriptor"}, ReturnType = "MoonSharp.Interpreter.Interop.IUserDataDescriptor")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "ResolveDefaultAccessModeForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.InteropAccessMode", typeof(Type)}, ReturnType = "MoonSharp.Interpreter.InteropAccessMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800026B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Error), Member = "MoreThanOneElement", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000075")]
	public static TSource SingleOrDefault(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6A9BA0", Offset = "0x6A8DA0", Length = "0xDA")]
	[CalledBy(Type = "MoonSharp.Interpreter.Coroutine", Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "MoonSharp.Interpreter.Debugging.SourceRef"}, ReturnType = "MoonSharp.Interpreter.Debugging.WatchItem[]")]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Request", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600005D")]
	public static IEnumerable<TSource> Skip(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x6A6070", Offset = "0x6A5270", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<SkipIterator>d__31`1))]
	[Token(Token = "0x600005E")]
	private static IEnumerable<TSource> SkipIterator(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x1575010", Offset = "0x1574210", Length = "0x24D")]
	[CalledBy(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int64>"}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000085")]
	public static long Sum(IEnumerable<Int64> source) { }

	[Address(RVA = "0x6A9DA0", Offset = "0x6A8FA0", Length = "0x53")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetTotalSendQueue", ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetTotalReceiveQueue", ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetTotalSendBuffer", ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetTotalReceiveBuffer", ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000086")]
	public static int Sum(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[Address(RVA = "0x6A9D40", Offset = "0x6A8F40", Length = "0x53")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetAverageMaxSendRate", ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetAverageMaxReceiveRate", ReturnType = typeof(long))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int64>)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000087")]
	public static long Sum(IEnumerable<TSource> source, Func<TSource, Int64> selector) { }

	[Address(RVA = "0x1574E60", Offset = "0x1574060", Length = "0x1A5")]
	[CalledBy(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Extension]
	[Token(Token = "0x6000084")]
	public static int Sum(IEnumerable<Int32> source) { }

	[Address(RVA = "0x6A9E00", Offset = "0x6A9000", Length = "0xF5")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "SortKerningPairs", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000061")]
	public static IOrderedEnumerable<TSource> ThenBy(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x6AA0B0", Offset = "0x6A92B0", Length = "0x8A")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "get_RegisteredTypes", ReturnType = "System.Collections.Generic.IEnumerable`1<KeyValuePair`2<Type, IUserDataDescriptor>>")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "get_RegisteredTypesHistory", ReturnType = "System.Collections.Generic.IEnumerable`1<KeyValuePair`2<Type, IUserDataDescriptor>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Buffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer`1), Member = "ToArray", ReturnType = "TElement[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000068")]
	public static TSource[] ToArray(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6AAA60", Offset = "0x6A9C60", Length = "0x62")]
	[CalledBy(Type = "Internal.Cryptography.OidLookup", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600006A")]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }

	[Address(RVA = "0x6AA750", Offset = "0x6A9950", Length = "0x307")]
	[CalledBy(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600006B")]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x6AADC0", Offset = "0x6A9FC0", Length = "0x94")]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000069")]
	public static List<TSource> ToList(IEnumerable<TSource> source) { }

	[Address(RVA = "0x6AB630", Offset = "0x6AA830", Length = "0x356")]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = "SimpleJSON.JSONNode")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "UpdateBundleSortList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<SerializedBundleRef>", "UnityEngine.Rendering.PostProcessing.PostProcessEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000057")]
	public static IEnumerable<TSource> Where(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

}

