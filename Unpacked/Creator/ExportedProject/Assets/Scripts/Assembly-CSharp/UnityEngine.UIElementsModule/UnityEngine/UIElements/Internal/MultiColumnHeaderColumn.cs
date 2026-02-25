namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000642")]
internal class MultiColumnHeaderColumn : VisualElement
{
	[Token(Token = "0x4001754")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4001755")]
	public static readonly string sortableUssClassName; //Field offset: 0x8
	[Token(Token = "0x4001756")]
	public static readonly string sortedAscendingUssClassName; //Field offset: 0x10
	[Token(Token = "0x4001757")]
	public static readonly string sortedDescendingUssClassName; //Field offset: 0x18
	[Token(Token = "0x4001758")]
	public static readonly string movingUssClassName; //Field offset: 0x20
	[Token(Token = "0x4001759")]
	public static readonly string contentContainerUssClassName; //Field offset: 0x28
	[Token(Token = "0x400175A")]
	public static readonly string contentUssClassName; //Field offset: 0x30
	[Token(Token = "0x400175B")]
	public static readonly string defaultContentUssClassName; //Field offset: 0x38
	[Token(Token = "0x400175C")]
	public static readonly string hasIconUssClassName; //Field offset: 0x40
	[Token(Token = "0x400175D")]
	public static readonly string hasTitleUssClassName; //Field offset: 0x48
	[Token(Token = "0x400175E")]
	public static readonly string titleUssClassName; //Field offset: 0x50
	[Token(Token = "0x400175F")]
	public static readonly string iconElementName; //Field offset: 0x58
	[Token(Token = "0x4001760")]
	public static readonly string titleElementName; //Field offset: 0x60
	[Token(Token = "0x4001761")]
	private static readonly string s_BoundVEPropertyName; //Field offset: 0x68
	[Token(Token = "0x4001762")]
	private static readonly string s_BindingCallbackVEPropertyName; //Field offset: 0x70
	[Token(Token = "0x4001763")]
	private static readonly string s_UnbindingCallbackVEPropertyName; //Field offset: 0x78
	[Token(Token = "0x4001764")]
	private static readonly string s_DestroyCallbackVEPropertyName; //Field offset: 0x80
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4001765")]
	private VisualElement m_ContentContainer; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4001766")]
	private VisualElement m_Content; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4001767")]
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4001768")]
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; //Field offset: 0x2E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4001769")]
	private Clickable <clickable>k__BackingField; //Field offset: 0x2F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400176A")]
	private ColumnMover <mover>k__BackingField; //Field offset: 0x2F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x400176B")]
	private Column <column>k__BackingField; //Field offset: 0x300

	[Token(Token = "0x17000B3D")]
	public private Clickable clickable
	{
		[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C16")]
		 get { } //Length: 8
		[Address(RVA = "0x1B2F890", Offset = "0x1B2EA90", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C17")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B40")]
	public private Column column
	{
		[Address(RVA = "0x1BF7F10", Offset = "0x1BF7110", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C1B")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF8000", Offset = "0x1BF7200", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C1C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B41")]
	public VisualElement content
	{
		[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C1D")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF8020", Offset = "0x1BF7220", Length = "0x2A3")]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "ClearProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
		[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002C1E")]
		 set { } //Length: 675
	}

	[Token(Token = "0x17000B42")]
	private bool isContentBound
	{
		[Address(RVA = "0x1BF7F20", Offset = "0x1BF7120", Length = "0xCD")]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "BindHeaderContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002C1F")]
		private get { } //Length: 205
		[Address(RVA = "0x1BF82D0", Offset = "0x1BF74D0", Length = "0xA3")]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "BindHeaderContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002C20")]
		private set { } //Length: 163
	}

	[Token(Token = "0x17000B3E")]
	public private ColumnMover mover
	{
		[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C18")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF8380", Offset = "0x1BF7580", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002C19")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B3F")]
	public string sortOrderLabel
	{
		[Address(RVA = "0x1BF83A0", Offset = "0x1BF75A0", Length = "0x39")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002C1A")]
		 set { } //Length: 57
	}

	[Address(RVA = "0x1BF6F50", Offset = "0x1BF6150", Length = "0x5A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C2F")]
	private static MultiColumnHeaderColumn() { }

	[Address(RVA = "0x1BF7500", Offset = "0x1BF6700", Length = "0xA07")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateGeometryFromColumn", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "InitManipulators", ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "add_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002C21")]
	public MultiColumnHeaderColumn(Column column) { }

	[Address(RVA = "0x1BF5920", Offset = "0x1BF4B20", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "get_isContentBound", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C27")]
	private void BindHeaderContent() { }

	[Address(RVA = "0x1BF5A00", Offset = "0x1BF4C00", Length = "0x270")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C2A")]
	private VisualElement CreateDefaultHeaderContent() { }

	[Address(RVA = "0x1BF5C80", Offset = "0x1BF4E80", Length = "0x3AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_image", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_vectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumnIcon), Member = "UpdateClassList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C2B")]
	private void DefaultBindHeaderContent(VisualElement ve) { }

	[Address(RVA = "0x1BF6030", Offset = "0x1BF5230", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = "ClearProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C29")]
	private void DestroyHeaderContent() { }

	[Address(RVA = "0x1BF61E0", Offset = "0x1BF53E0", Length = "0x23E")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "CleanupColumnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Column), Member = "remove_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "remove_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C2E")]
	public void Dispose() { }

	[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C16")]
	public Clickable get_clickable() { }

	[Address(RVA = "0x1BF7F10", Offset = "0x1BF7110", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1B")]
	public Column get_column() { }

	[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1D")]
	public VisualElement get_content() { }

	[Address(RVA = "0x1BF7F20", Offset = "0x1BF7120", Length = "0xCD")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "BindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C1F")]
	private bool get_isContentBound() { }

	[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C18")]
	public ColumnMover get_mover() { }

	[Address(RVA = "0x1BF6420", Offset = "0x1BF5620", Length = "0x40C")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C24")]
	private void InitManipulators() { }

	[Address(RVA = "0x1BF6830", Offset = "0x1BF5A30", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C22")]
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	[Address(RVA = "0x1BF6950", Offset = "0x1BF5B50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateGeometryFromColumn", ReturnType = typeof(void))]
	[Token(Token = "0x6002C23")]
	private void OnColumnResized(Column c) { }

	[Address(RVA = "0x1BF6960", Offset = "0x1BF5B60", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C25")]
	private void OnMoverChanged(ColumnMover mv) { }

	[Address(RVA = "0x1B2F890", Offset = "0x1B2EA90", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C17")]
	private void set_clickable(Clickable value) { }

	[Address(RVA = "0x1BF8000", Offset = "0x1BF7200", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1C")]
	private void set_column(Column value) { }

	[Address(RVA = "0x1BF8020", Offset = "0x1BF7220", Length = "0x2A3")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = "ClearProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C1E")]
	public void set_content(VisualElement value) { }

	[Address(RVA = "0x1BF82D0", Offset = "0x1BF74D0", Length = "0xA3")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "BindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002C20")]
	private void set_isContentBound(bool value) { }

	[Address(RVA = "0x1BF8380", Offset = "0x1BF7580", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002C19")]
	private void set_mover(ColumnMover value) { }

	[Address(RVA = "0x1BF83A0", Offset = "0x1BF75A0", Length = "0x39")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C1A")]
	public void set_sortOrderLabel(string value) { }

	[Address(RVA = "0x1BF6A10", Offset = "0x1BF5C10", Length = "0xD6")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DestroyHeaderContent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "get_isContentBound", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C28")]
	private void UnbindHeaderContent() { }

	[Address(RVA = "0x1BF6AF0", Offset = "0x1BF5CF0", Length = "0x101")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "get_isContentBound", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C26")]
	private void UpdateDataFromColumn() { }

	[Address(RVA = "0x1BF6C00", Offset = "0x1BF5E00", Length = "0x126")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C2D")]
	private void UpdateGeometryFromColumn() { }

	[Address(RVA = "0x1BF6D30", Offset = "0x1BF5F30", Length = "0x21C")]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C2C")]
	private void UpdateHeaderTemplate() { }

}

