namespace Mirror.BouncyCastle.Asn1.X9;

[Token(Token = "0x2000216")]
public abstract class X9ECParametersHolder
{
	[CompilerGenerated]
	[Token(Token = "0x2000217")]
	private sealed class <>c
	{
		[Token(Token = "0x40004E2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004E3")]
		public static Func<X9ECParametersHolder, ECCurve> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x40004E4")]
		public static Func<X9ECParametersHolder, X9ECParameters> <>9__5_0; //Field offset: 0x10

		[Address(RVA = "0x11186A0", Offset = "0x11178A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001238")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001239")]
		public <>c() { }

		[Address(RVA = "0x1118640", Offset = "0x1117840", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600123A")]
		internal ECCurve <get_Curve>b__3_0(X9ECParametersHolder self) { }

		[Address(RVA = "0x1118670", Offset = "0x1117870", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600123B")]
		internal X9ECParameters <get_Parameters>b__5_0(X9ECParametersHolder self) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E0")]
	private ECCurve m_curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E1")]
	private X9ECParameters m_parameters; //Field offset: 0x18

	[Token(Token = "0x170001A6")]
	public ECCurve Curve
	{
		[Address(RVA = "0x111C0B0", Offset = "0x111B2B0", Length = "0x111")]
		[CallerCount(Count = 111)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001233")]
		 get { } //Length: 273
	}

	[Token(Token = "0x170001A7")]
	public X9ECParameters Parameters
	{
		[Address(RVA = "0x111C1D0", Offset = "0x111B3D0", Length = "0x111")]
		[CalledBy(Type = typeof(GMNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(AnssiNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(ECGost3410NamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(X9ECParametersHolder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
		[CalledBy(Type = typeof(SecNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(ECNamedCurveTable), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(CustomNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "FindECCurveByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(X962NamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001234")]
		 get { } //Length: 273
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001237")]
	protected X9ECParametersHolder() { }

	[Address(RVA = "0x111C090", Offset = "0x111B290", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001235")]
	protected override ECCurve CreateCurve() { }

	[Token(Token = "0x6001236")]
	protected abstract X9ECParameters CreateParameters() { }

	[Address(RVA = "0x111C0B0", Offset = "0x111B2B0", Length = "0x111")]
	[CallerCount(Count = 111)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001233")]
	public ECCurve get_Curve() { }

	[Address(RVA = "0x111C1D0", Offset = "0x111B3D0", Length = "0x111")]
	[CalledBy(Type = typeof(X962NamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(ECNamedCurveTable), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(SecNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "FindECCurveByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(ECGost3410NamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(AnssiNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(GMNamedCurves), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(X9ECParametersHolder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001234")]
	public X9ECParameters get_Parameters() { }

}

