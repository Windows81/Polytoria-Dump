namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x20000AD")]
public struct Resolution
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001ED")]
	private int m_Width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001EE")]
	private int m_Height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001EF")]
	private RefreshRate m_RefreshRate; //Field offset: 0x8

	[Address(RVA = "0x193E120", Offset = "0x193D320", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600039B")]
	public virtual string ToString() { }

}

