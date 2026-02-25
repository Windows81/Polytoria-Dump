namespace UnityEngine.UIElements;

[Obsolete("UxmlStyleTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B3")]
public class UxmlStyleTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FD8")]
	private UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FD9")]
	private UxmlStringAttributeDescription m_Path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FDA")]
	private UxmlStringAttributeDescription m_Src; //Field offset: 0x28

	[Address(RVA = "0x1B53290", Offset = "0x1B52490", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023A8")]
	public UxmlStyleTraits() { }

}

