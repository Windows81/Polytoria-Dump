namespace SimpleFileBrowser;

[Token(Token = "0x2000004")]
public class FileBrowser : MonoBehaviour, IListViewAdapter
{
	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000083")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000084")]
		public static Comparison<FileSystemEntry> <>9__222_0; //Field offset: 0x8

		[Address(RVA = "0x15507E0", Offset = "0x154F9E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000092")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000093")]
		public <>c() { }

		[Address(RVA = "0x15504F0", Offset = "0x154F6F0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000094")]
		internal int <RefreshFiles>b__222_0(FileSystemEntry entry1, FileSystemEntry entry2) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <>c__DisplayClass227_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000085")]
		public FileSystemEntry fileInfo; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000086")]
		public FileBrowser <>4__this; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000095")]
		public <>c__DisplayClass227_0() { }

		[Address(RVA = "0x1550550", Offset = "0x154F750", Length = "0x263")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000096")]
		internal void <RenameSelectedFile>b__0(string newName) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c__DisplayClass244_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000087")]
		public bool directoryExists; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000088")]
		public string path; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		public <>c__DisplayClass244_0() { }

		[Address(RVA = "0x15507C0", Offset = "0x154F9C0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000098")]
		internal void <CheckDirectoryExistsWithTimeout>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <CreateNewFolderCoroutine>d__226 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000089")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008A")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400008B")]
		public FileBrowser <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700001B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600009C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600009E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		public <CreateNewFolderCoroutine>d__226(int <>1__state) { }

		[Address(RVA = "0x1550100", Offset = "0x154F300", Length = "0x3AB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FileBrowserRenamedItem), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), typeof(OnRenameCompleted)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600009B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600009C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x15504B0", Offset = "0x154F6B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600009D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <WaitForLoadDialog>d__250 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400008E")]
		public PickMode pickMode; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400008F")]
		public bool allowMultiSelection; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000090")]
		public string initialPath; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000091")]
		public string initialFilename; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000092")]
		public string title; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000093")]
		public string loadButtonText; //Field offset: 0x40

		[Token(Token = "0x1700001D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		public <WaitForLoadDialog>d__250(int <>1__state) { }

		[Address(RVA = "0x1550850", Offset = "0x154FA50", Length = "0x18A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000A1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x15509E0", Offset = "0x154FBE0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60000A3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000012")]
	private sealed class <WaitForSaveDialog>d__249 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000094")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000095")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000096")]
		public PickMode pickMode; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000097")]
		public bool allowMultiSelection; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000098")]
		public string initialPath; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000099")]
		public string initialFilename; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400009A")]
		public string title; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400009B")]
		public string saveButtonText; //Field offset: 0x40

		[Token(Token = "0x1700001F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000020")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		public <WaitForSaveDialog>d__249(int <>1__state) { }

		[Address(RVA = "0x1550A20", Offset = "0x154FC20", Length = "0x18F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000A7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1550BB0", Offset = "0x154FDB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60000A9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A6")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200000C")]
	internal sealed class FileSystemEntryFilter : MulticastDelegate
	{

		[Address(RVA = "0xC462D0", Offset = "0xC454D0", Length = "0xA6")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008E")]
		public FileSystemEntryFilter(object object, IntPtr method) { }

		[Address(RVA = "0x154EAC0", Offset = "0x154DCC0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000090")]
		public override IAsyncResult BeginInvoke(FileSystemEntry entry, AsyncCallback callback, object object) { }

		[Address(RVA = "0x3A5E80", Offset = "0x3A5080", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000091")]
		public override bool EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x80C2A0", Offset = "0x80B4A0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		public override bool Invoke(FileSystemEntry entry) { }

	}

	[Token(Token = "0x2000007")]
	private struct FiletypeIcon
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000079")]
		public string extension; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007A")]
		public Sprite icon; //Field offset: 0x8

	}

	[Token(Token = "0x2000009")]
	internal class Filter
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007E")]
		public readonly string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400007F")]
		public readonly String[] extensions; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000080")]
		public readonly HashSet<String> extensionsSet; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000081")]
		public readonly string defaultExtension; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000082")]
		public readonly bool allExtensionsHaveSingleSuffix; //Field offset: 0x30

		[Address(RVA = "0x154F0E0", Offset = "0x154E2E0", Length = "0x65")]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_AllFilesFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000081")]
		internal Filter(string name) { }

		[Address(RVA = "0x154F150", Offset = "0x154E350", Length = "0x199")]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportModel", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportGLTF", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ImportModel", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileOpen", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000082")]
		public Filter(string name, string extension) { }

		[Address(RVA = "0x154EEF0", Offset = "0x154E0F0", Length = "0x1E3")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileOpen", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000083")]
		public Filter(string name, String[] extensions) { }

		[Address(RVA = "0x154EC70", Offset = "0x154DE70", Length = "0x124")]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000084")]
		public bool MatchesExtension(string extension, bool extensionMayHaveMultipleSuffixes) { }

		[Address(RVA = "0x154EDA0", Offset = "0x154DFA0", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000085")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x200000B")]
	internal sealed class OnCancel : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008A")]
		public OnCancel(object object, IntPtr method) { }

		[Address(RVA = "0x2D87D0", Offset = "0x2D79D0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008D")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		public override void Invoke() { }

	}

	[Token(Token = "0x200000A")]
	internal sealed class OnSuccess : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000086")]
		public OnSuccess(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000088")]
		public override IAsyncResult BeginInvoke(String[] paths, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000089")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000087")]
		public override void Invoke(String[] paths) { }

	}

	[Token(Token = "0x2000005")]
	internal enum Permission
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2,
	}

	[Token(Token = "0x2000006")]
	internal enum PickMode
	{
		Files = 0,
		Folders = 1,
		FilesAndFolders = 2,
	}

	[Token(Token = "0x2000008")]
	private struct QuickLink
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		public SpecialFolder target; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007C")]
		public string name; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007D")]
		public Sprite icon; //Field offset: 0x10

	}

	[Token(Token = "0x4000006")]
	private const int FILENAME_INPUT_FIELD_MAX_FILE_COUNT = 7; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private const string SAF_PICK_FOLDER_QUICK_LINK_PATH = "SAF_PICK_FOLDER"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000008")]
	private static bool <IsOpen>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000009")]
	private static bool <Success>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	[Token(Token = "0x400000A")]
	private static String[] <Result>k__BackingField; //Field offset: 0x8
	[Token(Token = "0x400000F")]
	private static bool m_askPermissions; //Field offset: 0x10
	[Token(Token = "0x4000010")]
	private static bool m_singleClickMode; //Field offset: 0x11
	[Token(Token = "0x4000011")]
	private static FileSystemEntryFilter m_displayedEntriesFilter; //Field offset: 0x18
	[Token(Token = "0x4000012")]
	private static float m_drivesRefreshInterval; //Field offset: 0x20
	[Token(Token = "0x4000013")]
	private static bool m_displayHiddenFilesToggle; //Field offset: 0x24
	[Token(Token = "0x4000014")]
	private static string m_allFilesFilterText; //Field offset: 0x28
	[Token(Token = "0x4000015")]
	private static string m_foldersFilterText; //Field offset: 0x30
	[Token(Token = "0x4000016")]
	private static string m_pickFolderQuickLinkText; //Field offset: 0x38
	[Token(Token = "0x4000017")]
	private static FileBrowser m_instance; //Field offset: 0x40
	[Token(Token = "0x400001F")]
	private static bool quickLinksInitialized; //Field offset: 0x48
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private UISkin m_skin; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000C")]
	private int m_skinVersion; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000D")]
	private Sprite m_skinPrevDriveIcon; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	private Sprite m_skinPrevFolderIcon; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Header("Settings")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	internal int minWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	internal int minHeight; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private float narrowScreenWidth; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private float quickLinksMaxWidthPercentage; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private bool sortFilesByName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("excludeExtensions")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private String[] excludedExtensions; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private QuickLink[] quickLinks; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000020")]
	private readonly HashSet<String> excludedExtensionsSet; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private bool generateQuickLinksForDrives; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private bool contextMenuShowDeleteButton; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private bool contextMenuShowRenameButton; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private bool showResizeCursor; //Field offset: 0x73
	[FieldOffset(Offset = "0x78")]
	[Header("Internal References")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private FileBrowserMovement window; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000026")]
	private RectTransform windowTR; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private RectTransform topViewNarrowScreen; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000028")]
	private RectTransform middleView; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000029")]
	private Vector2 middleViewOriginalPosition; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400002A")]
	private Vector2 middleViewOriginalSize; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private RectTransform middleViewQuickLinks; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400002C")]
	private Vector2 middleViewQuickLinksOriginalSize; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400002D")]
	private RectTransform middleViewFiles; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x400002E")]
	private RectTransform middleViewSeparator; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400002F")]
	private FileBrowserItem itemPrefab; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000030")]
	private readonly List<FileBrowserItem> allItems; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000031")]
	private FileBrowserQuickLink quickLinkPrefab; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000032")]
	private readonly List<FileBrowserQuickLink> allQuickLinks; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000033")]
	private Text titleText; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000034")]
	private Button backButton; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000035")]
	private Button forwardButton; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000036")]
	private Button upButton; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private Button moreOptionsButton; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private InputField pathInputField; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000039")]
	private RectTransform pathInputFieldSlotTop; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x400003A")]
	private RectTransform pathInputFieldSlotBottom; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x400003B")]
	private InputField searchInputField; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x400003C")]
	private RectTransform quickLinksContainer; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400003D")]
	private ScrollRect quickLinksScrollRect; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x400003E")]
	private RectTransform filesContainer; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x400003F")]
	private ScrollRect filesScrollRect; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000040")]
	private RecycledListView listView; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000041")]
	private InputField filenameInputField; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000042")]
	private Text filenameInputFieldOverlayText; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private Image filenameImage; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	private Dropdown filtersDropdown; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private RectTransform filtersDropdownContainer; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x4000046")]
	private Text filterItemTemplate; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x4000047")]
	private Toggle showHiddenFilesToggle; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x4000048")]
	private Text submitButtonText; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x4000049")]
	private Button[] allButtons; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x400004A")]
	private RectTransform moreOptionsContextMenuPosition; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private FileBrowserRenamedItem renameItem; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x400004C")]
	private FileBrowserContextMenu contextMenu; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private FileBrowserDeleteConfirmationPanel deleteConfirmationPanel; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private FileBrowserCursorHandler resizeCursorHandler; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400004F")]
	internal RectTransform rectTransform; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000050")]
	private Canvas canvas; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000051")]
	private FileAttributes ignoredFileAttributes; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000052")]
	private FileSystemEntry[] allFileEntries; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000053")]
	private readonly List<FileSystemEntry> validFileEntries; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000054")]
	private readonly List<Int32> selectedFileEntries; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000055")]
	private readonly List<String> pendingFileEntrySelection; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000056")]
	private int multiSelectionPivotFileEntry; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000057")]
	private StringBuilder multiSelectionFilenameBuilder; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000058")]
	private readonly List<Filter> filters; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000059")]
	private Filter allFilesFilter; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400005A")]
	private bool showAllFilesFilter; //Field offset: 0x220
	[FieldOffset(Offset = "0x221")]
	[Token(Token = "0x400005B")]
	private bool allFiltersHaveSingleSuffix; //Field offset: 0x221
	[FieldOffset(Offset = "0x222")]
	[Token(Token = "0x400005C")]
	private bool allExcludedExtensionsHaveSingleSuffix; //Field offset: 0x222
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400005D")]
	private string defaultInitialPath; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x400005E")]
	private int currentPathIndex; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x400005F")]
	private readonly List<String> pathsFollowed; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000060")]
	private HashSet<Char> invalidFilenameChars; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000061")]
	private float drivesNextRefreshTime; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000062")]
	private String[] driveQuickLinks; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000063")]
	private int numberOfDriveQuickLinks; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000064")]
	private readonly List<String> timedOutDirectoryExistsRequests; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000065")]
	private bool canvasDimensionsChanged; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000066")]
	private readonly CompareInfo textComparer; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000067")]
	private readonly CompareOptions textCompareOptions; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000068")]
	private PointerEventData nullPointerEventData; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000069")]
	private string m_currentPath; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400006A")]
	private string m_searchString; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400006B")]
	private bool m_acceptNonExistingFilename; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x400006C")]
	private PickMode m_pickerMode; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400006D")]
	private bool m_allowMultiSelection; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A1")]
	[Token(Token = "0x400006E")]
	private bool m_multiSelectionToggleSelectionMode; //Field offset: 0x2A1
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400006F")]
	private OnSuccess onSuccess; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000070")]
	private OnCancel onCancel; //Field offset: 0x2B0

	[Token(Token = "0x14000001")]
	public static event FileSystemEntryFilter DisplayedEntriesFilter
	{
		[Address(RVA = "0x154C7F0", Offset = "0x154B9F0", Length = "0x24D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600000F")]
		 add { } //Length: 589
		[Address(RVA = "0x154D140", Offset = "0x154C340", Length = "0x19B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000010")]
		 remove { } //Length: 411
	}

	[Token(Token = "0x17000011")]
	private bool AcceptNonExistingFilename
	{
		[Address(RVA = "0x154CA40", Offset = "0x154BC40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000023")]
		private get { } //Length: 8
		[Address(RVA = "0x154D2E0", Offset = "0x154C4E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000024")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700000E")]
	private bool AllExtensionsHaveSingleSuffix
	{
		[Address(RVA = "0x154CA50", Offset = "0x154BC50", Length = "0x54")]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600001E")]
		private get { } //Length: 84
	}

	[Token(Token = "0x1700000A")]
	public static string AllFilesFilterText
	{
		[Address(RVA = "0x154CAB0", Offset = "0x154BCB0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 79
		[Address(RVA = "0x154D2F0", Offset = "0x154C4F0", Length = "0x385")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000018")]
		 set { } //Length: 901
	}

	[Token(Token = "0x17000013")]
	internal bool AllowMultiSelection
	{
		[Address(RVA = "0x492EB0", Offset = "0x4920B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		internal get { } //Length: 8
		[Address(RVA = "0x154D680", Offset = "0x154C880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000028")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000005")]
	public static bool AskPermissions
	{
		[Address(RVA = "0x154CB00", Offset = "0x154BD00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 79
		[Address(RVA = "0x154D690", Offset = "0x154C890", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 84
	}

	[Token(Token = "0x1700000F")]
	private string CurrentPath
	{
		[Address(RVA = "0x154CB50", Offset = "0x154BD50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		private get { } //Length: 8
		[Address(RVA = "0x154D6F0", Offset = "0x154C8F0", Length = "0x497")]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnPathChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnBackButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnForwardButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnUpButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000020")]
		private set { } //Length: 1175
	}

	[Token(Token = "0x17000009")]
	public static bool DisplayHiddenFilesToggle
	{
		[Address(RVA = "0x154CB60", Offset = "0x154BD60", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 79
		[Address(RVA = "0x154DB90", Offset = "0x154CD90", Length = "0x1ED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 493
	}

	[Token(Token = "0x17000007")]
	public static float DrivesRefreshInterval
	{
		[Address(RVA = "0x154CBB0", Offset = "0x154BDB0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 80
		[Address(RVA = "0x154DD80", Offset = "0x154CF80", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000012")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700000B")]
	public static string FoldersFilterText
	{
		[Address(RVA = "0x154CC00", Offset = "0x154BE00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 79
		[Address(RVA = "0x154DDE0", Offset = "0x154CFE0", Length = "0x201")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600001A")]
		 set { } //Length: 513
	}

	[Token(Token = "0x1700000D")]
	private static FileBrowser Instance
	{
		[Address(RVA = "0x154CC50", Offset = "0x154BE50", Length = "0x1D2")]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_ShowHiddenFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "get_ShowHiddenFiles", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
		[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Token(Token = "0x600001D")]
		private get { } //Length: 466
	}

	[Token(Token = "0x17000001")]
	public private static bool IsOpen
	{
		[Address(RVA = "0x154CE30", Offset = "0x154C030", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000003")]
		 get { } //Length: 78
		[Address(RVA = "0x154DFF0", Offset = "0x154D1F0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		private set { } //Length: 83
	}

	[Token(Token = "0x17000017")]
	private string LastBrowsedFolder
	{
		[Address(RVA = "0x154CE80", Offset = "0x154C080", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x600002F")]
		private get { } //Length: 53
		[Address(RVA = "0x154E050", Offset = "0x154D250", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000030")]
		private set { } //Length: 60
	}

	[Token(Token = "0x17000014")]
	internal bool MultiSelectionToggleSelectionMode
	{
		[Address(RVA = "0x154CEC0", Offset = "0x154C0C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000029")]
		internal get { } //Length: 8
		[Address(RVA = "0x154E090", Offset = "0x154D290", Length = "0x165")]
		[CalledBy(Type = typeof(<CreateNewFolderCoroutine>d__226), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600002A")]
		private set { } //Length: 357
	}

	[Token(Token = "0x17000012")]
	internal PickMode PickerMode
	{
		[Address(RVA = "0x154CF20", Offset = "0x154C120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		internal get { } //Length: 7
		[Address(RVA = "0x154E460", Offset = "0x154D660", Length = "0x295")]
		[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000026")]
		private set { } //Length: 661
	}

	[Token(Token = "0x1700000C")]
	public static string PickFolderQuickLinkText
	{
		[Address(RVA = "0x154CED0", Offset = "0x154C0D0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 79
		[Address(RVA = "0x154E200", Offset = "0x154D400", Length = "0x254")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
		[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600001C")]
		 set { } //Length: 596
	}

	[Token(Token = "0x17000003")]
	public private static String[] Result
	{
		[Address(RVA = "0x154CF30", Offset = "0x154C130", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 get { } //Length: 79
		[Address(RVA = "0x154E700", Offset = "0x154D900", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000010")]
	private string SearchString
	{
		[Address(RVA = "0x154CF80", Offset = "0x154C180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		private get { } //Length: 8
		[Address(RVA = "0x154E770", Offset = "0x154D970", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000022")]
		private set { } //Length: 113
	}

	[Token(Token = "0x17000008")]
	public static bool ShowHiddenFiles
	{
		[Address(RVA = "0x154CF90", Offset = "0x154C190", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 94
		[Address(RVA = "0x154E7F0", Offset = "0x154D9F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000014")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000019")]
	private override int SimpleFileBrowser.IListViewAdapter.Count
	{
		[Address(RVA = "0x154B7E0", Offset = "0x154A9E0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000038")]
		private get { } //Length: 63
	}

	[Token(Token = "0x1700001A")]
	private override float SimpleFileBrowser.IListViewAdapter.ItemHeight
	{
		[Address(RVA = "0x154B820", Offset = "0x154AA20", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000039")]
		private get { } //Length: 31
	}

	[Token(Token = "0x17000018")]
	private override OnItemClickedHandler SimpleFileBrowser.IListViewAdapter.OnItemClicked
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		private get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000037")]
		private set { } //Length: 3
	}

	[Token(Token = "0x17000006")]
	public static bool SingleClickMode
	{
		[Address(RVA = "0x154CFF0", Offset = "0x154C1F0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 79
		[Address(RVA = "0x154E860", Offset = "0x154DA60", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000004")]
	public static UISkin Skin
	{
		[Address(RVA = "0x154D040", Offset = "0x154C240", Length = "0x4F")]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 79
		[Address(RVA = "0x154E8C0", Offset = "0x154DAC0", Length = "0x133")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 307
	}

	[Token(Token = "0x17000016")]
	private string SubmitButtonText
	{
		[Address(RVA = "0x154D090", Offset = "0x154C290", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002D")]
		private get { } //Length: 45
		[Address(RVA = "0x154EA00", Offset = "0x154DC00", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		private set { } //Length: 45
	}

	[Token(Token = "0x17000002")]
	public private static bool Success
	{
		[Address(RVA = "0x154D0C0", Offset = "0x154C2C0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 get { } //Length: 79
		[Address(RVA = "0x154EA30", Offset = "0x154DC30", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000015")]
	private string Title
	{
		[Address(RVA = "0x154D110", Offset = "0x154C310", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002B")]
		private get { } //Length: 45
		[Address(RVA = "0x154EA90", Offset = "0x154DC90", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002C")]
		private set { } //Length: 45
	}

	[Address(RVA = "0x154C2A0", Offset = "0x154B4A0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600007E")]
	private static FileBrowser() { }

	[Address(RVA = "0x154C410", Offset = "0x154B610", Length = "0x3DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007D")]
	public FileBrowser() { }

	[Address(RVA = "0x154B840", Offset = "0x154AA40", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007F")]
	private void <CreateNewFolderCoroutine>b__226_0(string folderName) { }

	[Address(RVA = "0x154BAD0", Offset = "0x154ACD0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000080")]
	private void <DeleteSelectedFiles>b__228_0() { }

	[Address(RVA = "0x154C7F0", Offset = "0x154B9F0", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000F")]
	public static void add_DisplayedEntriesFilter(FileSystemEntryFilter value) { }

	[Address(RVA = "0x1542BB0", Offset = "0x1541DB0", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18153F2A0")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000070")]
	public static bool AddQuickLink(string name, string path, Sprite icon = null) { }

	[Address(RVA = "0x1542CF0", Offset = "0x1541EF0", Length = "0x2B1")]
	[CalledBy(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "CheckDirectoryExistsWithTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600005B")]
	private bool AddQuickLink(Sprite icon, string name, string path) { }

	[Address(RVA = "0x1542FB0", Offset = "0x15421B0", Length = "0x776")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_onValidateInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnValidateInput)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000031")]
	private void Awake() { }

	[Address(RVA = "0x1543730", Offset = "0x1542930", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Text), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_fontStyle", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FontStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CharacterInfo&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000067")]
	private int CalculateLengthOfDropdownText(string str) { }

	[Address(RVA = "0x1543880", Offset = "0x1542A80", Length = "0x197")]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000069")]
	private bool CheckDirectoryExistsWithTimeout(string path, int timeout = 750) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public static Permission CheckPermission() { }

	[Address(RVA = "0x1543C80", Offset = "0x1542E80", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000071")]
	public static void ClearQuickLinks() { }

	[Address(RVA = "0x1543A20", Offset = "0x1542C20", Length = "0x253")]
	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600005C")]
	private void ClearQuickLinksInternal() { }

	[Address(RVA = "0x1543D50", Offset = "0x1542F50", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000056")]
	public void CreateNewFolder() { }

	[Address(RVA = "0x1543CE0", Offset = "0x1542EE0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CreateNewFolderCoroutine>d__226))]
	[Token(Token = "0x6000057")]
	private IEnumerator CreateNewFolderCoroutine() { }

	[Address(RVA = "0x1543DD0", Offset = "0x1542FD0", Length = "0x165")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnDeleteButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(System.Collections.Generic.List`1<SimpleFileBrowser.FileSystemEntry>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(OnDeletionConfirmed)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000059")]
	public void DeleteSelectedFiles() { }

	[Address(RVA = "0x1543F40", Offset = "0x1543140", Length = "0xB8")]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnDeselectAllButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000055")]
	public void DeselectAllFiles() { }

	[Address(RVA = "0x1544000", Offset = "0x1543200", Length = "0x9C")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	private void EnsureScrollViewIsWithinBounds() { }

	[Address(RVA = "0x15440A0", Offset = "0x15432A0", Length = "0x1F8")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnEndResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005E")]
	internal void EnsureWindowIsWithinBounds() { }

	[Address(RVA = "0x15442A0", Offset = "0x15434A0", Length = "0x139")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000064")]
	private int ExtractFilenameFromInput(string input, ref int startIndex, out int nextStartIndex) { }

	[Address(RVA = "0x15443E0", Offset = "0x15435E0", Length = "0x12E")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000065")]
	private int FilenameInputToFileEntryIndex(string input, int startIndex, int length) { }

	[Address(RVA = "0x154CA40", Offset = "0x154BC40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000023")]
	private bool get_AcceptNonExistingFilename() { }

	[Address(RVA = "0x154CA50", Offset = "0x154BC50", Length = "0x54")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001E")]
	private bool get_AllExtensionsHaveSingleSuffix() { }

	[Address(RVA = "0x154CAB0", Offset = "0x154BCB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000017")]
	public static string get_AllFilesFilterText() { }

	[Address(RVA = "0x492EB0", Offset = "0x4920B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	internal bool get_AllowMultiSelection() { }

	[Address(RVA = "0x154CB00", Offset = "0x154BD00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600000B")]
	public static bool get_AskPermissions() { }

	[Address(RVA = "0x154CB50", Offset = "0x154BD50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	private string get_CurrentPath() { }

	[Address(RVA = "0x154CB60", Offset = "0x154BD60", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000015")]
	public static bool get_DisplayHiddenFilesToggle() { }

	[Address(RVA = "0x154CBB0", Offset = "0x154BDB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000011")]
	public static float get_DrivesRefreshInterval() { }

	[Address(RVA = "0x154CC00", Offset = "0x154BE00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000019")]
	public static string get_FoldersFilterText() { }

	[Address(RVA = "0x154CC50", Offset = "0x154BE50", Length = "0x1D2")]
	[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "get_ShowHiddenFiles", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_ShowHiddenFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x600001D")]
	private static FileBrowser get_Instance() { }

	[Address(RVA = "0x154CE30", Offset = "0x154C030", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000003")]
	public static bool get_IsOpen() { }

	[Address(RVA = "0x154CE80", Offset = "0x154C080", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600002F")]
	private string get_LastBrowsedFolder() { }

	[Address(RVA = "0x154CEC0", Offset = "0x154C0C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000029")]
	internal bool get_MultiSelectionToggleSelectionMode() { }

	[Address(RVA = "0x154CF20", Offset = "0x154C120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000025")]
	internal PickMode get_PickerMode() { }

	[Address(RVA = "0x154CED0", Offset = "0x154C0D0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600001B")]
	public static string get_PickFolderQuickLinkText() { }

	[Address(RVA = "0x154CF30", Offset = "0x154C130", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public static String[] get_Result() { }

	[Address(RVA = "0x154CF80", Offset = "0x154C180", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	private string get_SearchString() { }

	[Address(RVA = "0x154CF90", Offset = "0x154C190", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000013")]
	public static bool get_ShowHiddenFiles() { }

	[Address(RVA = "0x154CFF0", Offset = "0x154C1F0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600000D")]
	public static bool get_SingleClickMode() { }

	[Address(RVA = "0x154D040", Offset = "0x154C240", Length = "0x4F")]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000009")]
	public static UISkin get_Skin() { }

	[Address(RVA = "0x154D090", Offset = "0x154C290", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	private string get_SubmitButtonText() { }

	[Address(RVA = "0x154D0C0", Offset = "0x154C2C0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	public static bool get_Success() { }

	[Address(RVA = "0x154D110", Offset = "0x154C310", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	private string get_Title() { }

	[Address(RVA = "0x1544510", Offset = "0x1543710", Length = "0xCB")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserHelpers), Member = "GetEntriesInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileSystemEntry[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000061")]
	internal static string GetExtensionFromFilename(string filename, bool extractOnlyLastSuffix) { }

	[Address(RVA = "0x15445E0", Offset = "0x15437E0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry), typeof(bool)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000060")]
	internal Sprite GetIconForFileEntry(FileSystemEntry fileInfo) { }

	[Address(RVA = "0x1544670", Offset = "0x1543870", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000068")]
	private string GetInitialPath(string initialPath) { }

	[Address(RVA = "0x15447B0", Offset = "0x15439B0", Length = "0x113")]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000062")]
	private string GetPathWithoutTrailingDirectorySeparator(string path) { }

	[Address(RVA = "0x1544930", Offset = "0x1543B30", Length = "0x12B")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000052")]
	public void Hide() { }

	[Address(RVA = "0x15448D0", Offset = "0x1543AD0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006D")]
	public static void HideDialog(bool invokeCancelCallback = false) { }

	[Address(RVA = "0x1544A60", Offset = "0x1543C60", Length = "0x151")]
	[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	private void InitializeQuickLinks() { }

	[Address(RVA = "0x1544BC0", Offset = "0x1543DC0", Length = "0x583")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "SelectAllFiles", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "DeleteSelectedFiles", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureWindowIsWithinBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000034")]
	private void LateUpdate() { }

	[Address(RVA = "0x1545150", Offset = "0x1544350", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Token(Token = "0x6000035")]
	private void OnApplicationFocus(bool focus) { }

	[Address(RVA = "0x1545170", Offset = "0x1544370", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	public void OnBackButtonPressed() { }

	[Address(RVA = "0x15451F0", Offset = "0x15443F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000046")]
	public void OnCancelButtonClicked() { }

	[Address(RVA = "0x1545200", Offset = "0x1544400", Length = "0x10E")]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "ShowContextMenuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000043")]
	internal void OnContextMenuTriggered(Vector2 pointerPos) { }

	[Address(RVA = "0x1545310", Offset = "0x1544510", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000050")]
	private void OnFilenameInputChanged(string text) { }

	[Address(RVA = "0x1545380", Offset = "0x1544580", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	public void OnFilterChanged() { }

	[Address(RVA = "0x15454B0", Offset = "0x15446B0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	public void OnForwardButtonPressed() { }

	[Address(RVA = "0x1545540", Offset = "0x1544740", Length = "0x1D4")]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004E")]
	public void OnItemHeld(FileBrowserItem item) { }

	[Address(RVA = "0x1545720", Offset = "0x1544920", Length = "0x679")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(FileBrowser), Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	public void OnItemSelected(FileBrowserItem item, bool isDoubleClick) { }

	[Address(RVA = "0x1545DA0", Offset = "0x1544FA0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FileBrowser), Member = "ShowContextMenuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000042")]
	public void OnMoreOptionsButtonClicked() { }

	[Address(RVA = "0x1545E30", Offset = "0x1545030", Length = "0x19D")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnCancelButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	private void OnOperationCanceled(bool invokeCancelCallback) { }

	[Address(RVA = "0x1545FD0", Offset = "0x15451D0", Length = "0x198")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private void OnOperationSuccessful(String[] paths) { }

	[Address(RVA = "0x1546170", Offset = "0x1545370", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000049")]
	public void OnPathChanged(string newPath) { }

	[Address(RVA = "0x15461F0", Offset = "0x15453F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000032")]
	private void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1546200", Offset = "0x1545400", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004A")]
	public void OnSearchStringChanged(string newSearchString) { }

	[Address(RVA = "0x15462D0", Offset = "0x15454D0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600004C")]
	public void OnShowHiddenFilesToggleChanged() { }

	[Address(RVA = "0x1546350", Offset = "0x1545550", Length = "0x7FD")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnValidateFilenameInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileBrowser), Member = "FilenameInputToFileEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "ChangeExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Filter), Member = "MatchesExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "GetExtensionFromFilename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "VerifyFilenameInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FileBrowser), Member = "ExtractFilenameFromInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000045")]
	public void OnSubmitButtonClicked() { }

	[Address(RVA = "0x1546B50", Offset = "0x1545D50", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	public void OnUpButtonPressed() { }

	[Address(RVA = "0x1546BA0", Offset = "0x1545DA0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[Token(Token = "0x600004F")]
	private char OnValidateFilenameInput(string text, int charIndex, char addedChar) { }

	[Address(RVA = "0x1546BD0", Offset = "0x1545DD0", Length = "0x450")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005F")]
	internal void OnWindowDimensionsChanged(Vector2 size) { }

	[Address(RVA = "0x1547030", Offset = "0x1546230", Length = "0x196")]
	[CalledBy(Type = typeof(FileBrowser), Member = "add_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "remove_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnShowHiddenFilesToggleChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600005A")]
	private void PersistFileEntrySelection() { }

	[Address(RVA = "0x15471D0", Offset = "0x15463D0", Length = "0x567")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600003D")]
	private void RefreshDriveQuickLinks() { }

	[Address(RVA = "0x1547740", Offset = "0x1546940", Length = "0x88A")]
	[CalledBy(Type = typeof(FileBrowser), Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnShowHiddenFilesToggleChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_SearchString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "remove_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "add_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass227_0), Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D2A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180021EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Filter), Member = "MatchesExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserHelpers), Member = "GetEntriesInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileSystemEntry[]))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000053")]
	public void RefreshFiles(bool pathChanged) { }

	[Address(RVA = "0x1547FD0", Offset = "0x15471D0", Length = "0x1050")]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserRenamedItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RecycledListView), Member = "DestroyItemsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(FileBrowserContextMenu), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 21)]
	[Token(Token = "0x600003E")]
	private void RefreshSkin() { }

	[Address(RVA = "0x154D140", Offset = "0x154C340", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000010")]
	public static void remove_DisplayedEntriesFilter(FileSystemEntryFilter value) { }

	[Address(RVA = "0x1549030", Offset = "0x1548230", Length = "0x4F5")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnRenameButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry), typeof(bool)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FileBrowserRenamedItem), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), typeof(OnRenameCompleted)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000058")]
	public void RenameSelectedFile() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public static Permission RequestPermission() { }

	[Address(RVA = "0x1549530", Offset = "0x1548730", Length = "0x1D0")]
	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnSelectAllButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000054")]
	public void SelectAllFiles() { }

	[Address(RVA = "0x154D2E0", Offset = "0x154C4E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000024")]
	private void set_AcceptNonExistingFilename(bool value) { }

	[Address(RVA = "0x154D2F0", Offset = "0x154C4F0", Length = "0x385")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000018")]
	public static void set_AllFilesFilterText(string value) { }

	[Address(RVA = "0x154D680", Offset = "0x154C880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000028")]
	private void set_AllowMultiSelection(bool value) { }

	[Address(RVA = "0x154D690", Offset = "0x154C890", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600000C")]
	public static void set_AskPermissions(bool value) { }

	[Address(RVA = "0x154D6F0", Offset = "0x154C8F0", Length = "0x497")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnUpButtonPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnBackButtonPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnPathChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnForwardButtonPressed", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000020")]
	private void set_CurrentPath(string value) { }

	[Address(RVA = "0x154DB90", Offset = "0x154CD90", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000016")]
	public static void set_DisplayHiddenFilesToggle(bool value) { }

	[Address(RVA = "0x154DD80", Offset = "0x154CF80", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000012")]
	public static void set_DrivesRefreshInterval(float value) { }

	[Address(RVA = "0x154DDE0", Offset = "0x154CFE0", Length = "0x201")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600001A")]
	public static void set_FoldersFilterText(string value) { }

	[Address(RVA = "0x154DFF0", Offset = "0x154D1F0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	private static void set_IsOpen(bool value) { }

	[Address(RVA = "0x154E050", Offset = "0x154D250", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000030")]
	private void set_LastBrowsedFolder(string value) { }

	[Address(RVA = "0x154E090", Offset = "0x154D290", Length = "0x165")]
	[CalledBy(Type = typeof(<CreateNewFolderCoroutine>d__226), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600002A")]
	private void set_MultiSelectionToggleSelectionMode(bool value) { }

	[Address(RVA = "0x154E460", Offset = "0x154D660", Length = "0x295")]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000026")]
	private void set_PickerMode(PickMode value) { }

	[Address(RVA = "0x154E200", Offset = "0x154D400", Length = "0x254")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
	[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600001C")]
	public static void set_PickFolderQuickLinkText(string value) { }

	[Address(RVA = "0x154E700", Offset = "0x154D900", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	private static void set_Result(String[] value) { }

	[Address(RVA = "0x154E770", Offset = "0x154D970", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000022")]
	private void set_SearchString(string value) { }

	[Address(RVA = "0x154E7F0", Offset = "0x154D9F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000014")]
	public static void set_ShowHiddenFiles(bool value) { }

	[Address(RVA = "0x154E860", Offset = "0x154DA60", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600000E")]
	public static void set_SingleClickMode(bool value) { }

	[Address(RVA = "0x154E8C0", Offset = "0x154DAC0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000A")]
	public static void set_Skin(UISkin value) { }

	[Address(RVA = "0x154EA00", Offset = "0x154DC00", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	private void set_SubmitButtonText(string value) { }

	[Address(RVA = "0x154EA30", Offset = "0x154DC30", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	private static void set_Success(bool value) { }

	[Address(RVA = "0x154EA90", Offset = "0x154DC90", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	private void set_Title(string value) { }

	[Address(RVA = "0x1549710", Offset = "0x1548910", Length = "0x248")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportModel", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportGLTF", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ImportModel", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileOpen", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600007A")]
	public static bool SetDefaultFilter(string defaultFilter) { }

	[Address(RVA = "0x1549960", Offset = "0x1548B60", Length = "0x274")]
	[CalledBy(Type = typeof(FileBrowser), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000072")]
	public static void SetExcludedExtensions(String[] excludedExtensions) { }

	[Address(RVA = "0x154A510", Offset = "0x1549710", Length = "0x29D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	public static void SetFilters(bool showAllFilesFilter, IEnumerable<String> filters) { }

	[Address(RVA = "0x154A3F0", Offset = "0x15495F0", Length = "0x115")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportModel", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ExportGLTF", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ImportModel", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileOpen", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000077")]
	public static void SetFilters(bool showAllFilesFilter, Filter[] filters) { }

	[Address(RVA = "0x154A7B0", Offset = "0x15499B0", Length = "0x26A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public static void SetFilters(bool showAllFilesFilter, IEnumerable<Filter> filters) { }

	[Address(RVA = "0x154A290", Offset = "0x1549490", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000075")]
	public static void SetFilters(bool showAllFilesFilter, String[] filters) { }

	[Address(RVA = "0x154A1E0", Offset = "0x15493E0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[Token(Token = "0x6000073")]
	public static void SetFilters(bool showAllFilesFilter) { }

	[Address(RVA = "0x1549BE0", Offset = "0x1548DE0", Length = "0x4E9")]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CharacterInfo&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FontStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_fontStyle", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Text), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	private static void SetFiltersPostProcessing() { }

	[Address(RVA = "0x154A0D0", Offset = "0x15492D0", Length = "0x108")]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000078")]
	private static void SetFiltersPreProcessing(bool showAllFilesFilter) { }

	[Address(RVA = "0x154AF30", Offset = "0x154A130", Length = "0x43B")]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	public void Show(string initialPath, string initialFilename) { }

	[Address(RVA = "0x154AA20", Offset = "0x1549C20", Length = "0x1F3")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnMoreOptionsButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowserContextMenu), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000044")]
	private void ShowContextMenuAt(Vector2 position, bool isMoreOptionsMenu) { }

	[Address(RVA = "0x154AC20", Offset = "0x1549E20", Length = "0x18E")]
	[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowSaveDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowLoadDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600006C")]
	private static bool ShowDialogInternal(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection, bool acceptNonExistingFilename, string initialPath, string initialFilename, string title, string submitButtonText) { }

	[Address(RVA = "0x154ADB0", Offset = "0x1549FB0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600006B")]
	public static bool ShowLoadDialog(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Load", string loadButtonText = "Select") { }

	[Address(RVA = "0x154AE70", Offset = "0x154A070", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006A")]
	public static bool ShowSaveDialog(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Save", string saveButtonText = "Save") { }

	[Address(RVA = "0x154B370", Offset = "0x154A570", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600003A")]
	private override ListItem SimpleFileBrowser.IListViewAdapter.CreateItem() { }

	[Address(RVA = "0x154B7E0", Offset = "0x154A9E0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000038")]
	private override int SimpleFileBrowser.IListViewAdapter.get_Count() { }

	[Address(RVA = "0x154B820", Offset = "0x154AA20", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000039")]
	private override float SimpleFileBrowser.IListViewAdapter.get_ItemHeight() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	private override OnItemClickedHandler SimpleFileBrowser.IListViewAdapter.get_OnItemClicked() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	private override void SimpleFileBrowser.IListViewAdapter.set_OnItemClicked(OnItemClickedHandler value) { }

	[Address(RVA = "0x154B4C0", Offset = "0x154A6C0", Length = "0x31E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry), typeof(bool)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003B")]
	private override void SimpleFileBrowser.IListViewAdapter.SetItemContent(ListItem item) { }

	[Address(RVA = "0x154BF80", Offset = "0x154B180", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000033")]
	private void Update() { }

	[Address(RVA = "0x154BBF0", Offset = "0x154ADF0", Length = "0x386")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SelectAllFiles", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	private void UpdateFilenameInputFieldWithSelection() { }

	[Address(RVA = "0x154C010", Offset = "0x154B210", Length = "0xEC")]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000066")]
	private bool VerifyFilenameInput(string input, int startIndex, int length) { }

	[Address(RVA = "0x154C100", Offset = "0x154B300", Length = "0xCC")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<ShowImportModelDialog>d__64", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<ShowOpenDialog>d__84", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<WaitForLoadDialog>d__250))]
	[Token(Token = "0x600006F")]
	public static IEnumerator WaitForLoadDialog(PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Load", string loadButtonText = "Select") { }

	[Address(RVA = "0x154C1D0", Offset = "0x154B3D0", Length = "0xCC")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<ShowExportGLTFDialog>d__59", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<ShowExportModelDialog>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<ShowSaveDialog>d__89", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<WaitForSaveDialog>d__249))]
	[Token(Token = "0x600006E")]
	public static IEnumerator WaitForSaveDialog(PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Save", string saveButtonText = "Save") { }

}

