namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoSkeletonBone")]
[RequiredByNativeCode]
[Token(Token = "0x2000017")]
public struct SkeletonBone
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Name")]
	[Token(Token = "0x4000046")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_ParentName")]
	[Token(Token = "0x4000047")]
	internal string parentName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_Position")]
	[Token(Token = "0x4000048")]
	public Vector3 position; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[NativeName("m_Rotation")]
	[Token(Token = "0x4000049")]
	public Quaternion rotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[NativeName("m_Scale")]
	[Token(Token = "0x400004A")]
	public Vector3 scale; //Field offset: 0x2C

}

