namespace Battlehub.UIControls;

[Token(Token = "0x2000010")]
public class InputProvider : MonoBehaviour
{

	[Token(Token = "0x17000006")]
	public override float HorizontalAxis
	{
		[Address(RVA = "0x5C4B80", Offset = "0x5C3D80", Length = "0x46")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000040")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000008")]
	public override float HorizontalAxis2
	{
		[Address(RVA = "0x5C4B30", Offset = "0x5C3D30", Length = "0x46")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000042")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000015")]
	public override bool IsAnyKeyDown
	{
		[Address(RVA = "0x488DB0", Offset = "0x487FB0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_anyKeyDown", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000012")]
	public override bool IsCancelButtonDown
	{
		[Address(RVA = "0x5C4BD0", Offset = "0x5C3DD0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004C")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000013")]
	public override bool IsDeleteButtonDown
	{
		[Address(RVA = "0x5C4BE0", Offset = "0x5C3DE0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004D")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700000F")]
	public override bool IsFunctional2ButtonPressed
	{
		[Address(RVA = "0x5C4BF0", Offset = "0x5C3DF0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000049")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700000E")]
	public override bool IsFunctionalButtonPressed
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C3E00", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000048")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700000C")]
	public override bool IsHorizontal2ButtonDown
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C3E10", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000046")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700000A")]
	public override bool IsHorizontalButtonDown
	{
		[Address(RVA = "0x5C4C40", Offset = "0x5C3E40", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000044")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000018")]
	public override bool IsKeyboardPresent
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000053")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000017")]
	public override bool IsMousePresent
	{
		[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000052")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000014")]
	public override bool IsSelectAllButtonDown
	{
		[Address(RVA = "0x5C4C70", Offset = "0x5C3E70", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004E")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000010")]
	public override bool IsSubmitButtonDown
	{
		[Address(RVA = "0x5C4C80", Offset = "0x5C3E80", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004A")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000011")]
	public override bool IsSubmitButtonUp
	{
		[Address(RVA = "0x5C4C90", Offset = "0x5C3E90", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004B")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700001A")]
	public override bool IsTouchSupported
	{
		[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000D")]
	public override bool IsVertical2ButtonDown
	{
		[Address(RVA = "0x5C4CB0", Offset = "0x5C3EB0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000047")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700000B")]
	public override bool IsVerticalButtonDown
	{
		[Address(RVA = "0x5C4CE0", Offset = "0x5C3EE0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000045")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000016")]
	public override Vector3 MousePosition
	{
		[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000019")]
	public override int TouchCount
	{
		[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000054")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	public override float VerticalAxis
	{
		[Address(RVA = "0x5C4D60", Offset = "0x5C3F60", Length = "0x46")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000041")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000009")]
	public override float VerticalAxis2
	{
		[Address(RVA = "0x5C4D10", Offset = "0x5C3F10", Length = "0x46")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000043")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public InputProvider() { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3D80", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000040")]
	public override float get_HorizontalAxis() { }

	[Address(RVA = "0x5C4B30", Offset = "0x5C3D30", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000042")]
	public override float get_HorizontalAxis2() { }

	[Address(RVA = "0x488DB0", Offset = "0x487FB0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_anyKeyDown", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public override bool get_IsAnyKeyDown() { }

	[Address(RVA = "0x5C4BD0", Offset = "0x5C3DD0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	public override bool get_IsCancelButtonDown() { }

	[Address(RVA = "0x5C4BE0", Offset = "0x5C3DE0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	public override bool get_IsDeleteButtonDown() { }

	[Address(RVA = "0x5C4BF0", Offset = "0x5C3DF0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	public override bool get_IsFunctional2ButtonPressed() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C3E00", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	public override bool get_IsFunctionalButtonPressed() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C3E10", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000046")]
	public override bool get_IsHorizontal2ButtonDown() { }

	[Address(RVA = "0x5C4C40", Offset = "0x5C3E40", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000044")]
	public override bool get_IsHorizontalButtonDown() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public override bool get_IsKeyboardPresent() { }

	[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	public override bool get_IsMousePresent() { }

	[Address(RVA = "0x5C4C70", Offset = "0x5C3E70", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public override bool get_IsSelectAllButtonDown() { }

	[Address(RVA = "0x5C4C80", Offset = "0x5C3E80", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	public override bool get_IsSubmitButtonDown() { }

	[Address(RVA = "0x5C4C90", Offset = "0x5C3E90", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	public override bool get_IsSubmitButtonUp() { }

	[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public override bool get_IsTouchSupported() { }

	[Address(RVA = "0x5C4CB0", Offset = "0x5C3EB0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000047")]
	public override bool get_IsVertical2ButtonDown() { }

	[Address(RVA = "0x5C4CE0", Offset = "0x5C3EE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000045")]
	public override bool get_IsVerticalButtonDown() { }

	[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000050")]
	public override Vector3 get_MousePosition() { }

	[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public override int get_TouchCount() { }

	[Address(RVA = "0x5C4D60", Offset = "0x5C3F60", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000041")]
	public override float get_VerticalAxis() { }

	[Address(RVA = "0x5C4D10", Offset = "0x5C3F10", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000043")]
	public override float get_VerticalAxis2() { }

	[Address(RVA = "0x5C4AE0", Offset = "0x5C3CE0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public override Touch GetTouch(int i) { }

	[Address(RVA = "0x561D50", Offset = "0x560F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	public override bool IsMouseButtonDown(int button) { }

}

