namespace RLD;

[Token(Token = "0x20002AF")]
public class ObjectDeselectEventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A72")]
	private ObjectDeselectReason _deselectReason; //Field offset: 0x10

	[Token(Token = "0x1700087E")]
	public ObjectDeselectReason DeselectReason
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001989")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600198A")]
	public ObjectDeselectEventArgs(ObjectDeselectReason deselectReason) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001989")]
	public ObjectDeselectReason get_DeselectReason() { }

}

