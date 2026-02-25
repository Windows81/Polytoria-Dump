namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000070")]
public class WNafPreCompInfo : PreCompInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000109")]
	internal int m_promotionCountdown; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400010A")]
	protected int m_confWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400010B")]
	protected ECPoint[] m_preComp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400010C")]
	protected ECPoint[] m_preCompNeg; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010D")]
	protected ECPoint m_twice; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010E")]
	protected int m_width; //Field offset: 0x30

	[Token(Token = "0x1700004D")]
	public override int ConfWidth
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000428")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000429")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004C")]
	public override bool IsPromoted
	{
		[Address(RVA = "0x11629C0", Offset = "0x1161BC0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000427")]
		 get { } //Length: 25
	}

	[Token(Token = "0x1700004E")]
	public override ECPoint[] PreComp
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042A")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600042B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004F")]
	public override ECPoint[] PreCompNeg
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042C")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600042D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004B")]
	internal int PromotionCountdown
	{
		[Address(RVA = "0x11629E0", Offset = "0x1161BE0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6000425")]
		internal get { } //Length: 22
		[Address(RVA = "0x1162A00", Offset = "0x1161C00", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6000426")]
		internal set { } //Length: 34
	}

	[Token(Token = "0x17000050")]
	public override ECPoint Twice
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042E")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600042F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000051")]
	public override int Width
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000430")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000431")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1162980", Offset = "0x1161B80", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000432")]
	public WNafPreCompInfo() { }

	[Address(RVA = "0x1162950", Offset = "0x1161B50", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000424")]
	internal int DecrementPromotionCountdown() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000428")]
	public override int get_ConfWidth() { }

	[Address(RVA = "0x11629C0", Offset = "0x1161BC0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000427")]
	public override bool get_IsPromoted() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042A")]
	public override ECPoint[] get_PreComp() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042C")]
	public override ECPoint[] get_PreCompNeg() { }

	[Address(RVA = "0x11629E0", Offset = "0x1161BE0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000425")]
	internal int get_PromotionCountdown() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042E")]
	public override ECPoint get_Twice() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000430")]
	public override int get_Width() { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000429")]
	public override void set_ConfWidth(int value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042B")]
	public override void set_PreComp(ECPoint[] value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042D")]
	public override void set_PreCompNeg(ECPoint[] value) { }

	[Address(RVA = "0x1162A00", Offset = "0x1161C00", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000426")]
	internal void set_PromotionCountdown(int value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042F")]
	public override void set_Twice(ECPoint value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000431")]
	public override void set_Width(int value) { }

}

