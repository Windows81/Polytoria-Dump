namespace UnityEngine;

[Token(Token = "0x2000018")]
internal class GUIStateObjects
{
	[Token(Token = "0x40000A1")]
	private static Dictionary<Int32, Object> s_StateCache; //Field offset: 0x0

	[Address(RVA = "0x19AB800", Offset = "0x19AAA00", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600016C")]
	private static GUIStateObjects() { }

	[Address(RVA = "0x19AB6B0", Offset = "0x19AA8B0", Length = "0x146")]
	[CalledBy(Type = typeof(GUIUtility), Member = "GetStateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SliderHandler), Member = "SliderState", ReturnType = typeof(SliderState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600016B")]
	internal static object GetStateObject(Type t, int controlID) { }

}

