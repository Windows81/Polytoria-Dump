namespace GLTFast;

[Token(Token = "0x200003D")]
public interface IGltfReadable
{

	[Token(Token = "0x600010B")]
	public Material GetDefaultMaterial() { }

	[Token(Token = "0x600010A")]
	public Material GetMaterial(int index = 0) { }

	[Token(Token = "0x600010E")]
	public CameraBase GetSourceCamera(uint index) { }

	[Token(Token = "0x6000110")]
	public LightPunctual GetSourceLightPunctual(uint index) { }

	[Token(Token = "0x600010F")]
	public TextureBase GetSourceTexture(int index = 0) { }

	[Token(Token = "0x600010C")]
	public Texture2D GetTexture(int index = 0) { }

	[Token(Token = "0x600010D")]
	public bool IsTextureYFlipped(int index = 0) { }

}

