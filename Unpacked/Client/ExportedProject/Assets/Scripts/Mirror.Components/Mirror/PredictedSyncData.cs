namespace Mirror;

[Token(Token = "0x200003C")]
public struct PredictedSyncData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	public float deltaTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000159")]
	public Vector3 position; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015A")]
	public Quaternion rotation; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015B")]
	public Vector3 velocity; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400015C")]
	public Vector3 angularVelocity; //Field offset: 0x2C

	[Address(RVA = "0x1240BA0", Offset = "0x123FDA0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600020B")]
	public PredictedSyncData(float deltaTime, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) { }

}

