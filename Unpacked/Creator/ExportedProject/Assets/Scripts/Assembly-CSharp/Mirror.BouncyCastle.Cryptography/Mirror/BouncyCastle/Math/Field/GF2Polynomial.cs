namespace Mirror.BouncyCastle.Math.Field;

[Token(Token = "0x2000032")]
internal class GF2Polynomial : IPolynomial
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007D")]
	protected readonly Int32[] exponents; //Field offset: 0x10

	[Token(Token = "0x17000017")]
	public override int Degree
	{
		[Address(RVA = "0x1150110", Offset = "0x114F310", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000214")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x11500A0", Offset = "0x114F2A0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000213")]
	internal GF2Polynomial(Int32[] exponents) { }

	[Address(RVA = "0x114FF40", Offset = "0x114F140", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000216")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1150110", Offset = "0x114F310", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000214")]
	public override int get_Degree() { }

	[Address(RVA = "0x1150000", Offset = "0x114F200", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Token(Token = "0x6000215")]
	public override Int32[] GetExponentsPresent() { }

	[Address(RVA = "0x1150050", Offset = "0x114F250", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[Token(Token = "0x6000217")]
	public virtual int GetHashCode() { }

}

