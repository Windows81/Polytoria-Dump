namespace Mirror;

[AddComponentMenu("Network/Network Ping Display")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-ping-display")]
[Token(Token = "0x2000024")]
public class NetworkPingDisplay : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A1")]
	public Color color; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A2")]
	public int padding; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000A3")]
	public int width; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A4")]
	public int height; //Field offset: 0x38

	[Address(RVA = "0x1218F80", Offset = "0x1218180", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000DE")]
	public NetworkPingDisplay() { }

	[Address(RVA = "0x1218C70", Offset = "0x1217E70", Length = "0x308")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "EndHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConnectionQualityHeuristics), Member = "ColorCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionQuality)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(NetworkTime), Member = "get_rtt", ReturnType = typeof(double))]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DD")]
	private void OnGUI() { }

}

