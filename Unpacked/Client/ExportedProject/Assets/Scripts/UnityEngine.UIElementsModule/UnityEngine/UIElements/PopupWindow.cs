namespace UnityEngine.UIElements;

[Token(Token = "0x2000127")]
public class PopupWindow : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000128")]
	internal class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
	{

		[Address(RVA = "0x1C2C410", Offset = "0x1C2B610", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000930")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000129")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x1C16720", Offset = "0x1C15920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000931")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40005BA")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40005BB")]
	public static readonly string contentUssClassName; //Field offset: 0x8
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x40005B9")]
	private VisualElement m_ContentContainer; //Field offset: 0x3D8

	[Token(Token = "0x1700018A")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1BD97A0", Offset = "0x1BD89A0", Length = "0xA")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092E")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1C19A80", Offset = "0x1C18C80", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600092F")]
	private static PopupWindow() { }

	[Address(RVA = "0x1C19B40", Offset = "0x1C18D40", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600092D")]
	public PopupWindow() { }

	[Address(RVA = "0x1BD97A0", Offset = "0x1BD89A0", Length = "0xA")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092E")]
	public virtual VisualElement get_contentContainer() { }

}

