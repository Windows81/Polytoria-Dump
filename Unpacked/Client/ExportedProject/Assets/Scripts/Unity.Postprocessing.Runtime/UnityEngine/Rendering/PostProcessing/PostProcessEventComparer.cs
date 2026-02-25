namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000066")]
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
{

	[Address(RVA = "0x1843DF0", Offset = "0x1842FF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000122")]
	public override bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	[Address(RVA = "0x32B1B0", Offset = "0x32A3B0", Length = "0x3")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000123")]
	public override int GetHashCode(PostProcessEvent obj) { }

}

