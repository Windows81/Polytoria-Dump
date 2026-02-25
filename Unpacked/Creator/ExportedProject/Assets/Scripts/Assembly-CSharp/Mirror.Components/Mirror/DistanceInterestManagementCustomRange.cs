namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Distance/Distance Custom Range")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[Token(Token = "0x2000007")]
public class DistanceInterestManagementCustomRange : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000014")]
	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange; //Field offset: 0x68

	[Address(RVA = "0x120B470", Offset = "0x120A670", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000012")]
	public DistanceInterestManagementCustomRange() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public virtual bool Weaved() { }

}

