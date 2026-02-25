namespace UnityEngine.UIElements;

[Token(Token = "0x2000018")]
public class BindableElement : VisualElement, IBindable
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000019")]
	internal class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
	{

		[Address(RVA = "0x1AB73A0", Offset = "0x1AB65A0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000078")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200001A")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000030")]
		private UxmlStringAttributeDescription m_PropertyPath; //Field offset: 0x88

		[Address(RVA = "0x1AB7580", Offset = "0x1AB6780", Length = "0x96")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000079")]
		public UxmlTraits() { }

		[Address(RVA = "0x1AB73E0", Offset = "0x1AB65E0", Length = "0x190")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600007A")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400002D")]
	internal const string k_BindingPathTooltip = "Default method to define a path to a serialized property. Most often used for Editor extensions and inspectors."; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400002E")]
	private IBinding <binding>k__BackingField; //Field offset: 0x2D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400002F")]
	private string <bindingPath>k__BackingField; //Field offset: 0x2D8

	[Token(Token = "0x17000019")]
	public override IBinding binding
	{
		[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000075")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001A")]
	public override string bindingPath
	{
		[Address(RVA = "0x1A934C0", Offset = "0x1A926C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000076")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x1A93470", Offset = "0x1A92670", Length = "0x49")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemplateContainer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemplateContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemplateContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000077")]
	public BindableElement() { }

	[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	public override IBinding get_binding() { }

	[Address(RVA = "0x1A934C0", Offset = "0x1A926C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000076")]
	public override void set_bindingPath(string value) { }

}

