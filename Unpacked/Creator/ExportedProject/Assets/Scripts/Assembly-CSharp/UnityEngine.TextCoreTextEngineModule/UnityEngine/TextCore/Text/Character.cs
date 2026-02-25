namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000017")]
public class Character : TextElement
{

	[Address(RVA = "0x1A23C00", Offset = "0x1A22E00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000030")]
	public Character() { }

	[Address(RVA = "0x1A23C30", Offset = "0x1A22E30", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6000031")]
	public Character(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	[Address(RVA = "0x1A23B80", Offset = "0x1A22D80", Length = "0x78")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000032")]
	internal Character(uint unicode, uint glyphIndex) { }

}

