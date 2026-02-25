namespace Mirror.BouncyCastle.Asn1.Anssi;

[Token(Token = "0x2000273")]
public static class AnssiNamedCurves
{
	[Token(Token = "0x2000274")]
	public class Frp256v1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40007BB")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1122A00", Offset = "0x1121C00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60013B6")]
		private static Frp256v1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B3")]
		private Frp256v1Holder() { }

		[Address(RVA = "0x11226F0", Offset = "0x11218F0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AnssiNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60013B4")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1122840", Offset = "0x1121A40", Length = "0x1B5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X9ECPoint), Member = "get_Point", ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60013B5")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x40007B8")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x0
	[Token(Token = "0x40007B9")]
	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves; //Field offset: 0x8
	[Token(Token = "0x40007BA")]
	private static readonly Dictionary<DerObjectIdentifier, String> names; //Field offset: 0x10

	[Address(RVA = "0x11200A0", Offset = "0x111F2A0", Length = "0x31A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013B0")]
	private static AnssiNamedCurves() { }

	[Address(RVA = "0x111FD00", Offset = "0x111EF00", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X9ECPoint), Member = "get_Point", ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013AC")]
	private static X9ECPoint ConfigureBasepoint(ECCurve curve, string encoding) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AD")]
	private static ECCurve ConfigureCurve(ECCurve curve) { }

	[Address(RVA = "0x111FDE0", Offset = "0x111EFE0", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013AF")]
	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder) { }

	[Address(RVA = "0x111FEE0", Offset = "0x111F0E0", Length = "0x87")]
	[CalledBy(Type = typeof(Frp256v1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60013AE")]
	private static BigInteger FromHex(string hex) { }

	[Address(RVA = "0x111FFE0", Offset = "0x111F1E0", Length = "0xB2")]
	[CalledBy(Type = typeof(ECNamedCurveTable), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x60013B1")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

	[Address(RVA = "0x111FF70", Offset = "0x111F170", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x60013B2")]
	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid) { }

}

