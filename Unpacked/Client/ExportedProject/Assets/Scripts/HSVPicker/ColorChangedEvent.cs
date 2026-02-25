//Type is in global namespace

[Token(Token = "0x2000003")]
public class ColorChangedEvent : UnityEvent<Color>
{

	[Address(RVA = "0x10952E0", Offset = "0x10944E0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	public ColorChangedEvent() { }

}

