namespace namudev;

[Token(Token = "0x20002DF")]
public class PropertyGridTemplate : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000B1E")]
	private string type; //Field offset: 0x20

	[Token(Token = "0x170008CA")]
	public string Type
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AF1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AF2")]
	public PropertyGridTemplate() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AF1")]
	public string get_Type() { }

}

