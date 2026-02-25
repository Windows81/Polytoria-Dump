namespace RLD;

[Token(Token = "0x20001E1")]
public class PrefabLibDbSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000761")]
	private bool _spawnPrefabOnPreviewClick; //Field offset: 0x10

	[Token(Token = "0x170005E2")]
	public bool SpawnPrefabOnPreviewClick
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A4")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A5")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5775A0", Offset = "0x5767A0", Length = "0xB")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A6")]
	public PrefabLibDbSettings() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A4")]
	public bool get_SpawnPrefabOnPreviewClick() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A5")]
	public void set_SpawnPrefabOnPreviewClick(bool value) { }

}

