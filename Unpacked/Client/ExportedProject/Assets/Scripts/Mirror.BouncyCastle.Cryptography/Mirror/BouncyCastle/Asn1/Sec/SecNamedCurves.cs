namespace Mirror.BouncyCastle.Asn1.Sec;

[Token(Token = "0x2000234")]
public static class SecNamedCurves
{
	[Token(Token = "0x2000235")]
	public class Secp112r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400059F")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11130B0", Offset = "0x11122B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012BC")]
		private static Secp112r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012B9")]
		private Secp112r1Holder() { }

		[Address(RVA = "0x1112E00", Offset = "0x1112000", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012BA")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1112F50", Offset = "0x1112150", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012BB")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000236")]
	public class Secp112r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A0")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11133D0", Offset = "0x11125D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012C0")]
		private static Secp112r2Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012BD")]
		private Secp112r2Holder() { }

		[Address(RVA = "0x1113120", Offset = "0x1112320", Length = "0x14D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012BE")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1113270", Offset = "0x1112470", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012BF")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000237")]
	public class Secp128r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A1")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11136F0", Offset = "0x11128F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012C4")]
		private static Secp128r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012C1")]
		private Secp128r1Holder() { }

		[Address(RVA = "0x1113440", Offset = "0x1112640", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012C2")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1113590", Offset = "0x1112790", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012C3")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000238")]
	public class Secp128r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A2")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1113A10", Offset = "0x1112C10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012C8")]
		private static Secp128r2Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012C5")]
		private Secp128r2Holder() { }

		[Address(RVA = "0x1113760", Offset = "0x1112960", Length = "0x14D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012C6")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11138B0", Offset = "0x1112AB0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012C7")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000239")]
	public class Secp160k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A3")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1113FD0", Offset = "0x11131D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012CC")]
		private static Secp160k1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012C9")]
		private Secp160k1Holder() { }

		[Address(RVA = "0x1113A80", Offset = "0x1112C80", Length = "0x42B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012CA")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1113EB0", Offset = "0x11130B0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012CB")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023A")]
	public class Secp160r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A4")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11142F0", Offset = "0x11134F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012D0")]
		private static Secp160r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012CD")]
		private Secp160r1Holder() { }

		[Address(RVA = "0x1114040", Offset = "0x1113240", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012CE")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1114190", Offset = "0x1113390", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012CF")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023B")]
	public class Secp160r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A5")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1114610", Offset = "0x1113810", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012D4")]
		private static Secp160r2Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012D1")]
		private Secp160r2Holder() { }

		[Address(RVA = "0x1114360", Offset = "0x1113560", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012D2")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11144B0", Offset = "0x11136B0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012D3")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023C")]
	public class Secp192k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A6")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1114BD0", Offset = "0x1113DD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012D8")]
		private static Secp192k1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012D5")]
		private Secp192k1Holder() { }

		[Address(RVA = "0x1114680", Offset = "0x1113880", Length = "0x42B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012D6")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1114AB0", Offset = "0x1113CB0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012D7")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023D")]
	public class Secp192r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A7")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1114EF0", Offset = "0x11140F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012DC")]
		private static Secp192r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012D9")]
		private Secp192r1Holder() { }

		[Address(RVA = "0x1114C40", Offset = "0x1113E40", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012DA")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1114D90", Offset = "0x1113F90", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012DB")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023E")]
	public class Secp224k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A8")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11154B0", Offset = "0x11146B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012E0")]
		private static Secp224k1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012DD")]
		private Secp224k1Holder() { }

		[Address(RVA = "0x1114F60", Offset = "0x1114160", Length = "0x42B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012DE")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1115390", Offset = "0x1114590", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012DF")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200023F")]
	public class Secp224r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005A9")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11157D0", Offset = "0x11149D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012E4")]
		private static Secp224r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012E1")]
		private Secp224r1Holder() { }

		[Address(RVA = "0x1115520", Offset = "0x1114720", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012E2")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1115670", Offset = "0x1114870", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012E3")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000240")]
	public class Secp256k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AA")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1115D90", Offset = "0x1114F90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012E8")]
		private static Secp256k1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012E5")]
		private Secp256k1Holder() { }

		[Address(RVA = "0x1115840", Offset = "0x1114A40", Length = "0x42B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012E6")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1115C70", Offset = "0x1114E70", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012E7")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000241")]
	public class Secp256r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AB")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11160B0", Offset = "0x11152B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012EC")]
		private static Secp256r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012E9")]
		private Secp256r1Holder() { }

		[Address(RVA = "0x1115E00", Offset = "0x1115000", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012EA")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1115F50", Offset = "0x1115150", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012EB")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000242")]
	public class Secp384r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AC")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1132480", Offset = "0x1131680", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F0")]
		private static Secp384r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012ED")]
		private Secp384r1Holder() { }

		[Address(RVA = "0x11321C0", Offset = "0x11313C0", Length = "0x156")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012EE")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1132320", Offset = "0x1131520", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012EF")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000243")]
	public class Secp521r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AD")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11327B0", Offset = "0x11319B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F4")]
		private static Secp521r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F1")]
		private Secp521r1Holder() { }

		[Address(RVA = "0x11324F0", Offset = "0x11316F0", Length = "0x156")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F2")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1132650", Offset = "0x1131850", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012F3")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000244")]
	public class Sect113r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AE")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1132AC0", Offset = "0x1131CC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F8")]
		private static Sect113r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F5")]
		private Sect113r1Holder() { }

		[Address(RVA = "0x1132820", Offset = "0x1131A20", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012F6")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1132960", Offset = "0x1131B60", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012F7")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000245")]
	public class Sect113r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005AF")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1132DD0", Offset = "0x1131FD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012FC")]
		private static Sect113r2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012F9")]
		private Sect113r2Holder() { }

		[Address(RVA = "0x1132B30", Offset = "0x1131D30", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012FA")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1132C70", Offset = "0x1131E70", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012FB")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000246")]
	public class Sect131r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B0")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11330F0", Offset = "0x11322F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001300")]
		private static Sect131r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012FD")]
		private Sect131r1Holder() { }

		[Address(RVA = "0x1132E40", Offset = "0x1132040", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012FE")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1132F90", Offset = "0x1132190", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012FF")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000247")]
	public class Sect131r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B1")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1133410", Offset = "0x1132610", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001304")]
		private static Sect131r2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001301")]
		private Sect131r2Holder() { }

		[Address(RVA = "0x1133160", Offset = "0x1132360", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001302")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11332B0", Offset = "0x11324B0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001303")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000248")]
	public class Sect163k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B2")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11336D0", Offset = "0x11328D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001308")]
		private static Sect163k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001305")]
		private Sect163k1Holder() { }

		[Address(RVA = "0x1133480", Offset = "0x1132680", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001306")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11335B0", Offset = "0x11327B0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001307")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000249")]
	public class Sect163r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B3")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11339F0", Offset = "0x1132BF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600130C")]
		private static Sect163r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001309")]
		private Sect163r1Holder() { }

		[Address(RVA = "0x1133740", Offset = "0x1132940", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600130A")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1133890", Offset = "0x1132A90", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600130B")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024A")]
	public class Sect163r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B4")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1133D10", Offset = "0x1132F10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001310")]
		private static Sect163r2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600130D")]
		private Sect163r2Holder() { }

		[Address(RVA = "0x1133A60", Offset = "0x1132C60", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600130E")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1133BB0", Offset = "0x1132DB0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600130F")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024B")]
	public class Sect193r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B5")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1134020", Offset = "0x1133220", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001314")]
		private static Sect193r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001311")]
		private Sect193r1Holder() { }

		[Address(RVA = "0x1133D80", Offset = "0x1132F80", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001312")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1133EC0", Offset = "0x11330C0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001313")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024C")]
	public class Sect193r2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B6")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1134330", Offset = "0x1133530", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001318")]
		private static Sect193r2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001315")]
		private Sect193r2Holder() { }

		[Address(RVA = "0x1134090", Offset = "0x1133290", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001316")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11341D0", Offset = "0x11333D0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001317")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024D")]
	public class Sect233k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B7")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11345E0", Offset = "0x11337E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600131C")]
		private static Sect233k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001319")]
		private Sect233k1Holder() { }

		[Address(RVA = "0x11343A0", Offset = "0x11335A0", Length = "0x11B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600131A")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11344C0", Offset = "0x11336C0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600131B")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024E")]
	public class Sect233r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B8")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11348F0", Offset = "0x1133AF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001320")]
		private static Sect233r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131D")]
		private Sect233r1Holder() { }

		[Address(RVA = "0x1134650", Offset = "0x1133850", Length = "0x137")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600131E")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1134790", Offset = "0x1133990", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600131F")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200024F")]
	public class Sect239k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005B9")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1134BA0", Offset = "0x1133DA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001324")]
		private static Sect239k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001321")]
		private Sect239k1Holder() { }

		[Address(RVA = "0x1134960", Offset = "0x1133B60", Length = "0x11B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001322")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1134A80", Offset = "0x1133C80", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001323")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000250")]
	public class Sect283k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BA")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1134E60", Offset = "0x1134060", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001328")]
		private static Sect283k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001325")]
		private Sect283k1Holder() { }

		[Address(RVA = "0x1134C10", Offset = "0x1133E10", Length = "0x12B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001326")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1134D40", Offset = "0x1133F40", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001327")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000251")]
	public class Sect283r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BB")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1135180", Offset = "0x1134380", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600132C")]
		private static Sect283r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001329")]
		private Sect283r1Holder() { }

		[Address(RVA = "0x1134ED0", Offset = "0x11340D0", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600132A")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1135020", Offset = "0x1134220", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600132B")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000252")]
	public class Sect409k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BC")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1135430", Offset = "0x1134630", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001330")]
		private static Sect409k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600132D")]
		private Sect409k1Holder() { }

		[Address(RVA = "0x11351F0", Offset = "0x11343F0", Length = "0x11B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600132E")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1135310", Offset = "0x1134510", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600132F")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000253")]
	public class Sect409r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BD")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1135740", Offset = "0x1134940", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001334")]
		private static Sect409r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001331")]
		private Sect409r1Holder() { }

		[Address(RVA = "0x11354A0", Offset = "0x11346A0", Length = "0x137")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001332")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11355E0", Offset = "0x11347E0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001333")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000254")]
	public class Sect571k1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BE")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1135A00", Offset = "0x1134C00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001338")]
		private static Sect571k1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001335")]
		private Sect571k1Holder() { }

		[Address(RVA = "0x11357B0", Offset = "0x11349B0", Length = "0x12B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001336")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11358E0", Offset = "0x1134AE0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001337")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000255")]
	public class Sect571r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40005BF")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1135D20", Offset = "0x1134F20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600133C")]
		private static Sect571r1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001339")]
		private Sect571r1Holder() { }

		[Address(RVA = "0x1135A70", Offset = "0x1134C70", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SecNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600133A")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1135BC0", Offset = "0x1134DC0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600133B")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x400059C")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x0
	[Token(Token = "0x400059D")]
	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves; //Field offset: 0x8
	[Token(Token = "0x400059E")]
	private static readonly Dictionary<DerObjectIdentifier, String> names; //Field offset: 0x10

	[Address(RVA = "0x1111EC0", Offset = "0x11110C0", Length = "0xF3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecNamedCurves), Member = "DefineCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier), typeof(X9ECParametersHolder)}, ReturnType = typeof(void))]
	[Token(Token = "0x60012B6")]
	private static SecNamedCurves() { }

	[Address(RVA = "0x1111A70", Offset = "0x1110C70", Length = "0xD4")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X9ECPoint), Member = "get_Point", ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B1")]
	private static X9ECPoint ConfigureBasepoint(ECCurve curve, string encoding) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012B2")]
	private static ECCurve ConfigureCurve(ECCurve curve) { }

	[Address(RVA = "0x1111B50", Offset = "0x1110D50", Length = "0xAF")]
	[CalledBy(Type = typeof(Secp160k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp192k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp224k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp256k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GlvTypeBEndomorphism), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Config), Member = "SetEndomorphism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism)}, ReturnType = typeof(Config))]
	[Calls(Type = typeof(Config), Member = "Create", ReturnType = typeof(ECCurve))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B3")]
	private static ECCurve ConfigureCurveGlv(ECCurve c, GlvTypeBParameters p) { }

	[Address(RVA = "0x1111C00", Offset = "0x1110E00", Length = "0xFE")]
	[CalledBy(Type = typeof(SecNamedCurves), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B5")]
	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder) { }

	[Address(RVA = "0x1111D00", Offset = "0x1110F00", Length = "0x87")]
	[CallerCount(Count = 89)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60012B4")]
	private static BigInteger FromHex(string hex) { }

	[Address(RVA = "0x1111E00", Offset = "0x1111000", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x60012B7")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

	[Address(RVA = "0x1111D90", Offset = "0x1110F90", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x60012B8")]
	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid) { }

}

