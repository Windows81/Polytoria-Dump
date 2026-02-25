namespace Mirror;

[Token(Token = "0x200001E")]
public class LagCompensationSettings
{
	[FieldOffset(Offset = "0x10")]
	[Header("Buffering")]
	[Token(Token = "0x4000049")]
	[Tooltip("Keep this many past snapshots in the buffer. The larger this is, the further we can rewind into the past.\nMaximum rewind time := historyAmount * captureInterval")]
	public int historyLimit; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400004A")]
	[Tooltip("Capture state every 'captureInterval' seconds. Larger values will space out the captures more, which gives a longer history but with possible gaps inbetween.\nSmaller values will have fewer gaps, with shorter history.")]
	public float captureInterval; //Field offset: 0x14

	[Address(RVA = "0x1250A80", Offset = "0x124FC80", Length = "0x15")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AB")]
	public LagCompensationSettings() { }

}

