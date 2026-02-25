namespace UnityEngine.UI;

[Obsolete("Use BaseMeshEffect instead", True)]
[Token(Token = "0x2000082")]
public abstract class BaseVertexEffect
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000534")]
	protected BaseVertexEffect() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	[Token(Token = "0x6000533")]
	public abstract void ModifyVertices(List<UIVertex> vertices) { }

}

