namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x200014A")]
public sealed class EventHandlerList : IDisposable
{
	[Token(Token = "0x200014B")]
	private sealed class ListEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005E3")]
		internal ListEntry _next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005E4")]
		internal object _key; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005E5")]
		internal Delegate _handler; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E1")]
	private ListEntry _head; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E2")]
	private Component _parent; //Field offset: 0x18

	[Token(Token = "0x1700017E")]
	public Delegate Item
	{
		[Address(RVA = "0x177F1E0", Offset = "0x177E3E0", Length = "0x5B")]
		[CalledBy(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600081D")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081C")]
	public EventHandlerList() { }

	[Address(RVA = "0x13D6400", Offset = "0x13D5600", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600081E")]
	public override void Dispose() { }

	[Address(RVA = "0x177F1C0", Offset = "0x177E3C0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600081F")]
	private ListEntry Find(object key) { }

	[Address(RVA = "0x177F1E0", Offset = "0x177E3E0", Length = "0x5B")]
	[CalledBy(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081D")]
	public Delegate get_Item(object key) { }

}

