namespace UnityEngine.UI.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000089")]
internal class IndexedSet : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000275")]
	private readonly List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000276")]
	private Dictionary<T, Int32> m_Dictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000277")]
	private int m_EnabledObjectCount; //Field offset: 0x0

	[Token(Token = "0x1700015A")]
	public int Capacity
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000559")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000159")]
	public override int Count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000558")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700015B")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700015C")]
	public override T Item
	{
		[Address(RVA = "0xC8F7B0", Offset = "0xC8E9B0", Length = "0x6E")]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Cull", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055F")]
		 get { } //Length: 110
		[Address(RVA = "0xC8F820", Offset = "0xC8EA20", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000560")]
		 set { } //Length: 199
	}

	[Address(RVA = "0xC8F590", Offset = "0xC8E790", Length = "0xD8")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000563")]
	public IndexedSet`1() { }

	[Address(RVA = "0xC8D990", Offset = "0xC8CB90", Length = "0x17")]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6DD0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600054D")]
	public override void Add(T item) { }

	[Address(RVA = "0xC8D9B0", Offset = "0xC8CBB0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600054E")]
	public void Add(T item, bool isActive) { }

	[Address(RVA = "0xC8D520", Offset = "0xC8C720", Length = "0x11E")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6DD0")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600054F")]
	public bool AddUnique(T item, bool isActive = true) { }

	[Address(RVA = "0xC8DB30", Offset = "0xC8CD30", Length = "0x71")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000555")]
	public override void Clear() { }

	[Address(RVA = "0xC8DBB0", Offset = "0xC8CDB0", Length = "0x2A")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000556")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xC8DCD0", Offset = "0xC8CED0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000557")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xC8DD30", Offset = "0xC8CF30", Length = "0x90")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000551")]
	public bool DisableItem(T item) { }

	[Address(RVA = "0xC8E080", Offset = "0xC8D280", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000550")]
	public bool EnableItem(T item) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000559")]
	public int get_Capacity() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000558")]
	public override int get_Count() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055A")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xC8F7B0", Offset = "0xC8E9B0", Length = "0x6E")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Cull", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055F")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000553")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xC8E220", Offset = "0xC8D420", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600055B")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xC8E270", Offset = "0xC8D470", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600055C")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xC8EB00", Offset = "0xC8DD00", Length = "0x78")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000552")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xC8E2C0", Offset = "0xC8D4C0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B70C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000561")]
	public void RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0xC8E870", Offset = "0xC8DA70", Length = "0x149")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7140")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055D")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xC8F820", Offset = "0xC8EA20", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000560")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xC8EDB0", Offset = "0xC8DFB0", Length = "0xB7")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000562")]
	public void Sort(Comparison<T> sortLayoutFunction) { }

	[Address(RVA = "0xC8EE70", Offset = "0xC8E070", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055E")]
	private void Swap(int index1, int index2) { }

	[Address(RVA = "0xC8F480", Offset = "0xC8E680", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180034D90")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000554")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

