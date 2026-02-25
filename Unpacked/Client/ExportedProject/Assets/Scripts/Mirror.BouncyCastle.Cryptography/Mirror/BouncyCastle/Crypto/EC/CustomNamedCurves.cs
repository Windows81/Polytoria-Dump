namespace Mirror.BouncyCastle.Crypto.EC;

[Token(Token = "0x2000159")]
public static class CustomNamedCurves
{
	[Token(Token = "0x200015A")]
	public class SecP128R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F1")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F22E0", Offset = "0x11F14E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CBF")]
		private static SecP128R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CBC")]
		private SecP128R1Holder() { }

		[Address(RVA = "0x11F2110", Offset = "0x11F1310", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP128R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CBD")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F2180", Offset = "0x11F1380", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CBE")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200015B")]
	public class SecP160K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F2")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F27E0", Offset = "0x11F19E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CC3")]
		private static SecP160K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC0")]
		private SecP160K1Holder() { }

		[Address(RVA = "0x11F2350", Offset = "0x11F1550", Length = "0x36C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecP160K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CC1")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F26C0", Offset = "0x11F18C0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CC2")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200015C")]
	public class SecP160R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F3")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F2A20", Offset = "0x11F1C20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CC7")]
		private static SecP160R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC4")]
		private SecP160R1Holder() { }

		[Address(RVA = "0x11F2850", Offset = "0x11F1A50", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP160R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CC5")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F28C0", Offset = "0x11F1AC0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CC6")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200015D")]
	public class SecP160R2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F4")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F2C60", Offset = "0x11F1E60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CCB")]
		private static SecP160R2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC8")]
		private SecP160R2Holder() { }

		[Address(RVA = "0x11F2A90", Offset = "0x11F1C90", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP160R2Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CC9")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F2B00", Offset = "0x11F1D00", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CCA")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200015E")]
	public class SecP192K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F5")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F3160", Offset = "0x11F2360", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CCF")]
		private static SecP192K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCC")]
		private SecP192K1Holder() { }

		[Address(RVA = "0x11F2CD0", Offset = "0x11F1ED0", Length = "0x36C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecP192K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CCD")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F3040", Offset = "0x11F2240", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CCE")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200015F")]
	public class SecP192R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F6")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F33A0", Offset = "0x11F25A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CD3")]
		private static SecP192R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CD0")]
		private SecP192R1Holder() { }

		[Address(RVA = "0x11F31D0", Offset = "0x11F23D0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP192R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CD1")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F3240", Offset = "0x11F2440", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CD2")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000160")]
	public class SecP224K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F7")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F38A0", Offset = "0x11F2AA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CD7")]
		private static SecP224K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CD4")]
		private SecP224K1Holder() { }

		[Address(RVA = "0x11F3410", Offset = "0x11F2610", Length = "0x36C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecP224K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CD5")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F3780", Offset = "0x11F2980", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CD6")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000161")]
	public class SecP224R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F8")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F3AE0", Offset = "0x11F2CE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CDB")]
		private static SecP224R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CD8")]
		private SecP224R1Holder() { }

		[Address(RVA = "0x11F3910", Offset = "0x11F2B10", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP224R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CD9")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F3980", Offset = "0x11F2B80", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CDA")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000162")]
	public class SecP256K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002F9")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F3FE0", Offset = "0x11F31E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CDF")]
		private static SecP256K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CDC")]
		private SecP256K1Holder() { }

		[Address(RVA = "0x11F3B50", Offset = "0x11F2D50", Length = "0x36C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScalarSplitParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger[]), typeof(BigInteger[]), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecP256K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CDD")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F3EC0", Offset = "0x11F30C0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CDE")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000163")]
	public class SecP256R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FA")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F4220", Offset = "0x11F3420", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CE3")]
		private static SecP256R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE0")]
		private SecP256R1Holder() { }

		[Address(RVA = "0x11F4050", Offset = "0x11F3250", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP256R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CE1")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F40C0", Offset = "0x11F32C0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CE2")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000164")]
	public class SecP384R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FB")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F4460", Offset = "0x11F3660", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CE7")]
		private static SecP384R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE4")]
		private SecP384R1Holder() { }

		[Address(RVA = "0x11F4290", Offset = "0x11F3490", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP384R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CE5")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F4300", Offset = "0x11F3500", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CE6")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000165")]
	public class SecP521R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FC")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11F46A0", Offset = "0x11F38A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CEB")]
		private static SecP521R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE8")]
		private SecP521R1Holder() { }

		[Address(RVA = "0x11F44D0", Offset = "0x11F36D0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecP521R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000CE9")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11F4540", Offset = "0x11F3740", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CEA")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000166")]
	public class SecT113R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FD")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1208950", Offset = "0x1207B50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CEF")]
		private static SecT113R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CEC")]
		private SecT113R1Holder() { }

		[Address(RVA = "0x1208780", Offset = "0x1207980", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT113R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CED")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x12087F0", Offset = "0x12079F0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CEE")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000167")]
	public class SecT113R2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FE")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1208B90", Offset = "0x1207D90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CF3")]
		private static SecT113R2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF0")]
		private SecT113R2Holder() { }

		[Address(RVA = "0x12089C0", Offset = "0x1207BC0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT113R2Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CF1")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1208A30", Offset = "0x1207C30", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CF2")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000168")]
	public class SecT131R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x40002FF")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1208DD0", Offset = "0x1207FD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CF7")]
		private static SecT131R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF4")]
		private SecT131R1Holder() { }

		[Address(RVA = "0x1208C00", Offset = "0x1207E00", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT131R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CF5")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1208C70", Offset = "0x1207E70", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CF6")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000169")]
	public class SecT131R2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000300")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209010", Offset = "0x1208210", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CFB")]
		private static SecT131R2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF8")]
		private SecT131R2Holder() { }

		[Address(RVA = "0x1208E40", Offset = "0x1208040", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT131R2Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CF9")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1208EB0", Offset = "0x12080B0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CFA")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016A")]
	public class SecT163K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000301")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209210", Offset = "0x1208410", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CFF")]
		private static SecT163K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CFC")]
		private SecT163K1Holder() { }

		[Address(RVA = "0x1209080", Offset = "0x1208280", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT163K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CFD")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x12090F0", Offset = "0x12082F0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CFE")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016B")]
	public class SecT163R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000302")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209450", Offset = "0x1208650", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D03")]
		private static SecT163R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D00")]
		private SecT163R1Holder() { }

		[Address(RVA = "0x1209280", Offset = "0x1208480", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT163R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D01")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x12092F0", Offset = "0x12084F0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D02")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016C")]
	public class SecT163R2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000303")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209690", Offset = "0x1208890", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D07")]
		private static SecT163R2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D04")]
		private SecT163R2Holder() { }

		[Address(RVA = "0x12094C0", Offset = "0x12086C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT163R2Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D05")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1209530", Offset = "0x1208730", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D06")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016D")]
	public class SecT193R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000304")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x12098D0", Offset = "0x1208AD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D0B")]
		private static SecT193R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D08")]
		private SecT193R1Holder() { }

		[Address(RVA = "0x1209700", Offset = "0x1208900", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT193R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D09")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1209770", Offset = "0x1208970", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D0A")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016E")]
	public class SecT193R2Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000305")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209B10", Offset = "0x1208D10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D0F")]
		private static SecT193R2Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0C")]
		private SecT193R2Holder() { }

		[Address(RVA = "0x1209940", Offset = "0x1208B40", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT193R2Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D0D")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x12099B0", Offset = "0x1208BB0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D0E")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200016F")]
	public class SecT233K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000306")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209D10", Offset = "0x1208F10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D13")]
		private static SecT233K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D10")]
		private SecT233K1Holder() { }

		[Address(RVA = "0x1209B80", Offset = "0x1208D80", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT233K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D11")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1209BF0", Offset = "0x1208DF0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D12")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000170")]
	public class SecT233R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000307")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1209F50", Offset = "0x1209150", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D17")]
		private static SecT233R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D14")]
		private SecT233R1Holder() { }

		[Address(RVA = "0x1209D80", Offset = "0x1208F80", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT233R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D15")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1209DF0", Offset = "0x1208FF0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D16")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000171")]
	public class SecT239K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000308")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120A150", Offset = "0x1209350", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D1B")]
		private static SecT239K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D18")]
		private SecT239K1Holder() { }

		[Address(RVA = "0x1209FC0", Offset = "0x12091C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT239K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D19")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120A030", Offset = "0x1209230", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D1A")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000172")]
	public class SecT283K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000309")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120A350", Offset = "0x1209550", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D1F")]
		private static SecT283K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1C")]
		private SecT283K1Holder() { }

		[Address(RVA = "0x120A1C0", Offset = "0x12093C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT283K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D1D")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120A230", Offset = "0x1209430", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D1E")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000173")]
	public class SecT283R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030A")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120A590", Offset = "0x1209790", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D23")]
		private static SecT283R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D20")]
		private SecT283R1Holder() { }

		[Address(RVA = "0x120A3C0", Offset = "0x12095C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT283R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D21")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120A430", Offset = "0x1209630", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D22")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000174")]
	public class SecT409K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030B")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120A790", Offset = "0x1209990", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D27")]
		private static SecT409K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D24")]
		private SecT409K1Holder() { }

		[Address(RVA = "0x120A600", Offset = "0x1209800", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT409K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D25")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120A670", Offset = "0x1209870", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D26")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000175")]
	public class SecT409R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030C")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120A9D0", Offset = "0x1209BD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D2B")]
		private static SecT409R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D28")]
		private SecT409R1Holder() { }

		[Address(RVA = "0x120A800", Offset = "0x1209A00", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT409R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D29")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120A870", Offset = "0x1209A70", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D2A")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000176")]
	public class SecT571K1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030D")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120ABD0", Offset = "0x1209DD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D2F")]
		private static SecT571K1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2C")]
		private SecT571K1Holder() { }

		[Address(RVA = "0x120AA40", Offset = "0x1209C40", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT571K1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D2D")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120AAB0", Offset = "0x1209CB0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D2E")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000177")]
	public class SecT571R1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030E")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x120AE10", Offset = "0x120A010", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "UnityEngine.Time", Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D33")]
		private static SecT571R1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D30")]
		private SecT571R1Holder() { }

		[Address(RVA = "0x120AC40", Offset = "0x1209E40", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecT571R1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D31")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x120ACB0", Offset = "0x1209EB0", Length = "0x155")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D32")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000178")]
	public class SM2P256V1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400030F")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1208710", Offset = "0x1207910", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D37")]
		private static SM2P256V1Holder() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D34")]
		private SM2P256V1Holder() { }

		[Address(RVA = "0x1208580", Offset = "0x1207780", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SM2P256V1Curve), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D35")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x12085F0", Offset = "0x12077F0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000D36")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x40002EE")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x0
	[Token(Token = "0x40002EF")]
	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves; //Field offset: 0x8
	[Token(Token = "0x40002F0")]
	private static readonly Dictionary<DerObjectIdentifier, String> names; //Field offset: 0x10

	[Address(RVA = "0x11DE860", Offset = "0x11DDA60", Length = "0x1158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomNamedCurves), Member = "DefineCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier), typeof(X9ECParametersHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomNamedCurves), Member = "DefineCurveAlias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CB9")]
	private static CustomNamedCurves() { }

	[Address(RVA = "0x11DE390", Offset = "0x11DD590", Length = "0xD4")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X9ECPoint), Member = "get_Point", ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB4")]
	private static X9ECPoint ConfigureBasepoint(ECCurve curve, string encoding) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB5")]
	private static ECCurve ConfigureCurve(ECCurve curve) { }

	[Address(RVA = "0x11DE470", Offset = "0x11DD670", Length = "0xAF")]
	[CalledBy(Type = typeof(SecP160K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP192K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP224K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP256K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GlvTypeBEndomorphism), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Config), Member = "SetEndomorphism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism)}, ReturnType = typeof(Config))]
	[Calls(Type = typeof(Config), Member = "Create", ReturnType = typeof(ECCurve))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CB6")]
	private static ECCurve ConfigureCurveGlv(ECCurve c, GlvTypeBParameters p) { }

	[Address(RVA = "0x11DE630", Offset = "0x11DD830", Length = "0xFE")]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB7")]
	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder) { }

	[Address(RVA = "0x11DE520", Offset = "0x11DD720", Length = "0x10E")]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CB8")]
	private static void DefineCurveAlias(string name, DerObjectIdentifier oid) { }

	[Address(RVA = "0x11DE7A0", Offset = "0x11DD9A0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x6000CBA")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

	[Address(RVA = "0x11DE730", Offset = "0x11DD930", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x6000CBB")]
	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid) { }

}

