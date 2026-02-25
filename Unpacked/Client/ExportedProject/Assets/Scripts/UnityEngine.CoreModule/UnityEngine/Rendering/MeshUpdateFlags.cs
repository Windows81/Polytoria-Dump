namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20002AA")]
public enum MeshUpdateFlags
{
	Default = 0,
	DontValidateIndices = 1,
	DontResetBoneBounds = 2,
	DontNotifyMeshUsers = 4,
	DontRecalculateBounds = 8,
	DontValidateLodRanges = 16,
}

