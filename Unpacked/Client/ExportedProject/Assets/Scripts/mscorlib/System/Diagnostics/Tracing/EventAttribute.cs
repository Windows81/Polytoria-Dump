namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000585")]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400178B")]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400178C")]
	private EventLevel <Level>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400178D")]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400178E")]
	private string <Message>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000611")]
	private int EventId
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002853")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000613")]
	public EventKeywords Keywords
	{
		[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002855")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000612")]
	public EventLevel Level
	{
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002854")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000614")]
	public string Message
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002856")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002852")]
	public EventAttribute(int eventId) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002853")]
	private void set_EventId(int value) { }

	[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002855")]
	public void set_Keywords(EventKeywords value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002854")]
	public void set_Level(EventLevel value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002856")]
	public void set_Message(string value) { }

}

