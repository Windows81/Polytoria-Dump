namespace UnityEngine.Playables;

[Token(Token = "0x2000290")]
public struct FrameData
{
	[Flags]
	[Token(Token = "0x2000291")]
	public enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 16,
		EffectivePlayStatePlaying = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C1")]
	internal ulong m_FrameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006C2")]
	internal double m_DeltaTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006C3")]
	internal float m_Weight; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006C4")]
	internal float m_EffectiveWeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006C5")]
	internal double m_EffectiveParentDelay; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006C6")]
	internal float m_EffectiveParentSpeed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40006C7")]
	internal float m_EffectiveSpeed; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006C8")]
	internal Flags m_Flags; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006C9")]
	internal PlayableOutput m_Output; //Field offset: 0x30

}

