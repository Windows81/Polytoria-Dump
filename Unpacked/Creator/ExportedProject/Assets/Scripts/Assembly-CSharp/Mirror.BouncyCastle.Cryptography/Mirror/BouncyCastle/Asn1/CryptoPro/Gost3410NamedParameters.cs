namespace Mirror.BouncyCastle.Asn1.CryptoPro;

[Token(Token = "0x200026F")]
public static class Gost3410NamedParameters
{
	[Token(Token = "0x40007A9")]
	private static readonly Gost3410ParamSetParameters cryptoProA; //Field offset: 0x0
	[Token(Token = "0x40007AA")]
	private static readonly Gost3410ParamSetParameters cryptoProB; //Field offset: 0x8
	[Token(Token = "0x40007AB")]
	private static readonly Gost3410ParamSetParameters cryptoProXchA; //Field offset: 0x10
	[Token(Token = "0x40007AC")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x18
	[Token(Token = "0x40007AD")]
	private static readonly Dictionary<DerObjectIdentifier, Gost3410ParamSetParameters> parameters; //Field offset: 0x20

	[Address(RVA = "0x1125920", Offset = "0x1124B20", Length = "0x518")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3410ParamSetParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3410NamedParameters), Member = "DefineParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier), typeof(Gost3410ParamSetParameters)}, ReturnType = typeof(void))]
	[Token(Token = "0x600139C")]
	private static Gost3410NamedParameters() { }

	[Address(RVA = "0x11257E0", Offset = "0x11249E0", Length = "0xCA")]
	[CalledBy(Type = typeof(Gost3410NamedParameters), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600139B")]
	private static void DefineParameters(string name, DerObjectIdentifier oid, Gost3410ParamSetParameters parameterSet) { }

	[Address(RVA = "0x11258B0", Offset = "0x1124AB0", Length = "0x6C")]
	[CalledBy(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x600139D")]
	public static Gost3410ParamSetParameters GetByOid(DerObjectIdentifier oid) { }

}

