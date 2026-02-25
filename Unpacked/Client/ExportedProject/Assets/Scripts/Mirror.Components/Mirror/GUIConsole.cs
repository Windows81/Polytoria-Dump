namespace Mirror;

[Token(Token = "0x2000005")]
public class GUIConsole : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	public int height; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000009")]
	public int offsetY; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	public int maxLogCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400000B")]
	public bool showInEditor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	private readonly Queue<LogEntry> log; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000D")]
	[Tooltip("Hotkey to show/hide the console at runtime\nBack Quote is usually on the left above Tab\nChange with caution - F keys are generally already taken in Browsers")]
	public KeyCode hotKey; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000E")]
	private bool visible; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000F")]
	private Vector2 scroll; //Field offset: 0x40

	[Token(Token = "0x17000001")]
	private bool show
	{
		[Address(RVA = "0x120C3F0", Offset = "0x120B5F0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		private get { } //Length: 81
	}

	[Address(RVA = "0x120C320", Offset = "0x120B520", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000009")]
	public GUIConsole() { }

	[Address(RVA = "0x120BCF0", Offset = "0x120AEF0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LogCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCallback)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	private void Awake() { }

	[Address(RVA = "0x120C3F0", Offset = "0x120B5F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	private bool get_show() { }

	[Address(RVA = "0x120BDD0", Offset = "0x120AFD0", Length = "0x389")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "EndScrollView", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Queue`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Queue`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GUILayout), Member = "Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(GUILayoutOption))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUILayout), Member = "Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(GUILayoutOption))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000008")]
	private void OnGUI() { }

	[Address(RVA = "0x120C160", Offset = "0x120B360", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000006")]
	private void OnLog(string message, string stackTrace, LogType type) { }

	[Address(RVA = "0x120C2B0", Offset = "0x120B4B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000007")]
	private void Update() { }

}

