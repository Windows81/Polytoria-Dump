namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BC")]
public class BaseInput : UIBehaviour
{

	[Token(Token = "0x170001E6")]
	public override Vector2 compositionCursorPos
	{
		[Address(RVA = "0x1CE0240", Offset = "0x1CDF440", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
		[Token(Token = "0x6000702")]
		 get { } //Length: 7
		[Address(RVA = "0x1CE0290", Offset = "0x1CDF490", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000703")]
		 set { } //Length: 17
	}

	[Token(Token = "0x170001E4")]
	public override string compositionString
	{
		[Address(RVA = "0x19D70C0", Offset = "0x19D62C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001E5")]
	public override IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x1CE0250", Offset = "0x1CDF450", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
		[Token(Token = "0x6000700")]
		 get { } //Length: 7
		[Address(RVA = "0x1CE02B0", Offset = "0x1CDF4B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000701")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001E8")]
	public override Vector2 mousePosition
	{
		[Address(RVA = "0x1CE0260", Offset = "0x1CDF460", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[Token(Token = "0x6000708")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170001E7")]
	public override bool mousePresent
	{
		[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000704")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001E9")]
	public override Vector2 mouseScrollDelta
	{
		[Address(RVA = "0x19D70D0", Offset = "0x19D62D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000709")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001EA")]
	public override float mouseScrollDeltaPerTick
	{
		[Address(RVA = "0x1A66E30", Offset = "0x1A66030", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600070A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001EC")]
	public override int touchCount
	{
		[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x600070C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001EB")]
	public override bool touchSupported
	{
		[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x600070B")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000710")]
	public BaseInput() { }

	[Address(RVA = "0x1CE0240", Offset = "0x1CDF440", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
	[Token(Token = "0x6000702")]
	public override Vector2 get_compositionCursorPos() { }

	[Address(RVA = "0x19D70C0", Offset = "0x19D62C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60006FF")]
	public override string get_compositionString() { }

	[Address(RVA = "0x1CE0250", Offset = "0x1CDF450", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
	[Token(Token = "0x6000700")]
	public override IMECompositionMode get_imeCompositionMode() { }

	[Address(RVA = "0x1CE0260", Offset = "0x1CDF460", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Token(Token = "0x6000708")]
	public override Vector2 get_mousePosition() { }

	[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000704")]
	public override bool get_mousePresent() { }

	[Address(RVA = "0x19D70D0", Offset = "0x19D62D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000709")]
	public override Vector2 get_mouseScrollDelta() { }

	[Address(RVA = "0x1A66E30", Offset = "0x1A66030", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600070A")]
	public override float get_mouseScrollDeltaPerTick() { }

	[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070C")]
	public override int get_touchCount() { }

	[Address(RVA = "0x5C4CA0", Offset = "0x5C3EA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070B")]
	public override bool get_touchSupported() { }

	[Address(RVA = "0x19D7050", Offset = "0x19D6250", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070E")]
	public override float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x19D7060", Offset = "0x19D6260", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070F")]
	public override bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x561CC0", Offset = "0x560EC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000707")]
	public override bool GetMouseButton(int button) { }

	[Address(RVA = "0x561D50", Offset = "0x560F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000705")]
	public override bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x561D60", Offset = "0x560F60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000706")]
	public override bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x5C4AE0", Offset = "0x5C3CE0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070D")]
	public override Touch GetTouch(int index) { }

	[Address(RVA = "0x1CE0290", Offset = "0x1CDF490", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000703")]
	public override void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x1CE02B0", Offset = "0x1CDF4B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000701")]
	public override void set_imeCompositionMode(IMECompositionMode value) { }

}

