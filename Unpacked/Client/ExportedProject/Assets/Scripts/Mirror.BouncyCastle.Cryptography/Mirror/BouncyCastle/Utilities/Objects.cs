namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x200000B")]
public static class Objects
{

	[Address(RVA = "0x71CEC0", Offset = "0x71C0C0", Length = "0x84")]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "GetID", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ECDomainParameters), Member = "get_HInv", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Ed25519PrivateKeyParameters), Member = "GeneratePublicKey", ReturnType = typeof(Ed25519PublicKeyParameters))]
	[CalledBy(Type = typeof(Ed448PrivateKeyParameters), Member = "GeneratePublicKey", ReturnType = typeof(Ed448PublicKeyParameters))]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "GetID", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Asn1RelativeOid), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[CalledBy(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	internal static TValue EnsureSingletonInitialized(ref TValue value, TArg arg, Func<TArg, TValue> initialize) { }

	[Address(RVA = "0x10BD530", Offset = "0x10BC730", Length = "0x1C")]
	[CalledBy(Type = typeof(DerExternal), Member = "Asn1GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public static int GetHashCode(object obj) { }

}

