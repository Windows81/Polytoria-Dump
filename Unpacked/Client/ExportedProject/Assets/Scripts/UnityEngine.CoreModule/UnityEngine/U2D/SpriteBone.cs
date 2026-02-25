namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeType(CodegenOptions::Custom (1), "ScriptingSpriteBone")]
[RequiredByNativeCode]
[Token(Token = "0x2000325")]
public struct SpriteBone
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("name")]
	[SerializeField]
	[Token(Token = "0x4000ABF")]
	private string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("guid")]
	[SerializeField]
	[Token(Token = "0x4000AC0")]
	private string m_Guid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("position")]
	[SerializeField]
	[Token(Token = "0x4000AC1")]
	private Vector3 m_Position; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[NativeName("rotation")]
	[SerializeField]
	[Token(Token = "0x4000AC2")]
	private Quaternion m_Rotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[NativeName("length")]
	[SerializeField]
	[Token(Token = "0x4000AC3")]
	private float m_Length; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("parentId")]
	[SerializeField]
	[Token(Token = "0x4000AC4")]
	private int m_ParentId; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("color")]
	[SerializeField]
	[Token(Token = "0x4000AC5")]
	private Color32 m_Color; //Field offset: 0x34

}

