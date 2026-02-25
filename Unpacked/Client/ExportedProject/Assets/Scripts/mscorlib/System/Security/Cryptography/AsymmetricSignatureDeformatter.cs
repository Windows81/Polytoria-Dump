namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002DE")]
public abstract class AsymmetricSignatureDeformatter
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001798")]
	protected AsymmetricSignatureDeformatter() { }

	[Token(Token = "0x600179A")]
	public abstract void SetHashAlgorithm(string strName) { }

	[Token(Token = "0x6001799")]
	public abstract void SetKey(AsymmetricAlgorithm key) { }

	[Token(Token = "0x600179B")]
	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

