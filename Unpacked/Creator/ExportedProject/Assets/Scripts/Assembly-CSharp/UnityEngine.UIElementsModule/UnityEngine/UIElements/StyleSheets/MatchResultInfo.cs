namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000601")]
internal struct MatchResultInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001673")]
	public readonly bool success; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001674")]
	public readonly PseudoStates triggerPseudoMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001675")]
	public readonly PseudoStates dependencyPseudoMask; //Field offset: 0x8

	[Address(RVA = "0x155DDC0", Offset = "0x155CFC0", Length = "0xB")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A6B")]
	public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }

}

