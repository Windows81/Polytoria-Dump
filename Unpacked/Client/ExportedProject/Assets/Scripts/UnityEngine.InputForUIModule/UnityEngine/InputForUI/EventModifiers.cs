namespace UnityEngine.InputForUI;

[Token(Token = "0x200000B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct EventModifiers
{
	[Flags]
	[Token(Token = "0x200000C")]
	internal enum Modifiers
	{
		LeftShift = 1,
		RightShift = 2,
		Shift = 3,
		LeftCtrl = 4,
		RightCtrl = 8,
		Ctrl = 12,
		LeftAlt = 16,
		RightAlt = 32,
		Alt = 48,
		LeftMeta = 64,
		RightMeta = 128,
		Meta = 192,
		CapsLock = 256,
		Numlock = 512,
		FunctionKey = 1024,
		Numeric = 2048,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000033")]
	private uint _state; //Field offset: 0x0

	[Token(Token = "0x17000011")]
	public bool isAltPressed
	{
		[Address(RVA = "0x19D0470", Offset = "0x19CF670", Length = "0x7")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public bool isCapsLockEnabled
	{
		[Address(RVA = "0x19D0480", Offset = "0x19CF680", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000026")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000010")]
	public bool isCtrlPressed
	{
		[Address(RVA = "0x19D0490", Offset = "0x19CF690", Length = "0x7")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000023")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000014")]
	public bool isFunctionKeyPressed
	{
		[Address(RVA = "0x19D04A0", Offset = "0x19CF6A0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000027")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000012")]
	public bool isMetaPressed
	{
		[Address(RVA = "0x19D04B0", Offset = "0x19CF6B0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000025")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000015")]
	public bool isNumericPressed
	{
		[Address(RVA = "0x19D04C0", Offset = "0x19CF6C0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000028")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700000F")]
	public bool isShiftPressed
	{
		[Address(RVA = "0x19D04D0", Offset = "0x19CF6D0", Length = "0x7")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000022")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x19CFE70", Offset = "0x19CF070", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600002B")]
	private static void Append(ref string str, string value) { }

	[Address(RVA = "0x19D0470", Offset = "0x19CF670", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000024")]
	public bool get_isAltPressed() { }

	[Address(RVA = "0x19D0480", Offset = "0x19CF680", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000026")]
	public bool get_isCapsLockEnabled() { }

	[Address(RVA = "0x19D0490", Offset = "0x19CF690", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000023")]
	public bool get_isCtrlPressed() { }

	[Address(RVA = "0x19D04A0", Offset = "0x19CF6A0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000027")]
	public bool get_isFunctionKeyPressed() { }

	[Address(RVA = "0x19D04B0", Offset = "0x19CF6B0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	public bool get_isMetaPressed() { }

	[Address(RVA = "0x19D04C0", Offset = "0x19CF6C0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public bool get_isNumericPressed() { }

	[Address(RVA = "0x19D04D0", Offset = "0x19CF6D0", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000022")]
	public bool get_isShiftPressed() { }

	[Address(RVA = "0x19CFEE0", Offset = "0x19CF0E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000021")]
	public bool IsPressed(Modifiers mod) { }

	[Address(RVA = "0x1308BB0", Offset = "0x1307DB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	public void Reset() { }

	[Address(RVA = "0x19CFB90", Offset = "0x19CED90", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	public void SetPressed(Modifiers modifier, bool pressed) { }

	[Address(RVA = "0x19CFEF0", Offset = "0x19CF0F0", Length = "0x571")]
	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600002C")]
	public virtual string ToString() { }

}

