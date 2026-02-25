namespace System.Runtime.Serialization;

[Token(Token = "0x20003DB")]
internal class FixupHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F4C")]
	internal long m_id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F4D")]
	internal object m_fixupInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F4E")]
	internal int m_fixupType; //Field offset: 0x20

	[Address(RVA = "0x137E8D0", Offset = "0x137DAD0", Length = "0x53")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RecordFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(MemberInfo), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D6A")]
	internal FixupHolder(long id, object fixupInfo, int fixupType) { }

}

