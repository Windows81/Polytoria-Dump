namespace UnityEngine.UIElements;

[HideInInspector]
[Token(Token = "0x2000472")]
[UxmlElement("Instance")]
public class TemplateContainer : BindableElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000473")]
	internal class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{

		[Token(Token = "0x170008D6")]
		public virtual string uxmlName
		{
			[Address(RVA = "0x1B3A140", Offset = "0x1B39340", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6002134")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170008D7")]
		public virtual string uxmlQualifiedName
		{
			[Address(RVA = "0x1B3A170", Offset = "0x1B39370", Length = "0x78")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6002135")]
			 get { } //Length: 120
		}

		[Address(RVA = "0x1B3A100", Offset = "0x1B39300", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002136")]
		public UxmlFactory() { }

		[Address(RVA = "0x1B3A140", Offset = "0x1B39340", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6002134")]
		public virtual string get_uxmlName() { }

		[Address(RVA = "0x1B3A170", Offset = "0x1B39370", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002135")]
		public virtual string get_uxmlQualifiedName() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000474")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000ECA")]
		private UxmlStringAttributeDescription m_Template; //Field offset: 0x90

		[Address(RVA = "0x1B3A720", Offset = "0x1B39920", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002138")]
		public UxmlTraits() { }

		[Address(RVA = "0x1B3A1F0", Offset = "0x1B393F0", Length = "0x52B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002137")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000EC5")]
	internal static readonly BindingId templateIdProperty; //Field offset: 0x0
	[Token(Token = "0x4000EC6")]
	internal static readonly BindingId templateSourceProperty; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000EC7")]
	private string <templateId>k__BackingField; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000EC8")]
	private VisualElement m_ContentContainer; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000EC9")]
	private VisualTreeAsset m_TemplateSource; //Field offset: 0x2F0

	[Token(Token = "0x170008D5")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1B2F850", Offset = "0x1B2EA50", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002131")]
		 get { } //Length: 10
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170008D3")]
	public private string templateId
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600212A")]
		 get { } //Length: 8
		[Address(RVA = "0x1B2F870", Offset = "0x1B2EA70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x600212B")]
		private set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170008D4")]
	public internal VisualTreeAsset templateSource
	{
		[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600212C")]
		 get { } //Length: 8
		[Address(RVA = "0x1B2F890", Offset = "0x1B2EA90", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600212D")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x1B2F520", Offset = "0x1B2E720", Length = "0x1E2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002133")]
	private static TemplateContainer() { }

	[Address(RVA = "0x1B2F780", Offset = "0x1B2E980", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600212E")]
	public TemplateContainer() { }

	[Address(RVA = "0x1B2F710", Offset = "0x1B2E910", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600212F")]
	public TemplateContainer(string templateId) { }

	[Address(RVA = "0x1B2F7E0", Offset = "0x1B2E9E0", Length = "0x70")]
	[CalledBy(Type = typeof(UIDocumentRootElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002130")]
	internal TemplateContainer(string templateId, VisualTreeAsset templateSource) { }

	[Address(RVA = "0x1B2F850", Offset = "0x1B2EA50", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002131")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600212A")]
	public string get_templateId() { }

	[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600212C")]
	public VisualTreeAsset get_templateSource() { }

	[Address(RVA = "0x1B2F870", Offset = "0x1B2EA70", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x600212B")]
	private void set_templateId(string value) { }

	[Address(RVA = "0x1B2F890", Offset = "0x1B2EA90", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600212D")]
	internal void set_templateSource(VisualTreeAsset value) { }

	[Address(RVA = "0x1B2F500", Offset = "0x1B2E700", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002132")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetContentContainer(VisualElement content) { }

}

