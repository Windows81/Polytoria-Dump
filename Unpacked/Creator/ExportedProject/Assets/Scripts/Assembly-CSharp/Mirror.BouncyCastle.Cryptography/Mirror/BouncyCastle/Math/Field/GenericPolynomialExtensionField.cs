namespace Mirror.BouncyCastle.Math.Field;

[Token(Token = "0x2000031")]
internal class GenericPolynomialExtensionField : IPolynomialExtensionField, IFiniteField
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007B")]
	protected readonly IFiniteField subfield; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007C")]
	protected readonly IPolynomial minimalPolynomial; //Field offset: 0x18

	[Token(Token = "0x17000014")]
	public override BigInteger Characteristic
	{
		[Address(RVA = "0x11502D0", Offset = "0x114F4D0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020E")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000015")]
	public override int Dimension
	{
		[Address(RVA = "0x1150320", Offset = "0x114F520", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020F")]
		 get { } //Length: 124
	}

	[Token(Token = "0x17000016")]
	public override IPolynomial MinimalPolynomial
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000210")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020D")]
	internal GenericPolynomialExtensionField(IFiniteField subfield, IPolynomial polynomial) { }

	[Address(RVA = "0x1150150", Offset = "0x114F350", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000211")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11502D0", Offset = "0x114F4D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020E")]
	public override BigInteger get_Characteristic() { }

	[Address(RVA = "0x1150320", Offset = "0x114F520", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020F")]
	public override int get_Dimension() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000210")]
	public override IPolynomial get_MinimalPolynomial() { }

	[Address(RVA = "0x1150230", Offset = "0x114F430", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000212")]
	public virtual int GetHashCode() { }

}

