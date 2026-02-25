namespace Polytoria.Datamodel;

[Token(Token = "0x2000338")]
public class NetMessage
{
	[FieldOffset(Offset = "0x10")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CD6")]
	public readonly Dictionary<String, String> strings; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CD7")]
	public readonly Dictionary<String, Int32> ints; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CD8")]
	public readonly Dictionary<String, Single> numbers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CD9")]
	public readonly Dictionary<String, Boolean> bools; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CDA")]
	public readonly Dictionary<String, Vector2> vec2s; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CDB")]
	public readonly Dictionary<String, Vector3> vec3s; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CDC")]
	public readonly Dictionary<String, Color> colors; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[MoonSharpHidden]
	[Token(Token = "0x4000CDD")]
	public readonly Dictionary<String, Instance> instances; //Field offset: 0x48

	[Address(RVA = "0x43AD20", Offset = "0x439F20", Length = "0x265")]
	[CalledBy(Type = typeof(NetMessage), Member = "New", ReturnType = typeof(NetMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EF9")]
	public NetMessage() { }

	[Address(RVA = "0x43AF90", Offset = "0x43A190", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F0B")]
	public NetMessage(Dictionary<String, String> strings, Dictionary<String, Int32> ints, Dictionary<String, Single> numbers, Dictionary<String, Boolean> bools, Dictionary<String, Vector2> vec2s, Dictionary<String, Vector3> vec3s, Dictionary<String, Color> colors, Dictionary<String, Instance> instances) { }

	[Address(RVA = "0x43A600", Offset = "0x439800", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFC")]
	public void AddBool(string key, bool value) { }

	[Address(RVA = "0x43A670", Offset = "0x439870", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Color>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F00")]
	public void AddColor(string key, Color value) { }

	[Address(RVA = "0x43A6E0", Offset = "0x4398E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F01")]
	public void AddInstance(string key, Instance value) { }

	[Address(RVA = "0x43A750", Offset = "0x439950", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFB")]
	public void AddInt(string key, int value) { }

	[Address(RVA = "0x43A7C0", Offset = "0x4399C0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFD")]
	public void AddNumber(string key, float value) { }

	[Address(RVA = "0x43A830", Offset = "0x439A30", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFA")]
	public void AddString(string key, string value) { }

	[Address(RVA = "0x43A8A0", Offset = "0x439AA0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector2>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFE")]
	public void AddVector2(string key, Vector2 value) { }

	[Address(RVA = "0x43A910", Offset = "0x439B10", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001EFF")]
	public void AddVector3(string key, Vector3 value) { }

	[Address(RVA = "0x43A990", Offset = "0x439B90", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F05")]
	public bool GetBool(string key) { }

	[Address(RVA = "0x43A9F0", Offset = "0x439BF0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F08")]
	public Color GetColor(string key) { }

	[Address(RVA = "0x43AA70", Offset = "0x439C70", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F09")]
	public Instance GetInstance(string key) { }

	[Address(RVA = "0x43AAD0", Offset = "0x439CD0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F03")]
	public int GetInt(string key) { }

	[Address(RVA = "0x43AB30", Offset = "0x439D30", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F04")]
	public float GetNumber(string key) { }

	[Address(RVA = "0x43AB90", Offset = "0x439D90", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F02")]
	public string GetString(string key) { }

	[Address(RVA = "0x43ABF0", Offset = "0x439DF0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F06")]
	public Vector2 GetVector2(string key) { }

	[Address(RVA = "0x43AC50", Offset = "0x439E50", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Vector3>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F07")]
	public Vector3 GetVector3(string key) { }

	[Address(RVA = "0x43ACD0", Offset = "0x439ED0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetMessage), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001F0A")]
	public static NetMessage New() { }

}

