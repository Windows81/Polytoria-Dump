namespace TMPro;

[Token(Token = "0x200002C")]
public class TMP_Character : TMP_TextElement
{

	[Address(RVA = "0x1889CB0", Offset = "0x1888EB0", Length = "0x21")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000154")]
	public TMP_Character() { }

	[Address(RVA = "0x1889D40", Offset = "0x1888F40", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000155")]
	public TMP_Character(uint unicode, Glyph glyph) { }

	[Address(RVA = "0x1889DC0", Offset = "0x1888FC0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000156")]
	public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	[Address(RVA = "0x1889CE0", Offset = "0x1888EE0", Length = "0x5F")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000157")]
	internal TMP_Character(uint unicode, uint glyphIndex) { }

}

