namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoHumanLimit")]
[Token(Token = "0x2000018")]
public struct HumanLimit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004B")]
	private Vector3 m_Min; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400004C")]
	private Vector3 m_Max; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private Vector3 m_Center; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400004E")]
	private float m_AxisLength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	private int m_UseDefaultValues; //Field offset: 0x28

}

