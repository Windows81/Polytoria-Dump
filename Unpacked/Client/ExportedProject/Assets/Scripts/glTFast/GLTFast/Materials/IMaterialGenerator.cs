namespace GLTFast.Materials;

[Token(Token = "0x20000DC")]
public interface IMaterialGenerator
{

	[Token(Token = "0x600028E")]
	public Material GenerateMaterial(MaterialBase gltfMaterial, IGltfReadable gltf, bool pointsSupport = false) { }

	[Token(Token = "0x600028D")]
	public Material GetDefaultMaterial(bool pointsSupport = false) { }

	[Token(Token = "0x600028F")]
	public void SetLogger(ICodeLogger logger) { }

}

