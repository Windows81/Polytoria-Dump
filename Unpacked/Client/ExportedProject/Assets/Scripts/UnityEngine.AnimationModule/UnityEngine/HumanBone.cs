namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoHumanBone")]
[RequiredByNativeCode]
[Token(Token = "0x2000019")]
public struct HumanBone
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	private string m_BoneName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000051")]
	private string m_HumanName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_Limit")]
	[Token(Token = "0x4000052")]
	public HumanLimit limit; //Field offset: 0x10

}

