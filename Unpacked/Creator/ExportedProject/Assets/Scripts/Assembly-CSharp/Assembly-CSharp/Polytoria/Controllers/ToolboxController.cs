namespace Polytoria.Controllers;

[Token(Token = "0x200041E")]
public class ToolboxController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000420")]
	private sealed class <>c
	{
		[Token(Token = "0x4001169")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400116A")]
		public static Action<Instance> <>9__24_0; //Field offset: 0x8

		[Address(RVA = "0x4E8460", Offset = "0x4E7660", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002BBA")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BBB")]
		public <>c() { }

		[Address(RVA = "0x4E7870", Offset = "0x4E6A70", Length = "0xAA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CreatorController), Member = "ToolboxModelAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Model)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002BBC")]
		internal void <InsertModel>b__24_0(Instance i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000421")]
	private sealed class <>c__DisplayClass22_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400116B")]
		public JSONNode entry; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400116C")]
		public ToolboxController <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BBD")]
		public <>c__DisplayClass22_0() { }

		[Address(RVA = "0x4E7E70", Offset = "0x4E7070", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ToolboxController), Member = "InsertModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002BBE")]
		internal void <DoReloadToolbox>b__0() { }

		[Address(RVA = "0x4E7EF0", Offset = "0x4E70F0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ToolboxController), Member = "InsertModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002BBF")]
		internal void <DoReloadToolbox>b__1() { }

		[Address(RVA = "0x4E7F70", Offset = "0x4E7170", Length = "0xA8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002BC0")]
		internal void <DoReloadToolbox>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000422")]
	private sealed class <DoReloadToolbox>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400116D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400116E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400116F")]
		public ToolboxController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001170")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x28

		[Token(Token = "0x17000CF0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BC5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CF1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BC7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC1")]
		public <DoReloadToolbox>d__22(int <>1__state) { }

		[Address(RVA = "0x4E3320", Offset = "0x4E2520", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002BC4")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E24F0", Offset = "0x4E16F0", Length = "0xD58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
		[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "EscapeURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF8D0")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 13)]
		[Token(Token = "0x6002BC3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E3250", Offset = "0x4E2450", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002BC6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E3290", Offset = "0x4E2490", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF860")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002BC2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000423")]
	private sealed class <LoadThumbnail>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001171")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001172")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001173")]
		public JSONNode entry; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001174")]
		public RawImage image; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001175")]
		private UnityWebRequest <twr>5__2; //Field offset: 0x30

		[Token(Token = "0x17000CF2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BCC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CF3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BCE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC8")]
		public <LoadThumbnail>d__23(int <>1__state) { }

		[Address(RVA = "0x4E77A0", Offset = "0x4E69A0", Length = "0x50")]
		[CalledBy(Type = typeof(<LoadThumbnail>d__23), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002BCB")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E73F0", Offset = "0x4E65F0", Length = "0x2D9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(<LoadThumbnail>d__23), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[Calls(Type = typeof(RawImage), Member = "set_texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DownloadHandlerTexture), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFB30")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002BCA")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BCC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BCE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E76D0", Offset = "0x4E68D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002BCD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E7710", Offset = "0x4E6910", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFCF0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002BC9")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200041F")]
	internal enum ToolboxCategory
	{
		RecentlyUpdated = 0,
		UploadedModels = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400115E")]
	private TMP_Dropdown categorySelector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400115F")]
	private RectTransform toolboxContainer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4001160")]
	private RectTransform entryPrefab; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001161")]
	private TMP_Text pageLabel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001162")]
	private int page; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001163")]
	private int pageLimit; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001164")]
	private ToolboxCategory cat; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001165")]
	private string searchQuery; //Field offset: 0x50

	[Token(Token = "0x17000CEE")]
	public ToolboxCategory Category
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAC")]
		 get { } //Length: 4
		[Address(RVA = "0x4E0440", Offset = "0x4DF640", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
		[Token(Token = "0x6002BAD")]
		 set { } //Length: 10
	}

	[Token(Token = "0x17000CED")]
	public int Page
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAA")]
		 get { } //Length: 4
		[Address(RVA = "0x4E0450", Offset = "0x4DF650", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
		[Token(Token = "0x6002BAB")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000CEF")]
	public string SearchQuery
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAE")]
		 get { } //Length: 5
		[Address(RVA = "0x4E0180", Offset = "0x4DF380", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAF")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x4E0420", Offset = "0x4DF620", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002BB9")]
	public ToolboxController() { }

	[Address(RVA = "0x4DFDD0", Offset = "0x4DEFD0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoReloadToolbox>d__22))]
	[Token(Token = "0x6002BB5")]
	private IEnumerator DoReloadToolbox() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAC")]
	public ToolboxCategory get_Category() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAA")]
	public int get_Page() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAE")]
	public string get_SearchQuery() { }

	[Address(RVA = "0x4DFE40", Offset = "0x4DF040", Length = "0x18A")]
	[CalledBy(Type = typeof(<>c__DisplayClass22_0), Member = "<DoReloadToolbox>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass22_0), Member = "<DoReloadToolbox>b__1", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameIO), Member = "LoadModelFromSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Instance), typeof(System.Action`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002BB7")]
	public void InsertModel(int id) { }

	[Address(RVA = "0x4DFFD0", Offset = "0x4DF1D0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadThumbnail>d__23))]
	[Token(Token = "0x6002BB6")]
	private IEnumerator LoadThumbnail(JSONNode entry, RawImage image) { }

	[Address(RVA = "0x4E0060", Offset = "0x4DF260", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[Token(Token = "0x6002BB4")]
	public void PageDown() { }

	[Address(RVA = "0x4E00A0", Offset = "0x4DF2A0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002BB3")]
	public void PageUp() { }

	[Address(RVA = "0x4E00E0", Offset = "0x4DF2E0", Length = "0x71")]
	[CalledBy(Type = typeof(ToolboxController), Member = "set_Page", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "set_Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToolboxCategory)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "set_SearchQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "SetSearchQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "PageDown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "SetCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002BB2")]
	public void ReloadToolbox() { }

	[Address(RVA = "0x4E0440", Offset = "0x4DF640", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[Token(Token = "0x6002BAD")]
	public void set_Category(ToolboxCategory value) { }

	[Address(RVA = "0x4E0450", Offset = "0x4DF650", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[Token(Token = "0x6002BAB")]
	public void set_Page(int value) { }

	[Address(RVA = "0x4E0180", Offset = "0x4DF380", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAF")]
	public void set_SearchQuery(string value) { }

	[Address(RVA = "0x4E0160", Offset = "0x4DF360", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[Token(Token = "0x6002BB8")]
	public void SetCategory(int c) { }

	[Address(RVA = "0x4E0180", Offset = "0x4DF380", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ToolboxController), Member = "ReloadToolbox", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BB1")]
	public void SetSearchQuery(string q) { }

	[Address(RVA = "0x4E01B0", Offset = "0x4DF3B0", Length = "0x26A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OptionData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002BB0")]
	private void Start() { }

}

