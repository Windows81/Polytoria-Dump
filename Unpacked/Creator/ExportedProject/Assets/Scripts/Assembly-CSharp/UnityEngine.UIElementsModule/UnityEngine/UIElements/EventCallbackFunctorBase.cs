namespace UnityEngine.UIElements;

[Token(Token = "0x20001C1")]
internal abstract class EventCallbackFunctorBase : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000804")]
	public long eventTypeId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000805")]
	public InvokePolicy invokePolicy; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCC")]
	protected EventCallbackFunctorBase() { }

	[Token(Token = "0x6000CCA")]
	public abstract void Dispose() { }

	[Token(Token = "0x6000CC8")]
	public abstract void Invoke(EventBase evt) { }

	[Token(Token = "0x6000CCB")]
	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Token(Token = "0x6000CC9")]
	public abstract void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

