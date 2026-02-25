namespace UnityEngine.EventSystems;

[Token(Token = "0x200009A")]
public class AxisEventData : BaseEventData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CC")]
	private Vector2 <moveVector>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002CD")]
	private MoveDirection <moveDir>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700019D")]
	public MoveDirection moveDir
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600062E")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600062F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700019C")]
	public Vector2 moveVector
	{
		[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600062C")]
		 get { } //Length: 19
		[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600062D")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x1CDEC00", Offset = "0x1CDDE00", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000630")]
	public AxisEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600062E")]
	public MoveDirection get_moveDir() { }

	[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600062C")]
	public Vector2 get_moveVector() { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600062F")]
	public void set_moveDir(MoveDirection value) { }

	[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600062D")]
	public void set_moveVector(Vector2 value) { }

}

