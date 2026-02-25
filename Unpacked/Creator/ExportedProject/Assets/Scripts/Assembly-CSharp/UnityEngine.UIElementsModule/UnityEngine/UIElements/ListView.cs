namespace UnityEngine.UIElements;

[Token(Token = "0x20000F8")]
public class ListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F9")]
	internal class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{

		[Address(RVA = "0x1C159B0", Offset = "0x1C14BB0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007BF")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FA")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40004CA")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate; //Field offset: 0x108

		[Address(RVA = "0x1C167E0", Offset = "0x1C159E0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007C1")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C15AB0", Offset = "0x1C14CB0", Length = "0x2AE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007C0")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40004BF")]
	internal static readonly BindingId itemTemplateProperty; //Field offset: 0x0
	[Token(Token = "0x40004C0")]
	internal static readonly BindingId makeItemProperty; //Field offset: 0x98
	[Token(Token = "0x40004C1")]
	internal static readonly BindingId bindItemProperty; //Field offset: 0x130
	[Token(Token = "0x40004C2")]
	internal static readonly BindingId unbindItemProperty; //Field offset: 0x1C8
	[Token(Token = "0x40004C3")]
	internal static readonly BindingId destroyItemProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x40004C4")]
	private Func<VisualElement> m_MakeItem; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x40004C5")]
	private Func<VisualElement> m_TemplateMakeItem; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x40004C6")]
	private VisualTreeAsset m_ItemTemplate; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x40004C7")]
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x4F0
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x40004C8")]
	private Action<VisualElement, Int32> m_UnbindItem; //Field offset: 0x4F8
	[FieldOffset(Offset = "0x500")]
	[Token(Token = "0x40004C9")]
	private Action<VisualElement> m_DestroyItem; //Field offset: 0x500

	[CreateProperty]
	[Token(Token = "0x1700013A")]
	public Action<VisualElement, Int32> bindItem
	{
		[Address(RVA = "0x1C0AFB0", Offset = "0x1C0A1B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60007B5")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B000", Offset = "0x1C0A200", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007B6")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x1700013C")]
	public Action<VisualElement> destroyItem
	{
		[Address(RVA = "0x1C0AFC0", Offset = "0x1C0A1C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B0B0", Offset = "0x1C0A2B0", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007BA")]
		 set { } //Length: 155
	}

	[CreateProperty]
	[Token(Token = "0x17000139")]
	public VisualTreeAsset itemTemplate
	{
		[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A1D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B2")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B150", Offset = "0x1C0A350", Length = "0x180")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007B3")]
		 set { } //Length: 384
	}

	[CreateProperty]
	[Token(Token = "0x17000138")]
	public Func<VisualElement> makeItem
	{
		[Address(RVA = "0x1C0AFE0", Offset = "0x1C0A1E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B0")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B2D0", Offset = "0x1C0A4D0", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007B1")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x1700013B")]
	public Action<VisualElement, Int32> unbindItem
	{
		[Address(RVA = "0x1C0AFF0", Offset = "0x1C0A1F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B380", Offset = "0x1C0A580", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007B8")]
		 set { } //Length: 155
	}

	[Address(RVA = "0x1C0AAB0", Offset = "0x1C09CB0", Length = "0x42B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60007BE")]
	private static ListView() { }

	[Address(RVA = "0x1C0AEE0", Offset = "0x1C0A0E0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007BD")]
	public ListView() { }

	[Address(RVA = "0x1C0A900", Offset = "0x1C09B00", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007BC")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x1C0AFB0", Offset = "0x1C0A1B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007B5")]
	public Action<VisualElement, Int32> get_bindItem() { }

	[Address(RVA = "0x1C0AFC0", Offset = "0x1C0A1C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007B9")]
	public Action<VisualElement> get_destroyItem() { }

	[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A1D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B2")]
	public VisualTreeAsset get_itemTemplate() { }

	[Address(RVA = "0x1C0AFE0", Offset = "0x1C0A1E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B0")]
	public Func<VisualElement> get_makeItem() { }

	[Address(RVA = "0x1C0AFF0", Offset = "0x1C0A1F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007B7")]
	public Action<VisualElement, Int32> get_unbindItem() { }

	[Address(RVA = "0x1C0A950", Offset = "0x1C09B50", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseListView), Member = "get_autoAssignSource", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BB")]
	internal virtual bool HasValidDataAndBindings() { }

	[Address(RVA = "0x1C0B000", Offset = "0x1C0A200", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007B6")]
	public void set_bindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1C0B0B0", Offset = "0x1C0A2B0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007BA")]
	public void set_destroyItem(Action<VisualElement> value) { }

	[Address(RVA = "0x1C0B150", Offset = "0x1C0A350", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007B3")]
	public void set_itemTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x1C0B2D0", Offset = "0x1C0A4D0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007B1")]
	public void set_makeItem(Func<VisualElement> value) { }

	[Address(RVA = "0x1C0B380", Offset = "0x1C0A580", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007B8")]
	public void set_unbindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1C0A9C0", Offset = "0x1C09BC0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B4")]
	private VisualElement TemplateMakeItem() { }

}

