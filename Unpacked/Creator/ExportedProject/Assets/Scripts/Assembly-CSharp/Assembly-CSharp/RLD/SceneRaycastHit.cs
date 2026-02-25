namespace RLD;

[Token(Token = "0x2000215")]
public class SceneRaycastHit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400080F")]
	private GameObjectRayHit _objectHit; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000810")]
	private XZGridRayHit _gridHit; //Field offset: 0x18

	[Token(Token = "0x17000675")]
	public XZGridRayHit GridHit
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600144C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000674")]
	public GameObjectRayHit ObjectHit
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600144B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000672")]
	public bool WasAnObjectHit
	{
		[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001449")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000671")]
	public bool WasAnythingHit
	{
		[Address(RVA = "0x5A28C0", Offset = "0x5A1AC0", Length = "0x13")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001448")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000673")]
	public bool WasGridHit
	{
		[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600144A")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600144D")]
	public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600144C")]
	public XZGridRayHit get_GridHit() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600144B")]
	public GameObjectRayHit get_ObjectHit() { }

	[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001449")]
	public bool get_WasAnObjectHit() { }

	[Address(RVA = "0x5A28C0", Offset = "0x5A1AC0", Length = "0x13")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001448")]
	public bool get_WasAnythingHit() { }

	[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600144A")]
	public bool get_WasGridHit() { }

}

