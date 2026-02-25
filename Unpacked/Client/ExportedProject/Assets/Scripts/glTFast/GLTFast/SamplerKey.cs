namespace GLTFast;

[Token(Token = "0x2000050")]
internal struct SamplerKey : IEquatable<SamplerKey>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000196")]
	private FilterMode m_FilterMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000197")]
	private TextureWrapMode m_WrapModeU; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000198")]
	private TextureWrapMode m_WrapModeV; //Field offset: 0x8

	[Address(RVA = "0x107A210", Offset = "0x1079410", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014A")]
	public SamplerKey(Sampler sampler) { }

	[Address(RVA = "0x107A160", Offset = "0x1079360", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	public override bool Equals(SamplerKey other) { }

	[Address(RVA = "0x107A0B0", Offset = "0x10792B0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x107A180", Offset = "0x1079380", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600014B")]
	public virtual int GetHashCode() { }

}

