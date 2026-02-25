namespace Polytoria.Datamodel.Services;

[Token(Token = "0x2000382")]
public class GetDataStoreQueueEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5A")]
	public Datastore datastore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5B")]
	public Action<Boolean> callback; //Field offset: 0x18

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025C9")]
	public GetDataStoreQueueEntry(Datastore datastore, Action<Boolean> callback) { }

}

