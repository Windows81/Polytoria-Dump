namespace UnityEngine.UIElements;

[Token(Token = "0x20004BE")]
public abstract class TypedUxmlAttributeDescription : UxmlAttributeDescription
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FF5")]
	private T <defaultValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000971")]
	public T defaultValue
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023CB")]
		 get { } //Length: 5
		[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023CC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x83D0E0", Offset = "0x83C2E0", Length = "0x7")]
	[CalledBy(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlDoubleAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlUnsignedIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlUnsignedLongAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlLongAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlHash128AttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60023CD")]
	protected TypedUxmlAttributeDescription`1() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023CB")]
	public T get_defaultValue() { }

	[Token(Token = "0x60023CA")]
	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023CC")]
	public void set_defaultValue(T value) { }

}

