namespace RLD;

[Token(Token = "0x200006F")]
public class GizmoEngineSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000193")]
	private bool _enableGizmoSorting; //Field offset: 0x28

	[Token(Token = "0x170000E2")]
	public bool EnableGizmoSorting
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036C")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3CD460", Offset = "0x3CC660", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600036E")]
	public GizmoEngineSettings() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036C")]
	public bool get_EnableGizmoSorting() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036D")]
	public void set_EnableGizmoSorting(bool value) { }

}

