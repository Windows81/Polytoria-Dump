namespace RLD;

[Token(Token = "0x200007A")]
public class GizmoHandleShape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B2")]
	private bool _isVisible; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40001B3")]
	private bool _isHoverable; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B4")]
	private Shape3D _shape; //Field offset: 0x18

	[Token(Token = "0x1700013D")]
	public bool IsHoverable
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000407")]
		 get { } //Length: 5
		[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000408")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700013C")]
	public bool IsVisible
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000405")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000406")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700013B")]
	public Shape3D Shape
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000404")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3CE330", Offset = "0x3CD530", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000409")]
	public GizmoHandleShape3D(Shape3D shape) { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000407")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000404")]
	public Shape3D get_Shape() { }

	[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000408")]
	public void set_IsHoverable(bool value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000406")]
	public void set_IsVisible(bool value) { }

}

