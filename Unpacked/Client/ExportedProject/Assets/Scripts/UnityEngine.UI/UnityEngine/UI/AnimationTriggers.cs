namespace UnityEngine.UI;

[Token(Token = "0x2000004")]
public class AnimationTriggers
{
	[Token(Token = "0x4000006")]
	private const string kDefaultNormalAnimName = "Normal"; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private const string kDefaultHighlightedAnimName = "Highlighted"; //Field offset: 0x0
	[Token(Token = "0x4000008")]
	private const string kDefaultPressedAnimName = "Pressed"; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	private const string kDefaultSelectedAnimName = "Selected"; //Field offset: 0x0
	[Token(Token = "0x400000A")]
	private const string kDefaultDisabledAnimName = "Disabled"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private string m_NormalTrigger; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private string m_HighlightedTrigger; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private string m_PressedTrigger; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	private string m_SelectedTrigger; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	private string m_DisabledTrigger; //Field offset: 0x30

	[Token(Token = "0x17000005")]
	public string disabledTrigger
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000002")]
	public string highlightedTrigger
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	public string normalTrigger
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public string pressedTrigger
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000008")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000004")]
	public string selectedTrigger
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1A76610", Offset = "0x1A75810", Length = "0xEB")]
	[CalledBy(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public AnimationTriggers() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public string get_disabledTrigger() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public string get_highlightedTrigger() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public string get_normalTrigger() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public string get_pressedTrigger() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public string get_selectedTrigger() { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public void set_disabledTrigger(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public void set_highlightedTrigger(string value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public void set_normalTrigger(string value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public void set_pressedTrigger(string value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public void set_selectedTrigger(string value) { }

}

