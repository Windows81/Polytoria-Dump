namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Obsolete("TextValueFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x200015B")]
public class TextValueFieldTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E3")]
	private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E4")]
	private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E5")]
	private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E6")]
	private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0

	[Address(RVA = "0xFEDB40", Offset = "0xFECD40", Length = "0x1C4")]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Double, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA5")]
	public TextValueFieldTraits`2() { }

	[Address(RVA = "0xFEB850", Offset = "0xFEAA50", Length = "0x2FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA4")]
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

