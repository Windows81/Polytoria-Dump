namespace TMPro;

[Token(Token = "0x200004D")]
public class TMP_Glyph : TMP_TextElement_Legacy
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029A")]
	public TMP_Glyph() { }

	[Address(RVA = "0x18A2D70", Offset = "0x18A1F70", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000299")]
	public static TMP_Glyph Clone(TMP_Glyph source) { }

}

