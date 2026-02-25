namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200007F")]
public static class HaltonSeq
{

	[Address(RVA = "0x183F600", Offset = "0x183E800", Length = "0x53")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E6")]
	public static float Get(int index, int radix) { }

}

