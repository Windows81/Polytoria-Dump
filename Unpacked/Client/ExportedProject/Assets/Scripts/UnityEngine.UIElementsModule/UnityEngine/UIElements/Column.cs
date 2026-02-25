namespace UnityEngine.UIElements;

[Token(Token = "0x2000104")]
[UxmlObject]
public class Column : INotifyBindablePropertyChanged
{
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000106")]
	public class UxmlObjectFactory : UxmlObjectFactory<Column>
	{

		[Address(RVA = "0x1C15A70", Offset = "0x1C14C70", Length = "0x39")]
		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600083C")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000105")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x849EA0", Offset = "0x8490A0", Length = "0x22")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600083B")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000107")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000108")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000531")]
			public VisualTreeAsset asset; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000840")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0x7FD650", Offset = "0x7FC850", Length = "0xE3")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000841")]
			internal VisualElement <Init>b__0() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000109")]
		private sealed class <>c__DisplayClass14_1
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000532")]
			public VisualTreeAsset asset; //Field offset: 0x0

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000842")]
			public <>c__DisplayClass14_1() { }

			[Address(RVA = "0x7FD740", Offset = "0x7FC940", Length = "0xE3")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000843")]
			internal VisualElement <Init>b__1() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000524")]
		private UxmlStringAttributeDescription m_Name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000525")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000526")]
		private UxmlBoolAttributeDescription m_Visible; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000527")]
		private UxmlStringAttributeDescription m_Width; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000528")]
		private UxmlStringAttributeDescription m_MinWidth; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000529")]
		private UxmlStringAttributeDescription m_MaxWidth; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052A")]
		private UxmlBoolAttributeDescription m_Stretch; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052B")]
		private UxmlBoolAttributeDescription m_Sortable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052C")]
		private UxmlBoolAttributeDescription m_Optional; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052D")]
		private UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052E")]
		private UxmlStringAttributeDescription m_HeaderTemplateId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400052F")]
		private UxmlStringAttributeDescription m_CellTemplateId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000530")]
		private UxmlStringAttributeDescription m_BindingPath; //Field offset: 0x0

		[Address(RVA = "0x84B950", Offset = "0x84AB50", Length = "0x490")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083F")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x84ADD0", Offset = "0x849FD0", Length = "0x833")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Column), Member = "set_sortable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Column), Member = "set_resizable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_optional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_stretchable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180035060")]
		[Calls(Type = typeof(Column), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_title", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Column), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_makeCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083E")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

		[Address(RVA = "0x84B7B0", Offset = "0x84A9B0", Length = "0x19B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083D")]
		private static Length ParseLength(string str, Length defaultValue) { }

	}

	[Token(Token = "0x40004FB")]
	private static readonly BindingId nameProperty; //Field offset: 0x0
	[Token(Token = "0x40004FC")]
	private static readonly BindingId titleProperty; //Field offset: 0x98
	[Token(Token = "0x40004FD")]
	private static readonly BindingId iconProperty; //Field offset: 0x130
	[Token(Token = "0x40004FE")]
	private static readonly BindingId visibleProperty; //Field offset: 0x1C8
	[Token(Token = "0x40004FF")]
	private static readonly BindingId widthProperty; //Field offset: 0x260
	[Token(Token = "0x4000500")]
	private static readonly BindingId minWidthProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000501")]
	private static readonly BindingId maxWidthProperty; //Field offset: 0x390
	[Token(Token = "0x4000502")]
	private static readonly BindingId sortableProperty; //Field offset: 0x428
	[Token(Token = "0x4000503")]
	private static readonly BindingId stretchableProperty; //Field offset: 0x4C0
	[Token(Token = "0x4000504")]
	private static readonly BindingId optionalProperty; //Field offset: 0x558
	[Token(Token = "0x4000505")]
	private static readonly BindingId resizableProperty; //Field offset: 0x5F0
	[Token(Token = "0x4000506")]
	private static readonly BindingId headerTemplateProperty; //Field offset: 0x688
	[Token(Token = "0x4000507")]
	private static readonly BindingId cellTemplateProperty; //Field offset: 0x720
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000508")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000509")]
	private string m_Title; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400050A")]
	private Background m_Icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400050B")]
	private bool m_Visible; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400050C")]
	private Length m_Width; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400050D")]
	private Length m_MinWidth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400050E")]
	private Length m_MaxWidth; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400050F")]
	private float m_DesiredWidth; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000510")]
	private bool m_Stretchable; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000511")]
	private bool m_Sortable; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000512")]
	private bool m_Optional; //Field offset: 0x62
	[FieldOffset(Offset = "0x63")]
	[Token(Token = "0x4000513")]
	private bool m_Resizable; //Field offset: 0x63
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000514")]
	private VisualTreeAsset m_HeaderTemplate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000515")]
	private VisualTreeAsset m_CellTemplate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000516")]
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000517")]
	private Action<VisualElement> m_BindHeader; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000518")]
	private Action<VisualElement> m_UnbindHeader; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000519")]
	private Action<VisualElement> m_DestroyHeader; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400051A")]
	private Func<VisualElement> m_MakeCell; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400051B")]
	private Action<VisualElement, Int32> m_BindCell; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400051C")]
	private Action<VisualElement, Int32> m_UnbindCellItem; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400051D")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400051E")]
	private Comparison<Int32> <comparison>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400051F")]
	private string <bindingPath>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000520")]
	private Action<VisualElement> <destroyCell>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000521")]
	private Columns <collection>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000522")]
	private Action<Column, ColumnDataType> changed; //Field offset: 0xD8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000523")]
	private Action<Column> resized; //Field offset: 0xE0

	[Token(Token = "0x14000015")]
	internal event Action<Column, ColumnDataType> changed
	{
		[Address(RVA = "0x1C00090", Offset = "0x1BFF290", Length = "0xBA")]
		[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000830")]
		internal add { } //Length: 186
		[Address(RVA = "0x1C00500", Offset = "0x1BFF700", Length = "0xBA")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000831")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x14000014")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x1C00150", Offset = "0x1BFF350", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000801")]
		 add { } //Length: 186
		[Address(RVA = "0x1C005C0", Offset = "0x1BFF7C0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000802")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000016")]
	internal event Action<Column> resized
	{
		[Address(RVA = "0x1C00210", Offset = "0x1BFF410", Length = "0xBA")]
		[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000832")]
		internal add { } //Length: 186
		[Address(RVA = "0x1C00680", Offset = "0x1BFF880", Length = "0xBA")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000833")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x17000162")]
	public Action<VisualElement, Int32> bindCell
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015E")]
	public Action<VisualElement> bindHeader
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000826")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015A")]
	public string bindingPath
	{
		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600081F")]
		 set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x1700015C")]
	public VisualTreeAsset cellTemplate
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000822")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00740", Offset = "0x1BFF940", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000823")]
		 set { } //Length: 227
	}

	[Token(Token = "0x17000165")]
	public internal Columns collection
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600082E")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600082F")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700014D")]
	public Comparison<Int32> comparison
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000809")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000155")]
	internal float desiredWidth
	{
		[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000815")]
		internal get { } //Length: 6
		[Address(RVA = "0x1C00830", Offset = "0x1BFFA30", Length = "0x30")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000816")]
		internal set { } //Length: 48
	}

	[Token(Token = "0x17000164")]
	public Action<VisualElement> destroyCell
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600082D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000160")]
	public Action<VisualElement> destroyHeader
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000828")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700014F")]
	internal int displayIndex
	{
		[Address(RVA = "0x1C002D0", Offset = "0x1BFF4D0", Length = "0xA9")]
		[CalledBy(Type = typeof(ColumnMover), Member = "EndDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Token(Token = "0x600080B")]
		internal get { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x1700015B")]
	public VisualTreeAsset headerTemplate
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000820")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00860", Offset = "0x1BFFA60", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000821")]
		 set { } //Length: 227
	}

	[CreateProperty]
	[Token(Token = "0x1700014C")]
	public Background icon
	{
		[Address(RVA = "0x1C00380", Offset = "0x1BFF580", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000807")]
		 get { } //Length: 19
		[Address(RVA = "0x1C00950", Offset = "0x1BFFB50", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000808")]
		 set { } //Length: 229
	}

	[Token(Token = "0x1700014E")]
	internal int index
	{
		[Address(RVA = "0x1C003A0", Offset = "0x1BFF5A0", Length = "0x71")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass73_0", Member = "<UpdateSortColumnDescriptionsOnClick>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600080A")]
		internal get { } //Length: 113
	}

	[Token(Token = "0x17000161")]
	public Func<VisualElement> makeCell
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000829")]
		 get { } //Length: 8
		[Address(RVA = "0x1C00A40", Offset = "0x1BFFC40", Length = "0x67")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600082A")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700015D")]
	public Func<VisualElement> makeHeader
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000824")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00AB0", Offset = "0x1BFFCB0", Length = "0x5E")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000825")]
		 set { } //Length: 94
	}

	[CreateProperty]
	[Token(Token = "0x17000154")]
	public Length maxWidth
	{
		[Address(RVA = "0x1C00420", Offset = "0x1BFF620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000813")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00B10", Offset = "0x1BFFD10", Length = "0xA9")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000814")]
		 set { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x17000153")]
	public Length minWidth
	{
		[Address(RVA = "0x1C00430", Offset = "0x1BFF630", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000811")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00BC0", Offset = "0x1BFFDC0", Length = "0xA9")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000812")]
		 set { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x1700014A")]
	public string name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000803")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00C70", Offset = "0x1BFFE70", Length = "0xAB")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000804")]
		 set { } //Length: 171
	}

	[CreateProperty]
	[Token(Token = "0x17000158")]
	public bool optional
	{
		[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081B")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00D20", Offset = "0x1BFFF20", Length = "0x9C")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600081C")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000159")]
	public bool resizable
	{
		[Address(RVA = "0x3D0210", Offset = "0x3CF410", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081D")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00DC0", Offset = "0x1BFFFC0", Length = "0x9C")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600081E")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000156")]
	public bool sortable
	{
		[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000817")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00E60", Offset = "0x1C00060", Length = "0x9C")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000818")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000157")]
	public bool stretchable
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000819")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00F00", Offset = "0x1C00100", Length = "0x9C")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600081A")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x1700014B")]
	public string title
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000805")]
		 get { } //Length: 5
		[Address(RVA = "0x1C00FA0", Offset = "0x1C001A0", Length = "0xB5")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000806")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000163")]
	public Action<VisualElement, Int32> unbindCell
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015F")]
	public Action<VisualElement> unbindHeader
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000827")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000151")]
	public bool visible
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080D")]
		 get { } //Length: 5
		[Address(RVA = "0x1C01060", Offset = "0x1C00260", Length = "0x9C")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass67_0", Member = "<OnContextualMenuManipulator>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600080E")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000150")]
	internal int visibleIndex
	{
		[Address(RVA = "0x1C00440", Offset = "0x1BFF640", Length = "0xA9")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnLayout), Member = "GetDesiredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Columns), Member = "IsPrimary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Token(Token = "0x600080C")]
		internal get { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x17000152")]
	public Length width
	{
		[Address(RVA = "0x1C004F0", Offset = "0x1BFF6F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600080F")]
		 get { } //Length: 5
		[Address(RVA = "0x1C01100", Offset = "0x1C00300", Length = "0xE1")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000810")]
		 set { } //Length: 225
	}

	[Address(RVA = "0x1BFF5D0", Offset = "0x1BFE7D0", Length = "0xA47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600083A")]
	private static Column() { }

	[Address(RVA = "0x1C00020", Offset = "0x1BFF220", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000839")]
	public Column() { }

	[Address(RVA = "0x1C00090", Offset = "0x1BFF290", Length = "0xBA")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000830")]
	internal void add_changed(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x1C00150", Offset = "0x1BFF350", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000801")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x1C00210", Offset = "0x1BFF410", Length = "0xBA")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000832")]
	internal void add_resized(Action<Column> value) { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082B")]
	public Action<VisualElement, Int32> get_bindCell() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	public Action<VisualElement> get_bindHeader() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000822")]
	public VisualTreeAsset get_cellTemplate() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600082E")]
	public Columns get_collection() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000809")]
	public Comparison<Int32> get_comparison() { }

	[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000815")]
	internal float get_desiredWidth() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600082D")]
	public Action<VisualElement> get_destroyCell() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000828")]
	public Action<VisualElement> get_destroyHeader() { }

	[Address(RVA = "0x1C002D0", Offset = "0x1BFF4D0", Length = "0xA9")]
	[CalledBy(Type = typeof(ColumnMover), Member = "EndDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x600080B")]
	internal int get_displayIndex() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000820")]
	public VisualTreeAsset get_headerTemplate() { }

	[Address(RVA = "0x1C00380", Offset = "0x1BFF580", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000807")]
	public Background get_icon() { }

	[Address(RVA = "0x1C003A0", Offset = "0x1BFF5A0", Length = "0x71")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass73_0", Member = "<UpdateSortColumnDescriptionsOnClick>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600080A")]
	internal int get_index() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000829")]
	public Func<VisualElement> get_makeCell() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000824")]
	public Func<VisualElement> get_makeHeader() { }

	[Address(RVA = "0x1C00420", Offset = "0x1BFF620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000813")]
	public Length get_maxWidth() { }

	[Address(RVA = "0x1C00430", Offset = "0x1BFF630", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000811")]
	public Length get_minWidth() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000803")]
	public string get_name() { }

	[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081B")]
	public bool get_optional() { }

	[Address(RVA = "0x3D0210", Offset = "0x3CF410", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081D")]
	public bool get_resizable() { }

	[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000817")]
	public bool get_sortable() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000819")]
	public bool get_stretchable() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000805")]
	public string get_title() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082C")]
	public Action<VisualElement, Int32> get_unbindCell() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000827")]
	public Action<VisualElement> get_unbindHeader() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080D")]
	public bool get_visible() { }

	[Address(RVA = "0x1C00440", Offset = "0x1BFF640", Length = "0xA9")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "GetDesiredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Columns), Member = "IsPrimary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x600080C")]
	internal int get_visibleIndex() { }

	[Address(RVA = "0x1C004F0", Offset = "0x1BFF6F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600080F")]
	public Length get_width() { }

	[Address(RVA = "0x1BFF420", Offset = "0x1BFE620", Length = "0x27")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000837")]
	internal float GetMaxWidth(float layoutWidth) { }

	[Address(RVA = "0x1BFF450", Offset = "0x1BFE650", Length = "0x27")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000838")]
	internal float GetMinWidth(float layoutWidth) { }

	[Address(RVA = "0x1BFF480", Offset = "0x1BFE680", Length = "0x27")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000836")]
	internal float GetWidth(float layoutWidth) { }

	[Address(RVA = "0x1BFF4B0", Offset = "0x1BFE6B0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000834")]
	private void NotifyChange(ColumnDataType type) { }

	[Address(RVA = "0x1BFF4E0", Offset = "0x1BFE6E0", Length = "0xEC")]
	[CalledBy(Type = typeof(Column), Member = "set_sortable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_cellTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_headerTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_resizable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_optional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_stretchable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_icon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_title", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = "set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BindablePropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000835")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x1C00500", Offset = "0x1BFF700", Length = "0xBA")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000831")]
	internal void remove_changed(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x1C005C0", Offset = "0x1BFF7C0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000802")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x1C00680", Offset = "0x1BFF880", Length = "0xBA")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000833")]
	internal void remove_resized(Action<Column> value) { }

	[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600081F")]
	public void set_bindingPath(string value) { }

	[Address(RVA = "0x1C00740", Offset = "0x1BFF940", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000823")]
	public void set_cellTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600082F")]
	internal void set_collection(Columns value) { }

	[Address(RVA = "0x1C00830", Offset = "0x1BFFA30", Length = "0x30")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000816")]
	internal void set_desiredWidth(float value) { }

	[Address(RVA = "0x1C00860", Offset = "0x1BFFA60", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000821")]
	public void set_headerTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x1C00950", Offset = "0x1BFFB50", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000808")]
	public void set_icon(Background value) { }

	[Address(RVA = "0x1C00A40", Offset = "0x1BFFC40", Length = "0x67")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600082A")]
	public void set_makeCell(Func<VisualElement> value) { }

	[Address(RVA = "0x1C00AB0", Offset = "0x1BFFCB0", Length = "0x5E")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000825")]
	public void set_makeHeader(Func<VisualElement> value) { }

	[Address(RVA = "0x1C00B10", Offset = "0x1BFFD10", Length = "0xA9")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000814")]
	public void set_maxWidth(Length value) { }

	[Address(RVA = "0x1C00BC0", Offset = "0x1BFFDC0", Length = "0xA9")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000812")]
	public void set_minWidth(Length value) { }

	[Address(RVA = "0x1C00C70", Offset = "0x1BFFE70", Length = "0xAB")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000804")]
	public void set_name(string value) { }

	[Address(RVA = "0x1C00D20", Offset = "0x1BFFF20", Length = "0x9C")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081C")]
	public void set_optional(bool value) { }

	[Address(RVA = "0x1C00DC0", Offset = "0x1BFFFC0", Length = "0x9C")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081E")]
	public void set_resizable(bool value) { }

	[Address(RVA = "0x1C00E60", Offset = "0x1C00060", Length = "0x9C")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000818")]
	public void set_sortable(bool value) { }

	[Address(RVA = "0x1C00F00", Offset = "0x1C00100", Length = "0x9C")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081A")]
	public void set_stretchable(bool value) { }

	[Address(RVA = "0x1C00FA0", Offset = "0x1C001A0", Length = "0xB5")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000806")]
	public void set_title(string value) { }

	[Address(RVA = "0x1C01060", Offset = "0x1C00260", Length = "0x9C")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass67_0", Member = "<OnContextualMenuManipulator>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600080E")]
	public void set_visible(bool value) { }

	[Address(RVA = "0x1C01100", Offset = "0x1C00300", Length = "0xE1")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000810")]
	public void set_width(Length value) { }

}

