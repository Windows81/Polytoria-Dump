//Type is in global namespace

[Token(Token = "0x2000004")]
public class HSVChangedEvent : UnityEvent<Single, Single, Single>
{

	[Address(RVA = "0x1098800", Offset = "0x1097A00", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	public HSVChangedEvent() { }

}

