namespace UnityEngine.UIElements;

[Token(Token = "0x2000068")]
internal class ReusableListViewItem : ReusableCollectionItem
{
	[Token(Token = "0x40001EF")]
	private static readonly string k_SortingDisablesReorderingTooltip; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001F0")]
	private VisualElement m_Container; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001F1")]
	private VisualElement m_DragHandle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F2")]
	private VisualElement m_ItemContainer; //Field offset: 0x58

	[Token(Token = "0x1700007B")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0x1ACAF30", Offset = "0x1ACA130", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003A5")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x1ACAEB0", Offset = "0x1ACA0B0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003AE")]
	private static ReusableListViewItem() { }

	[Address(RVA = "0x1ACAF20", Offset = "0x1ACA120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReusableCollectionItem), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60003AD")]
	public ReusableListViewItem() { }

	[Address(RVA = "0x1ACA710", Offset = "0x1AC9910", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "DetachElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AB")]
	public virtual void DetachElement() { }

	[Address(RVA = "0x1ACAF30", Offset = "0x1ACA130", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60003A5")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x1ACA7A0", Offset = "0x1AC99A0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReusableListViewItem), Member = "UpdateHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A6")]
	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	[Address(RVA = "0x1ACA880", Offset = "0x1AC9A80", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "PreAttachElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AA")]
	public virtual void PreAttachElement() { }

	[Address(RVA = "0x1ACA910", Offset = "0x1AC9B10", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "SetDragGhost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003AC")]
	public virtual void SetDragGhost(bool dragGhost) { }

	[Address(RVA = "0x1ACA980", Offset = "0x1AC9B80", Length = "0x99")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A9")]
	public void SetDragHandleEnabled(bool enabled) { }

	[Address(RVA = "0x1ACAA20", Offset = "0x1AC9C20", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60003A8")]
	public void UpdateDragHandle(bool needsDragHandle) { }

	[Address(RVA = "0x1ACAB90", Offset = "0x1AC9D90", Length = "0x314")]
	[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60003A7")]
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

}

