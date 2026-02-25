namespace System.Xml.Schema;

[Token(Token = "0x20000CF")]
internal class UpaException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400046D")]
	private object particle1; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400046E")]
	private object particle2; //Field offset: 0x98

	[Address(RVA = "0x16B5970", Offset = "0x16B4B70", Length = "0x8E")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000887")]
	public UpaException(object particle1, object particle2) { }

}

