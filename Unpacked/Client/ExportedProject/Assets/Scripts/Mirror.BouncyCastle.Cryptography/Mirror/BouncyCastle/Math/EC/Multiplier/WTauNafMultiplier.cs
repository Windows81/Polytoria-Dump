namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000075")]
public class WTauNafMultiplier : AbstractECMultiplier
{
	[Token(Token = "0x2000076")]
	private class WTauNafCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011D")]
		private readonly AbstractF2mPoint m_p; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011E")]
		private readonly sbyte m_a; //Field offset: 0x18

		[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000451")]
		internal WTauNafCallback(AbstractF2mPoint p, sbyte a) { }

		[Address(RVA = "0x1164000", Offset = "0x1163200", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Tnaf), Member = "GetPreComp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(sbyte)}, ReturnType = typeof(AbstractF2mPoint[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000452")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x400011C")]
	internal static readonly string PRECOMP_NAME; //Field offset: 0x0

	[Address(RVA = "0x1164A10", Offset = "0x1163C10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000450")]
	private static WTauNafMultiplier() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044F")]
	public WTauNafMultiplier() { }

	[Address(RVA = "0x11640F0", Offset = "0x11632F0", Length = "0x51C")]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyWTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(ZTauElement), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(AbstractF2mPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x600044E")]
	private static AbstractF2mPoint MultiplyFromWTnaf(AbstractF2mPoint p, SByte[] u) { }

	[Address(RVA = "0x1164610", Offset = "0x1163810", Length = "0x2D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tnaf), Member = "GetTw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Tnaf), Member = "GetMu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(Tnaf), Member = "PartModReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mCurve), typeof(BigInteger), typeof(sbyte), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Tnaf), Member = "TauAdicWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(ZTauElement), typeof(int), typeof(int), typeof(ZTauElement[])}, ReturnType = typeof(SByte[]))]
	[Calls(Type = typeof(WTauNafMultiplier), Member = "MultiplyFromWTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(SByte[])}, ReturnType = typeof(AbstractF2mPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600044C")]
	protected virtual ECPoint MultiplyPositive(ECPoint point, BigInteger k) { }

	[Address(RVA = "0x11648F0", Offset = "0x1163AF0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Tnaf), Member = "GetTw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(Tnaf), Member = "TauAdicWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(ZTauElement), typeof(int), typeof(int), typeof(ZTauElement[])}, ReturnType = typeof(SByte[]))]
	[Calls(Type = typeof(WTauNafMultiplier), Member = "MultiplyFromWTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(SByte[])}, ReturnType = typeof(AbstractF2mPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044D")]
	private AbstractF2mPoint MultiplyWTnaf(AbstractF2mPoint p, ZTauElement lambda, sbyte a, sbyte mu) { }

}

