namespace UnityEngine.UIElements;

[Obsolete("UxmlRootElementTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B1")]
public class UxmlRootElementTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FD6")]
	protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FD7")]
	private UxmlStringAttributeDescription m_Class; //Field offset: 0x20

	[Address(RVA = "0x1B52CB0", Offset = "0x1B51EB0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023A3")]
	public UxmlRootElementTraits() { }

}

