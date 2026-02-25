namespace Battlehub.UIControls;

[Token(Token = "0x2000011")]
public class InputProviderAdapter : InputProvider
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private InputProvider m_inputProvider; //Field offset: 0x20

	[Token(Token = "0x1700001C")]
	public virtual float HorizontalAxis
	{
		[Address(RVA = "0x5C4700", Offset = "0x5C3900", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001E")]
	public virtual float HorizontalAxis2
	{
		[Address(RVA = "0x5C46D0", Offset = "0x5C38D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001B")]
	public InputProvider InputProvider
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000058")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000059")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	public virtual bool IsAnyKeyDown
	{
		[Address(RVA = "0x5C4730", Offset = "0x5C3930", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000028")]
	public virtual bool IsCancelButtonDown
	{
		[Address(RVA = "0x5C4760", Offset = "0x5C3960", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000066")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000029")]
	public virtual bool IsDeleteButtonDown
	{
		[Address(RVA = "0x5C4790", Offset = "0x5C3990", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000067")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000025")]
	public virtual bool IsFunctional2ButtonPressed
	{
		[Address(RVA = "0x5C47C0", Offset = "0x5C39C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000024")]
	public virtual bool IsFunctionalButtonPressed
	{
		[Address(RVA = "0x5C47F0", Offset = "0x5C39F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000062")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000022")]
	public virtual bool IsHorizontal2ButtonDown
	{
		[Address(RVA = "0x5C4820", Offset = "0x5C3A20", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000060")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000020")]
	public virtual bool IsHorizontalButtonDown
	{
		[Address(RVA = "0x5C4850", Offset = "0x5C3A50", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700002E")]
	public virtual bool IsKeyboardPresent
	{
		[Address(RVA = "0x5C4880", Offset = "0x5C3A80", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700002D")]
	public virtual bool IsMousePresent
	{
		[Address(RVA = "0x5C48B0", Offset = "0x5C3AB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700002A")]
	public virtual bool IsSelectAllButtonDown
	{
		[Address(RVA = "0x5C48E0", Offset = "0x5C3AE0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000068")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000026")]
	public virtual bool IsSubmitButtonDown
	{
		[Address(RVA = "0x5C4910", Offset = "0x5C3B10", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000064")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000027")]
	public virtual bool IsSubmitButtonUp
	{
		[Address(RVA = "0x5C4940", Offset = "0x5C3B40", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000030")]
	public virtual bool IsTouchSupported
	{
		[Address(RVA = "0x5C4970", Offset = "0x5C3B70", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000070")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000023")]
	public virtual bool IsVertical2ButtonDown
	{
		[Address(RVA = "0x5C49A0", Offset = "0x5C3BA0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000061")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000021")]
	public virtual bool IsVerticalButtonDown
	{
		[Address(RVA = "0x5C49D0", Offset = "0x5C3BD0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700002C")]
	public virtual Vector3 MousePosition
	{
		[Address(RVA = "0x5C4A00", Offset = "0x5C3C00", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006A")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700002F")]
	public virtual int TouchCount
	{
		[Address(RVA = "0x5C4A50", Offset = "0x5C3C50", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001D")]
	public virtual float VerticalAxis
	{
		[Address(RVA = "0x5C4AB0", Offset = "0x5C3CB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001F")]
	public virtual float VerticalAxis2
	{
		[Address(RVA = "0x5C4A80", Offset = "0x5C3C80", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005D")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public InputProviderAdapter() { }

	[Address(RVA = "0x5C4700", Offset = "0x5C3900", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005A")]
	public virtual float get_HorizontalAxis() { }

	[Address(RVA = "0x5C46D0", Offset = "0x5C38D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	public virtual float get_HorizontalAxis2() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public InputProvider get_InputProvider() { }

	[Address(RVA = "0x5C4730", Offset = "0x5C3930", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	public virtual bool get_IsAnyKeyDown() { }

	[Address(RVA = "0x5C4760", Offset = "0x5C3960", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public virtual bool get_IsCancelButtonDown() { }

	[Address(RVA = "0x5C4790", Offset = "0x5C3990", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public virtual bool get_IsDeleteButtonDown() { }

	[Address(RVA = "0x5C47C0", Offset = "0x5C39C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public virtual bool get_IsFunctional2ButtonPressed() { }

	[Address(RVA = "0x5C47F0", Offset = "0x5C39F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000062")]
	public virtual bool get_IsFunctionalButtonPressed() { }

	[Address(RVA = "0x5C4820", Offset = "0x5C3A20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	public virtual bool get_IsHorizontal2ButtonDown() { }

	[Address(RVA = "0x5C4850", Offset = "0x5C3A50", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public virtual bool get_IsHorizontalButtonDown() { }

	[Address(RVA = "0x5C4880", Offset = "0x5C3A80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	public virtual bool get_IsKeyboardPresent() { }

	[Address(RVA = "0x5C48B0", Offset = "0x5C3AB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	public virtual bool get_IsMousePresent() { }

	[Address(RVA = "0x5C48E0", Offset = "0x5C3AE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	public virtual bool get_IsSelectAllButtonDown() { }

	[Address(RVA = "0x5C4910", Offset = "0x5C3B10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	public virtual bool get_IsSubmitButtonDown() { }

	[Address(RVA = "0x5C4940", Offset = "0x5C3B40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public virtual bool get_IsSubmitButtonUp() { }

	[Address(RVA = "0x5C4970", Offset = "0x5C3B70", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public virtual bool get_IsTouchSupported() { }

	[Address(RVA = "0x5C49A0", Offset = "0x5C3BA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000061")]
	public virtual bool get_IsVertical2ButtonDown() { }

	[Address(RVA = "0x5C49D0", Offset = "0x5C3BD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public virtual bool get_IsVerticalButtonDown() { }

	[Address(RVA = "0x5C4A00", Offset = "0x5C3C00", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public virtual Vector3 get_MousePosition() { }

	[Address(RVA = "0x5C4A50", Offset = "0x5C3C50", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	public virtual int get_TouchCount() { }

	[Address(RVA = "0x5C4AB0", Offset = "0x5C3CB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	public virtual float get_VerticalAxis() { }

	[Address(RVA = "0x5C4A80", Offset = "0x5C3C80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	public virtual float get_VerticalAxis2() { }

	[Address(RVA = "0x5C4640", Offset = "0x5C3840", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	public virtual Touch GetTouch(int i) { }

	[Address(RVA = "0x5C46A0", Offset = "0x5C38A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006B")]
	public virtual bool IsMouseButtonDown(int button) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	public void set_InputProvider(InputProvider value) { }

}

