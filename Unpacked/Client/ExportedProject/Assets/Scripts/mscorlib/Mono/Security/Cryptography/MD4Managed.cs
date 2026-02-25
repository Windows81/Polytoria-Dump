namespace Mono.Security.Cryptography;

[Token(Token = "0x2000068")]
internal class MD4Managed : MD4
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F2")]
	private UInt32[] state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F3")]
	private Byte[] buffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F4")]
	private UInt32[] count; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F5")]
	private UInt32[] x; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001F6")]
	private Byte[] digest; //Field offset: 0x48

	[Address(RVA = "0x12F54D0", Offset = "0x12F46D0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	public MD4Managed() { }

	[Address(RVA = "0x12CAE40", Offset = "0x12CA040", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	private void Decode(UInt32[] output, Byte[] input, int index) { }

	[Address(RVA = "0x12CAEF0", Offset = "0x12CA0F0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000181")]
	private void Encode(Byte[] output, UInt32[] input) { }

	[Address(RVA = "0x10D8890", Offset = "0x10D7A90", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017A")]
	private uint F(uint x, uint y, uint z) { }

	[Address(RVA = "0x12CAFA0", Offset = "0x12CA1A0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017E")]
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x10F1EE0", Offset = "0x10F10E0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	private uint G(uint x, uint y, uint z) { }

	[Address(RVA = "0x12CAFE0", Offset = "0x12CA1E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017F")]
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x10D8810", Offset = "0x10D7A10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	private uint H(uint x, uint y, uint z) { }

	[Address(RVA = "0x12CB070", Offset = "0x12CA270", Length = "0x17B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000177")]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Address(RVA = "0x12F51B0", Offset = "0x12F43B0", Length = "0x2BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000178")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x12CB030", Offset = "0x12CA230", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x12CB4B0", Offset = "0x12CA6B0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000176")]
	public virtual void Initialize() { }

	[Address(RVA = "0x12CB580", Offset = "0x12CA780", Length = "0xAAF")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	private void MD4Transform(UInt32[] state, Byte[] block, int index) { }

	[Address(RVA = "0x12F5470", Offset = "0x12F4670", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000179")]
	private Byte[] Padding(int nLength) { }

	[Address(RVA = "0x12CC090", Offset = "0x12CB290", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	private uint ROL(uint x, byte n) { }

}

