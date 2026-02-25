namespace UnityEngine.UIElements;

[Token(Token = "0x200021C")]
internal static class PointerEventHelper
{

	[Address(RVA = "0x1C5B6E0", Offset = "0x1C5A8E0", Length = "0x1A8")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessMouseEvents>b__29_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`4<System.Int32, System.Int32, UnityEngine.EventModifiers, System.Nullable`1<System.Int32>>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessMouseEvents>b__29_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`4<System.Int32, System.Int32, UnityEngine.EventModifiers, System.Nullable`1<System.Int32>>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "HasAdditionalPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
	[Token(Token = "0x6000EA6")]
	public static EventBase GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers, int displayIndex) { }

}

