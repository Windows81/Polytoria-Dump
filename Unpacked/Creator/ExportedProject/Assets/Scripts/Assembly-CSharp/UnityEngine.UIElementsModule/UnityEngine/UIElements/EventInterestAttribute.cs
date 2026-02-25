namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x2000518")]
public class EventInterestAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010E9")]
	internal Type[] eventTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010EA")]
	internal EventCategoryFlags categoryFlags; //Field offset: 0x18

	[Address(RVA = "0x1B65820", Offset = "0x1B64A20", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600251C")]
	public EventInterestAttribute(Type[] eventTypes) { }

	[Address(RVA = "0x1B657F0", Offset = "0x1B649F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600251D")]
	public EventInterestAttribute(EventInterestOptions interests) { }

	[Address(RVA = "0x1B657F0", Offset = "0x1B649F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600251E")]
	internal EventInterestAttribute(EventInterestOptionsInternal interests) { }

}

