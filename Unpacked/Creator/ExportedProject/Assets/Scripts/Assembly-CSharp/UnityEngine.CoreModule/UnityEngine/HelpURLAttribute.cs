namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x200012B")]
[UsedByNativeCode]
public class HelpURLAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400051D")]
	internal readonly string m_Url; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400051E")]
	internal readonly bool m_Dispatcher; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400051F")]
	internal readonly string m_DispatchingFieldName; //Field offset: 0x20

	[Address(RVA = "0x19634A0", Offset = "0x19626A0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008E3")]
	public HelpURLAttribute(string url) { }

}

