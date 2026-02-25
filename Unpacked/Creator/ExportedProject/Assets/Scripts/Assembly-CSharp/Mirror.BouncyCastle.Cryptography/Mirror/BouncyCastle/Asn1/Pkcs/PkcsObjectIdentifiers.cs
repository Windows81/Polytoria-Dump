namespace Mirror.BouncyCastle.Asn1.Pkcs;

[Token(Token = "0x2000259")]
public abstract class PkcsObjectIdentifiers
{
	[Token(Token = "0x400060D")]
	internal static readonly DerObjectIdentifier Pkcs1Oid; //Field offset: 0x0
	[Token(Token = "0x400060E")]
	public static readonly DerObjectIdentifier RsaEncryption; //Field offset: 0x8
	[Token(Token = "0x400060F")]
	public static readonly DerObjectIdentifier MD2WithRsaEncryption; //Field offset: 0x10
	[Token(Token = "0x4000610")]
	public static readonly DerObjectIdentifier MD4WithRsaEncryption; //Field offset: 0x18
	[Token(Token = "0x4000611")]
	public static readonly DerObjectIdentifier MD5WithRsaEncryption; //Field offset: 0x20
	[Token(Token = "0x4000612")]
	public static readonly DerObjectIdentifier Sha1WithRsaEncryption; //Field offset: 0x28
	[Token(Token = "0x4000613")]
	public static readonly DerObjectIdentifier SrsaOaepEncryptionSet; //Field offset: 0x30
	[Token(Token = "0x4000614")]
	public static readonly DerObjectIdentifier IdRsaesOaep; //Field offset: 0x38
	[Token(Token = "0x4000615")]
	public static readonly DerObjectIdentifier IdMgf1; //Field offset: 0x40
	[Token(Token = "0x4000616")]
	public static readonly DerObjectIdentifier IdPSpecified; //Field offset: 0x48
	[Token(Token = "0x4000617")]
	public static readonly DerObjectIdentifier IdRsassaPss; //Field offset: 0x50
	[Token(Token = "0x4000618")]
	public static readonly DerObjectIdentifier Sha256WithRsaEncryption; //Field offset: 0x58
	[Token(Token = "0x4000619")]
	public static readonly DerObjectIdentifier Sha384WithRsaEncryption; //Field offset: 0x60
	[Token(Token = "0x400061A")]
	public static readonly DerObjectIdentifier Sha512WithRsaEncryption; //Field offset: 0x68
	[Token(Token = "0x400061B")]
	public static readonly DerObjectIdentifier Sha224WithRsaEncryption; //Field offset: 0x70
	[Token(Token = "0x400061C")]
	public static readonly DerObjectIdentifier Sha512_224WithRSAEncryption; //Field offset: 0x78
	[Token(Token = "0x400061D")]
	public static readonly DerObjectIdentifier Sha512_256WithRSAEncryption; //Field offset: 0x80
	[Token(Token = "0x400061E")]
	public static readonly DerObjectIdentifier DhKeyAgreement; //Field offset: 0x88
	[Token(Token = "0x400061F")]
	public static readonly DerObjectIdentifier PbeWithMD2AndDesCbc; //Field offset: 0x90
	[Token(Token = "0x4000620")]
	public static readonly DerObjectIdentifier PbeWithMD2AndRC2Cbc; //Field offset: 0x98
	[Token(Token = "0x4000621")]
	public static readonly DerObjectIdentifier PbeWithMD5AndDesCbc; //Field offset: 0xA0
	[Token(Token = "0x4000622")]
	public static readonly DerObjectIdentifier PbeWithMD5AndRC2Cbc; //Field offset: 0xA8
	[Token(Token = "0x4000623")]
	public static readonly DerObjectIdentifier PbeWithSha1AndDesCbc; //Field offset: 0xB0
	[Token(Token = "0x4000624")]
	public static readonly DerObjectIdentifier PbeWithSha1AndRC2Cbc; //Field offset: 0xB8
	[Token(Token = "0x4000625")]
	public static readonly DerObjectIdentifier IdPbeS2; //Field offset: 0xC0
	[Token(Token = "0x4000626")]
	public static readonly DerObjectIdentifier IdPbkdf2; //Field offset: 0xC8
	[Token(Token = "0x4000627")]
	public static readonly DerObjectIdentifier DesEde3Cbc; //Field offset: 0xD0
	[Token(Token = "0x4000628")]
	public static readonly DerObjectIdentifier RC2Cbc; //Field offset: 0xD8
	[Token(Token = "0x4000629")]
	public static readonly DerObjectIdentifier rc4; //Field offset: 0xE0
	[Token(Token = "0x400062A")]
	public static readonly DerObjectIdentifier MD2; //Field offset: 0xE8
	[Token(Token = "0x400062B")]
	public static readonly DerObjectIdentifier MD4; //Field offset: 0xF0
	[Token(Token = "0x400062C")]
	public static readonly DerObjectIdentifier MD5; //Field offset: 0xF8
	[Token(Token = "0x400062D")]
	public static readonly DerObjectIdentifier IdHmacWithSha1; //Field offset: 0x100
	[Token(Token = "0x400062E")]
	public static readonly DerObjectIdentifier IdHmacWithSha224; //Field offset: 0x108
	[Token(Token = "0x400062F")]
	public static readonly DerObjectIdentifier IdHmacWithSha256; //Field offset: 0x110
	[Token(Token = "0x4000630")]
	public static readonly DerObjectIdentifier IdHmacWithSha384; //Field offset: 0x118
	[Token(Token = "0x4000631")]
	public static readonly DerObjectIdentifier IdHmacWithSha512; //Field offset: 0x120
	[Token(Token = "0x4000632")]
	public static readonly DerObjectIdentifier Data; //Field offset: 0x128
	[Token(Token = "0x4000633")]
	public static readonly DerObjectIdentifier SignedData; //Field offset: 0x130
	[Token(Token = "0x4000634")]
	public static readonly DerObjectIdentifier EnvelopedData; //Field offset: 0x138
	[Token(Token = "0x4000635")]
	public static readonly DerObjectIdentifier SignedAndEnvelopedData; //Field offset: 0x140
	[Token(Token = "0x4000636")]
	public static readonly DerObjectIdentifier DigestedData; //Field offset: 0x148
	[Token(Token = "0x4000637")]
	public static readonly DerObjectIdentifier EncryptedData; //Field offset: 0x150
	[Token(Token = "0x4000638")]
	public static readonly DerObjectIdentifier Pkcs9AtEmailAddress; //Field offset: 0x158
	[Token(Token = "0x4000639")]
	public static readonly DerObjectIdentifier Pkcs9AtUnstructuredName; //Field offset: 0x160
	[Token(Token = "0x400063A")]
	public static readonly DerObjectIdentifier Pkcs9AtContentType; //Field offset: 0x168
	[Token(Token = "0x400063B")]
	public static readonly DerObjectIdentifier Pkcs9AtMessageDigest; //Field offset: 0x170
	[Token(Token = "0x400063C")]
	public static readonly DerObjectIdentifier Pkcs9AtSigningTime; //Field offset: 0x178
	[Token(Token = "0x400063D")]
	public static readonly DerObjectIdentifier Pkcs9AtCounterSignature; //Field offset: 0x180
	[Token(Token = "0x400063E")]
	public static readonly DerObjectIdentifier Pkcs9AtChallengePassword; //Field offset: 0x188
	[Token(Token = "0x400063F")]
	public static readonly DerObjectIdentifier Pkcs9AtUnstructuredAddress; //Field offset: 0x190
	[Token(Token = "0x4000640")]
	public static readonly DerObjectIdentifier Pkcs9AtExtendedCertificateAttributes; //Field offset: 0x198
	[Token(Token = "0x4000641")]
	public static readonly DerObjectIdentifier Pkcs9AtSigningDescription; //Field offset: 0x1A0
	[Token(Token = "0x4000642")]
	public static readonly DerObjectIdentifier Pkcs9AtExtensionRequest; //Field offset: 0x1A8
	[Token(Token = "0x4000643")]
	public static readonly DerObjectIdentifier Pkcs9AtSmimeCapabilities; //Field offset: 0x1B0
	[Token(Token = "0x4000644")]
	public static readonly DerObjectIdentifier IdSmime; //Field offset: 0x1B8
	[Token(Token = "0x4000645")]
	public static readonly DerObjectIdentifier Pkcs9AtFriendlyName; //Field offset: 0x1C0
	[Token(Token = "0x4000646")]
	public static readonly DerObjectIdentifier Pkcs9AtLocalKeyID; //Field offset: 0x1C8
	[Token(Token = "0x4000647")]
	public static readonly DerObjectIdentifier X509Certificate; //Field offset: 0x1D0
	[Token(Token = "0x4000648")]
	public static readonly DerObjectIdentifier SdsiCertificate; //Field offset: 0x1D8
	[Token(Token = "0x4000649")]
	public static readonly DerObjectIdentifier X509Crl; //Field offset: 0x1E0
	[Token(Token = "0x400064A")]
	public static readonly DerObjectIdentifier IdAlg; //Field offset: 0x1E8
	[Token(Token = "0x400064B")]
	public static readonly DerObjectIdentifier IdAlgEsdh; //Field offset: 0x1F0
	[Token(Token = "0x400064C")]
	public static readonly DerObjectIdentifier IdAlgCms3DesWrap; //Field offset: 0x1F8
	[Token(Token = "0x400064D")]
	public static readonly DerObjectIdentifier IdAlgCmsRC2Wrap; //Field offset: 0x200
	[Token(Token = "0x400064E")]
	public static readonly DerObjectIdentifier IdAlgZlibCompress; //Field offset: 0x208
	[Token(Token = "0x400064F")]
	public static readonly DerObjectIdentifier IdAlgPwriKek; //Field offset: 0x210
	[Token(Token = "0x4000650")]
	public static readonly DerObjectIdentifier IdAlgSsdh; //Field offset: 0x218
	[Token(Token = "0x4000651")]
	public static readonly DerObjectIdentifier id_aa_cmsAlgorithmProtect; //Field offset: 0x220
	[Token(Token = "0x4000652")]
	public static readonly DerObjectIdentifier IdRsaKem; //Field offset: 0x228
	[Token(Token = "0x4000653")]
	public static readonly DerObjectIdentifier IdAlgAeadChaCha20Poly1305; //Field offset: 0x230
	[Token(Token = "0x4000654")]
	public static readonly DerObjectIdentifier IdAlgHssLmsHashsig; //Field offset: 0x238
	[Token(Token = "0x4000655")]
	public static readonly DerObjectIdentifier PreferSignedData; //Field offset: 0x240
	[Token(Token = "0x4000656")]
	public static readonly DerObjectIdentifier CannotDecryptAny; //Field offset: 0x248
	[Token(Token = "0x4000657")]
	public static readonly DerObjectIdentifier SmimeCapabilitiesVersions; //Field offset: 0x250
	[Token(Token = "0x4000658")]
	public static readonly DerObjectIdentifier IdAAReceiptRequest; //Field offset: 0x258
	[Token(Token = "0x4000659")]
	public static readonly DerObjectIdentifier IdCTAuthData; //Field offset: 0x260
	[Token(Token = "0x400065A")]
	public static readonly DerObjectIdentifier IdCTTstInfo; //Field offset: 0x268
	[Token(Token = "0x400065B")]
	public static readonly DerObjectIdentifier IdCTCompressedData; //Field offset: 0x270
	[Token(Token = "0x400065C")]
	public static readonly DerObjectIdentifier IdCTAuthEnvelopedData; //Field offset: 0x278
	[Token(Token = "0x400065D")]
	public static readonly DerObjectIdentifier IdCTTimestampedData; //Field offset: 0x280
	[Token(Token = "0x400065E")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfOrigin; //Field offset: 0x288
	[Token(Token = "0x400065F")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfReceipt; //Field offset: 0x290
	[Token(Token = "0x4000660")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfDelivery; //Field offset: 0x298
	[Token(Token = "0x4000661")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfSender; //Field offset: 0x2A0
	[Token(Token = "0x4000662")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfApproval; //Field offset: 0x2A8
	[Token(Token = "0x4000663")]
	public static readonly DerObjectIdentifier IdCtiEtsProofOfCreation; //Field offset: 0x2B0
	[Token(Token = "0x4000664")]
	public static readonly DerObjectIdentifier IdAAOid; //Field offset: 0x2B8
	[Token(Token = "0x4000665")]
	public static readonly DerObjectIdentifier IdAAContentHint; //Field offset: 0x2C0
	[Token(Token = "0x4000666")]
	public static readonly DerObjectIdentifier IdAAMsgSigDigest; //Field offset: 0x2C8
	[Token(Token = "0x4000667")]
	public static readonly DerObjectIdentifier IdAAContentReference; //Field offset: 0x2D0
	[Token(Token = "0x4000668")]
	public static readonly DerObjectIdentifier IdAAEncrypKeyPref; //Field offset: 0x2D8
	[Token(Token = "0x4000669")]
	public static readonly DerObjectIdentifier IdAASigningCertificate; //Field offset: 0x2E0
	[Token(Token = "0x400066A")]
	public static readonly DerObjectIdentifier IdAASigningCertificateV2; //Field offset: 0x2E8
	[Token(Token = "0x400066B")]
	public static readonly DerObjectIdentifier IdAAContentIdentifier; //Field offset: 0x2F0
	[Token(Token = "0x400066C")]
	public static readonly DerObjectIdentifier IdAASignatureTimeStampToken; //Field offset: 0x2F8
	[Token(Token = "0x400066D")]
	public static readonly DerObjectIdentifier IdAAEtsSigPolicyID; //Field offset: 0x300
	[Token(Token = "0x400066E")]
	public static readonly DerObjectIdentifier IdAAEtsCommitmentType; //Field offset: 0x308
	[Token(Token = "0x400066F")]
	public static readonly DerObjectIdentifier IdAAEtsSignerLocation; //Field offset: 0x310
	[Token(Token = "0x4000670")]
	public static readonly DerObjectIdentifier IdAAEtsSignerAttr; //Field offset: 0x318
	[Token(Token = "0x4000671")]
	public static readonly DerObjectIdentifier IdAAEtsOtherSigCert; //Field offset: 0x320
	[Token(Token = "0x4000672")]
	public static readonly DerObjectIdentifier IdAAEtsContentTimestamp; //Field offset: 0x328
	[Token(Token = "0x4000673")]
	public static readonly DerObjectIdentifier IdAAEtsCertificateRefs; //Field offset: 0x330
	[Token(Token = "0x4000674")]
	public static readonly DerObjectIdentifier IdAAEtsRevocationRefs; //Field offset: 0x338
	[Token(Token = "0x4000675")]
	public static readonly DerObjectIdentifier IdAAEtsCertValues; //Field offset: 0x340
	[Token(Token = "0x4000676")]
	public static readonly DerObjectIdentifier IdAAEtsRevocationValues; //Field offset: 0x348
	[Token(Token = "0x4000677")]
	public static readonly DerObjectIdentifier IdAAEtsEscTimeStamp; //Field offset: 0x350
	[Token(Token = "0x4000678")]
	public static readonly DerObjectIdentifier IdAAEtsCertCrlTimestamp; //Field offset: 0x358
	[Token(Token = "0x4000679")]
	public static readonly DerObjectIdentifier IdAAEtsArchiveTimestamp; //Field offset: 0x360
	[Token(Token = "0x400067A")]
	public static readonly DerObjectIdentifier IdAADecryptKeyID; //Field offset: 0x368
	[Token(Token = "0x400067B")]
	public static readonly DerObjectIdentifier IdAAImplCryptoAlgs; //Field offset: 0x370
	[Token(Token = "0x400067C")]
	public static readonly DerObjectIdentifier IdAAAsymmDecryptKeyID; //Field offset: 0x378
	[Token(Token = "0x400067D")]
	public static readonly DerObjectIdentifier IdAAImplCompressAlgs; //Field offset: 0x380
	[Token(Token = "0x400067E")]
	public static readonly DerObjectIdentifier IdAACommunityIdentifiers; //Field offset: 0x388
	[Token(Token = "0x400067F")]
	public static readonly DerObjectIdentifier IdSpqEtsUri; //Field offset: 0x390
	[Token(Token = "0x4000680")]
	public static readonly DerObjectIdentifier IdSpqEtsUNotice; //Field offset: 0x398
	[Token(Token = "0x4000681")]
	public static readonly DerObjectIdentifier KeyBag; //Field offset: 0x3A0
	[Token(Token = "0x4000682")]
	public static readonly DerObjectIdentifier Pkcs8ShroudedKeyBag; //Field offset: 0x3A8
	[Token(Token = "0x4000683")]
	public static readonly DerObjectIdentifier CertBag; //Field offset: 0x3B0
	[Token(Token = "0x4000684")]
	public static readonly DerObjectIdentifier CrlBag; //Field offset: 0x3B8
	[Token(Token = "0x4000685")]
	public static readonly DerObjectIdentifier SecretBag; //Field offset: 0x3C0
	[Token(Token = "0x4000686")]
	public static readonly DerObjectIdentifier SafeContentsBag; //Field offset: 0x3C8
	[Token(Token = "0x4000687")]
	public static readonly DerObjectIdentifier PbeWithShaAnd128BitRC4; //Field offset: 0x3D0
	[Token(Token = "0x4000688")]
	public static readonly DerObjectIdentifier PbeWithShaAnd40BitRC4; //Field offset: 0x3D8
	[Token(Token = "0x4000689")]
	public static readonly DerObjectIdentifier PbeWithShaAnd3KeyTripleDesCbc; //Field offset: 0x3E0
	[Token(Token = "0x400068A")]
	public static readonly DerObjectIdentifier PbeWithShaAnd2KeyTripleDesCbc; //Field offset: 0x3E8
	[Token(Token = "0x400068B")]
	public static readonly DerObjectIdentifier PbeWithShaAnd128BitRC2Cbc; //Field offset: 0x3F0
	[Token(Token = "0x400068C")]
	public static readonly DerObjectIdentifier PbewithShaAnd40BitRC2Cbc; //Field offset: 0x3F8

	[Address(RVA = "0x112B1C0", Offset = "0x112A3C0", Length = "0x31BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 35)]
	[Token(Token = "0x6001345")]
	private static PkcsObjectIdentifiers() { }

}

