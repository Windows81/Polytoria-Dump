namespace GLTFast.Addons;

[Token(Token = "0x200014A")]
public abstract class ImportAddonInstance : IDisposable
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000380")]
	protected ImportAddonInstance() { }

	[Token(Token = "0x600037F")]
	public abstract void Dispose() { }

	[Token(Token = "0x600037E")]
	public abstract void Inject(IInstantiator instantiator) { }

	[Token(Token = "0x600037D")]
	public abstract bool SupportsGltfExtension(string extensionName) { }

}

