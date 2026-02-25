namespace Mirror.BouncyCastle.Asn1.X9;

[Token(Token = "0x20001FA")]
public class ECNamedCurveTable
{

	[Address(RVA = "0x110E420", Offset = "0x110D620", Length = "0x301")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "FindECCurveByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Calls(Type = typeof(AnssiNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[Calls(Type = typeof(ECGost3410NamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[Calls(Type = typeof(GMNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x60011B8")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

}

