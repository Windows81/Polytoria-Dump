namespace UnityEngine.UIElements;

[Token(Token = "0x20001AD")]
public abstract class MouseCaptureEventBase : PointerCaptureEventBase<T>
{

	[Address(RVA = "0xE0AEE0", Offset = "0xE0A0E0", Length = "0x13")]
	[CalledBy(Type = "UnityEngine.UIElements.MouseCaptureOutEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(MouseCaptureOutEvent))]
	[CalledBy(Type = typeof(MouseCaptureOutEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MouseCaptureEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(MouseCaptureEvent))]
	[CalledBy(Type = typeof(MouseCaptureEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C43")]
	protected MouseCaptureEventBase`1() { }

}

