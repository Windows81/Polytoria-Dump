//Type is in global namespace

[Token(Token = "0x2000019")]
public class LTEvent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EA")]
	public int id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EB")]
	public object data; //Field offset: 0x18

	[Address(RVA = "0x2BE0F0", Offset = "0x2BD2F0", Length = "0x40")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	public LTEvent(int id, object data) { }

}

