namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000519")]
internal class EventCategoryAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010EB")]
	internal EventCategory category; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600251F")]
	public EventCategoryAttribute(EventCategory category) { }

}

