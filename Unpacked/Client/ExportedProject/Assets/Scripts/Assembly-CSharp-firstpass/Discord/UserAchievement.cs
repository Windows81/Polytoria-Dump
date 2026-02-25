namespace Discord;

[Token(Token = "0x20001E3")]
public struct UserAchievement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070B")]
	public long UserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400070C")]
	public long AchievementId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400070D")]
	public byte PercentComplete; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400070E")]
	public string UnlockedAt; //Field offset: 0x18

}

