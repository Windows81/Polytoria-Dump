namespace UnityEngine.UIElements;

[Obsolete("UxmlAttributeOverridesTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B7")]
public class UxmlAttributeOverridesTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FDE")]
	private UxmlStringAttributeDescription m_ElementName; //Field offset: 0x18

	[Address(RVA = "0x1B50780", Offset = "0x1B4F980", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023B2")]
	public UxmlAttributeOverridesTraits() { }

}

