namespace Mirror.BouncyCastle.Asn1.CryptoPro;

[Token(Token = "0x2000267")]
public static class ECGost3410NamedCurves
{
	[Token(Token = "0x2000268")]
	public class Holder_gostR3410_2001_CryptoPro_A : X9ECParametersHolder
	{
		[Token(Token = "0x40007A2")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1126A50", Offset = "0x1125C50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001382")]
		private static Holder_gostR3410_2001_CryptoPro_A() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600137F")]
		private Holder_gostR3410_2001_CryptoPro_A() { }

		[Address(RVA = "0x11267A0", Offset = "0x11259A0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001380")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x11268F0", Offset = "0x1125AF0", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001381")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000269")]
	public class Holder_gostR3410_2001_CryptoPro_B : X9ECParametersHolder
	{
		[Token(Token = "0x40007A3")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1126D70", Offset = "0x1125F70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001386")]
		private static Holder_gostR3410_2001_CryptoPro_B() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001383")]
		private Holder_gostR3410_2001_CryptoPro_B() { }

		[Address(RVA = "0x1126AC0", Offset = "0x1125CC0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001384")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1126C10", Offset = "0x1125E10", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001385")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200026A")]
	public class Holder_gostR3410_2001_CryptoPro_C : X9ECParametersHolder
	{
		[Token(Token = "0x40007A4")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1127090", Offset = "0x1126290", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600138A")]
		private static Holder_gostR3410_2001_CryptoPro_C() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001387")]
		private Holder_gostR3410_2001_CryptoPro_C() { }

		[Address(RVA = "0x1126DE0", Offset = "0x1125FE0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001388")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1126F30", Offset = "0x1126130", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001389")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200026B")]
	public class Holder_id_tc26_gost_3410_12_256_paramSetA : X9ECParametersHolder
	{
		[Token(Token = "0x40007A5")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11273A0", Offset = "0x11265A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600138E")]
		private static Holder_id_tc26_gost_3410_12_256_paramSetA() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600138B")]
		private Holder_id_tc26_gost_3410_12_256_paramSetA() { }

		[Address(RVA = "0x1127100", Offset = "0x1126300", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600138C")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1127250", Offset = "0x1126450", Length = "0x143")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600138D")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200026C")]
	public class Holder_id_tc26_gost_3410_12_512_paramSetA : X9ECParametersHolder
	{
		[Token(Token = "0x40007A6")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11276C0", Offset = "0x11268C0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001392")]
		private static Holder_id_tc26_gost_3410_12_512_paramSetA() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600138F")]
		private Holder_id_tc26_gost_3410_12_512_paramSetA() { }

		[Address(RVA = "0x1127410", Offset = "0x1126610", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001390")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1127560", Offset = "0x1126760", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001391")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200026D")]
	public class Holder_id_tc26_gost_3410_12_512_paramSetB : X9ECParametersHolder
	{
		[Token(Token = "0x40007A7")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x11279E0", Offset = "0x1126BE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001396")]
		private static Holder_id_tc26_gost_3410_12_512_paramSetB() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001393")]
		private Holder_id_tc26_gost_3410_12_512_paramSetB() { }

		[Address(RVA = "0x1127730", Offset = "0x1126930", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001394")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1127880", Offset = "0x1126A80", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001395")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200026E")]
	public class Holder_id_tc26_gost_3410_12_512_paramSetC : X9ECParametersHolder
	{
		[Token(Token = "0x40007A8")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x1127CF0", Offset = "0x1126EF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600139A")]
		private static Holder_id_tc26_gost_3410_12_512_paramSetC() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001397")]
		private Holder_id_tc26_gost_3410_12_512_paramSetC() { }

		[Address(RVA = "0x1127A50", Offset = "0x1126C50", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001398")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x1127BA0", Offset = "0x1126DA0", Length = "0x143")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001399")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x400079F")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x0
	[Token(Token = "0x40007A0")]
	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves; //Field offset: 0x8
	[Token(Token = "0x40007A1")]
	private static readonly Dictionary<DerObjectIdentifier, String> names; //Field offset: 0x10

	[Address(RVA = "0x1121C40", Offset = "0x1120E40", Length = "0x622")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ECGost3410NamedCurves), Member = "DefineCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier), typeof(X9ECParametersHolder)}, ReturnType = typeof(void))]
	[Token(Token = "0x600137C")]
	private static ECGost3410NamedCurves() { }

	[Address(RVA = "0x11218C0", Offset = "0x1120AC0", Length = "0xBB")]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetC), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_A), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_B), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_C), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_256_paramSetA), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetA), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetB), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001378")]
	private static X9ECPoint ConfigureBasepoint(ECCurve curve, BigInteger x, BigInteger y) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001379")]
	private static ECCurve ConfigureCurve(ECCurve curve) { }

	[Address(RVA = "0x1121980", Offset = "0x1120B80", Length = "0xFE")]
	[CalledBy(Type = typeof(ECGost3410NamedCurves), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600137B")]
	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder) { }

	[Address(RVA = "0x1121A80", Offset = "0x1120C80", Length = "0x87")]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetA), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetC), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetC), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetB), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetB), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_512_paramSetA), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_256_paramSetA), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_id_tc26_gost_3410_12_256_paramSetA), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_C), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_C), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_B), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_B), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_A), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(Holder_gostR3410_2001_CryptoPro_A), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600137A")]
	private static BigInteger FromHex(string hex) { }

	[Address(RVA = "0x1121B80", Offset = "0x1120D80", Length = "0xB2")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(ECNamedCurveTable), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x600137D")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

	[Address(RVA = "0x1121B10", Offset = "0x1120D10", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x600137E")]
	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid) { }

}

