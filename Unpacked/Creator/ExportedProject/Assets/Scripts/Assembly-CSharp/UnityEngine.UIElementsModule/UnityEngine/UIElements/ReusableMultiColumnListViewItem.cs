namespace UnityEngine.UIElements;

[Token(Token = "0x2000069")]
internal class ReusableMultiColumnListViewItem : ReusableListViewItem
{

	[Token(Token = "0x1700007C")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ACB1A0", Offset = "0x1ACA3A0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60003B2")]
	public ReusableMultiColumnListViewItem() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AF")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B0")]
	public virtual void Init(VisualElement item) { }

	[Address(RVA = "0x1ACAF40", Offset = "0x1ACA140", Length = "0x25B")]
	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Columns), Member = "IsPrimary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReusableListViewItem), Member = "UpdateHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60003B1")]
	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

}

