namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000018")]
internal static class ColorUtilities
{

	[Address(RVA = "0x1A23CD0", Offset = "0x1A22ED0", Length = "0x35")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000033")]
	internal static bool CompareColors(Color32 a, Color32 b) { }

	[Address(RVA = "0x1A23D10", Offset = "0x1A22F10", Length = "0xDA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SaveSpriteVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000034")]
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }

}

