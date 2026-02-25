namespace UnityEngine.EventSystems;

[Token(Token = "0x200009C")]
public class BaseEventData : AbstractEventData
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002CF")]
	private readonly EventSystem m_EventSystem; //Field offset: 0x18

	[Token(Token = "0x1700019F")]
	public BaseInputModule currentInputModule
	{
		[Address(RVA = "0x1CDEC80", Offset = "0x1CDDE80", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000636")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001A0")]
	public GameObject selectedObject
	{
		[Address(RVA = "0x3B6B10", Offset = "0x3B5D10", Length = "0x1B")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000637")]
		 get { } //Length: 27
		[Address(RVA = "0x1CDECA0", Offset = "0x1CDDEA0", Length = "0x24")]
		[CalledBy(Type = typeof(Selectable), Member = "Navigate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData), typeof(Selectable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000638")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x13847D0", Offset = "0x13839D0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000635")]
	public BaseEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x1CDEC80", Offset = "0x1CDDE80", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000636")]
	public BaseInputModule get_currentInputModule() { }

	[Address(RVA = "0x3B6B10", Offset = "0x3B5D10", Length = "0x1B")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000637")]
	public GameObject get_selectedObject() { }

	[Address(RVA = "0x1CDECA0", Offset = "0x1CDDEA0", Length = "0x24")]
	[CalledBy(Type = typeof(Selectable), Member = "Navigate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData), typeof(Selectable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000638")]
	public void set_selectedObject(GameObject value) { }

}

