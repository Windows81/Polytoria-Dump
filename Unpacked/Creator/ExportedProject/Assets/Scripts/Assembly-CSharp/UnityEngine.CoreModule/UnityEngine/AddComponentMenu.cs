namespace UnityEngine;

[Token(Token = "0x2000124")]
public sealed class AddComponentMenu : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000515")]
	private string m_AddComponentMenu; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000516")]
	private int m_Ordering; //Field offset: 0x18

	[Address(RVA = "0x195A960", Offset = "0x1959B60", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008D7")]
	public AddComponentMenu(string menuName) { }

	[Address(RVA = "0x13B9AE0", Offset = "0x13B8CE0", Length = "0x42")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D8")]
	public AddComponentMenu(string menuName, int order) { }

}

