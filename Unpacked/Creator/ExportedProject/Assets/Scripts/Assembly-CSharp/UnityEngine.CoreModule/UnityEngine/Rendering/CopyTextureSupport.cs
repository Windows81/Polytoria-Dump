namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20002C0")]
public enum CopyTextureSupport
{
	None = 0,
	Basic = 1,
	Copy3D = 2,
	DifferentTypes = 4,
	TextureToRT = 8,
	RTToTexture = 16,
}

