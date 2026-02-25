namespace UnityEngine.UIElements;

[Token(Token = "0x2000163")]
public class TreeView : BaseTreeView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000164")]
	internal class UxmlFactory : UxmlFactory<TreeView, UxmlTraits>
	{

		[Address(RVA = "0x1C46CF0", Offset = "0x1C45EF0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000AE2")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000165")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400070F")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate; //Field offset: 0xD0

		[Address(RVA = "0x1C47AC0", Offset = "0x1C46CC0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AE4")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C474C0", Offset = "0x1C466C0", Length = "0x225")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AE3")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000704")]
	internal static readonly BindingId itemTemplateProperty; //Field offset: 0x0
	[Token(Token = "0x4000705")]
	internal static readonly BindingId makeItemProperty; //Field offset: 0x98
	[Token(Token = "0x4000706")]
	internal static readonly BindingId bindItemProperty; //Field offset: 0x130
	[Token(Token = "0x4000707")]
	internal static readonly BindingId unbindItemProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000708")]
	internal static readonly BindingId destroyItemProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000709")]
	private Func<VisualElement> m_MakeItem; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x400070A")]
	private Func<VisualElement> m_TemplateMakeItem; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x400070B")]
	private VisualTreeAsset m_ItemTemplate; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x400070C")]
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x400
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x400070D")]
	private Action<VisualElement, Int32> m_UnbindItem; //Field offset: 0x408
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x400070E")]
	private Action<VisualElement> m_DestroyItem; //Field offset: 0x410

	[CreateProperty]
	[Token(Token = "0x170001DB")]
	public Action<VisualElement, Int32> bindItem
	{
		[Address(RVA = "0x1C40330", Offset = "0x1C3F530", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AD7")]
		 get { } //Length: 8
		[Address(RVA = "0x1C40360", Offset = "0x1C3F560", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000AD8")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170001DD")]
	public Action<VisualElement> destroyItem
	{
		[Address(RVA = "0x1C40340", Offset = "0x1C3F540", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000ADB")]
		 get { } //Length: 8
		[Address(RVA = "0x1C40410", Offset = "0x1C3F610", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000ADC")]
		 set { } //Length: 155
	}

	[CreateProperty]
	[Token(Token = "0x170001DA")]
	public VisualTreeAsset itemTemplate
	{
		[Address(RVA = "0x1C19680", Offset = "0x1C18880", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD4")]
		 get { } //Length: 8
		[Address(RVA = "0x1C404B0", Offset = "0x1C3F6B0", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000AD5")]
		 set { } //Length: 247
	}

	[CreateProperty]
	[Token(Token = "0x170001D9")]
	public Func<VisualElement> makeItem
	{
		[Address(RVA = "0x1C19670", Offset = "0x1C18870", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD2")]
		 get { } //Length: 8
		[Address(RVA = "0x1C405B0", Offset = "0x1C3F7B0", Length = "0xA5")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeView), Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, System.Int32>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000AD3")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170001DC")]
	public Action<VisualElement, Int32> unbindItem
	{
		[Address(RVA = "0x1C40350", Offset = "0x1C3F550", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AD9")]
		 get { } //Length: 8
		[Address(RVA = "0x1C40660", Offset = "0x1C3F860", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000ADA")]
		 set { } //Length: 155
	}

	[Address(RVA = "0x1C3FC50", Offset = "0x1C3EE50", Length = "0x42B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AE1")]
	private static TreeView() { }

	[Address(RVA = "0x1C40080", Offset = "0x1C3F280", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ADF")]
	public TreeView() { }

	[Address(RVA = "0x1C401D0", Offset = "0x1C3F3D0", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AE0")]
	public TreeView(Func<VisualElement> makeItem, Action<VisualElement, Int32> bindItem) { }

	[Address(RVA = "0x1C3FAC0", Offset = "0x1C3ECC0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DefaultTreeViewController`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000ADE")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x1C40330", Offset = "0x1C3F530", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AD7")]
	public Action<VisualElement, Int32> get_bindItem() { }

	[Address(RVA = "0x1C40340", Offset = "0x1C3F540", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ADB")]
	public Action<VisualElement> get_destroyItem() { }

	[Address(RVA = "0x1C19680", Offset = "0x1C18880", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD4")]
	public VisualTreeAsset get_itemTemplate() { }

	[Address(RVA = "0x1C19670", Offset = "0x1C18870", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD2")]
	public Func<VisualElement> get_makeItem() { }

	[Address(RVA = "0x1C40350", Offset = "0x1C3F550", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AD9")]
	public Action<VisualElement, Int32> get_unbindItem() { }

	[Address(RVA = "0x1C3FB20", Offset = "0x1C3ED20", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ADD")]
	internal virtual bool HasValidDataAndBindings() { }

	[Address(RVA = "0x1C40360", Offset = "0x1C3F560", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AD8")]
	public void set_bindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1C40410", Offset = "0x1C3F610", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ADC")]
	public void set_destroyItem(Action<VisualElement> value) { }

	[Address(RVA = "0x1C404B0", Offset = "0x1C3F6B0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeView), Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AD5")]
	public void set_itemTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x1C405B0", Offset = "0x1C3F7B0", Length = "0xA5")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AD3")]
	public void set_makeItem(Func<VisualElement> value) { }

	[Address(RVA = "0x1C40660", Offset = "0x1C3F860", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ADA")]
	public void set_unbindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x1C3FB60", Offset = "0x1C3ED60", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AD6")]
	private VisualElement TemplateMakeItem() { }

}

