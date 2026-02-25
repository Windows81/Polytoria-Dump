namespace TMPro;

[Token(Token = "0x2000033")]
public static class TMP_Compatibility
{
	[Token(Token = "0x2000034")]
	internal enum AnchorPositions
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
		BaseLine = 9,
		None = 10,
	}


	[Address(RVA = "0x188A000", Offset = "0x1889200", Length = "0xB0")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }

}

