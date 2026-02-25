namespace Mirror.BouncyCastle.Asn1.TeleTrust;

[Token(Token = "0x2000223")]
public static class TeleTrusTNamedCurves
{
	[Token(Token = "0x2000224")]
	public class BrainpoolP160r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000571")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FB2C0", Offset = "0x10FA4C0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001276")]
		private static BrainpoolP160r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001273")]
		private BrainpoolP160r1Holder() { }

		[Address(RVA = "0x10FB050", Offset = "0x10FA250", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001274")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FB1A0", Offset = "0x10FA3A0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001275")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000225")]
	public class BrainpoolP160t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000572")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FB5A0", Offset = "0x10FA7A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600127A")]
		private static BrainpoolP160t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001277")]
		private BrainpoolP160t1Holder() { }

		[Address(RVA = "0x10FB330", Offset = "0x10FA530", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001278")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FB480", Offset = "0x10FA680", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001279")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000226")]
	public class BrainpoolP192r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000573")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FB880", Offset = "0x10FAA80", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600127E")]
		private static BrainpoolP192r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600127B")]
		private BrainpoolP192r1Holder() { }

		[Address(RVA = "0x10FB610", Offset = "0x10FA810", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600127C")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FB760", Offset = "0x10FA960", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600127D")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000227")]
	public class BrainpoolP192t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000574")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FBB60", Offset = "0x10FAD60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001282")]
		private static BrainpoolP192t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600127F")]
		private BrainpoolP192t1Holder() { }

		[Address(RVA = "0x10FB8F0", Offset = "0x10FAAF0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001280")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FBA40", Offset = "0x10FAC40", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001281")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000228")]
	public class BrainpoolP224r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000575")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FBE40", Offset = "0x10FB040", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001286")]
		private static BrainpoolP224r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001283")]
		private BrainpoolP224r1Holder() { }

		[Address(RVA = "0x10FBBD0", Offset = "0x10FADD0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001284")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FBD20", Offset = "0x10FAF20", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001285")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000229")]
	public class BrainpoolP224t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000576")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FC120", Offset = "0x10FB320", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600128A")]
		private static BrainpoolP224t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001287")]
		private BrainpoolP224t1Holder() { }

		[Address(RVA = "0x10FBEB0", Offset = "0x10FB0B0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001288")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FC000", Offset = "0x10FB200", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001289")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022A")]
	public class BrainpoolP256r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000577")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FC400", Offset = "0x10FB600", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600128E")]
		private static BrainpoolP256r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600128B")]
		private BrainpoolP256r1Holder() { }

		[Address(RVA = "0x10FC190", Offset = "0x10FB390", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600128C")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FC2E0", Offset = "0x10FB4E0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600128D")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022B")]
	public class BrainpoolP256t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000578")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FC6E0", Offset = "0x10FB8E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001292")]
		private static BrainpoolP256t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600128F")]
		private BrainpoolP256t1Holder() { }

		[Address(RVA = "0x10FC470", Offset = "0x10FB670", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001290")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FC5C0", Offset = "0x10FB7C0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001291")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022C")]
	public class BrainpoolP320r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x4000579")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FC9C0", Offset = "0x10FBBC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001296")]
		private static BrainpoolP320r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001293")]
		private BrainpoolP320r1Holder() { }

		[Address(RVA = "0x10FC750", Offset = "0x10FB950", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001294")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FC8A0", Offset = "0x10FBAA0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001295")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022D")]
	public class BrainpoolP320t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400057A")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FCCA0", Offset = "0x10FBEA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600129A")]
		private static BrainpoolP320t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001297")]
		private BrainpoolP320t1Holder() { }

		[Address(RVA = "0x10FCA30", Offset = "0x10FBC30", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001298")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FCB80", Offset = "0x10FBD80", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001299")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022E")]
	public class BrainpoolP384r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400057B")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FCF80", Offset = "0x10FC180", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600129E")]
		private static BrainpoolP384r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600129B")]
		private BrainpoolP384r1Holder() { }

		[Address(RVA = "0x10FCD10", Offset = "0x10FBF10", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600129C")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FCE60", Offset = "0x10FC060", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600129D")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x200022F")]
	public class BrainpoolP384t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400057C")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FD260", Offset = "0x10FC460", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012A2")]
		private static BrainpoolP384t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600129F")]
		private BrainpoolP384t1Holder() { }

		[Address(RVA = "0x10FCFF0", Offset = "0x10FC1F0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012A0")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FD140", Offset = "0x10FC340", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012A1")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000230")]
	public class BrainpoolP512r1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400057D")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FD540", Offset = "0x10FC740", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012A6")]
		private static BrainpoolP512r1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A3")]
		private BrainpoolP512r1Holder() { }

		[Address(RVA = "0x10FD2D0", Offset = "0x10FC4D0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012A4")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FD420", Offset = "0x10FC620", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012A5")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x2000231")]
	public class BrainpoolP512t1Holder : X9ECParametersHolder
	{
		[Token(Token = "0x400057E")]
		internal static readonly X9ECParametersHolder Instance; //Field offset: 0x0

		[Address(RVA = "0x10FD820", Offset = "0x10FCA20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012AA")]
		private static BrainpoolP512t1Holder() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A7")]
		private BrainpoolP512t1Holder() { }

		[Address(RVA = "0x10FD5B0", Offset = "0x10FC7B0", Length = "0x150")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012A8")]
		protected virtual ECCurve CreateCurve() { }

		[Address(RVA = "0x10FD700", Offset = "0x10FC900", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Curve", ReturnType = typeof(ECCurve))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(X9ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60012A9")]
		protected virtual X9ECParameters CreateParameters() { }

	}

	[Token(Token = "0x400056E")]
	private static readonly Dictionary<String, DerObjectIdentifier> objIds; //Field offset: 0x0
	[Token(Token = "0x400056F")]
	private static readonly Dictionary<DerObjectIdentifier, X9ECParametersHolder> curves; //Field offset: 0x8
	[Token(Token = "0x4000570")]
	private static readonly Dictionary<DerObjectIdentifier, String> names; //Field offset: 0x10

	[Address(RVA = "0x1116DF0", Offset = "0x1115FF0", Length = "0x798")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TeleTrusTNamedCurves), Member = "DefineCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier), typeof(X9ECParametersHolder)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001270")]
	private static TeleTrusTNamedCurves() { }

	[Address(RVA = "0x1116A50", Offset = "0x1115C50", Length = "0xD4")]
	[CalledBy(Type = typeof(BrainpoolP384r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP512t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP512r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP384t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP320t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP320r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP256r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP256t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP224r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP192t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP192r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP160t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP160r1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(BrainpoolP224t1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X9ECPoint), Member = "get_Point", ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600126C")]
	private static X9ECPoint ConfigureBasepoint(ECCurve curve, string encoding) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x600126D")]
	private static ECCurve ConfigureCurve(ECCurve curve) { }

	[Address(RVA = "0x1116B30", Offset = "0x1115D30", Length = "0xFE")]
	[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126F")]
	private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder) { }

	[Address(RVA = "0x1116C30", Offset = "0x1115E30", Length = "0x87")]
	[CalledBy(Type = typeof(BrainpoolP320r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP512t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP512r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP384t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP384r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP320t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP256t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP256r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP224t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP224r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP192t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP192r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP160t1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(BrainpoolP160r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 56)]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600126E")]
	private static BigInteger FromHex(string hex) { }

	[Address(RVA = "0x1116D30", Offset = "0x1115F30", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Calls(Type = typeof(X9ECParametersHolder), Member = "get_Parameters", ReturnType = typeof(X9ECParameters))]
	[Token(Token = "0x6001271")]
	public static X9ECParameters GetByOid(DerObjectIdentifier oid) { }

	[Address(RVA = "0x1116CC0", Offset = "0x1115EC0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionUtilities), Member = "GetValueOrNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<K, V>", "K"}, ReturnType = "V")]
	[Token(Token = "0x6001272")]
	public static X9ECParametersHolder GetByOidLazy(DerObjectIdentifier oid) { }

}

