namespace RLD;

[Token(Token = "0x2000178")]
public class InputDeviceDeltaCapture
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000665")]
	private int _id; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000666")]
	private Vector3 _origin; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000667")]
	private Vector3 _delta; //Field offset: 0x20

	[Token(Token = "0x1700056D")]
	public Vector3 Delta
	{
		[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BA")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700056B")]
	public int Id
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700056C")]
	public Vector3 Origin
	{
		[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B9")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x561A00", Offset = "0x560C00", Length = "0x40")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010BB")]
	public InputDeviceDeltaCapture(int id, Vector3 origin) { }

	[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BA")]
	public Vector3 get_Delta() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B8")]
	public int get_Id() { }

	[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B9")]
	public Vector3 get_Origin() { }

	[Address(RVA = "0x5619C0", Offset = "0x560BC0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010BC")]
	public void Update(Vector3 devicePosition) { }

}

