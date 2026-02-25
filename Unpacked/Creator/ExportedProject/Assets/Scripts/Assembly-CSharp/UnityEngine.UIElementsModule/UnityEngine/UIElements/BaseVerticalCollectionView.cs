namespace UnityEngine.UIElements;

[Token(Token = "0x2000087")]
public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x200008A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000332")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000333")]
		public static Action <>9__179_1; //Field offset: 0x8

		[Address(RVA = "0x1BE4CC0", Offset = "0x1BE3EC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600056A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056B")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056C")]
		internal void <.ctor>b__179_1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <>c__DisplayClass182_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000334")]
		public int id; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056D")]
		public <>c__DisplayClass182_0() { }

		[Address(RVA = "0x1BE4A40", Offset = "0x1BE3C40", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600056E")]
		internal bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008C")]
	private struct <>c__DisplayClass193_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000335")]
		public bool selectedIndicesChanged; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000336")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000337")]
		public int previousSelectionCount; //Field offset: 0x10

	}

	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private struct <>c__DisplayClass204_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000338")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000339")]
		public bool shiftKey; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x200008E")]
	private sealed class <get_selectedItems>d__88 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400033B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400033C")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400033D")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400033E")]
		private Enumerator<Int32> <>s__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400033F")]
		private int <index>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000340")]
		private object <item>5__3; //Field offset: 0x50

		[Token(Token = "0x170000DA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000573")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000DB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000575")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600056F")]
		public <get_selectedItems>d__88(int <>1__state) { }

		[Address(RVA = "0x1BE5270", Offset = "0x1BE4470", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000572")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1BE4E80", Offset = "0x1BE4080", Length = "0x27D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BCDB90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000571")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1BE5100", Offset = "0x1BE4300", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000576")]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000573")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x1BE5100", Offset = "0x1BE4300", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000577")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000575")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1BE51A0", Offset = "0x1BE43A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000574")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1BE51E0", Offset = "0x1BE43E0", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent+<>c", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BCDBA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6000570")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000089")]
	private class Selection
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400032B")]
		private readonly HashSet<Int32> m_IndexLookup; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400032C")]
		private readonly HashSet<Int32> m_IdLookup; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400032D")]
		private int m_MinIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400032E")]
		private int m_MaxIndex; //Field offset: 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400032F")]
		private List<Int32> <selectedIds>k__BackingField; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000330")]
		public readonly List<Int32> indices; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000331")]
		public readonly Dictionary<Int32, Object> items; //Field offset: 0x38

		[Token(Token = "0x170000D9")]
		public int capacity
		{
			[Address(RVA = "0x1BE4810", Offset = "0x1BE3A10", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600055B")]
			 get { } //Length: 68
			[Address(RVA = "0x1BE4940", Offset = "0x1BE3B40", Length = "0x8E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600055C")]
			 set { } //Length: 142
		}

		[Token(Token = "0x170000D6")]
		public int idCount
		{
			[Address(RVA = "0x1BE4860", Offset = "0x1BE3A60", Length = "0x3C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000558")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000D5")]
		public int indexCount
		{
			[Address(RVA = "0x1BE48A0", Offset = "0x1BE3AA0", Length = "0x3C")]
			[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000557")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000D8")]
		public int maxIndex
		{
			[Address(RVA = "0x1BE48E0", Offset = "0x1BE3AE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
			[Token(Token = "0x600055A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000D7")]
		public int minIndex
		{
			[Address(RVA = "0x1BE4910", Offset = "0x1BE3B10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
			[Token(Token = "0x6000559")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000D4")]
		public List<Int32> selectedIds
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000555")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000556")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x1BE46D0", Offset = "0x1BE38D0", Length = "0x139")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000569")]
		public Selection() { }

		[Address(RVA = "0x1BE3F70", Offset = "0x1BE3170", Length = "0xB2")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000561")]
		public void AddId(int id) { }

		[Address(RVA = "0x1BE4030", Offset = "0x1BE3230", Length = "0xFE")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000562")]
		public void AddIndex(int index, object obj) { }

		[Address(RVA = "0x1BE4260", Offset = "0x1BE3460", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000568")]
		public void Clear() { }

		[Address(RVA = "0x1BE4130", Offset = "0x1BE3330", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000566")]
		public void ClearIds() { }

		[Address(RVA = "0x1BE41A0", Offset = "0x1BE33A0", Length = "0x6C")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000567")]
		public void ClearIndices() { }

		[Address(RVA = "0x1BE4210", Offset = "0x1BE3410", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000565")]
		public void ClearItems() { }

		[Address(RVA = "0x1BE4360", Offset = "0x1BE3560", Length = "0x51")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000560")]
		public bool ContainsId(int id) { }

		[Address(RVA = "0x1BE43C0", Offset = "0x1BE35C0", Length = "0x51")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600055F")]
		public bool ContainsIndex(int index) { }

		[Address(RVA = "0x1BE4420", Offset = "0x1BE3620", Length = "0x66")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_selectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600055D")]
		public int FirstIndex() { }

		[Address(RVA = "0x1BE4490", Offset = "0x1BE3690", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600055E")]
		public object FirstObject() { }

		[Address(RVA = "0x1BE4810", Offset = "0x1BE3A10", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600055B")]
		public int get_capacity() { }

		[Address(RVA = "0x1BE4860", Offset = "0x1BE3A60", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000558")]
		public int get_idCount() { }

		[Address(RVA = "0x1BE48A0", Offset = "0x1BE3AA0", Length = "0x3C")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000557")]
		public int get_indexCount() { }

		[Address(RVA = "0x1BE48E0", Offset = "0x1BE3AE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
		[Token(Token = "0x600055A")]
		public int get_maxIndex() { }

		[Address(RVA = "0x1BE4910", Offset = "0x1BE3B10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000559")]
		public int get_minIndex() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000555")]
		public List<Int32> get_selectedIds() { }

		[Address(RVA = "0x1BE4560", Offset = "0x1BE3760", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000564")]
		public void RemoveId(int id) { }

		[Address(RVA = "0x1BE4940", Offset = "0x1BE3B40", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600055C")]
		public void set_capacity(int value) { }

		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000556")]
		public void set_selectedIds(List<Int32> value) { }

		[Address(RVA = "0x1BE45E0", Offset = "0x1BE37E0", Length = "0xEE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000563")]
		public bool TryRemove(int index) { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000088")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000324")]
		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000325")]
		private readonly UxmlIntAttributeDescription m_FixedItemHeight; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000326")]
		private readonly UxmlBoolAttributeDescription m_ShowBorder; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000327")]
		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000328")]
		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000329")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400032A")]
		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; //Field offset: 0xC0

		[Address(RVA = "0x1BE8AC0", Offset = "0x1BE7CC0", Length = "0x41A")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000553")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE74F0", Offset = "0x1BE66F0", Length = "0x6C9")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "set_selectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_showBorder", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000554")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40002E7")]
	internal static readonly BindingId itemsSourceProperty; //Field offset: 0x0
	[Token(Token = "0x40002E8")]
	internal static readonly BindingId selectionTypeProperty; //Field offset: 0x98
	[Token(Token = "0x40002E9")]
	internal static readonly BindingId selectedItemProperty; //Field offset: 0x130
	[Token(Token = "0x40002EA")]
	internal static readonly BindingId selectedItemsProperty; //Field offset: 0x1C8
	[Token(Token = "0x40002EB")]
	internal static readonly BindingId selectedIndexProperty; //Field offset: 0x260
	[Token(Token = "0x40002EC")]
	internal static readonly BindingId selectedIndicesProperty; //Field offset: 0x2F8
	[Token(Token = "0x40002ED")]
	internal static readonly BindingId showBorderProperty; //Field offset: 0x390
	[Token(Token = "0x40002EE")]
	internal static readonly BindingId reorderableProperty; //Field offset: 0x428
	[Token(Token = "0x40002EF")]
	internal static readonly BindingId horizontalScrollingEnabledProperty; //Field offset: 0x4C0
	[Token(Token = "0x40002F0")]
	internal static readonly BindingId showAlternatingRowBackgroundsProperty; //Field offset: 0x558
	[Token(Token = "0x40002F1")]
	internal static readonly BindingId virtualizationMethodProperty; //Field offset: 0x5F0
	[Token(Token = "0x40002F2")]
	internal static readonly BindingId fixedItemHeightProperty; //Field offset: 0x688
	[Token(Token = "0x40002F3")]
	private static readonly ProfilerMarker k_RefreshMarker; //Field offset: 0x720
	[Token(Token = "0x40002F4")]
	private static readonly ProfilerMarker k_RebuildMarker; //Field offset: 0x728
	[Token(Token = "0x4000300")]
	private static readonly List<ReusableCollectionItem> k_EmptyItems; //Field offset: 0x730
	[Token(Token = "0x4000304")]
	internal static readonly string k_InvalidTemplateError; //Field offset: 0x738
	[Token(Token = "0x4000312")]
	internal static CustomStyleProperty<Int32> s_ItemHeightProperty; //Field offset: 0x740
	[Token(Token = "0x4000316")]
	public static readonly string ussClassName; //Field offset: 0x748
	[Token(Token = "0x4000317")]
	public static readonly string borderUssClassName; //Field offset: 0x750
	[Token(Token = "0x4000318")]
	public static readonly string itemUssClassName; //Field offset: 0x758
	[Token(Token = "0x4000319")]
	public static readonly string dragHoverBarUssClassName; //Field offset: 0x760
	[Token(Token = "0x400031A")]
	public static readonly string dragHoverMarkerUssClassName; //Field offset: 0x768
	[Token(Token = "0x400031B")]
	public static readonly string itemDragHoverUssClassName; //Field offset: 0x770
	[Token(Token = "0x400031C")]
	public static readonly string itemSelectedVariantUssClassName; //Field offset: 0x778
	[Token(Token = "0x400031D")]
	public static readonly string itemAlternativeBackgroundUssClassName; //Field offset: 0x780
	[Token(Token = "0x400031E")]
	public static readonly string listScrollViewUssClassName; //Field offset: 0x788
	[Token(Token = "0x400031F")]
	internal static readonly string backgroundFillUssClassName; //Field offset: 0x790
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40002F5")]
	private Action<IEnumerable`1<Object>> itemsChosen; //Field offset: 0x2E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40002F6")]
	private Action<IEnumerable`1<Object>> selectionChanged; //Field offset: 0x2E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40002F7")]
	private Action<IEnumerable`1<Int32>> selectedIndicesChanged; //Field offset: 0x2F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40002F8")]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x2F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40002F9")]
	private Action itemsSourceChanged; //Field offset: 0x300
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x40002FA")]
	private Action m_SelectionNotChanged; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x40002FB")]
	private Func<CanStartDragArgs, Boolean> canStartDrag; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x40002FC")]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x40002FD")]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x40002FE")]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x40002FF")]
	private SelectionType m_SelectionType; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000301")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool allowSingleClickChoice; //Field offset: 0x334
	[FieldOffset(Offset = "0x335")]
	[Token(Token = "0x4000302")]
	private bool m_HorizontalScrollingEnabled; //Field offset: 0x335
	[DontCreateProperty]
	[FieldOffset(Offset = "0x338")]
	[SerializeField]
	[Token(Token = "0x4000303")]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x4000305")]
	internal float m_FixedItemHeight; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000306")]
	internal bool m_ItemHeightIsInline; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x4000307")]
	private CollectionVirtualizationMethod m_VirtualizationMethod; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000308")]
	private readonly ScrollView m_ScrollView; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000309")]
	private CollectionViewController m_ViewController; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x400030A")]
	private CollectionVirtualizationController m_VirtualizationController; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x400030B")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x360
	[DontCreateProperty]
	[FieldOffset(Offset = "0x368")]
	[SerializeField]
	[Token(Token = "0x400030C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal SerializedVirtualizationData serializedVirtualizationData; //Field offset: 0x368
	[DontCreateProperty]
	[FieldOffset(Offset = "0x370")]
	[SerializeField]
	[Token(Token = "0x400030D")]
	private List<Int32> m_SelectedIds; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x400030E")]
	private readonly Selection m_Selection; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x400030F")]
	private float m_LastHeight; //Field offset: 0x380
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x4000310")]
	private bool m_IsRangeSelectionDirectionUp; //Field offset: 0x384
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000311")]
	private ListViewDragger m_Dragger; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000313")]
	private Action<Int32, Int32> m_ItemIndexChangedCallback; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000314")]
	private Action m_ItemsSourceChangedCallback; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000315")]
	private IVisualElementScheduledItem m_RebuildScheduled; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000320")]
	internal int m_PreviousRefreshedCount; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3AC")]
	[Token(Token = "0x4000321")]
	private Vector3 m_TouchDownPosition; //Field offset: 0x3AC
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000322")]
	private long m_LastPointerDownTimeStamp; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x4000323")]
	private int m_PointerDownCount; //Field offset: 0x3C0

	[Token(Token = "0x170000C7")]
	internal IEnumerable<ReusableCollectionItem> activeItems
	{
		[Address(RVA = "0x1BD67E0", Offset = "0x1BD59E0", Length = "0x7C")]
		[CalledBy(Type = typeof(ListViewDragger), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
		[CalledBy(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "ClearDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "GetRootElementForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelectionWithoutValidation", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000500")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x170000C0")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C9")]
	internal ListViewDragger dragger
	{
		[Address(RVA = "0x95D850", Offset = "0x95CA50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000502")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170000D1")]
	public float fixedItemHeight
	{
		[Address(RVA = "0x1BD6860", Offset = "0x1BD5A60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000510")]
		 get { } //Length: 9
		[Address(RVA = "0x1BD6CB0", Offset = "0x1BD5EB0", Length = "0x140")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000511")]
		 set { } //Length: 320
	}

	[CreateProperty]
	[Token(Token = "0x170000CE")]
	public bool horizontalScrollingEnabled
	{
		[Address(RVA = "0x1BD6870", Offset = "0x1BD5A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600050A")]
		 get { } //Length: 8
		[Address(RVA = "0x1BD6DF0", Offset = "0x1BD5FF0", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600050B")]
		 set { } //Length: 183
	}

	[Token(Token = "0x170000D3")]
	internal bool isRebuildScheduled
	{
		[Address(RVA = "0x1BD6880", Offset = "0x1BD5A80", Length = "0x4C")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6000513")]
		internal get { } //Length: 76
	}

	[CreateProperty]
	[Token(Token = "0x170000BF")]
	public IList itemsSource
	{
		[Address(RVA = "0x1BD68D0", Offset = "0x1BD5AD0", Length = "0x23")]
		[CalledBy(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "<get_trackCount>b__65_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnAddClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "GetPreviousAndNextItemsIgnoringDraggedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "IsIndexOutOfBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004F5")]
		 get { } //Length: 35
		[Address(RVA = "0x1BD6EB0", Offset = "0x1BD60B0", Length = "0x130")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60004F6")]
		 set { } //Length: 304
	}

	[Token(Token = "0x170000D2")]
	internal float lastHeight
	{
		[Address(RVA = "0x1BD6900", Offset = "0x1BD5B00", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000512")]
		internal get { } //Length: 9
	}

	[CreateProperty]
	[Token(Token = "0x170000CD")]
	public bool reorderable
	{
		[Address(RVA = "0x1BD6910", Offset = "0x1BD5B10", Length = "0x8D")]
		[CalledBy(Type = typeof(BaseReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
		[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListViewController), Member = "UpdateReorderClassList", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent+<>c", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6000508")]
		 get { } //Length: 141
		[Address(RVA = "0x1BD6FF0", Offset = "0x1BD61F0", Length = "0x101")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BCDC50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000509")]
		 set { } //Length: 257
	}

	[Token(Token = "0x170000C8")]
	internal ScrollView scrollView
	{
		[Address(RVA = "0x1BD69A0", Offset = "0x1BD5BA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000501")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000C6")]
	public IEnumerable<Int32> selectedIds
	{
		[Address(RVA = "0x1BD69B0", Offset = "0x1BD5BB0", Length = "0x1E")]
		[CalledBy(Type = typeof(ListViewDragger), Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004FF")]
		 get { } //Length: 30
	}

	[CreateProperty]
	[Token(Token = "0x170000C4")]
	public int selectedIndex
	{
		[Address(RVA = "0x1BD69D0", Offset = "0x1BD5BD0", Length = "0xBB")]
		[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004FC")]
		 get { } //Length: 187
		[Address(RVA = "0x1BD2E90", Offset = "0x1BD2090", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FD")]
		 set { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000C5")]
	public IEnumerable<Int32> selectedIndices
	{
		[Address(RVA = "0x1BD6A90", Offset = "0x1BD5C90", Length = "0x1E")]
		[CalledBy(Type = typeof(CollectionViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 30
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000C2")]
	public object selectedItem
	{
		[Address(RVA = "0x1BD6AB0", Offset = "0x1BD5CB0", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004FA")]
		 get { } //Length: 214
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000C3")]
	public IEnumerable<Object> selectedItems
	{
		[Address(RVA = "0x1BD6B90", Offset = "0x1BD5D90", Length = "0x71")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
		[Token(Token = "0x60004FB")]
		 get { } //Length: 113
	}

	[CreateProperty]
	[Token(Token = "0x170000C1")]
	public SelectionType selectionType
	{
		[Address(RVA = "0x1BD6C10", Offset = "0x1BD5E10", Length = "0x9")]
		[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
		[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60004F8")]
		 get { } //Length: 9
		[Address(RVA = "0x1BD7100", Offset = "0x1BD6300", Length = "0x105")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Selection), Member = "FirstIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004F9")]
		 set { } //Length: 261
	}

	[CreateProperty]
	[Token(Token = "0x170000CF")]
	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		[Address(RVA = "0x1BD6C20", Offset = "0x1BD5E20", Length = "0x9")]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x600050C")]
		 get { } //Length: 9
		[Address(RVA = "0x1BD7210", Offset = "0x1BD6410", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600050D")]
		 set { } //Length: 134
	}

	[CreateProperty]
	[Token(Token = "0x170000CC")]
	public bool showBorder
	{
		[Address(RVA = "0x1BD6C30", Offset = "0x1BD5E30", Length = "0x73")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_showBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000506")]
		 get { } //Length: 115
		[Address(RVA = "0x1BD72A0", Offset = "0x1BD64A0", Length = "0xEC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_showBorder", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000507")]
		 set { } //Length: 236
	}

	[Token(Token = "0x170000CB")]
	public CollectionViewController viewController
	{
		[Address(RVA = "0x826C70", Offset = "0x825E70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000504")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CA")]
	internal CollectionVirtualizationController virtualizationController
	{
		[Address(RVA = "0x1BD1200", Offset = "0x1BD0400", Length = "0x40")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000503")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 64
	}

	[CreateProperty]
	[Token(Token = "0x170000D0")]
	public CollectionVirtualizationMethod virtualizationMethod
	{
		[Address(RVA = "0x673950", Offset = "0x672B50", Length = "0xF2")]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600050E")]
		 get { } //Length: 242
		[Address(RVA = "0x1BD7390", Offset = "0x1BD6590", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600050F")]
		 set { } //Length: 156
	}

	[Address(RVA = "0x1BD4E10", Offset = "0x1BD4010", Length = "0xEE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054F")]
	private static BaseVerticalCollectionView() { }

	[Address(RVA = "0x1BD6630", Offset = "0x1BD5830", Length = "0x1AB")]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600051E")]
	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1) { }

	[Address(RVA = "0x1BD5D00", Offset = "0x1BD4F00", Length = "0x926")]
	[CalledBy(Type = typeof(BaseTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "set_selectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "UnregisterCallbacksFromTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_isCompositeRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "add_valueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600051D")]
	public BaseVerticalCollectionView() { }

	[Address(RVA = "0x1BD4D40", Offset = "0x1BD3F40", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[Token(Token = "0x6000550")]
	private void <.ctor>b__179_0(float v) { }

	[Address(RVA = "0x1BD4BB0", Offset = "0x1BD3DB0", Length = "0x103")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000552")]
	private void <Apply>g__HandleSelectionAndScroll|204_0(int index, ref <>c__DisplayClass204_0 unnamed_param_1) { }

	[Address(RVA = "0x1BD4CC0", Offset = "0x1BD3EC0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000551")]
	private void <RefreshSelection>g__NotifyIfChanged|193_0(ref <>c__DisplayClass193_0 unnamed_param_0) { }

	[Address(RVA = "0x1BCFD50", Offset = "0x1BCEF50", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600053B")]
	public void AddToSelection(int index) { }

	[Address(RVA = "0x1BCFDC0", Offset = "0x1BCEFC0", Length = "0x21B")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600053C")]
	internal void AddToSelection(IList<Int32> indexes) { }

	[Address(RVA = "0x1BCFA60", Offset = "0x1BCEC60", Length = "0x2E6")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Selection), Member = "AddId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selection), Member = "AddIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600053D")]
	private void AddToSelectionWithoutValidation(int index) { }

	[Address(RVA = "0x1BCFFE0", Offset = "0x1BCF1E0", Length = "0x4AC")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "<Apply>g__HandleSelectionAndScroll|204_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass204_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Selection), Member = "get_indexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x600052E")]
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	[Address(RVA = "0x1BD04C0", Offset = "0x1BCF6C0", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600052F")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x1BD0940", Offset = "0x1BCFB40", Length = "0x80")]
	[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_selectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnPointerCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCancelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelectionWithoutValidation", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000546")]
	public void ClearSelection() { }

	[Address(RVA = "0x1BD0680", Offset = "0x1BCF880", Length = "0x2B3")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000547")]
	private void ClearSelectionWithoutValidation() { }

	[Token(Token = "0x600051C")]
	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x1BD09D0", Offset = "0x1BCFBD0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListViewDragger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Token(Token = "0x600051A")]
	internal override ListViewDragger CreateDragger() { }

	[Token(Token = "0x6000518")]
	protected abstract CollectionViewController CreateViewController() { }

	[Address(RVA = "0x683350", Offset = "0x682550", Length = "0x153")]
	[CalledBy(Type = typeof(BaseListView), Member = "CreateVirtualizationController", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CreateVirtualizationController", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "CreateVirtualizationController", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "CreateVirtualizationController", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_virtualizationMethod", ReturnType = typeof(CollectionVirtualizationMethod))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedHeightVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000516")]
	internal void CreateVirtualizationController() { }

	[Address(RVA = "0x1BD0A30", Offset = "0x1BCFC30", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000514")]
	override void CreateVirtualizationController() { }

	[Address(RVA = "0x1BD0A70", Offset = "0x1BCFC70", Length = "0x1B9")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "<Apply>g__HandleSelectionAndScroll|204_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass204_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelectionWithoutValidation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000538")]
	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	[Address(RVA = "0x1BD0C30", Offset = "0x1BCFE30", Length = "0x56B")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Selection), Member = "ContainsId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selection), Member = "get_indexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selection), Member = "ContainsIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000537")]
	private void DoSelect(Vector2 localPosition, int mouseButton, int clickCount, bool actionKey, bool shiftKey) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", False)]
	[Token(Token = "0x600054A")]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x1BD67E0", Offset = "0x1BD59E0", Length = "0x7C")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelectionWithoutValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "GetRootElementForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[CalledBy(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[CalledBy(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "ClearDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000500")]
	internal IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F7")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x95D850", Offset = "0x95CA50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000502")]
	internal ListViewDragger get_dragger() { }

	[Address(RVA = "0x1BD6860", Offset = "0x1BD5A60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000510")]
	public float get_fixedItemHeight() { }

	[Address(RVA = "0x1BD6870", Offset = "0x1BD5A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600050A")]
	public bool get_horizontalScrollingEnabled() { }

	[Address(RVA = "0x1BD6880", Offset = "0x1BD5A80", Length = "0x4C")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6000513")]
	internal bool get_isRebuildScheduled() { }

	[Address(RVA = "0x1BD68D0", Offset = "0x1BD5AD0", Length = "0x23")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "IsIndexOutOfBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "<get_trackCount>b__65_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetPreviousAndNextItemsIgnoringDraggedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F5")]
	public IList get_itemsSource() { }

	[Address(RVA = "0x1BD6900", Offset = "0x1BD5B00", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000512")]
	internal float get_lastHeight() { }

	[Address(RVA = "0x1BD6910", Offset = "0x1BD5B10", Length = "0x8D")]
	[CalledBy(Type = "UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "UpdateReorderClassList", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000508")]
	public bool get_reorderable() { }

	[Address(RVA = "0x1BD69A0", Offset = "0x1BD5BA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000501")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ScrollView get_scrollView() { }

	[Address(RVA = "0x1BD69B0", Offset = "0x1BD5BB0", Length = "0x1E")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FF")]
	public IEnumerable<Int32> get_selectedIds() { }

	[Address(RVA = "0x1BD69D0", Offset = "0x1BD5BD0", Length = "0xBB")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FC")]
	public int get_selectedIndex() { }

	[Address(RVA = "0x1BD6A90", Offset = "0x1BD5C90", Length = "0x1E")]
	[CalledBy(Type = typeof(CollectionViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FE")]
	public IEnumerable<Int32> get_selectedIndices() { }

	[Address(RVA = "0x1BD6AB0", Offset = "0x1BD5CB0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FA")]
	public object get_selectedItem() { }

	[Address(RVA = "0x1BD6B90", Offset = "0x1BD5D90", Length = "0x71")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
	[Token(Token = "0x60004FB")]
	public IEnumerable<Object> get_selectedItems() { }

	[Address(RVA = "0x1BD6C10", Offset = "0x1BD5E10", Length = "0x9")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60004F8")]
	public SelectionType get_selectionType() { }

	[Address(RVA = "0x1BD6C20", Offset = "0x1BD5E20", Length = "0x9")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600050C")]
	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	[Address(RVA = "0x1BD6C30", Offset = "0x1BD5E30", Length = "0x73")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_showBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000506")]
	public bool get_showBorder() { }

	[Address(RVA = "0x826C70", Offset = "0x825E70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000504")]
	public CollectionViewController get_viewController() { }

	[Address(RVA = "0x1BD1200", Offset = "0x1BD0400", Length = "0x40")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000503")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CollectionVirtualizationController get_virtualizationController() { }

	[Address(RVA = "0x673950", Offset = "0x672B50", Length = "0xF2")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600050E")]
	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	[Address(RVA = "0x1BD11A0", Offset = "0x1BD03A0", Length = "0x5A")]
	[CalledBy(Type = typeof(BaseListView), Member = "AddItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000517")]
	internal CollectionViewController GetOrCreateViewController() { }

	[Address(RVA = "0x1BD1200", Offset = "0x1BD0400", Length = "0x40")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000515")]
	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	[Address(RVA = "0x1BD1240", Offset = "0x1BD0440", Length = "0xFC")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600051F")]
	public VisualElement GetRootElementForId(int id) { }

	[Address(RVA = "0x1BD1340", Offset = "0x1BD0540", Length = "0x373")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerUpEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(NavigationSubmitEvent)})]
	[Token(Token = "0x6000549")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000530")]
	override bool HandleItemNavigation(bool moveIn, bool altKey) { }

	[Address(RVA = "0x1BD16C0", Offset = "0x1BD08C0", Length = "0xC")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004F0")]
	internal bool HasCanStartDrag() { }

	[Address(RVA = "0x1BD16D0", Offset = "0x1BD08D0", Length = "0x3D")]
	[CalledBy(Type = typeof(ListView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TreeView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000520")]
	internal override bool HasValidDataAndBindings() { }

	[Address(RVA = "0x1BD1710", Offset = "0x1BD0910", Length = "0x121")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "UnregisterCallbacksFromTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600051B")]
	internal void InitializeDragAndDropController(bool enableReordering) { }

	[Address(RVA = "0x1BD1840", Offset = "0x1BD0A40", Length = "0x2C4")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BCDBF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000544")]
	private bool MatchesExistingSelection(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x1BD1B10", Offset = "0x1BD0D10", Length = "0x8D")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SelectAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "<RefreshSelection>g__NotifyIfChanged|193_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass193_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000545")]
	private void NotifyOfSelectionChange() { }

	[Address(RVA = "0x1BD1BA0", Offset = "0x1BD0DA0", Length = "0x33F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600052C")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x1BD1EE0", Offset = "0x1BD10E0", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600054C")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0x1BD2090", Offset = "0x1BD1290", Length = "0x2BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600052D")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1BD2350", Offset = "0x1BD1550", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000521")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	[Address(RVA = "0x1BD2390", Offset = "0x1BD1590", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000522")]
	private void OnItemsSourceChanged() { }

	[Address(RVA = "0x1BD24E0", Offset = "0x1BD16E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000533")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x1BD2550", Offset = "0x1BD1750", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000532")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x1BD2560", Offset = "0x1BD1760", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000531")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x1BD25E0", Offset = "0x1BD17E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000534")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1BD25F0", Offset = "0x1BD17F0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600052A")]
	private void OnScroll(Vector2 offset) { }

	[Address(RVA = "0x1BD2670", Offset = "0x1BD1870", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600054B")]
	private void OnSizeChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BD2710", Offset = "0x1BD1910", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000548")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1BD2760", Offset = "0x1BD1960", Length = "0xCE")]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000527")]
	override void PostRefresh() { }

	[Address(RVA = "0x1BD2830", Offset = "0x1BD1A30", Length = "0x28C")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000535")]
	private void ProcessPointerDown(IPointerEvent evt) { }

	[Address(RVA = "0x1BD2AC0", Offset = "0x1BD1CC0", Length = "0x3CC")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(Selection), Member = "get_indexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Selection), Member = "ContainsIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000536")]
	private void ProcessPointerUp(IPointerEvent evt) { }

	[Address(RVA = "0x1BD2E90", Offset = "0x1BD2090", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	private void ProcessSingleClick(int clickedIndex) { }

	[Address(RVA = "0x1BD2EA0", Offset = "0x1BD20A0", Length = "0x102")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanStartDragArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004F1")]
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<Int32> ids) { }

	[Address(RVA = "0x1BD2FB0", Offset = "0x1BD21B0", Length = "0x95")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandleDragAndDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F4")]
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	[Address(RVA = "0x1BD3050", Offset = "0x1BD2250", Length = "0x95")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetVisualMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DragPosition&)}, ReturnType = typeof(DragVisualMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HandleDragAndDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F3")]
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	[Address(RVA = "0x1BD30F0", Offset = "0x1BD22F0", Length = "0x143")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetupDragAndDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(StartDragArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004F2")]
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<Int32> ids, StartDragArgs args) { }

	[Address(RVA = "0x1BD3240", Offset = "0x1BD2440", Length = "0x18B")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListView), Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_virtualizationMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionVirtualizationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000524")]
	public void Rebuild() { }

	[Address(RVA = "0x1BD33D0", Offset = "0x1BD25D0", Length = "0x1B8")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000523")]
	public void RefreshItems() { }

	[Address(RVA = "0x1BD3590", Offset = "0x1BD2790", Length = "0x676")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selection), Member = "AddIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(Selection), Member = "ContainsIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selection), Member = "ClearIndices", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000526")]
	private void RefreshSelection() { }

	[Address(RVA = "0x1BD3F80", Offset = "0x1BD3180", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600053E")]
	public void RemoveFromSelection(int index) { }

	[Address(RVA = "0x1BD3C10", Offset = "0x1BD2E10", Length = "0x362")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RemoveFromSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600053F")]
	private void RemoveFromSelectionWithoutValidation(int index) { }

	[Address(RVA = "0x1BD3FE0", Offset = "0x1BD31E0", Length = "0xB7")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600052B")]
	private void Resize(Vector2 size) { }

	[Address(RVA = "0x1BD40A0", Offset = "0x1BD32A0", Length = "0x15")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RegisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "get_resolvedItemHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetExpectedItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetExpectedContentHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6000505")]
	internal float ResolveItemHeight(float height = -1) { }

	[Address(RVA = "0x1BD40C0", Offset = "0x1BD32C0", Length = "0x11E")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnsDataType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000525")]
	internal void ScheduleRebuild() { }

	[Address(RVA = "0x1BD4280", Offset = "0x1BD3480", Length = "0x77")]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "<Apply>g__HandleSelectionAndScroll|204_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass204_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000528")]
	public void ScrollToItem(int index) { }

	[Address(RVA = "0x1BD41E0", Offset = "0x1BD33E0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000529")]
	public void ScrollToItemById(int id) { }

	[Address(RVA = "0x1BD4300", Offset = "0x1BD3500", Length = "0x2EF")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(Selection), Member = "ContainsId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selection), Member = "AddId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selection), Member = "AddIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600053A")]
	internal void SelectAll() { }

	[Address(RVA = "0x1BD6CB0", Offset = "0x1BD5EB0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000511")]
	public void set_fixedItemHeight(float value) { }

	[Address(RVA = "0x1BD6DF0", Offset = "0x1BD5FF0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600050B")]
	public void set_horizontalScrollingEnabled(bool value) { }

	[Address(RVA = "0x1BD6EB0", Offset = "0x1BD60B0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60004F6")]
	public void set_itemsSource(IList value) { }

	[Address(RVA = "0x1BD6FF0", Offset = "0x1BD61F0", Length = "0x101")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BCDC50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000509")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x1BD2E90", Offset = "0x1BD2090", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FD")]
	public void set_selectedIndex(int value) { }

	[Address(RVA = "0x1BD7100", Offset = "0x1BD6300", Length = "0x105")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selection), Member = "FirstIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F9")]
	public void set_selectionType(SelectionType value) { }

	[Address(RVA = "0x1BD7210", Offset = "0x1BD6410", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600050D")]
	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	[Address(RVA = "0x1BD72A0", Offset = "0x1BD64A0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_showBorder", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000507")]
	public void set_showBorder(bool value) { }

	[Address(RVA = "0x1BD7390", Offset = "0x1BD6590", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600050F")]
	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	[Address(RVA = "0x1BD4A10", Offset = "0x1BD3C10", Length = "0x89")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessSingleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_selectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_selectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "DoSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "<Apply>g__HandleSelectionAndScroll|204_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass204_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6000540")]
	public void SetSelection(int index) { }

	[Address(RVA = "0x1BD4A00", Offset = "0x1BD3C00", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000541")]
	public void SetSelection(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x1BD45F0", Offset = "0x1BD37F0", Length = "0x3F8")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetSelectionById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetSelectionById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetSelectionInternalById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "NotifyOfSelectionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "AddToSelectionWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "MatchesExistingSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelectionWithoutValidation", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000543")]
	internal void SetSelectionInternal(IEnumerable<Int32> indices, bool sendNotification) { }

	[Address(RVA = "0x1BD49F0", Offset = "0x1BD3BF0", Length = "0xB")]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000542")]
	public void SetSelectionWithoutNotify(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x1BD4AA0", Offset = "0x1BD3CA0", Length = "0x103")]
	[CalledBy(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionViewController), Member = "remove_itemIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "remove_itemsSourceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionViewController), Member = "SetView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "add_itemIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "add_itemsSourceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000519")]
	public override void SetViewController(CollectionViewController controller) { }

	[Address(RVA = "0x1BD4DD0", Offset = "0x1BD3FD0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054E")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054D")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

