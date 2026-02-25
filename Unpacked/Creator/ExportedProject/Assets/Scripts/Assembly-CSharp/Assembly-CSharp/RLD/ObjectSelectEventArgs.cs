namespace RLD;

[Token(Token = "0x20002AE")]
public class ObjectSelectEventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A71")]
	private ObjectSelectReason _selectReason; //Field offset: 0x10

	[Token(Token = "0x1700087D")]
	public ObjectSelectReason SelectReason
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001987")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001988")]
	public ObjectSelectEventArgs(ObjectSelectReason selectReason) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001987")]
	public ObjectSelectReason get_SelectReason() { }

}

