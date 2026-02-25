namespace UnityEngine.UIElements;

[Token(Token = "0x2000295")]
public abstract class Manipulator : IManipulator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A35")]
	private VisualElement m_Target; //Field offset: 0x10

	[Token(Token = "0x17000367")]
	public override VisualElement target
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011F4")]
		 get { } //Length: 7
		[Address(RVA = "0x1C87510", Offset = "0x1C86710", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60011F5")]
		 set { } //Length: 98
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011F6")]
	protected Manipulator() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011F4")]
	public override VisualElement get_target() { }

	[Token(Token = "0x60011F2")]
	protected abstract void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x1C87510", Offset = "0x1C86710", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60011F5")]
	public override void set_target(VisualElement value) { }

	[Token(Token = "0x60011F3")]
	protected abstract void UnregisterCallbacksFromTarget() { }

}

